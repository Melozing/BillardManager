using BillardManager.Model;
using System;
using System.Windows.Forms;

namespace BillardManager.View
{
    public partial class FormBillView : Form
    {
        public FormBillView()
        {
            InitializeComponent();
        }

        private void FormBillView_Load(object sender, System.EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string query = "SELECT IdInvoice, " +
              "Invoice_time, " +
              "Invoice_PaymentTime, " +
              "Invoice_Received, " +
              "Invoice_Change, " +
              "Invoice_Total " +
              "FROM invoice " +
              "WHERE (IdInvoice LIKE '%" + guna2TextBoxSearch.Text + "%' " +
              "OR Invoice_time LIKE '%" + guna2TextBoxSearch.Text + "%' " +
              "OR Invoice_Total LIKE '%" + guna2TextBoxSearch.Text + "%' " +
              "OR Invoice_Received LIKE '%" + guna2TextBoxSearch.Text + "%' " +
              "OR Invoice_PaymentTime LIKE '%" + guna2TextBoxSearch.Text + "%' " +
              "OR Invoice_Change LIKE '%" + guna2TextBoxSearch.Text + "%') " +
              "AND Invoice_Status != 0";

            ListBox lb = new ListBox();
            lb.Items.Add(Id);
            lb.Items.Add(startTime);
            lb.Items.Add(paymentTime);
            lb.Items.Add(received);
            lb.Items.Add(change);
            lb.Items.Add(amount);

            MainClass.LoadData(query, guna2DataGridViewCategory, lb);
        }
        public void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FormStaffAdd());
            GetData();
        }

        public void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridViewCategory.RowCount < 1) return;
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryEdit")
            {
                FormPrintBillPage formPrintBillPage = new FormPrintBillPage();
                formPrintBillPage.GetBillInfoByID(guna2DataGridViewCategory.CurrentRow.Cells["Id"].Value.ToString());
                formPrintBillPage.FormBorderStyle = FormBorderStyle.None;
                formPrintBillPage.StartPosition = FormStartPosition.CenterScreen;
                formPrintBillPage.AddHeaderDetailBill();
                formPrintBillPage.LoadDataItemBill();
                formPrintBillPage.BringToFront();
                formPrintBillPage.ShowExitBtn();
                MainClass.BlurBackground(formPrintBillPage);
            }
        }

        private void guna2TextBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridViewCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (guna2DataGridViewCategory.Columns[e.ColumnIndex].Name == "received" ||
         guna2DataGridViewCategory.Columns[e.ColumnIndex].Name == "amount" ||
         guna2DataGridViewCategory.Columns[e.ColumnIndex].Name == "change")
            {
                if (e.Value != null && e.Value is decimal)
                {
                    e.Value = ((decimal)e.Value).ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
