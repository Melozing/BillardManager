using BillardManager.Admin;
using BillardManager.Model;
using System;
using System.Windows.Forms;

namespace BillardManager.View
{
    public partial class FormCategoryView : SampleView
    {
        public FormCategoryView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string query = "Select * from items_category where ItemCategory_Name like '%" + guna2TextBoxSearch + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(IdItemCategory);
            lb.Items.Add(ItemCategory_Name);

            MainClass.LoadData(query, guna2DataGridViewCategory, lb);
        }

        private void FormCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            FormCategoryAdd frm = new FormCategoryAdd();
            frm.ShowDialog();
            GetData();
        }

        public override void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
