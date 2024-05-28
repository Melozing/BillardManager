using BiaManager.Script;
using BillardManager.Admin;
using BillardManager.Model;
using System;
using System.Collections;
using System.Windows.Forms;

namespace BillardManager.View
{
    public partial class FormFoodView : SampleView
    {
        public FormFoodView()
        {
            InitializeComponent();
        }

        private void FormFoodView_Load(object sender, System.EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string query = "SELECT im.IdItem, im.item_Name, im.item_Price, ic.ItemCategory_Name, ic.IdItemCategory " +
                           "FROM items_menu im " +
                           "JOIN items_category ic ON im.IdItemCategory = ic.IdItemCategory " +
                           "WHERE (im.item_Name LIKE '%" + guna2TextBoxSearch.Text + "%' " +
                           "OR ic.ItemCategory_Name LIKE '%" + guna2TextBoxSearch.Text + "%' " +
                           "OR im.item_Price LIKE '%" + guna2TextBoxSearch.Text + "%') " +
                           "AND im.ItemStatus != 1 AND im.IdItem !='IHour'";


            ListBox lb = new ListBox();
            lb.Items.Add(Id);
            lb.Items.Add(name);
            lb.Items.Add(Price);
            lb.Items.Add(categoryName);
            lb.Items.Add(categoryID);

            MainClass.LoadData(query, guna2DataGridViewCategory, lb);
        }
        public override void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FormFoodAdd());
            GetData();
        }

        public override void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryEdit")
            {
                FormFoodAdd frm = new FormFoodAdd();
                frm.id = guna2DataGridViewCategory.CurrentRow.Cells["Id"].Value.ToString();
                frm.categoryId = guna2DataGridViewCategory.CurrentRow.Cells["categoryID"].Value.ToString();

                MainClass.BlurBackground(frm);
                GetData();
            }
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryDelete")
            {
                DialogResult dialogResult = MessageFuctionConstans.OKCancel("Are you sure you want to delete?");
                if (dialogResult == DialogResult.OK)
                {
                    string id = guna2DataGridViewCategory.CurrentRow.Cells["Id"].Value.ToString();
                    string query = "Update items_menu set ItemStatus = 1 where IdItem ='" + id + "'";
                    Hashtable hashtable = new Hashtable();
                    MainClass.SQL(query, hashtable);

                    MessageFuctionConstans.SuccessOK("Deleted successfully!");
                    GetData();
                }
            }
        }
    }
}
