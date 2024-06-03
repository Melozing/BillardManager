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
        public string id { get; set; }
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
            PStatus = "activeTables";
            FormPOS formPOS = new FormPOS();
            formPOS.idTable = id;
            formPOS.WindowState = FormWindowState.Maximized;
            MainClass.BlurBackground(formPOS);
            SetActiveOrder();
        }
        public void SetActiveOrder()
        {
            pictureBoxStatus.Image = Properties.Resources.Status_Playing;
            PanelTableName.BackColor = Color.Firebrick;
            PictureBoxTable.BackColor = Color.IndianRed;
            guna2ButtonStart.Hide();
            guna2ButtonOder.Show();
        }
        public void SetInactiveOrder()
        {
            pictureBoxStatus.Image = Properties.Resources.Status_Empty;
            PanelTableName.BackColor = Color.DarkGreen;
            PictureBoxTable.BackColor = Color.ForestGreen;
            guna2ButtonStart.Show();
            guna2ButtonOder.Hide();
        }
    }
}
