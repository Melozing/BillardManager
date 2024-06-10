using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BillardManager.Model;

namespace BillardManager.View
{
    public partial class Formrreport : Form
    {
        public Formrreport()
        {
            InitializeComponent();
            LoadRevenueData();
        }

        private void Formrreport_Load(object sender, EventArgs e)
        {
            LoadSummaryData();
        }

        private void LoadRevenueData()
        {
            string query = @"
            SELECT IdInvoice, TableID, Invoice_Total, Invoice_time, Invoice_PaymentTime
            FROM invoice
            WHERE Invoice_Status = 1"; // Assuming Invoice_Status = 1 means Paid

            // Load data using MainClass utility function
            MainClass.LoadData(query, dataGridViewInvoices, new ListBox());
        }

        private void LoadSummaryData()
        {
            decimal dailyRevenue = 0;
            decimal monthlyRevenue = 0;
            DateTime today = DateTime.Now;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);

            DataTable dataTable = GetInvoiceDataTable();

            foreach (DataRow row in dataTable.Rows)
            {
                decimal invoiceTotal = row["Invoice_Total"] != DBNull.Value ? Convert.ToDecimal(row["Invoice_Total"]) : 0;
                DateTime paymentTime = row["Invoice_PaymentTime"] != DBNull.Value ? Convert.ToDateTime(row["Invoice_PaymentTime"]) : DateTime.MinValue;

                if (paymentTime.Date == today.Date)
                {
                    dailyRevenue += invoiceTotal;
                }

                if (paymentTime >= firstDayOfMonth && paymentTime <= today)
                {
                    monthlyRevenue += invoiceTotal;
                }
            }

            lblDailyRevenue.Text = $"{dailyRevenue:C2}";
            lblMonthlyRevenue.Text = $"{monthlyRevenue:C2}";

            LoadChart(dataTable);
        }

        private DataTable GetInvoiceDataTable()
        {
            DataTable dataTable = new DataTable();
            string query = @"
            SELECT Invoice_Total, Invoice_PaymentTime
            FROM invoice
            WHERE Invoice_Status = 1";

            using (SqlConnection conn = new SqlConnection(MainClass.connect_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void LoadChart(DataTable dataTable)
        {
            chartColumn.Series.Clear();
            chartPie.Series.Clear();

            var dailySeries = new Series("Daily Revenue")
            {
                ChartType = SeriesChartType.Column
            };

            var monthlySeries = new Series("Monthly Revenue")
            {
                ChartType = SeriesChartType.Pie
            };

            DateTime today = DateTime.Now;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);

            foreach (DataRow row in dataTable.Rows)
            {
                decimal invoiceTotal = row["Invoice_Total"] != DBNull.Value ? Convert.ToDecimal(row["Invoice_Total"]) : 0;
                DateTime paymentTime = row["Invoice_PaymentTime"] != DBNull.Value ? Convert.ToDateTime(row["Invoice_PaymentTime"]) : DateTime.MinValue;

                if (paymentTime.Date == today.Date)
                {
                    dailySeries.Points.AddXY(paymentTime.ToString("dd/MM/yyyy"), invoiceTotal);
                }

                if (paymentTime >= firstDayOfMonth && paymentTime <= today)
                {
                    monthlySeries.Points.AddXY(paymentTime.ToString("dd/MM/yyyy"), invoiceTotal);
                }
            }

            chartColumn.Series.Add(dailySeries);
            chartPie.Series.Add(monthlySeries);
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewInvoices.SelectedRows[0];
                string invoiceID = row.Cells["IdInvoice"].Value.ToString();
                string tableID = row.Cells["TableID"].Value.ToString();
                string amount = row.Cells["Invoice_Total"].Value.ToString();
                MessageBox.Show($"Invoice ID: {invoiceID}\nTable: {tableID}\nAmount: {amount}", "Invoice Details");
            }
            else
            {
                MessageBox.Show("Please select an invoice to view details.", "Notification");
            }
        }
    }
}
