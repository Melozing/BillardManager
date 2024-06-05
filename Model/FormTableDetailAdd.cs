using BiaManager.Script;
using BillardManager.Admin;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace BillardManager.Model
{
    public partial class FormTableDetailAdd : SampleAdd
    {
        public string tableTypeId;
        public string tableDetailId;
        public FormTableDetailAdd()
        {
            InitializeComponent();
        }

        private void FormTableDetailAdd_Load(object sender, System.EventArgs e)
        {
            string query = "Select TableIDType 'id', TableType_Name 'name' from table_type Where TableTypeStatus != 1";
            MainClass.CBFILL(query, comboBoxCategory);

            if (!string.IsNullOrEmpty(tableTypeId))
            {
                comboBoxCategory.SelectedValue = tableTypeId;
            }
            if (!string.IsNullOrEmpty(tableDetailId))
            {
                ForUpdateLoadData();
            }
        }

        private void guna2ButtonSave_Click_1(object sender, System.EventArgs e)
        {
            string query;
            Hashtable ht = new Hashtable();

            if (string.IsNullOrEmpty(tableDetailId))
            {
                tableDetailId = MainClass.GenerateUniqueId("table_detail", "TableID", "TDT"); // Generate a new unique ID
                query = "INSERT INTO table_detail (TableID, TableNumber, Status, TableIDType, TableStatus) VALUES (@id, @Name, 0, @idType, 0)";
                ht.Add("@id", tableDetailId);
            }
            else
            {
                query = "UPDATE table_detail SET TableNumber = @Name WHERE TableID = @id";
                ht.Add("@id", tableDetailId);
            }

            ht.Add("@Name", guna2TextBoxName.Text);
            ht.Add("@idType", comboBoxCategory.SelectedValue.ToString());
            if (MainClass.SQL(query, ht) > 0)
            {
                MessageFuctionConstans.SuccessOK("Saved successfully...");
                tableDetailId = null;
                guna2TextBoxName.Clear();
                comboBoxCategory.SelectedIndex = 0;
                comboBoxCategory.SelectedIndex = -1;
                guna2TextBoxName.Focus();
            }
        }

        private void guna2TextBoxName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public override void guna2ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ForUpdateLoadData()
        {
            string query = @"Select * from table_detail where TableID = '" + tableDetailId + "'";
            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                guna2TextBoxName.Text = dt.Rows[0]["TableNumber"].ToString();
            }
        }
    }
}
