using BillardManager.Admin;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormPrintBill : SampleAdd
    {
        public string invoiceID;
        public string startTime;
        public string paymentTime;

        public string totalMoney;
        public string receivedMoney;
        public string changeMoney;

        public string totalPlayHour;
        public string priceHour;
        public string amountHourPlay;

        private Bitmap memoryImg;
        private FormPrintBillPage printPage;
        public FormPrintBill()
        {
            InitializeComponent();
        }

        private void FormPrintBill_Load(object sender, System.EventArgs e)
        {
            guna2ControlBoxMaximize.PerformClick();
            FormPrintBillPage formPrintBillPage = new FormPrintBillPage();
            formPrintBillPage.startTime = startTime;
            formPrintBillPage.paymentTime = paymentTime;
            formPrintBillPage.idInvoice = invoiceID;

            formPrintBillPage.totalMoney = totalMoney;
            formPrintBillPage.receivedMoney = receivedMoney;
            formPrintBillPage.changeMoney = changeMoney;

            formPrintBillPage.totalPlayHour = totalPlayHour;
            formPrintBillPage.priceHour = priceHour;
            formPrintBillPage.amountHourPlay = amountHourPlay;

            formPrintBillPage.TopLevel = false;
            formPrintBillPage.FormBorderStyle = FormBorderStyle.None;
            formPrintBillPage.StartPosition = FormStartPosition.Manual;

            int x = (guna2PanelContent.Width - formPrintBillPage.Width) / 2;

            int y = formPrintBillPage.Location.Y;

            formPrintBillPage.Location = new Point(x, y);

            guna2PanelContent.Controls.Clear();
            guna2PanelContent.Controls.Add(formPrintBillPage);
            formPrintBillPage.Show();
            formPrintBillPage.BringToFront();
            printPage = formPrintBillPage;
        }

        private void guna2ButtonSave_Click_1(object sender, System.EventArgs e)
        {
            Print(this.printPage);
        }

        private void Print(FormPrintBillPage pnl)
        {
            pnl.BackColor = Color.White;
            PrinterSettings ps = new PrinterSettings();
            GetPrintArea(pnl);

            int panelWidth = pnl.Width;
            int panelHeight = pnl.Height;

            int paperWidth = (int)(panelWidth * 100 / 96);
            int paperHeight = (int)(panelHeight * 100 / 96);

            printDocumentBill.DefaultPageSettings.PaperSize = new PaperSize("Custom", paperWidth, paperHeight);

            printDocumentBill.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            printPreviewDialogBill.Document = printDocumentBill;
            printDocumentBill.PrintPage -= printDocumentBill_PrintPage;
            printDocumentBill.PrintPage += new PrintPageEventHandler(printDocumentBill_PrintPage);
            printPreviewDialogBill.ShowDialog();
        }

        private void GetPrintArea(FormPrintBillPage pnl)
        {
            memoryImg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocumentBill_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImg, 0, 0);
        }
    }
}
