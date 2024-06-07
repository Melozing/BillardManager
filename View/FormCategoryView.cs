using BiaManager.Script;
using BillardManager.Admin;
using BillardManager.Model;
using System;
using System.Collections;
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
            string query = "Select IdItemCategory,ItemCategory_Name " +
                "from items_category where ItemCategory_Name like '%" + guna2TextBoxSearch.Text + "%'" +
                " AND ItemCategoryStatus != 1";
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
            //FormCategoryAdd frm = new FormCategoryAdd();
            //frm.ShowDialog();
            MainClass.BlurBackground(new FormCategoryAdd());
            GetData();
        }

        public override void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridViewCategory.RowCount < 1) return;
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryEdit")
            {
                FormCategoryAdd frm = new FormCategoryAdd();
                frm.categoryId = guna2DataGridViewCategory.CurrentRow.Cells["IdItemCategory"].Value.ToString();
                frm.guna2TextBoxName.Text = guna2DataGridViewCategory.CurrentRow.Cells["ItemCategory_Name"].Value.ToString();
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryDelete")
            {
                DialogResult dialogResult = MessageFuctionConstans.OKCancel("Are you sure you want to delete?");
                if (dialogResult == DialogResult.OK)
                {
                    string id = guna2DataGridViewCategory.CurrentRow.Cells["IdItemCategory"].Value.ToString();
                    string query = "Update items_category set ItemCategoryStatus = 1 where IdItemCategory ='" + id + "'";
                    Hashtable hashtable = new Hashtable();
                    MainClass.SQL(query, hashtable);

                    MessageFuctionConstans.SuccessOK("Deleted successfully!");
                    GetData();
                }
            }
        }

        private void guna2TextBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
