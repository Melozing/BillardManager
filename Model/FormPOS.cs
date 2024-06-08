using BiaManager.Script;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormPOS : Form
    {
        public string idTable;
        public string idInvoice;
        public string PStatus;
        public string startTime;

        public string totalPlayHour;
        public string priceHour;
        public string amountHourPlay;

        private FormShowProducts frm;
        public FormPOS()
        {
            InitializeComponent();
        }
        private void guna2PictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Formpos_Load(object sender, EventArgs e)
        {
            guna2DataGridViewCategory.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelCategory.Controls.Clear();
            panelProduct.Controls.Clear();
            frm = new FormShowProducts();
            if (PStatus == "inactive")
            {
                AddHourPlay();
            }
            CountHourPlay();
            AddCategory();
            LoadTableInfo();
            if (PStatus != "inactive")
            {
                LoadDataItemBill();
            }
            LoadProducts();
            foreach (var item in frm.flowLayoutPanelProduct.Controls)
            {
                var prod = (ucProduct)item;
                this.ClickItem(prod);
            }
            FormMain.Instance.guna2ButtonTable.PerformClick();
        }
        private void AddHourPlay()
        {
            DateTime currentTime = DateTime.Now;
            string idInvoiceCreate = MainClass.GenerateUniqueId("invoice", "IdInvoice", "IV");
            idInvoice = idInvoiceCreate;
            string formattedTime = currentTime.ToString("yyyy-MM-dd HH:mm:ss"); // Định dạng thời gian theo format của cột datetime trong database
            startTime = labelTittle.Text + " " + formattedTime;
            labelTittle.Text = startTime;
            Hashtable ht = new Hashtable();
            string query = @"
            BEGIN TRANSACTION;
            UPDATE table_detail 
            SET Status = 1 
            WHERE TableID = '" + idTable + "';" +
            "INSERT INTO invoice(IdInvoice, TableID, Invoice_time, Invoice_Status)" +
            "VALUES(@NewIDInvoice, '" + idTable + "', @FormattedTime, '0');" +
            "INSERT INTO invoice_detail(IdInvoice, IdItem, Invoice_TotalAmount, Invoice_Price)" +
            "VALUES(@NewIDInvoice, 'IHour', 1, 1);" +
            "COMMIT TRANSACTION;";
            ht.Add("@NewIDInvoice", idInvoiceCreate);
            ht.Add("@FormattedTime", formattedTime);
            MainClass.SQL(query, ht);
        }
        private void CountHourPlay()
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Lấy thời gian khởi tạo hóa đơn từ database
            (DateTime invoiceTime, string idInvoice) = GetInvoiceTimeFromDatabase();
            startTime = "Start time :" + " " + invoiceTime.ToString();
            // Tính khoảng cách thời gian giữa thời gian khởi tạo và thời gian hiện tại
            TimeSpan timeDifference = currentTime - invoiceTime;

            // Tính số phút chơi và số giờ chơi
            double totalMinutesPlayed = timeDifference.TotalMinutes;
            double totalHoursPlayed = timeDifference.TotalHours;

            // Làm tròn số giờ đã chơi đến hai chữ số thập phân
            double roundedTotalHoursPlayed = Math.Round(totalHoursPlayed, 2);

            // Lấy giá loại bàn từ cơ sở dữ liệu
            string queryTablePrice = @"
            SELECT tt.TableType_Price
            FROM table_detail td
            JOIN table_type tt ON td.TableIDType = tt.TableIDType
            WHERE td.TableID = @TableID";

            Hashtable htTablePrice = new Hashtable();
            htTablePrice.Add("@TableID", idTable);
            decimal tableTypePrice = 0;

            using (SqlCommand cmdTablePrice = new SqlCommand(queryTablePrice, MainClass.conn))
            {
                foreach (DictionaryEntry item in htTablePrice)
                {
                    cmdTablePrice.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (MainClass.conn.State == ConnectionState.Closed) { MainClass.conn.Open(); }
                try
                {
                    object result = cmdTablePrice.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        tableTypePrice = Convert.ToDecimal(result);
                    }
                }
                finally
                {
                    if (MainClass.conn.State == ConnectionState.Open) { MainClass.conn.Close(); }
                }
            }

            // Tính số tiền phải trả dựa trên số phút chơi và giá loại bàn
            decimal pricePerMinute = tableTypePrice / 60;
            decimal totalAmountDue = pricePerMinute * (decimal)totalMinutesPlayed;

            // Làm tròn số tiền phải trả đến gần nhất 1000 đồng
            decimal roundedTotalAmountDue = Math.Round(totalAmountDue / 1000, 0) * 1000;

            // Cập nhật tổng số giờ đã chơi vào cơ sở dữ liệu
            string queryUpdate = @"
            UPDATE invoice_detail 
            SET Invoice_TotalAmount = @HourCount, Invoice_Price = @Price
            WHERE IdInvoice = '" + idInvoice + "' AND IdItem = 'IHour'";

            Hashtable htUpdate = new Hashtable();
            htUpdate.Add("@HourCount", roundedTotalHoursPlayed);
            htUpdate.Add("@Price", int.Parse(Regex.Replace(roundedTotalAmountDue.ToString(), @"[^0-9.]", "")));

            MainClass.SQL(queryUpdate, htUpdate);

            totalPlayHour = roundedTotalHoursPlayed.ToString();
            priceHour = tableTypePrice.ToString();
            amountHourPlay = roundedTotalAmountDue.ToString();
            // Hiển thị số giờ đã chơi và tổng số tiền phải trả
            guna2DataGridViewHourPlay.Rows.Add(new object[]
            {
            null,
            "IHour",
            "Play time",
            roundedTotalHoursPlayed,
            tableTypePrice,
            roundedTotalAmountDue.ToString("N0"),
            null,
            null,
            null
            });
            GetTotal();
        }

        private (DateTime, string) GetInvoiceTimeFromDatabase()
        {
            // Đảm bảo idTable không null hoặc rỗng

            string query = @"
            SELECT Invoice_time, IdInvoice
            FROM invoice
            WHERE TableID = @TableID AND Invoice_Status = 0";

            Hashtable ht = new Hashtable();
            ht.Add("@TableID", idTable);

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, MainClass.conn))
                {
                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }

                    if (MainClass.conn.State == ConnectionState.Closed)
                    {
                        MainClass.conn.Open();
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime invoiceTime = reader.GetDateTime(0);
                            string idInvoiceGet = reader.GetString(1);
                            idInvoice = idInvoiceGet;

                            return (invoiceTime, idInvoiceGet);
                        }
                        else
                        {
                            throw new Exception("Invoice not found.");
                        }
                    }
                }
            }
            finally
            {
                if (MainClass.conn.State == ConnectionState.Open)
                {
                    MainClass.conn.Close();
                }
            }
        }



        private void AddCategory()
        {
            string query = "Select * From items_category WHERE ItemCategoryStatus != 1";
            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            flowLayoutPanelCategory.Controls.Clear();

            //Add button All
            Guna.UI2.WinForms.Guna2Button btnAll = new Guna.UI2.WinForms.Guna2Button();
            btnAll.FillColor = Color.FromArgb(50, 55, 89);
            btnAll.Size = new Size(134, 45);
            btnAll.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAll.Text = "All";
            btnAll.Click += new EventHandler(_ClickAll);
            btnAll.Width = flowLayoutPanelCategory.Width;
            flowLayoutPanelCategory.Controls.Add(btnAll);
            btnAll.Dock = DockStyle.Top;

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(134, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["ItemCategory_Name"].ToString();

                    //event for click
                    b.Click += new EventHandler(_Click);
                    b.Width = flowLayoutPanelCategory.Width;
                    flowLayoutPanelCategory.Controls.Add(b);
                    b.Dock = DockStyle.Top;
                }
            }
        }
        private void LoadTableInfo()
        {
            string query = "Select TableNumber From table_detail Where TableID = '" + idTable + "'";
            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    labelTittle.Text = "Table " + row["TableNumber"].ToString();
                }
            }
        }
        private void LoadDataItemBill()
        {
            guna2DataGridViewCategory.Rows.Clear();
            double totalAmount = 0;

            string query = "SELECT " +
                "iv.Invoice_Status, " +
                "im.IdItem, " +
                "id.Invoice_TotalAmount, " +
                "im.item_Name, " +
                "im.item_Price " +
                "FROM items_menu im " +
                "JOIN invoice_detail id " +
                "ON im.IdItem = id.IdItem " +
                "JOIN invoice iv " +
                "ON iv.IdInvoice = id.IdInvoice " +
                "WHERE iv.IdInvoice = '" + idInvoice + "' " +
                "AND iv.Invoice_Status = 0 " +
                "AND im.IdItem != 'IHour'";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    int quantity = int.Parse(Regex.Replace(row["Invoice_TotalAmount"].ToString(), @"[^0-9.]", ""));

                    double price = double.Parse(Regex.Replace(row["item_Price"].ToString(), @"[^0-9.]", ""));

                    double itemTotal = quantity * price;
                    totalAmount += itemTotal;

                    guna2DataGridViewCategory.Rows.Add(new object[] { 0, row["IdItem"].ToString(), row["item_Name"].ToString(), quantity, price.ToString("N0"), itemTotal.ToString("N0") });
                }

                GetTotal();
            }
        }

        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in frm.flowLayoutPanelProduct.Controls)
            {
                var prod = (ucProduct)item;
                prod.Visible = prod.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }
        private void _ClickAll(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in frm.flowLayoutPanelProduct.Controls)
            {
                var prod = (ucProduct)item;
                prod.Visible = prod.PCategory.ToLower().Contains("");
            }
        }
        public void ClickItem(ucProduct product)
        {
            double totalAmount = 0;
            product.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                foreach (DataGridViewRow item in guna2DataGridViewCategory.Rows)
                {
                    // Kiểm tra xem sản phẩm đã tồn tại trong DataGridView chưa
                    if (item.Cells["Id"].Value.ToString() == wdg.id)
                    {
                        // Cập nhật số lượng
                        int quantity = int.Parse(item.Cells["Quantity"].Value.ToString()) + 1;
                        item.Cells["Quantity"].Value = quantity;

                        // Cập nhật tổng giá trị
                        double parsedPrice = double.Parse(Regex.Replace(wdg.PPrice, @"[^0-9.]", ""));
                        totalAmount = quantity * parsedPrice;
                        string totalPrice = totalAmount.ToString("N0");
                        item.Cells["Amount"].Value = totalPrice;
                        string totalPriceUpdate = Regex.Replace(totalPrice.ToString(), @"[^0-9.]", "").ToString();
                        UpdateBillAmout(idInvoice, item.Cells["Id"].Value.ToString(), float.Parse(Regex.Replace(quantity.ToString("N0"), @"[^0-9.]", "")), totalPriceUpdate);
                        GetTotal();
                        return;
                    }
                }

                // Thêm sản phẩm mới
                double parsedPriceNew = double.Parse(Regex.Replace(wdg.PPrice, @"[^0-9.]", ""));
                totalAmount += parsedPriceNew;
                guna2DataGridViewCategory.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, parsedPriceNew.ToString("N0"), totalAmount.ToString("N0") });
                string priceInsert = Regex.Replace(totalAmount.ToString("N0"), @"[^0-9.]", "").ToString();
                InsertBillAmout(idInvoice, wdg.id, 1, priceInsert);
                GetTotal();
            };
        }
        private void InsertBillAmout(string idInvoice, string idItem, float amount, string price)
        {
            Hashtable ht = new Hashtable();
            string query = @"INSERT INTO invoice_detail " +
            "(IdInvoice, IdItem, Invoice_TotalAmount, Invoice_Price) " +
            "VALUES ('" + idInvoice + "', @idItem, @amount, @price)";
            ht.Add("@idItem", idItem);
            ht.Add("@amount", amount);
            ht.Add("@price", price);
            MainClass.SQL(query, ht);
        }
        private void UpdateBillAmout(string idInvoice, string idItem, float amount, string totalPrice)
        {
            Hashtable ht = new Hashtable();
            string query = @"UPDATE invoice_detail " +
            "Set Invoice_TotalAmount = @amount, " +
            "Invoice_Price = @price " +
            "WHERE IdInvoice = @idInvoice AND idItem = @idItem";
            ht.Add("@price", totalPrice);
            ht.Add("@idInvoice", idInvoice);
            ht.Add("@idItem", idItem);
            ht.Add("@amount", amount);
            MainClass.SQL(query, ht);
        }
        //Getting product form database
        private void LoadProducts()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LoadProducts));
                return;
            }

            frm.TopLevel = false;
            panelProduct.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }


        private void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in frm.flowLayoutPanelProduct.Controls)
            {
                var prod = (ucProduct)item;
                prod.Visible = prod.PName.ToLower().Contains(guna2TextBoxSearch.Text.Trim().ToLower());
            }
        }
        private void guna2DataGridViewCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridViewCategory.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double total = 0;
            labelTotalMoneyNum.Text = string.Empty;
            foreach (DataGridViewRow item in guna2DataGridViewHourPlay.Rows)
            {
                total += double.Parse(Regex.Replace(item.Cells[5].Value.ToString(), @"[^0-9.]", ""));
            }
            foreach (DataGridViewRow item in guna2DataGridViewCategory.Rows)
            {
                total += double.Parse(Regex.Replace(item.Cells["Amount"].Value.ToString(), @"[^0-9.]", ""));
            }

            labelTotalMoneyNum.Text = total.ToString("N0");
        }

        private void guna2ButtonCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCheckOut frmCheckOut = new FormCheckOut();
            frmCheckOut.tableID = idTable;
            frmCheckOut.amount = Convert.ToDouble(labelTotalMoneyNum.Text);
            frmCheckOut.idInvoice = idInvoice;
            frmCheckOut.startTime = startTime;

            frmCheckOut.priceHour = priceHour;
            frmCheckOut.totalPlayHour = totalPlayHour;
            frmCheckOut.amountHourPlay = amountHourPlay;

            MainClass.BlurBackground(frmCheckOut);
            FormMain.Instance.BringToFront();
        }

        private void guna2DataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double totalAmount = 0;
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "minus")
            {
                int quantity = int.Parse(guna2DataGridViewCategory.CurrentRow.Cells["Quantity"].Value.ToString());
                if (quantity <= 1)
                {
                    string id = guna2DataGridViewCategory.CurrentRow.Cells["Id"].Value.ToString();
                    RemoveItem(id);
                    return;
                };
                quantity -= 1;
                guna2DataGridViewCategory.CurrentRow.Cells["Quantity"].Value = quantity;

                // Cập nhật tổng giá trị
                double parsedPrice = double.Parse(Regex.Replace(guna2DataGridViewCategory.CurrentRow.Cells["Price"].Value.ToString(), @"[^0-9.]", ""));
                totalAmount = quantity * parsedPrice;
                string totalPrice = totalAmount.ToString("N0");
                guna2DataGridViewCategory.CurrentRow.Cells["Amount"].Value = totalPrice;
                string totalPriceUpdate = Regex.Replace(totalPrice.ToString(), @"[^0-9.]", "").ToString();
                UpdateBillAmout(idInvoice, guna2DataGridViewCategory.CurrentRow.Cells["Id"].Value.ToString(), float.Parse(Regex.Replace(quantity.ToString("N0"), @"[^0-9.]", "")), totalPriceUpdate);
                GetTotal();
            }
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "plus")
            {
                int quantity = int.Parse(guna2DataGridViewCategory.CurrentRow.Cells["Quantity"].Value.ToString()) + 1;
                guna2DataGridViewCategory.CurrentRow.Cells["Quantity"].Value = quantity;

                // Cập nhật tổng giá trị
                double parsedPrice = double.Parse(Regex.Replace(guna2DataGridViewCategory.CurrentRow.Cells["Price"].Value.ToString(), @"[^0-9.]", ""));
                totalAmount = quantity * parsedPrice;
                string totalPrice = totalAmount.ToString("N0");
                guna2DataGridViewCategory.CurrentRow.Cells["Amount"].Value = totalPrice;
                string totalPriceUpdate = Regex.Replace(totalPrice.ToString(), @"[^0-9.]", "").ToString();
                UpdateBillAmout(idInvoice, guna2DataGridViewCategory.CurrentRow.Cells["Id"].Value.ToString(), float.Parse(Regex.Replace(quantity.ToString("N0"), @"[^0-9.]", "")), totalPriceUpdate);
                GetTotal();
            }
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryDelete")
            {
                string id = guna2DataGridViewCategory.CurrentRow.Cells["Id"].Value.ToString();
                RemoveItem(id);

            }
        }

        private void RemoveItem(string idItem)
        {
            DialogResult dialogResult = MessageFuctionConstans.OKCancel("Are you sure you want to delete?");
            if (dialogResult == DialogResult.OK)
            {
                string query = "Delete from invoice_detail where IdItem ='" + idItem + "' AND IdInvoice = '" + idInvoice + "' ";
                Hashtable hashtable = new Hashtable();
                MainClass.SQL(query, hashtable);

                MessageFuctionConstans.SuccessOK("Deleted successfully!");
                LoadDataItemBill();
                GetTotal();
            }
        }
    }
}
