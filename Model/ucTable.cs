using System.Drawing;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class ucTable : UserControl
    {
        public ucTable()
        {
            InitializeComponent();
        }
        public string idTable { get; set; }
        public string idInvoice { get; set; }
        public string PName
        {
            get { return LabelTableName.Text; }
            set { LabelTableName.Text = value; }
        }
        public Image PImage
        {
            get { return PictureBoxTable.Image; }
            set { PictureBoxTable.Image = value; }
        }
        public Image PImageStatus
        {
            get { return pictureBoxStatus.Image; }
            set { pictureBoxStatus.Image = value; }
        }
        public string PStatus { get; set; }
        private void guna2ButtonStart_Click(object sender, System.EventArgs e)
        {
            if (PStatus == "activeTables")
            {
                PStatus = "inactive";
                FormPOS formPOS = new FormPOS();
                formPOS.Show();
                formPOS.idTable = idTable;
                formPOS.PStatus = PStatus;
                formPOS.WindowState = FormWindowState.Maximized;
                MainClass.BlurBackground(formPOS);
                FormMain.Instance.guna2ButtonTable.PerformClick();
                SetActiveOrder();
            }
            else
            {
                FormPOS formPOS = new FormPOS();
                formPOS.idTable = idTable;
                formPOS.WindowState = FormWindowState.Maximized;
                formPOS.idInvoice = idInvoice;
                MainClass.BlurBackground(formPOS);
            }

        }
        public void SetActiveOrder()
        {
            pictureBoxStatus.Image = Properties.Resources.Status_Playing;
            PanelTableName.BackColor = Color.Firebrick;
            PictureBoxTable.BackColor = Color.IndianRed;
            guna2ButtonStart.Text = "Order";
            guna2ButtonStart.FillColor = Color.ForestGreen;
        }
        public void SetInactiveOrder()
        {
            pictureBoxStatus.Image = Properties.Resources.Status_Empty;
            PanelTableName.BackColor = Color.DarkGreen;
            PictureBoxTable.BackColor = Color.ForestGreen;
            guna2ButtonStart.Text = "Start";
            guna2ButtonStart.FillColor = Color.FromArgb(255, 128, 128);
        }
    }
}
