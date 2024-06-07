using BillardManager.Admin;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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

        private void FormPrintBill_Load(object sender, EventArgs e)
        {
            guna2ControlBoxMaximize.PerformClick();
        }

        public void LoadPrintPage()
        {
            FormPrintBillPage formPrintBillPage = new FormPrintBillPage();
            formPrintBillPage.idInvoice = invoiceID;
            formPrintBillPage.startTime = startTime;
            formPrintBillPage.paymentTime = paymentTime;

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
            formPrintBillPage.AddHeaderDetailBill();
            formPrintBillPage.LoadDataItemBill();
            printPage = formPrintBillPage;
            guna2PanelContent.Controls.Clear();
            guna2PanelContent.Controls.Add(formPrintBillPage);
            formPrintBillPage.Show();
            formPrintBillPage.BringToFront();
        }

        public void PrintPage(FormPrintBillPage formPrintBillPage)
        {
            printPage = formPrintBillPage;
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
        }
        /*
        private void Print(FormPrintBillPage pnl)
        {
            pnl.BackColor = Color.White;
            GetPrintArea(pnl);

            int panelWidth = pnl.Width;
            int panelHeight = pnl.Height;

            // Convert the panel size to hundredths of an inch for printing
            int paperWidth = (int)(panelWidth / 96.0 * 100);
            int paperHeight = (int)(panelHeight / 96.0 * 100);

            printDocumentBill.DefaultPageSettings.PaperSize = new PaperSize("Custom", paperWidth, paperHeight);
            printDocumentBill.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            printPreviewDialogBill.Document = printDocumentBill;
            printDocumentBill.PrintPage -= printDocumentBill_PrintPage;
            printDocumentBill.PrintPage += new PrintPageEventHandler(printDocumentBill_PrintPage);
            printPreviewDialogBill.WindowState = FormWindowState.Maximized;
            printPreviewDialogBill.Size = Screen.PrimaryScreen.Bounds.Size;
            printPreviewDialogBill.ShowDialog();
        }*/

        private void GetPrintArea(FormPrintBillPage pnl)
        {
            memoryImg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImg, new System.Drawing.Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocumentBill_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImg, 0, 0);
        }

        private void SaveToPdf(FormPrintBillPage pnl)
        {
            GetPrintArea(pnl);

            string filePath = Path.Combine(FormMain.pathExportBill, "Bill_" + invoiceID + ".pdf");
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document(new iTextSharp.text.Rectangle(pnl.Width, pnl.Height), 0, 0, 0, 0); // Set all margins to 0
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryImg, System.Drawing.Imaging.ImageFormat.Png);
                img.SetAbsolutePosition(0, 0); // Set image position to (0,0)
                doc.Add(img);
                doc.Close();
                writer.Close();
            }

            // Open the PDF file
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

            PrintPdf(filePath);
            this.Close();
        }

        private void PrintPdf(string filePath)
        {
            // Use a Process to open the default print dialog for the PDF
            Process printProcess = new Process();
            printProcess.StartInfo = new ProcessStartInfo
            {
                FileName = filePath,
                Verb = "print",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true // Ensure UseShellExecute is true
            };
        }

        private void guna2ButtonSave_Click_2(object sender, EventArgs e)
        {
            SaveToPdf(this.printPage);
        }
    }
}
