using BillardManager.Forms;
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

        }

        private void guna2ButtonHome_Click(object sender, EventArgs e)
        {
            AddControls(new FormHome());
        }
    }
}
