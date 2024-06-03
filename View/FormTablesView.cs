using BiaManager.Script;
using BillardManager.Admin;
using BillardManager.Forms;
using BillardManager.Model;
using System;
using System.Collections;
using System.Windows.Forms;

namespace BillardManager.View
{
    public partial class FormTablesView : SampleView
    {
        public FormTablesView()
        {
            InitializeComponent();
        }

        private void FormTablesView_Load(object sender, System.EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string query = "Select TableIDType,TableType_Name,TableType_Price " +
                "from table_type " +
                "WHERE (TableType_Name LIKE '%" + guna2TextBoxSearch.Text + "%' OR TableType_Price LIKE '%" + guna2TextBoxSearch.Text + "%') " +
                " AND TableTypeStatus != 1";
            ListBox lb = new ListBox();
            lb.Items.Add(IdItemCategory);
            lb.Items.Add(ItemCategory_Name);
            lb.Items.Add(TableType_Price);

            MainClass.LoadData(query, guna2DataGridViewCategory, lb);
        }
        public override void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FormTableAdd());
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
                FormTableDetailAdd frm = new FormTableDetailAdd();
                frm.tableDetailId = guna2DataGridViewCategory.CurrentRow.Cells["IdItemCategory"].Value.ToString();
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
                    string query = "Update table_type set TableTypeStatus = 1 where TableIDType ='" + id + "'";
                    Hashtable hashtable = new Hashtable();
                    MainClass.SQL(query, hashtable);

                    MessageFuctionConstans.SuccessOK("Deleted successfully!");
                    GetData();
                }
            }
        }
    }
}
