using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class ucProduct : UserControl
    {
        public event EventHandler onSelect = null;

        public ucProduct()
        {
            InitializeComponent();
        }

        public string id { get; set; }
        public string PPrice { get; set; }
        public string PCategory { get; set; }
        public string PName
        {
            get { return labelProduct.Text; }
            set { labelProduct.Text = value; }
        }
        public Image PImage
        {
            get { return guna2PictureBoxProduct.Image; }
            set { guna2PictureBoxProduct.Image = value; }
        }

        private void guna2PictureBoxProduct_Click(object sender, System.EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
