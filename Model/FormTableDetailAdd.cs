using BiaManager.Script;
using BillardManager.Admin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace BillardManager.Model
{
    public partial class FormTableDetailAdd : SampleAdd
    {
        public string tableTypeId;
        public string tableDetailId;
        public FormTableDetailAdd()
        {
            InitializeComponent();
            
        }

        private void FormTableDetailAdd_Load(object sender, System.EventArgs e)
        {
            string query = "Select TableIDType 'id', TableType_Name 'name' from table_type Where TableTypeStatus != 1";
            MainClass.CBFILL(query, comboBoxCategory);
            pic_table.Image = null;
            if (!string.IsNullOrEmpty(tableTypeId))
            {
                comboBoxCategory.SelectedValue = tableTypeId;
            }
        }



        private void guna2ButtonSave_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn loại bàn chưa
            if (comboBoxCategory.SelectedIndex < 0)
            {
                MessageFuctionConstans.WarningOK("Please select a table type!");
                comboBoxCategory.Focus();
                return;
            }

            // Xác định số bàn tiếp theo dựa trên dữ liệu hiện có trong cơ sở dữ liệu
            int nextTableNumber = GetNextTableNumber();

            // Tạo một Hashtable chứa thông tin cần thiết cho truy vấn SQL
            Hashtable ht = new Hashtable();

            // Tạo một id cho bàn mới nếu là trường hợp thêm mới
            string tableDetailIdSet = string.IsNullOrEmpty(tableDetailId) ? MainClass.GenerateUniqueId("table_detail", "TableID", "TDT") : tableDetailId;

            // Thực hiện truy vấn SQL để thêm hoặc cập nhật dữ liệu
            string query;
            if (string.IsNullOrEmpty(tableDetailId))
            {

                // Thêm mới bàn
                query = "INSERT INTO table_detail (TableID, TableNumber, Status, TableIDType, TableStatus) VALUES (@id, @TableNumber, 0, @idType, 0)";
                ht.Add("@TableNumber", nextTableNumber);
            }
            else
            {
                // Cập nhật thông tin bàn
                query = "UPDATE table_detail SET TableIDType = @idType WHERE TableID = @id";
            }

            ht.Add("@id", tableDetailIdSet);
            // Thêm thông tin vào Hashtable
            ht.Add("@idType", comboBoxCategory.SelectedValue.ToString());

            // Thực thi truy vấn SQL và kiểm tra xem có thành công không
            if (MainClass.SQL(query, ht) > 0)
            {
                // Hiển thị thông báo và làm sạch các trường nhập liệu
                MessageFuctionConstans.SuccessOK("Saved successfully...");
                tableDetailId = null; // Không sửa đổi giá trị của biến này
                comboBoxCategory.SelectedIndex = -1;
                comboBoxCategory.Focus();
            }
        }
        private int GetNextTableNumber()
        {
            // Khởi tạo số bàn mặc định
            int nextTableNumber = 1;
            Hashtable ht = new Hashtable();
            // Tạo câu truy vấn SQL để lấy số bàn lớn nhất hiện có
            string query = "SELECT TableNumber FROM table_detail WHERE TableStatus != 1 ORDER BY TableNumber ASC";
            DataTable dt = MainClass.LoadDataTable(query, ht);

            // Tạo một danh sách các số bàn đã được sử dụng
            List<int> usedTableNumbers = new List<int>();
            foreach (DataRow row in dt.Rows)
            {
                usedTableNumbers.Add(Convert.ToInt32(row["TableNumber"]));
            }

            // Tìm số bàn tiếp theo dựa trên các số bàn đã sử dụng
            for (int i = 1; i <= usedTableNumbers.Count + 1; i++)
            {
                if (!usedTableNumbers.Contains(i))
                {
                    nextTableNumber = i;
                    break;
                }
            }

            return nextTableNumber;
        }



        private void guna2TextBoxName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị PictureBox tương ứng với giá trị đã chọn trong ComboBox
            if (comboBoxCategory.SelectedValue != null)
            {
                string selectedValue = comboBoxCategory.Text.ToString();

                if (selectedValue == "Carom billiards")
                {
                    pic_table.Image = Properties.Resources.caromBilliards; // Ảnh bàn carrom
                }
                else if (selectedValue == "Pocket billiards")
                {
                    pic_table.Image = Properties.Resources.pocketBilliards; // Ảnh bàn pool
                }
                else
                {
                    pic_table.Image = Properties.Resources.defaultTable; // Ảnh mặc định
                }
            }
        }
    }
}
