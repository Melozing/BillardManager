using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormShowProducts : Form
    {
        private DataTable dataTable;
        private SqlDataAdapter adapter;
        public FormShowProducts()
        {
            InitializeComponent();
        }
        private void LoadProducts()
        {
            foreach (DataRow item in dataTable.Rows)
            {
                Byte[] imageArray = (byte[])item["item_image"];
                byte[] imageByteArray = imageArray;
                int price = int.Parse(item["item_Price"].ToString());

                AddItems(item["IdItem"].ToString(), item["item_Name"].ToString(),
                    item["ItemCategory_Name"].ToString(), "$ " + price.ToString("N0"), Image.FromStream(new MemoryStream(imageByteArray)));
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
        }
        private void FormShowProducts_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            string query = "SELECT * " +
               "FROM items_menu im " +
               "JOIN items_category ic ON im.IdItemCategory = ic.IdItemCategory " +
               "WHERE im.ItemStatus != 1 AND im.IdItem !='IHour'";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            LoadProducts();
        }
    }
}
