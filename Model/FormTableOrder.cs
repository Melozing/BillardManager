using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormTableOrder : Form
    {
        public FormTableOrder()
        {
            InitializeComponent();
        }

        private void FormTableOrder_Load(object sender, System.EventArgs e)
        {
            flowLayoutPanelProduct.Controls.Clear();
            LoadProducts();
        }
        private void LoadProducts()
        {
            string query = "SELECT * " +
                           "FROM table_detail ORDER BY TableNumber";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach (DataRow item in dataTable.Rows)
            {
                AddItems(item["TableID"].ToString(), item["TableNumber"].ToString(), item["Status"].ToString(), item["TableIDType"].ToString());
            }
        }
        private void AddItems(string idTable, string tableNumber, string status, string tableTypeID)
        {
            Image imgStatus;
            Image imgType;
            if (int.Parse(status) > 0)
            {
                imgStatus = Properties.Resources.Status_Playing;
                status = "inactive";
            }
            else
            {
                imgStatus = Properties.Resources.Status_Empty;
                status = "activeTables";
            }
            if (tableTypeID == "TBT01")
            {
                imgType = Properties.Resources.caromBilliards;
            }
            else if (tableTypeID == "TBT02")
            {
                imgType = Properties.Resources.pocketBilliards;
            }
            else
            {
                imgType = Properties.Resources.defaultTable;
            }
            var w = new ucTable()
            {
                PName = "Table " + tableNumber,
                PImageStatus = imgStatus,
                PImage = imgType,
                PStatus = status,
                id = idTable
            };
            flowLayoutPanelProduct.Controls.Add(w);
        }

        private void showActiveTablesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var prod = (ucTable)item;
                prod.Visible = prod.PStatus.Contains("activeTables");
            }
        }

        private void showInactiveTablesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var prod = (ucTable)item;
                prod.Visible = prod.PStatus.ToLower().Contains("inactive");
            }
        }

        private void showAllTablesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var prod = (ucTable)item;
                prod.Visible = prod.PStatus.ToLower().Contains(""); ;
            }
        }

        private void flowLayoutPanelProduct_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        gunaContextMenuStrip.Show(this, new Point(e.X, e.Y + 30));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void guna2TextBoxSearch_TextChanged(object sender, System.EventArgs e)
        {
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var prod = (ucTable)item;
                prod.Visible = prod.PName.ToLower().Contains(guna2TextBoxSearch.Text.Trim().ToLower());
            }
        }
    }
}
