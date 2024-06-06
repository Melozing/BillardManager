using BillardManager.Admin;

namespace BillardManager.Model
{
    public partial class FormBillList : SampleAdd
    {
        public string idInvoice;
        public FormBillList()
        {
            InitializeComponent();
        }

        private void guna2DataGridViewCategory_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryEdit")
            {
                // To see bill detail
                idInvoice = guna2DataGridViewCategory.CurrentRow.Cells["Id"].Value.ToString();

            }
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryDelete")
            {
                // To print Bill
            }
        }
    }
}
