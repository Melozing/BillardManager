using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormTableOrder : Form
    {
        private string idInvoiceGet;
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
                           "FROM table_detail WHERE TableStatus != 1 ORDER BY TableNumber";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach (DataRow item in dataTable.Rows)
            {
                AddTables(item["TableID"].ToString(), item["TableNumber"].ToString(), item["Status"].ToString(), item["TableIDType"].ToString());
            }
        }
        private void AddTables(string idTable, string tableNumber, string status, string tableTypeID)
        {
            Image imgStatus;
            Image imgType;
            if (int.Parse(status) > 0)
            {
                imgStatus = Properties.Resources.Status_Playing;
                status = "inactive";
                GetInvoiceID(idTable);
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
                id = idTable,
                PName = "Table " + tableNumber.ToString(),
                PImageStatus = imgStatus,
                PImage = imgType,
                PStatus = status,
                idInvoice = idInvoiceGet,

            };
            if (status == "inactive")
            {
                w.SetActiveOrder();
            }
            else
            {
                w.SetInactiveOrder();
            }

            flowLayoutPanelProduct.Controls.Add(w);
        }
        private void GetInvoiceID(string idTable)
        {
            string query = @"SELECT invoice.IdInvoice
            FROM invoice
            JOIN table_detail ON invoice.TableID = table_detail.TableID
            WHERE invoice.TableID = '" + idTable + "'" +
            "AND invoice.Invoice_Status = 0";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach (DataRow item in dataTable.Rows)
            {
                idInvoiceGet = item["IdInvoice"].ToString();
            }
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
