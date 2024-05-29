using BillardManager.Forms;
using BillardManager.Model;
using BillardManager.View;
using System;
using System.Windows.Forms;

namespace BillardManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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
            AddControls(new FormPOS());
        }

        private void guna2ControlBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
