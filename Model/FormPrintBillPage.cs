using System;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormPrintBillPage : Form
    {
        public string invoiceID;
        public string startTime;
        public string paymentTime;

        public string totalMoney;
        public string receivedMoney;
        public string changeMoney;
        public FormPrintBillPage()
        {
            InitializeComponent();
        }

        private void FormPrintBillPage_Load(object sender, EventArgs e)
        {
            labelTimeStart.Text = startTime;
            labelPaymentTime.Text = paymentTime;
            labelTotalMoney.Text = totalMoney;
            labelChangetxt.Text = changeMoney;
            labelRecivedAmounttxt.Text = receivedMoney;
        }
    }
}
