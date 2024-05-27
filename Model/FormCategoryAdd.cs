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

        private string _categoryId = null;

        public override void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            string query = "";
            Hashtable ht = new Hashtable();

            if (string.IsNullOrEmpty(_categoryId))
            {
                _categoryId = MainClass.GenerateUniqueId("items_category", "IdItemCategory", "IC"); // Generate a new unique ID
                query = "INSERT INTO items_category (IdItemCategory, ItemCategory_Name) VALUES (@id, @Name)";
                ht.Add("@id", _categoryId);
            }
            else
            {
                query = "UPDATE items_category SET ItemCategory_Name = @Name WHERE IdItemCategory = @id";
                ht.Add("@id", _categoryId);
            }

            ht.Add("@Name", guna2TextBoxName.Text);

            if (MainClass.SQL(query, ht) > 0)
            {
                MessageFuctionConstans.SuccessOK("Saved successfully...");
                _categoryId = null;
                guna2TextBoxName.Clear();
                guna2TextBoxName.Focus();
            }
        }
    }
}
