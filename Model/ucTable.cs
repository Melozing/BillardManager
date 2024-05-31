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
            MainClass.BlurBackground(new FormPOS());
        }
    }
}
