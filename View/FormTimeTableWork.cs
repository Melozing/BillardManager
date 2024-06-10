using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillardManager.Admin;

namespace BillardManager.View
{
    public partial class FormTimeTableWork : Form
    {
        public FormTimeTableWork()
        {
            InitializeComponent();
        }

        private void FormTimeTableWork_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();

            LoadUsers();
            
            LoadWorkSchedule();
           
        }

        private void LoadUsers()
        {
            string query = "SELECT IdUser, UserName FROM dbo.user_account WHERE UserRole = 1";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(MainClass.connect_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }

            guna2ComboBox1.DisplayMember = "UserName";
            guna2ComboBox1.ValueMember = "IdUser";
            guna2ComboBox1.DataSource = dataTable;
        }

        private void btn_checklogin_Click(object sender, EventArgs e)
        {
            if (guna2DateTimePickerselect != null)
                SaveSchedule(guna2ComboBox1.SelectedValue.ToString(), guna2DateTimePickerselect.Value,
                    guna2DateTimePickerLogIN.Value.TimeOfDay, guna2DateTimePickerlogOUT.Value.TimeOfDay);
            LoadWorkSchedule();
        }

        private void btn_saveschedule_Click(object sender, EventArgs e)
        {
            CheckLateOrEarlyLogin();
        }
        private void ConfigureDataGridView()
        {
            guna2DataGridView1.Columns.Add("ColumnIdSchedule", "IdSchedule");
            guna2DataGridView1.Columns["ColumnIdSchedule"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            guna2DataGridView1.Columns.Add("ColumnUserName", "User Name");
            guna2DataGridView1.Columns["ColumnUserName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            guna2DataGridView1.Columns.Add("ColumnWorkDate", "Work Date");
            guna2DataGridView1.Columns["ColumnWorkDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            guna2DataGridView1.Columns.Add("ColumnStartTime", "Start Time");
            guna2DataGridView1.Columns["ColumnStartTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            guna2DataGridView1.Columns.Add("ColumnEndTime", "End Time");
            guna2DataGridView1.Columns["ColumnEndTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadWorkSchedule()
        {
            string query = @"
        SELECT ws.IdSchedule, ua.UserName, ws.WorkDate, ws.StartTime, ws.EndTime
        FROM dbo.work_schedule ws
        JOIN dbo.user_account ua ON ws.IdUser = ua.IdUser
        WHERE ua.UserRole = 1";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(MainClass.connect_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }

            guna2DataGridView1.Rows.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                DateTime workDate = ConvertToVietnamTime(Convert.ToDateTime(row["WorkDate"]));
                TimeSpan startTime = TimeSpan.Parse(row["StartTime"].ToString());
                TimeSpan endTime = TimeSpan.Parse(row["EndTime"].ToString());

                guna2DataGridView1.Rows.Add(
                    row["IdSchedule"],
                    row["UserName"],
                    workDate.ToString("dd/MM/yyyy HH:mm:ss"), // Định dạng ngày giờ chuẩn
                    DateTime.Today.Add(startTime).ToString("HH:mm:ss"), // Chỉ hiển thị thời gian
                    DateTime.Today.Add(endTime).ToString("HH:mm:ss") // Chỉ hiển thị thời gian
                );
            }

            // Đổi tên cột
            guna2DataGridView1.Columns["ColumnIdSchedule"].HeaderText = "ID";
            guna2DataGridView1.Columns["ColumnUserName"].HeaderText = "Name";
            guna2DataGridView1.Columns["ColumnWorkDate"].HeaderText = "WorkDate";
            guna2DataGridView1.Columns["ColumnStartTime"].HeaderText = "StartTime";
            guna2DataGridView1.Columns["ColumnEndTime"].HeaderText = "EndTime";
        }

        private void SaveSchedule(string userId, DateTime workDate, TimeSpan startTime, TimeSpan endTime)
        {
            string query = "INSERT INTO dbo.work_schedule (IdUser, WorkDate, StartTime, EndTime) VALUES (@IdUser, @WorkDate, @StartTime, @EndTime)";

            Hashtable parameters = new Hashtable
            {
                { "@IdUser", userId },
                { "@WorkDate", workDate },
                { "@StartTime", startTime },
                { "@EndTime", endTime }
            };

            int result = MainClass.SQL(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Schedule saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CheckLateOrEarlyLogin()
        {
            string query = @"
        SELECT lh.IdUser, ua.UserName, ws.WorkDate, ws.StartTime, ws.EndTime, lh.LoginTime, lh.LogoutTime
        FROM dbo.login_history lh
        JOIN dbo.user_account ua ON lh.IdUser = ua.IdUser
        JOIN dbo.work_schedule ws ON lh.IdUser = ws.IdUser AND CAST(lh.LoginTime AS DATE) = ws.WorkDate
        WHERE ua.UserRole = 1";

            using (SqlConnection connection = new SqlConnection(MainClass.connect_string))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    TimeSpan startTime = (TimeSpan)row["StartTime"];
                    TimeSpan endTime = (TimeSpan)row["EndTime"];
                    DateTime loginTime = (DateTime)row["LoginTime"];
                    DateTime? logoutTime = row["LogoutTime"] as DateTime?;

                    if (loginTime.TimeOfDay > startTime)
                    {
                        MessageBox.Show($"User {row["UserName"]} logged in late on {row["WorkDate"]}.", "Late Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (logoutTime.HasValue && logoutTime.Value.TimeOfDay < endTime)
                    {
                        MessageBox.Show($"User {row["UserName"]} logged out early on {row["WorkDate"]}.", "Early Logout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private DateTime ConvertToVietnamTime(DateTime utcTime)
        {
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime vietnamTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, vietnamTimeZone);
            return vietnamTime;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
