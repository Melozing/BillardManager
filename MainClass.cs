using BiaManager.Script;
using BillardManager.Scripts.Ultility;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BillardManager
{
    class MainClass
    {
        //Manh Laptop : DESKTOP-NQD44KU\MYMSSQLSERVER
        //Manh PC : DESKTOP-G0D14LK
        private static readonly string nameServer = "DESKTOP-NQD44KU\\MYMSSQLSERVER";
        public static readonly string connect_string = "Data Source='" + nameServer + "';Initial Catalog=db_biamanager;Initial Catalog=db_biamanager;Integrated Security=True";
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
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
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
        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
        //Create New ID
        public static string GenerateUniqueId(string nameTable, string nameIdcol, string keyWordId)
        {
            string newId;
            do
            {
                string uuid = Guid.NewGuid().ToString("N"); // Generate a new GUID without hyphens
                newId = keyWordId + uuid.Substring(0, 7); // Create the new ID using the first 7 characters of the GUID
            } while (CheckIfIdExists(newId, nameTable, nameIdcol));

            return newId;
        }

        public static bool CheckIfIdExists(string id, string nameTable, string nameIdcol)
        {
            string query = "SELECT COUNT(*) FROM " + nameTable + " WHERE " + nameIdcol + " = @id";
            using (SqlConnection con = new SqlConnection(connect_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5;
                Background.BackColor = Color.Black;
                Background.Size = FormMain.Instance.Size;
                Background.Location = FormMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        public static void CBFILL(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }
    }
}
