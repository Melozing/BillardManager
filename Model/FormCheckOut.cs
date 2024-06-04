using BillardManager.Admin;
using System;
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
            string query = @"Update invoice set 
                            Invoice_Total = @total, 
                            Invoice_Received = @rec, 
                            Invoice_Change = @change, 
                            Invoice_Status = 1 
                            Where IdInvoice = '" + invoiceID + "'";
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
    }
}
