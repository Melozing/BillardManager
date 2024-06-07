using BiaManager.Script;
using BillardManager.Admin;
using BillardManager.Model;
using System;
using System.Collections;
using System.Windows.Forms;

namespace BillardManager.View
{
    public partial class FormStaffView : SampleView
    {
        public FormStaffView()
        {
            InitializeComponent();
        }

        private void FormStaffView_Load(object sender, System.EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string query = "SELECT ua.IdUser, ua.UserName, " +
               "ui.User_FullName, ui.User_Phone, ui.User_BankAccountNumber, ui.User_BankName " +
               "FROM user_account ua " +
               "JOIN user_info ui ON ua.IdUser = ui.idUser " +
               "WHERE (ua.UserName LIKE '%" + guna2TextBoxSearch.Text + "%' " +
               "OR ui.User_FullName LIKE '%" + guna2TextBoxSearch.Text + "%' " +
               "OR ui.User_Phone LIKE '%" + guna2TextBoxSearch.Text + "%' " +
               "OR ui.User_BankAccountNumber LIKE '%" + guna2TextBoxSearch.Text + "%' " +
               "OR ui.User_BankName LIKE '%" + guna2TextBoxSearch.Text + "%') " +
               "AND ua.AccountStatus != 1 AND ua.idUser != 'U0'";

            ListBox lb = new ListBox();
            lb.Items.Add(Id);
            lb.Items.Add(Username);
            lb.Items.Add(User_FullName);
            lb.Items.Add(User_Phone);
            lb.Items.Add(User_BankAccountNumber);
            lb.Items.Add(User_BankName);

            MainClass.LoadData(query, guna2DataGridViewCategory, lb);
        }
        public override void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FormStaffAdd());
            GetData();
        }

        public override void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridViewCategory.RowCount < 1) return;
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryEdit")
            {
                FormStaffAdd frm = new FormStaffAdd();
                frm.id = guna2DataGridViewCategory.CurrentRow.Cells["Id"].Value.ToString();
                frm.guna2TextBoxUsername.Text = guna2DataGridViewCategory.CurrentRow.Cells["Username"].Value.ToString();
                frm.guna2TextBoxFullName.Text = guna2DataGridViewCategory.CurrentRow.Cells["User_FullName"].Value.ToString();
                frm.guna2TextBoxPhone.Text = guna2DataGridViewCategory.CurrentRow.Cells["User_Phone"].Value.ToString();
                frm.guna2TextBoxBankAccountNumber.Text = guna2DataGridViewCategory.CurrentRow.Cells["User_BankAccountNumber"].Value.ToString();
                frm.guna2TextBoxBankName.Text = guna2DataGridViewCategory.CurrentRow.Cells["User_BankName"].Value.ToString();
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (guna2DataGridViewCategory.CurrentCell.OwningColumn.Name == "ItemCategoryDelete")
            {
                DialogResult dialogResult = MessageFuctionConstans.OKCancel("Are you sure you want to delete?");
                if (dialogResult == DialogResult.OK)
                {
                    string id = guna2DataGridViewCategory.CurrentRow.Cells["Id"].Value.ToString();
                    string query = "Update user_account set AccountStatus = 1 where IdUser ='" + id + "'";
                    Hashtable hashtable = new Hashtable();
                    MainClass.SQL(query, hashtable);

                    MessageFuctionConstans.SuccessOK("Deleted successfully!");
                    GetData();
                }
            }
        }
    }
}
