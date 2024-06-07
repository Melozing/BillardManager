using BiaManager.Script;
using BillardManager.Admin;
using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace BillardManager.Forms
{
    public partial class FormTableAdd : SampleAdd
    {
        public FormTableAdd()
        {
            InitializeComponent();
        }
        public string tableId;
        private bool CheckInputTableType()
        {
            if (string.IsNullOrWhiteSpace(guna2TextBoxName.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid name!");
                return false;
            }

            if (!int.TryParse(Regex.Replace(guna2TextBoxPrice.Text, @"[^\d]", "").ToString(), out int price) || price < 0)
            {
                MessageFuctionConstans.WarningOK("Please enter a reasonable price level!");
                return false;
            }

            Hashtable ht = new Hashtable();

            string queryCheck = "SELECT * FROM table_type WHERE TableType_Name = '" + guna2TextBoxName.Text + "' " +
                "AND TableTypeStatus != 1 AND TableIDType != '" + tableId + "'";

            if (MainClass.SQL(queryCheck, ht) > 0)
            {
                MessageFuctionConstans.WarningOK("This TableType name already exists. Please enter another name.");
                return false;
            }
            return true;
        }
        public override void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputTableType()) return;

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
                query = "UPDATE table_type SET TableType_Name = @Name, TableType_Price = @Price WHERE TableIDType = @id";
                ht.Add("@id", tableId);
            }

            ht.Add("@Name", guna2TextBoxName.Text);
            ht.Add("@Price", Regex.Replace(guna2TextBoxPrice.Text, @"[^\d]", ""));

            if (MainClass.SQL(query, ht) > 0)
            {
                MessageFuctionConstans.SuccessOK("Saved successfully...");
                if (tableId == null)
                {
                    tableId = null;
                    guna2TextBoxName.Clear();
                    guna2TextBoxPrice.Clear();
                    guna2TextBoxName.Focus();
                }
            }
        }

        private void guna2TextBoxPrice_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBoxPrice.Text))
            {
                double receipt = double.Parse(guna2TextBoxPrice.Text);
                guna2TextBoxPrice.Text = receipt.ToString("N0");
                guna2TextBoxPrice.SelectionStart = guna2TextBoxPrice.Text.Length;
            }
        }
        public override void guna2ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
