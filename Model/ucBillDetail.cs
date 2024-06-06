using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class ucBillDetail : UserControl
    {
        public ucBillDetail()
        {
            InitializeComponent();
        }
        public string PSr
        {
            get { return gunaLabelNum.Text; }
            set { gunaLabelNum.Text = value; }
        }
        public string PName
        {
            get { return gunaLabelName.Text; }
            set { gunaLabelName.Text = value; }
        }
        public string PPrice
        {
            get { return gunaLabelPrice.Text; }
            set { gunaLabelPrice.Text = value; }
        }
        public string PQuantity
        {
            get { return gunaLabelQuantity.Text; }
            set { gunaLabelQuantity.Text = value; }
        }
        public string PAmount
        {
            get { return gunaLabelAmount.Text; }
            set { gunaLabelAmount.Text = value; }
        }
    }
}
