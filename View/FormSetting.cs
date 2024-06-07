using BiaManager.Script;
using System;
using System.Collections;
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

        private void guna2ButtonChoicePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                guna2TextBoxDirectBill.Text = folder.SelectedPath;
                UpdateBillPath(guna2TextBoxDirectBill.Text);
            }
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            guna2TextBoxDirectBill.Text = FormMain.pathExportBill;
        }

        private void UpdateBillPath(string path)
        {
            FormMain.pathExportBill = path;
            Hashtable ht = new Hashtable();
            string query = @"Update user_info Set User_BillPath = @path " +
                "Where idUser = @idUser";
            ht.Add("@path", path.ToString());
            ht.Add("@idUser", FormMain.Instance.idUser.ToString());
            MainClass.SQL(query, ht);
        }
    }
}
