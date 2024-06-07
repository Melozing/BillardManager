using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BillardManager.View
{
    public partial class FormUserInfoView : Form
    {
        public FormUserInfoView()
        {
            InitializeComponent();
        }

        private void FormUserInfoView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            using (SqlConnection connection = new SqlConnection(MainClass.connect_string))
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL
                string query = "SELECT * FROM user_info";

                // Tạo đối tượng SqlCommand để thực hiện truy vấn
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và nhận dữ liệu bằng SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Kiểm tra xem có dòng dữ liệu nào không
                        if (reader.HasRows)
                        {
                            // Duyệt qua từng dòng và xử lý dữ liệu
                            while (reader.Read())
                            {
                                guna2TextBoxFullName.Text = reader["User_FullName"].ToString();
                                guna2TextBoxPhone.Text = reader["User_Phone"].ToString();
                                guna2TextBoxBankAccountNumber.Text = reader["User_BankAccountNumber"].ToString();
                                guna2TextBoxBankName.Text = reader["User_BankName"].ToString();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
        }
    }
}
