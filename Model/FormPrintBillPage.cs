using BiaManager.Script;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormPrintBillPage : Form
    {
        public string idInvoice;
        public string startTime;
        public string paymentTime;

        public string totalMoney;
        public string receivedMoney;
        public string changeMoney;

        public string totalPlayHour;
        public string priceHour;
        public string amountHourPlay;

        private bool isShowBillList = false;

        public FormPrintBillPage()
        {
            InitializeComponent();
        }

        private void FormPrintBillPage_Load(object sender, EventArgs e)
        {
            labelTimeStart.Text = startTime;
            labelPaymentTime.Text = paymentTime;
            labelTotalMoney.Text = totalMoney;
            labelChangetxt.Text = changeMoney;
            labelRecivedAmounttxt.Text = receivedMoney;
        }

        public void GetBillInfoByID(string idInvoiceGet)
        {
            idInvoice = idInvoiceGet;
            string queryGet = @"
            SELECT Invoice_time, 
                   Invoice_PaymentTime, 
                   Invoice_Total, 
                   Invoice_Received, 
                   Invoice_Change  
            FROM invoice 
            WHERE IdInvoice = @idInvoice";

            string queryGetHour = @"
            SELECT inv_det.Invoice_TotalAmount, tbl_type.TableType_Price
            FROM invoice_detail inv_det
            INNER JOIN invoice inv ON inv_det.IdInvoice = inv.IdInvoice
            INNER JOIN table_detail tbl_det ON inv.TableID = tbl_det.TableID
            INNER JOIN table_type tbl_type ON tbl_det.TableIDType = tbl_type.TableIDType
            WHERE inv_det.IdInvoice = @idInvoice AND inv_det.IdItem = 'IHour'";

            try
            {
                // Create a new SQL command for the first query
                using (SqlCommand cmd = new SqlCommand(queryGet, MainClass.conn))
                {
                    // Add parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@idInvoice", idInvoiceGet);

                    // Open the connection if it is closed
                    if (MainClass.conn.State == ConnectionState.Closed)
                    {
                        MainClass.conn.Open();
                    }

                    // Execute the command and use SqlDataReader to read the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            startTime = reader.GetDateTime(0).ToString();
                            paymentTime = "Payment time : " + reader.GetDateTime(1).ToString();
                            totalMoney = "$ " + reader.GetDecimal(2).ToString("N0");
                            receivedMoney = "$ " + reader.GetDecimal(3).ToString("N0");
                            changeMoney = "$ " + reader.GetDecimal(4).ToString("N0");
                        }
                    }
                }

                // Create a new SQL command for the second query
                using (SqlCommand cmd = new SqlCommand(queryGetHour, MainClass.conn))
                {
                    // Add parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@idInvoice", idInvoiceGet);

                    // Execute the command and use SqlDataReader to read the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double totalAmount = reader.GetDouble(0);
                            int hourlyRate = reader.GetInt32(1);

                            amountHourPlay = (totalAmount * hourlyRate).ToString("N0"); // Total hours played
                            priceHour = hourlyRate.ToString("N0"); // Hourly rate
                            totalPlayHour = totalAmount.ToString("N2"); // Total amount paid for playing hours
                        }
                    }

                    // Close the connection if it is open
                    if (MainClass.conn.State == ConnectionState.Open)
                    {
                        MainClass.conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageFuctionConstans.ErrorOK(ex.ToString());
                if (MainClass.conn.State == ConnectionState.Open)
                {
                    MainClass.conn.Close();
                }
            }
            isShowBillList = true;
        }



        public void AddHeaderDetailBill()
        {
            panelBillDetail.Controls.Clear();
            var ucTittle = new ucBillDetail();
            ShowItemBill(ucTittle);
            ucTittle.Dock = DockStyle.Top;
            if (float.Parse(amountHourPlay.ToString()) > 0)
            {
                var w = new ucBillDetail()
                {
                    PName = "Play time",
                    PPrice = priceHour,
                    PQuantity = totalPlayHour,
                    PAmount = amountHourPlay,
                    PSr = "1"
                };
                ShowItemBill(w);
            }
        }

        public void LoadDataItemBill()
        {
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
                "AND im.IdItem != 'IHour'";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                int num = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    num++;
                    int quantity = int.Parse(Regex.Replace(row["Invoice_TotalAmount"].ToString(), @"[^0-9.]", ""));

                    double price = double.Parse(Regex.Replace(row["item_Price"].ToString(), @"[^0-9.]", ""));

                    double itemTotal = quantity * price;
                    totalAmount += itemTotal;
                    var b = new ucBillDetail()
                    {
                        PName = row["item_Name"].ToString(),
                        PPrice = price.ToString("N0"),
                        PQuantity = quantity.ToString(),
                        PAmount = totalAmount.ToString("N0"),
                        PSr = num.ToString()
                    };
                    ShowItemBill(b);
                }
            }
            pictureBoxExit.Visible = isShowBillList;
        }

        private void ShowItemBill(ucBillDetail bdt)
        {
            panelBillDetail.Controls.Add(bdt);
            bdt.Show();
            bdt.BringToFront();
            bdt.Dock = DockStyle.Top;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}