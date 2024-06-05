using BiaManager.Script;
using BillardManager.Admin;
using BillardManager.Model;
using System;
using System.Collections;
using System.Windows.Forms;

namespace BillardManager.View
{
    public partial class FormTablesDetailView : SampleView
    {
        public FormTablesDetailView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string query = "SELECT td.TableID, td.TableNumber, tt.TableType_Name, td.TableIDType " +
               "FROM table_detail td " +
               "JOIN table_type tt ON td.TableIDType = tt.TableIDType " +
               "WHERE (tt.TableType_Name LIKE '%" + guna2TextBoxSearch.Text + "%' " +
               "OR tt.TableType_Price LIKE '%" + guna2TextBoxSearch.Text + "%') " +
               "AND tt.TableTypeStatus != 1 ORDER BY td.TableNumber";

            ListBox lb = new ListBox();
            lb.Items.Add(IdItemCategory);
            lb.Items.Add(ItemCategory_Name);
            lb.Items.Add(TableType);
            lb.Items.Add(TypeID);

            MainClass.LoadData(query, guna2DataGridViewCategory, lb);
        }
        public override void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FormTableDetailAdd());
            GetData();
        }

        private void guna2DataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryEdit")
            {
                FormTableDetailAdd frm = new FormTableDetailAdd();
                frm.tableDetailId = guna2DataGridViewCategory.CurrentRow.Cells["IdItemCategory"].Value.ToString();
                frm.tableTypeId = guna2DataGridViewCategory.CurrentRow.Cells["TypeID"].Value.ToString();
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryDelete")
            {
                DialogResult dialogResult = MessageFuctionConstans.OKCancel("Are you sure you want to delete?");
                if (dialogResult == DialogResult.OK)
                {
                    string id = guna2DataGridViewCategory.CurrentRow.Cells["IdItemCategory"].Value.ToString();
                    string query = "Update table_detail set TableStatus = 1 where TableID ='" + id + "'";
                    Hashtable hashtable = new Hashtable();
                    MainClass.SQL(query, hashtable);

                    MessageFuctionConstans.SuccessOK("Deleted successfully!");
                    GetData();
                }
            }
        }
        private void guna2TextBoxSearch_TextChanged_1(object sender, System.EventArgs e)
        {
            GetData();
        }

        private void FormTablesDetailView_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
