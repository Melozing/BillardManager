using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormPOS : Form
    {
        public string idTable;
        public string idInvoice;
        public string PStatus;
        public FormPOS()
        {
            InitializeComponent();
        }

        private void guna2PictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formpos_Load(object sender, EventArgs e)
        {
            guna2DataGridViewCategory.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelCategory.Controls.Clear();
            flowLayoutPanelProduct.Controls.Clear();
            if (PStatus == "inactive")
            {
                AddHourPlay();
            }
            CountHourPlay();
            AddCategory();
            LoadProducts();
            LoadTableInfo();
        }
        private void AddHourPlay()
        {
            DateTime currentTime = DateTime.Now;
            string idInvoice = MainClass.GenerateUniqueId("invoice", "IdInvoice", "U");
            string formattedTime = currentTime.ToString("yyyy-MM-dd HH:mm:ss"); // Định dạng thời gian theo format của cột datetime trong database
            Hashtable ht = new Hashtable();
            string query = @"
            BEGIN TRANSACTION;
            UPDATE table_detail 
            SET Status = 1 
            WHERE TableID = '" + idTable + "';" +
            "INSERT INTO invoice(IdInvoice, TableID, Invoice_time, Invoice_Status)" +
            "VALUES(@NewIDInvoice, '" + idTable + "', @FormattedTime, '0');" +
            "INSERT INTO invoice_detail(IdInvoice, IdItem, Invoice_TotalAmount)" +
            "VALUES(@NewIDInvoice, 'IHour', 1);" +
            "COMMIT TRANSACTION;";
            ht.Add("@NewIDInvoice", idInvoice);
            ht.Add("@FormattedTime", formattedTime);
            MainClass.SQL(query, ht);
        }
        private void CountHourPlay()
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Lấy thời gian khởi tạo hóa đơn từ database
            DateTime invoiceTime = GetInvoiceTimeFromDatabase();

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
            SET Invoice_TotalAmount = @HourCount 
            WHERE IdInvoice = '" + idInvoice + "' AND IdItem = 'IHour'";

            Hashtable htUpdate = new Hashtable();
            htUpdate.Add("@HourCount", roundedTotalHoursPlayed);

            MainClass.SQL(queryUpdate, htUpdate);

            // Hiển thị số giờ đã chơi và tổng số tiền phải trả
            guna2DataGridViewCategory.Rows.Add(new object[]
            {
            0,
            "IHour",
            "Play time",
            roundedTotalHoursPlayed,
            tableTypePrice,
            roundedTotalAmountDue.ToString("N0")
            });
            GetTotal();
        }

        private DateTime GetInvoiceTimeFromDatabase()
        {
            // Giả sử bạn đã có hàm này để lấy thời gian hóa đơn từ cơ sở dữ liệu
            string query = @"
            SELECT Invoice_time
            FROM invoice
            WHERE TableID = @TableID AND Invoice_Status = 0";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            cmd.Parameters.AddWithValue("@TableID", idTable);
            if (MainClass.conn.State == ConnectionState.Closed) { MainClass.conn.Open(); }
            DateTime invoiceTime = (DateTime)cmd.ExecuteScalar();
            if (MainClass.conn.State == ConnectionState.Open) { MainClass.conn.Close(); }
            return invoiceTime;
        }


        private void AddCategory()
        {
            string query = "Select * From items_category";
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

        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var prod = (ucProduct)item;
                prod.Visible = prod.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }
        private void _ClickAll(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var prod = (ucProduct)item;
                prod.Visible = prod.PCategory.ToLower().Contains("");
            }
        }

        private void AddItems(string idItem, string name, string cat, string price, Image pimage)
        {
            double totalAmount = 0;

            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = idItem
            };
            flowLayoutPanelProduct.Controls.Add(w);
            w.onSelect += (ss, ee) =>
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
                        item.Cells["Amount"].Value = totalAmount.ToString("N0");
                        GetTotal();
                        return;
                    }
                }

                // Thêm sản phẩm mới
                double parsedPriceNew = double.Parse(Regex.Replace(wdg.PPrice, @"[^0-9.]", ""));
                totalAmount += parsedPriceNew;
                guna2DataGridViewCategory.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, parsedPriceNew.ToString("N0"), totalAmount.ToString("N0") });
                GetTotal();
            };
        }

        //Getting product form database
        private void LoadProducts()
        {
            string query = "SELECT * " +
                           "FROM items_menu im " +
                           "JOIN items_category ic ON im.IdItemCategory = ic.IdItemCategory " +
                           "WHERE im.ItemStatus != 1 AND im.IdItem !='IHour'";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach (DataRow item in dataTable.Rows)
            {
                Byte[] imageArray = (byte[])item["item_image"];
                byte[] imageByteArray = imageArray;

                AddItems(item["IdItem"].ToString(), item["item_Name"].ToString(),
                    item["ItemCategory_Name"].ToString(), "$ " + item["item_Price"].ToString(), Image.FromStream(new MemoryStream(imageByteArray)));
            }
        }

        private void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanelProduct.Controls)
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
            foreach (DataGridViewRow item in guna2DataGridViewCategory.Rows)
            {
                total += double.Parse(Regex.Replace(item.Cells["Amount"].Value.ToString(), @"[^0-9.]", ""));
            }

            labelTotalMoneyNum.Text = total.ToString("N0");
        }

        private void guna2ButtonCheckOut_Click(object sender, EventArgs e)
        {
            FormCheckOut frmCheckOut = new FormCheckOut();
            frmCheckOut.tableID = idTable;
            frmCheckOut.amount = Convert.ToDouble(labelTotalMoneyNum.Text);
            MainClass.BlurBackground(frmCheckOut);
        }
    }
}
