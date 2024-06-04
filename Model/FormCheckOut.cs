using BiaManager.Script;
using BillardManager.Admin;
using BillardManager.Reports;
using System;
using System.Collections;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormCheckOut : SampleAdd
    {
        public FormCheckOut()
        {
            InitializeComponent();
        }

        public double amount;
        public string tableID;
        public string invoiceID;
        private void guna2TextBox1_TextChanged(object sender, System.EventArgs e)
        {
            double amt = 0;
            double receipt = double.Parse(guna2TextBoxReceived.Text);
            double change = 0;

            double.TryParse(guna2TextBoxBillAmount.Text, out amt);
            double.TryParse(guna2TextBoxReceived.Text, out receipt);
            double.TryParse(guna2TextBoxReceived.Text, out receipt);

            change = Math.Abs(amt - receipt);

            guna2TextBoxChange.Text = change.ToString("N0");
            guna2TextBoxReceived.Text = receipt.ToString("N0");
            guna2TextBoxReceived.SelectionStart = guna2TextBoxReceived.Text.Length;
        }
        public override void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.OKCancel("Confirm payment for this bill?");
            if (result == DialogResult.OK)
            {
                DialogResult resultExportBill = MessageFuctionConstans.YesNoCancel("Do you want to generate an invoice?");
                if (resultExportBill == DialogResult.Yes)
                {
                    ExportAndPrintInvoice();
                }
                else if (resultExportBill == DialogResult.No)
                {
                    UpdateInvoiceAndTableStatus();
                    PaySuccessful();
                }
            }
            string query = @"Update invoice set 
                            Invoice_Total = @total, 
                            Invoice_Received = @rec, 
                            Invoice_Change = @change, 
                            Invoice_PaymentTime  = @paymentTime, 
                            Invoice_Status = 1 
                            Where IdInvoice = '" + invoiceID + "'";
        }
        private void ExportAndPrintInvoice()
        {
            FormPrintBill frm = new FormPrintBill();
            CrystalReportBill cr = new CrystalReportBill();
            cr.SetDatabaseLogon(MainClass.nameServer, "");
            cr.SetDataSource(invoiceID);
        }
        private void UpdateInvoiceAndTableStatus()
        {
            string queryPay = @"
            UPDATE inv
            SET inv.Invoice_Status = 1
            FROM invoice AS inv
            INNER JOIN invoice_detail AS inv_det ON inv.IdInvoice = inv_det.IdInvoice
            INNER JOIN table_detail AS tbl_det ON inv.TableID = tbl_det.TableID
            WHERE inv.IdInvoice = '" + invoiceID + "' AND inv.Invoice_Status = 0;" +
            "UPDATE table_detail SET Status = 0 WHERE TableID = '" + tableID + "'; ";
            Hashtable ht = new Hashtable();
            MainClass.SQL(queryPay, ht);
        }
        private void PaySuccessful()
        {
            this.Close();
            MessageFuctionConstans.SuccessOK("Payment successful!");
        }
        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            guna2TextBoxBillAmount.Text = amount.ToString("N0");
        }

        private void guna2TextBoxReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public override void guna2ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
