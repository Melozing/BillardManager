using BillardManager.Admin;

namespace BillardManager.Model
{
    public partial class FormPrintBill : SampleAdd
    {
        public FormPrintBill()
        {
            InitializeComponent();
        }

        private void FormPrintBill_Load(object sender, System.EventArgs e)
        {
            guna2ControlBoxMaximize.PerformClick();
        }
    }
}
