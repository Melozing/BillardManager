using BiaManager.Script;
using System;
using System.Windows.Forms;

namespace BillardManager
{
    public partial class FormLogin : Form
    {
        public static bool isStaffLogin;
        public static string idUser;
        public static string userFullName;
        public static string userBillPath;

        public FormLogin()
        {
            InitializeComponent();
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
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
                this.Hide();

                FormMain formMain = new FormMain();
                formMain.idUser = idUser;
                formMain.userFullName = userFullName;
                formMain.userPathBill = userBillPath;
                if (isStaffLogin)
                {
                    formMain.isStaffLogin = isStaffLogin;
                }
                formMain.Show();
            }
        }
    }
}
