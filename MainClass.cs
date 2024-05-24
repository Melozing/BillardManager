using BillardManager.Scripts.Ultility;
using System.Data;
using System.Data.SqlClient;

namespace BillardManager
{
    class MainClass
    {
        public static readonly string connect_string = "Data Source=DESKTOP-G0D14LK;Initial Catalog=db_biamanager;Initial Catalog=db_biamanager;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connect_string);

        //Methord to check user validation
        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;
            string hashedPassword = PasswordHasher.HashPassword(password);
            string query = "SELECT * FROM user_account WHERE UserName = '" + username + "' AND UserPassword = '" + hashedPassword + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            if (data.Rows.Count > 0)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
