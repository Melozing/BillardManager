using BillardManager.Forms;
using BillardManager.Model;
using BillardManager.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillardManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public bool isStaffLogin;
        public string userPathBill;
        public string idUser;
        public string userFullName;
        public string userBillPath;

        public static string pathExportBill;

        static FormMain _obj;
        public static FormMain Instance
        {
            get { if (_obj == null) { _obj = new FormMain(); } return _obj; }
        }

        private void AddControls(Form form)
        {
            gunaPanelContent.Controls.Clear();
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            gunaPanelContent.Controls.Add(form);
            form.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _obj = this;
            guna2ButtonHome.PerformClick();
            if (isStaffLogin)
            {
                StaffLogin();
            }
            if (!string.IsNullOrEmpty(userPathBill))
            {
                pathExportBill = userPathBill;
            }
            else
            {
                pathExportBill = AppDomain.CurrentDomain.BaseDirectory;
            }
        }
        private void StaffLogin()
        {
            guna2ButtonUserManagement.Hide();
            guna2ButtonFoodType.Hide();
            guna2ButtonFoodManagement.Hide();
            guna2ButtonTableManagement.Hide();
            guna2ButtonTableDetail.Hide();
            guna2ButtonTimeTable.Hide();
            guna2ButtonSetting.Location = new Point(-20, 215);
        }

        private void guna2ButtonHome_Click(object sender, EventArgs e)
        {
            AddControls(new FormHome());
        }

        private void guna2ButtonMenu_Click(object sender, EventArgs e)
        {
            AddControls(new FormCategoryView());
        }

        private void guna2ButtonTables_Click(object sender, EventArgs e)
        {
            AddControls(new FormTablesView());
        }

        private void guna2ButtonUserManagement_Click(object sender, EventArgs e)
        {
            AddControls(new FormStaffView());
        }

        private void guna2ButtonItem_Click(object sender, EventArgs e)
        {
            AddControls(new FormFoodView());
        }

        private void guna2ButtonTable_Click(object sender, EventArgs e)
        {
            AddControls(new FormTableOrder());
        }

        private void guna2ControlBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ButtonTableDetail_Click(object sender, EventArgs e)
        {
            AddControls(new FormTablesDetailView());
        }

        private void guna2ButtonSetting_Click(object sender, EventArgs e)
        {
            AddControls(new FormSetting());
        }

        private void guna2ButtonBills_Click(object sender, EventArgs e)
        {
            AddControls(new FormBillView());
        }

        private void guna2ButtonUser_Click(object sender, EventArgs e)
        {
            AddControls(new FormUserInfoView());
        }

        private void guna2ButtonTimeTable_Click(object sender, EventArgs e)
        {
            AddControls((new FormTimeTableWork()));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new Formrreport());
        }
    }
}
