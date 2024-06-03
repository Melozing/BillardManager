using BiaManager.Script;
using BillardManager.Admin;
using System;
using System.Collections;

namespace BillardManager.Forms
{
    public partial class FormTableAdd : SampleAdd
    {
        public FormTableAdd()
        {
            InitializeComponent();
        }
        public string tableId;
        public override void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            string query;
            Hashtable ht = new Hashtable();

            if (string.IsNullOrEmpty(tableId))
            {
                tableId = MainClass.GenerateUniqueId("table_type", "TableIDType", "TBT"); // Generate a new unique ID
                query = "INSERT INTO table_type (TableIDType, TableType_Name, TableType_Price, TableTypeStatus) VALUES (@id, @Name, @Price, 0)";
                ht.Add("@id", tableId);
            }
            else
            {
                query = "UPDATE table_type SET TableType_Name = @Name, TableType_Price = @Price WHERE IdItemCategory = @id";
                ht.Add("@id", tableId);
            }

            ht.Add("@Name", guna2TextBoxName.Text);
            ht.Add("@Price", guna2TextBoxPrice.Text);

            if (MainClass.SQL(query, ht) > 0)
            {
                MessageFuctionConstans.SuccessOK("Saved successfully...");
                tableId = null;
                guna2TextBoxName.Clear();
                guna2TextBoxName.Focus();
            }
        }

        private void guna2TextBoxPrice_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
