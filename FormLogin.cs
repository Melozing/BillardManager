using BiaManager.Script;
using System.Windows.Forms;

namespace BillardManager
{
    public partial class FormLogin : Form
    {
        public static bool isStaffLogin;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void guna2ButtonExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
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
                if (isStaffLogin)
                {
                    formMain.isStaffLogin = isStaffLogin;
                }
                formMain.Show();
                this.Hide();
            }
        }
    }
}
