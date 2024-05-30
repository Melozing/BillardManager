using BillardManager.Admin;
using System;

namespace BillardManager.Model
{
    public partial class FormCheckOut : SampleAdd
    {
        public FormCheckOut()
        {
            InitializeComponent();
        }

        public double amount;

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
            string query = @"";
        }
    }
}
