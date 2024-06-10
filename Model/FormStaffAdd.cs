using BiaManager.Script;
using BillardManager.Admin;
using BillardManager.Scripts.Ultility;
using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormStaffAdd : SampleAdd
    {
        public FormStaffAdd()
        {
            InitializeComponent();

            guna2ComboBoxBankName.Items.AddRange(new string[]
            {
                "MB BANK",
                "AGRIBANK",
                "TECHCOMBANK",
                "VIETTIN BANK",
                "VIETCOM BANK"
            });
            guna2ComboBoxBankName.SelectedIndex = -1;
        }

        public string id;
        


        public override void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            if (!CheckUserInputCreate()) return;
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

            // Lấy giá trị từ ComboBoxBankName
            if (guna2ComboBoxBankName.SelectedItem != null)
            {
                ht.Add("@User_BankName", guna2ComboBoxBankName.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a bank name.");
                return;
            }

            if (MainClass.SQL(queryUserAccount, ht) > 0 && MainClass.SQL(queryUserInfo, ht) > 0)
            {
                MessageFuctionConstans.SuccessOK("Saved successfully...");
                id = null;
                guna2TextBoxUsername.Clear();
                guna2TextBoxFullName.Clear();
                guna2TextBoxPhone.Clear();
                guna2TextBoxBankAccountNumber.Clear();
                guna2ComboBoxBankName.SelectedIndex = -1;
                guna2TextBoxUsername.Focus();
            }
        }
        private bool CheckAccount(string username)
        {
            return Regex.IsMatch(username, "^[a-zA-Z0-9]{6,24}");
        }
        private bool CheckFullName(string name)
        {
            return Regex.IsMatch(name, "^[a-zA-Z0-9]{1,5}");
        }

        private bool CheckUserInputCreate()
        {
            // Kiểm tra tính hợp lệ của tên đăng nhập và mật khẩu
            if (!CheckAccount(guna2TextBoxUsername.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid username and password. They should be 6-24 characters long and should not contain any special characters!");
                return false;
            }
            if (!CheckFullName(guna2TextBoxFullName.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid Full Name.");
                return false;
            }

            // Kiểm tra số điện thoại đã tồn tại trong cơ sở dữ liệu hay chưa
            string queryCheckPhone = "SELECT ua.*, ui.* " +
                "FROM user_account AS ua " +
                "JOIN user_info AS ui " +
                "ON ua.IdUser = ui.IdUser " +
                "WHERE ui.User_Phone = '" + guna2TextBoxPhone.Text + "' " +
                "AND ua.AccountStatus != 1";
            Hashtable ht = new Hashtable();
            if (MainClass.SQL(queryCheckPhone, ht) > 0)
            {
                MessageFuctionConstans.WarningOK("This phone number already exists. Please enter another number.");
                return false;
            }
            return true;
        }
        private void guna2TextBoxBankAccountNumber_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
    }
}
