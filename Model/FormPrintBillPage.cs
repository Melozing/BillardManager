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

            LoadDataItemBill();
        }

        private void LoadDataItemBill()
        {
            double totalAmount = 0;
            panelBillDetail.Controls.Clear();
            var ucTittle = new ucBillDetail();
            ShowItemBill(ucTittle);
            ucTittle.Dock = DockStyle.Top;
            if (int.Parse(amountHourPlay) > 0)
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
        }

        private void ShowItemBill(ucBillDetail bdt)
        {
            panelBillDetail.Controls.Add(bdt);
            bdt.Show();
            bdt.BringToFront();
            bdt.Dock = DockStyle.Top;
        }

    }
}
