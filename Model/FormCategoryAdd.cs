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

        private string _categoryId;
        public override void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            string query = "";

            if (_categoryId == "")
            {
                query = "Insert into items_category Value(@Name)";
            }
            else
            {
                query = "Update items_category Set ItemCategory_Name = @Name where IdItemCategory = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", _categoryId);
            ht.Add("@Name", guna2TextBoxName);

            if (MainClass.SQL(query, ht) > 0)
            {
                MessageFuctionConstans.SuccessOK("Saved successfully...");
                _categoryId = "";
                guna2TextBoxName.Focus();
            }
        }
    }
}
