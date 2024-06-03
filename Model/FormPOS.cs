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
            CountHourPlay();
            ShowHourPlay();
            if (PStatus == "inactive")
            {
                AddHourPlay();
            }
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
            ShowHourPlay();
        }
        private void ShowHourPlay()
        {
            string query = @"
            SELECT tt.TableType_Price, inv_det.Invoice_TotalAmount
            FROM table_detail td
            JOIN table_type tt ON td.TableIDType = tt.TableIDType
            JOIN invoice inv ON td.TableID = inv.TableID
            JOIN invoice_detail inv_det ON inv.IdInvoice = inv_det.IdInvoice
            WHERE td.TableID = @TableID 
            AND inv.Invoice_Status = 0;";

            using (SqlCommand cmd = new SqlCommand(query, MainClass.conn))
            {
                // Thêm tham số vào truy vấn
                cmd.Parameters.AddWithValue("@TableID", idTable);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow item in dataTable.Rows)
                    {
                        // Loại bỏ các ký tự đặc biệt từ TableType_Price trước khi chuyển đổi thành số
                        string priceStr = Regex.Replace(item["TableType_Price"].ToString(), @"[^0-9.]", "");
                        double price = double.Parse(priceStr);
                        int invoiceTotalAmount = int.Parse(item["Invoice_TotalAmount"].ToString());
                        double total = price * invoiceTotalAmount;

                        // Thêm dòng vào DataGridView
                        guna2DataGridViewCategory.Rows.Add(new object[]
                        {
                    0,
                    "IHour",
                    "Play time",
                    invoiceTotalAmount,
                    priceStr,
                    total
                        });
                    }
                }
            }
        }
        private void CountHourPlay()
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Lấy thời gian khởi tạo hóa đơn từ database
            DateTime invoiceTime = GetInvoiceTimeFromDatabase();

            // Tính khoảng cách thời gian giữa thời gian khởi tạo và thời gian hiện tại
            TimeSpan timeDifference = currentTime - invoiceTime;

            // Tính số phút chơi
            float totalMinutesPlayed = (float)timeDifference.TotalMinutes;
            double totalHoursPlayed = timeDifference.TotalHours;
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
                object result = cmdTablePrice.ExecuteScalar();
                if (MainClass.conn.State == ConnectionState.Open) { MainClass.conn.Close(); }

                if (result != null && result != DBNull.Value)
                {
                    tableTypePrice = Convert.ToDecimal(result);
                }
            }

            // Tính số tiền phải trả dựa trên số phút chơi và giá loại bàn
            decimal pricePerMinute = tableTypePrice / 60;
            decimal totalAmountDue = pricePerMinute * (decimal)totalMinutesPlayed;
            string queryUpdate = "Update invoice_detail SET Invoice_TotalAmount = @HourCount " +
                "Where IdInvoice = @idInvoice AND IdItem = 'IHour'";
            Hashtable ht = new Hashtable();
            ht.Add("@idInvoice", idInvoice);
            ht.Add("@HourCount", totalHoursPlayed);
            MainClass.SQL(queryUpdate, ht);
            // Hiển thị tổng số tiền phải trả
            MessageBox.Show($"Số giờ đã chơi: {totalHoursPlayed:F2} giờ\nTổng số tiền phải trả: {totalAmountDue:C}");

            // Lưu biến totalAmountDue để sử dụng sau
            // Bạn có thể lưu biến này vào đâu đó nếu cần thiết
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
                    //check it produuct already there then a one to quantity and update price
                    if (item.Cells["Id"].Value.ToString() == wdg.id)
                    {
                        item.Cells["Quantity"].Value = int.Parse(item.Cells["Quantity"].Value.ToString()) + 1;
                        item.Cells["Amount"].Value = int.Parse(item.Cells["Quantity"].Value.ToString()) *
                        double.Parse(Regex.Replace(item.Cells["Price"].Value.ToString(), @"[^0-9.]", ""));
                        return;
                    }
                }

                //add new product
                guna2DataGridViewCategory.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, Regex.Replace(wdg.PPrice, @"[^0-9.]", ""), Regex.Replace(wdg.PPrice, @"[^0-9.]", "") });
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

            labelTotalMoneyNum.Text = total.ToString("N2");
        }

        private void guna2ButtonCheckOut_Click(object sender, EventArgs e)
        {
            FormCheckOut frmCheckOut = new FormCheckOut();
            frmCheckOut.tableID = idTable;
            MainClass.BlurBackground(frmCheckOut);
        }
    }
}
