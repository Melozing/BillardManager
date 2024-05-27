using BiaManager.Script;
using BillardManager.Scripts.Ultility;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        //Methord for CRUD operation
        public static int SQL(string query, Hashtable ht)
        {
            int result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (conn.State == ConnectionState.Closed) { conn.Open(); }
                result = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open) { conn.Close(); }
            }
            catch (Exception ex)
            {
                MessageFuctionConstans.ErrorOK(ex.ToString());
                conn.Close();
            }
            return result;
        }

        //For loading data from database
        public static void LoadData(string query, DataGridView gv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageFuctionConstans.ErrorOK(ex.ToString());
                conn.Close();
            }
        }
    }
}
