using BiaManager.Script;
using System.Windows.Forms;

namespace BillardManager
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void guna2ButtonExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ButtonLogin_Click(object sender, System.EventArgs e)
        {
            if (!MainClass.IsValidUser(guna2TextBoxUsername.Text, guna2TextBoxPassword.Text))
            {
                MessageFuctionConstans.WarningOK("Invalid Username or Passowrd!");
                return;
            }
            else
            {
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
            }
        }
    }
}
