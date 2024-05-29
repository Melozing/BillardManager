using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormPOS : Form
    {
        public FormPOS()
        {
            InitializeComponent();
        }

        private void guna2PictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formpos_Load(object sender, EventArgs e)
        {
            guna2DataGridViewCategory.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelCategory.Controls.Clear();
            flowLayoutPanelProduct.Controls.Clear();

            AddCategory();
            LoadProducts();
        }

        private void AddCategory()
        {
            string query = "Select * From items_category";
            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            flowLayoutPanelCategory.Controls.Clear();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(134, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["ItemCategory_Name"].ToString();

                    //event for click
                    b.Click += new EventHandler(_Click);
                    b.Width = flowLayoutPanelCategory.Width;
                    flowLayoutPanelCategory.Controls.Add(b);
                    b.Dock = DockStyle.Top;
                }
            }
        }

        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var prod = (ucProduct)item;
                prod.Visible = prod.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string idItem, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = idItem
            };
            flowLayoutPanelProduct.Controls.Add(w);
            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                foreach (DataGridViewRow item in guna2DataGridViewCategory.Rows)
                {
                    //check it produuct already there then a one to quantity and update price
                    if (item.Cells["Id"].Value.ToString() == wdg.id)
                    {
                        item.Cells["Quantity"].Value = int.Parse(item.Cells["Quantity"].Value.ToString()) + 1;
                        item.Cells["Amount"].Value = int.Parse(item.Cells["Quantity"].Value.ToString()) *
                        double.Parse(item.Cells["Price"].Value.ToString());
                        return;
                    }
                }
                //add new product
                guna2DataGridViewCategory.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };
        }

        //Getting product form database
        private void LoadProducts()
        {
            string query = "SELECT * " +
                           "FROM items_menu im " +
                           "JOIN items_category ic ON im.IdItemCategory = ic.IdItemCategory " +
                           "WHERE im.ItemStatus != 1 AND im.IdItem !='IHour'";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach (DataRow item in dataTable.Rows)
            {
                Byte[] imageArray = (byte[])item["item_image"];
                byte[] imageByteArray = imageArray;

                AddItems(item["IdItem"].ToString(), item["item_Name"].ToString(),
                    item["ItemCategory_Name"].ToString(), item["item_Price"].ToString(), Image.FromStream(new MemoryStream(imageByteArray)));
            }
        }

        private void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var prod = (ucProduct)item;
                prod.Visible = prod.PName.ToLower().Contains(guna2TextBoxSearch.Text.Trim().ToLower());
            }
        }

        private void guna2DataGridViewCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridViewCategory.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double total = 0;
            labelTotalMoneyNum.Text = string.Empty;
            foreach (DataGridViewRow item in guna2DataGridViewCategory.Rows)
            {
                total += double.Parse(item.Cells["Amount"].Value.ToString());
            }

            labelTotalMoneyNum.Text = total.ToString("N2");
        }
    }
}
