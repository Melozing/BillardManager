using BiaManager.Script;
using BillardManager.Admin;
using System;
using System.Collections;

namespace BillardManager.Model
{
    public partial class FormCategoryAdd : SampleAdd
    {
        public FormCategoryAdd()
        {
            InitializeComponent();
        }

        public string categoryId = null;

        public override void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            string query;
            Hashtable ht = new Hashtable();

            if (string.IsNullOrEmpty(categoryId))
            {
                categoryId = MainClass.GenerateUniqueId("items_category", "IdItemCategory", "IC"); // Generate a new unique ID
                query = "INSERT INTO items_category (IdItemCategory, ItemCategory_Name, ItemCategoryStatus) VALUES (@id, @Name, 0)";
                ht.Add("@id", categoryId);
            }
            else
            {
                query = "UPDATE items_category SET ItemCategory_Name = @Name WHERE IdItemCategory = @id";
                ht.Add("@id", categoryId);
            }

            ht.Add("@Name", guna2TextBoxName.Text);

            if (MainClass.SQL(query, ht) > 0)
            {
                MessageFuctionConstans.SuccessOK("Saved successfully...");
                categoryId = null;
                guna2TextBoxName.Clear();
                guna2TextBoxName.Focus();
            }
        }
        public override void guna2ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
