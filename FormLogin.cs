using BiaManager.Script;
using System.Windows.Forms;
using BillardManager.View;

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
        }

        private void guna2ButtonExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void panelTittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            WindowSizeCtrl.MoveWindow(this.Handle);
        }
        private void guna2ButtonLogin_Click(object sender, System.EventArgs e)
        {
            if (!MainClass.IsValidUser(guna2TextBoxUsername.Text, guna2TextBoxPassword.Text))
            {
                //MessageFuctionConstans.WarningOK("Invalid Username or Passowrd!");
                messageBox.ShowMess("Invalid Username or Passowrd!");
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

        private void guna2CheckBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (guna2CheckBox1.Checked == false)
            {
                guna2TextBoxPassword.UseSystemPasswordChar =  true;
            }
            else
            {
                guna2TextBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            WindowSizeCtrl.MoveWindow(this.Handle);
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vtc.edu.vn/");
        }
    }
}
