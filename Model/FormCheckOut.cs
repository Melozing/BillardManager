using BiaManager.Script;
using BillardManager.Admin;
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
        public string idInvoice;
        public string startTime;
        public string paymentTime;

        public string totalPlayHour;
        public string priceHour;
        public string amountHourPlay;

        private double changeMoney;
        private void guna2TextBoxReceived_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBoxReceived.Text))
            {
                guna2TextBoxChange.Text = null;
                return;
            };
            double amt;
            double receipt = double.Parse(guna2TextBoxReceived.Text);
            double change;

            double.TryParse(guna2TextBoxBillAmount.Text, out amt);
            double.TryParse(guna2TextBoxReceived.Text, out receipt);
            double.TryParse(guna2TextBoxReceived.Text, out receipt);

            //change = Math.Abs(amt - receipt);
            change = receipt - amt;
            changeMoney = change;
            guna2TextBoxChange.Text = change.ToString("N0");
            guna2TextBoxReceived.Text = receipt.ToString("N0");
            guna2TextBoxReceived.SelectionStart = guna2TextBoxReceived.Text.Length;
        }
        private void ExportAndPrintInvoice()
        {
            DateTime currentTime = DateTime.Now;
            paymentTime = currentTime.ToString();
            FormPrintBillPage frm = new FormPrintBillPage();
            frm.startTime = startTime;
            frm.invoiceID = idInvoice;
            frm.paymentTime = "Payment time : " + paymentTime;
            frm.totalMoney = "$ " + guna2TextBoxBillAmount.Text;
            frm.receivedMoney = "$ " + guna2TextBoxReceived.Text;
            frm.changeMoney = "$ " + guna2TextBoxChange.Text;

            frm.totalPlayHour = totalPlayHour;
            frm.priceHour = priceHour;
            frm.amountHourPlay = amountHourPlay;
            frm.ShowExitBtn();
            frm.ShowDialog();
        }
        private bool UpdateInvoiceAndTableStatus()
        {
            bool state = false;
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("yyyy-MM-dd HH:mm:ss"); // Định dạng thời gian theo format của cột datetime trong database
            paymentTime = formattedTime;
            Hashtable ht = new Hashtable();
            string queryPay = @"
            UPDATE inv
            SET inv.Invoice_Status = 1, 
                inv.Invoice_Total = @total, 
                inv.Invoice_Received = @received, 
                inv.Invoice_Change = @change, 
                inv.Invoice_PaymentTime = @paymentTime 
            FROM invoice AS inv
            INNER JOIN invoice_detail AS inv_det ON inv.IdInvoice = inv_det.IdInvoice
            INNER JOIN table_detail AS tbl_det ON inv.TableID = tbl_det.TableID
            WHERE inv.IdInvoice = @idInvoice; 
            UPDATE table_detail SET Status = 0 WHERE TableID = @tableID;
            ";

            ht.Add("@total", amount);
            ht.Add("@received", double.Parse(guna2TextBoxReceived.Text));
            ht.Add("@change", changeMoney);
            ht.Add("@paymentTime", paymentTime);
            ht.Add("@idInvoice", idInvoice);
            ht.Add("@tableID", tableID);
            if (MainClass.SQL(queryPay, ht) > 0)
            {
                FormMain.Instance.guna2ButtonTable.PerformClick();
                state = true;
            };
            //MainClass.SQL(queryOrder, htOder);
            return state;
        }
        private void PaySuccessful()
        {
            this.Hide();
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
            this.Hide();
        }

        private void guna2ButtonSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBoxChange.Text.ToString()) || double.Parse(guna2TextBoxChange.Text) < 0)
            {
                MessageFuctionConstans.ErrorOK("Received amount must be greater than the amount due");
                return;
            }
            DialogResult result = MessageFuctionConstans.OKCancel("Confirm payment for this bill?");
            if (result == DialogResult.OK)
            {
                DialogResult resultExportBill = MessageFuctionConstans.YesNoCancel("Do you want to generate an invoice?");
                if (resultExportBill == DialogResult.Yes)
                {
                    UpdateInvoiceAndTableStatus();
                    ExportAndPrintInvoice();
                    this.Hide();
                }
                else if (resultExportBill == DialogResult.No)
                {
                    if (UpdateInvoiceAndTableStatus())
                    {
                        PaySuccessful();
                        this.Hide();
                    };
                }
            }
        }
    }
}
