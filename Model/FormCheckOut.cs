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
        private void guna2TextBox1_TextChanged(object sender, System.EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(guna2TextBoxBillAmount.Text, out amt);
            double.TryParse(guna2TextBoxReceived.Text, out amt);

            change = amt - receipt;

            guna2TextBoxChange.Text = change.ToString();
        }
        public override void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            string query = @"Update invoice set Invoice_Total = @total, 
                            Invoice_Received = @rec, Invoice_Change = @change";
        }

        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            MessageBox.Show(tableID);
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
