using BiaManager.Script;
using BillardManager.Admin;
using BillardManager.Properties;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormFoodAdd : SampleAdd
    {
        public FormFoodAdd()
        {
            InitializeComponent();
        }
        public string id;
        public string categoryId;
        private string filePath;
        private Byte[] imageByteArray;

        private bool choiceImg = false;
        private bool isUpdate = false;
        private void FormFoodAdd_Load(object sender, System.EventArgs e)
        {
            string query = "Select IdItemCategory 'id', ItemCategory_Name 'name' from items_category WHERE ItemCategoryStatus != 1";
            MainClass.CBFILL(query, comboBoxCategory);

            if (!string.IsNullOrEmpty(categoryId))
            {
                comboBoxCategory.SelectedValue = categoryId;
            }
            if (!string.IsNullOrEmpty(id))
            {
                ForUpdateLoadData();
            }
        }
        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(guna2TextBoxName.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid name!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxCategory.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid type of Item!");
                return false;
            }

            if (!int.TryParse(Regex.Replace(guna2TextBoxPrice.Text, @"[^\d]", "").ToString(), out int price) || price < 0)
            {
                MessageFuctionConstans.WarningOK("Please enter a reasonable price level!");
                return false;
            }
            if (!string.IsNullOrEmpty(id))
            {
                choiceImg = true;
            }

            if (guna2CirclePictureBoxFood.Image == null || !choiceImg)
            {
                MessageFuctionConstans.WarningOK("Please enter an image!");
                return false;
            }
            Hashtable ht = new Hashtable();
            string queryCheck = "SELECT item_Name FROM items_menu WHERE item_Name = '" + guna2TextBoxName.Text + "' AND ItemStatus != 1";
            if (MainClass.SQL(queryCheck, ht) > 0)
            {
                MessageFuctionConstans.WarningOK("This Item already exists. Please enter another name.");
                return false;
            }

            return true;
        }
        private void guna2ButtonBrowse_Click(object sender, System.EventArgs e)
        {
            choiceImg = true;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                guna2CirclePictureBoxFood.Image = new Bitmap(filePath);
            }
        }
        public override void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            choiceImg = true;
            string query;
            Hashtable ht = new Hashtable();

            if (string.IsNullOrEmpty(id))
            {
                // Generate a new unique ID
                id = MainClass.GenerateUniqueId("items_menu", "IdItem", "IT");

                // Insert into user_account
                query = "INSERT INTO items_menu (IdItem, item_Name, IdItemCategory, item_Price, item_image, ItemStatus) " +
                                       "VALUES (@id, @Name, @cat, @price, @image, 0)";

                ht.Add("@id", id);
                isUpdate = false;
            }
            else
            {
                isUpdate = true;
                // Update user_account
                query = "UPDATE items_menu SET item_Name = @Name, IdItemCategory = @cat, item_Price = @price " +
                                       "WHERE IdItem = @id";

                ht.Add("@id", id);
            }

            // Nén hình ảnh trước khi lưu
            Image temp = new Bitmap(guna2CirclePictureBoxFood.Image);
            using (MemoryStream ms = new MemoryStream())
            {
                SaveImageWithCompression(temp, ms, 50L); // Chất lượng 50
                imageByteArray = ms.ToArray();
            }

            ht.Add("@Name", guna2TextBoxName.Text);
            ht.Add("@cat", comboBoxCategory.SelectedValue.ToString());
            ht.Add("@price", Regex.Replace(guna2TextBoxPrice.Text, @"[^\d]", ""));
            ht.Add("@image", imageByteArray);

            if (MainClass.SQL(query, ht) > 0)
            {
                MessageFuctionConstans.SuccessOK("Saved successfully...");
                if (!isUpdate)
                {
                    id = null;
                    categoryId = null;
                    guna2TextBoxName.Clear();
                    guna2TextBoxPrice.Clear();
                    comboBoxCategory.SelectedIndex = 0;
                    comboBoxCategory.SelectedIndex = -1;
                    guna2CirclePictureBoxFood.Image = Resources.food_add;
                    guna2TextBoxName.Focus();
                    choiceImg = false;
                }
            }
        }

        private void ForUpdateLoadData()
        {
            string query = @"Select * from items_menu where IdItem = '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                guna2TextBoxName.Text = dt.Rows[0]["item_Name"].ToString();
                guna2TextBoxPrice.Text = dt.Rows[0]["item_Price"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["item_image"]);
                byte[] imageByteArray = imageArray;
                guna2CirclePictureBoxFood.Image = Image.FromStream(new MemoryStream(imageByteArray));
            }
        }

        private void guna2TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBoxPrice.Text))
            {
                double receipt = double.Parse(guna2TextBoxPrice.Text);
                guna2TextBoxPrice.Text = receipt.ToString("N0");
                guna2TextBoxPrice.SelectionStart = guna2TextBoxPrice.Text.Length;
            }
        }
        public override void guna2ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveImageWithCompression(Image image, MemoryStream ms, long quality)
        {
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID for Quality
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 20L); // Giảm chất lượng xuống còn 20%
            myEncoderParameters.Param[0] = myEncoderParameter;
            image.Save(ms, jpgEncoder, myEncoderParameters);
        }



        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

    }
}
