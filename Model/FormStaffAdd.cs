using BiaManager.Script;
using BillardManager.Admin;
using BillardManager.Scripts.Ultility;
using System;
using System.Collections;

namespace BillardManager.Model
{
    public partial class FormStaffAdd : SampleAdd
    {
        public FormStaffAdd()
        {
            InitializeComponent();
        }

        public string id;
        public override void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            string queryUserAccount;
            string queryUserInfo;
            string hashedPassword = PasswordHasher.HashPassword("123456");
            Hashtable ht = new Hashtable();

            if (string.IsNullOrEmpty(id))
            {
                // Generate a new unique ID
                id = MainClass.GenerateUniqueId("user_account", "IdUser", "U");

                // Insert into user_account
                queryUserAccount = "INSERT INTO user_account (IdUser, UserName, UserPassword, UserRole, AccountStatus) " +
                                   "VALUES (@id, @UserName, @UserPassword, 1, 0)";

                // Insert into user_info
                queryUserInfo = "INSERT INTO user_info (idUser, User_FullName, User_Phone, User_BankAccountNumber, User_BankName) " +
                                "VALUES (@id, @User_FullName, @User_Phone, @User_BankAccountNumber, @User_BankName)";

                ht.Add("@id", id);
            }
            else
            {
                // Update user_account
                queryUserAccount = "UPDATE user_account SET UserName = @UserName, UserPassword = @UserPassword, AccountStatus = 0 " +
                                   "WHERE IdUser = @id";

                // Update user_info
                queryUserInfo = "UPDATE user_info SET User_FullName = @User_FullName, User_Phone = @User_Phone, User_BankAccountNumber = @User_BankAccountNumber, User_BankName = @User_BankName " +
                                "WHERE idUser = @id";

                ht.Add("@id", id);
            }

            ht.Add("@UserName", guna2TextBoxUsername.Text);
            ht.Add("@UserPassword", hashedPassword);
            ht.Add("@User_FullName", guna2TextBoxFullName.Text);
            ht.Add("@User_Phone", guna2TextBoxPhone.Text);
            ht.Add("@User_BankAccountNumber", guna2TextBoxBankAccountNumber.Text);
            ht.Add("@User_BankName", guna2TextBoxBankName.Text);

            if (MainClass.SQL(queryUserAccount, ht) > 0 && MainClass.SQL(queryUserInfo, ht) > 0)
            {
                MessageFuctionConstans.SuccessOK("Saved successfully...");
                id = null;
                guna2TextBoxUsername.Clear();
                guna2TextBoxFullName.Clear();
                guna2TextBoxPhone.Clear();
                guna2TextBoxBankAccountNumber.Clear();
                guna2TextBoxBankName.Clear();
                guna2TextBoxUsername.Focus();
            }
        }

        private void guna2TextBoxBankAccountNumber_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
