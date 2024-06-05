using BiaManager.Script;
using System;
using System.Windows.Forms;

namespace BillardManager.View
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void guna2ButtonSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.OKCancel("Would you like to log out of this account?");
            if (result == DialogResult.OK)
            {
                this.Close();
                FormMain.Instance.Close();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }
    }
}
