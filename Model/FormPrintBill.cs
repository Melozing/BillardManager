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
            formPrintBillPage.invoiceID = invoiceID;
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

            //int x = (guna2PanelContent.Width - formPrintBillPage.Width) / 2;
            //int y = formPrintBillPage.Location.Y;

            //formPrintBillPage.Location = new Point(x, y);
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
            //int x = (guna2PanelContent.Width - formPrintBillPage.Width) / 2;
            //int y = formPrintBillPage.Location.Y;

            //formPrintBillPage.Location = new Point(x, y);
            guna2PanelContent.Controls.Clear();
            guna2PanelContent.Controls.Add(formPrintBillPage);
            formPrintBillPage.Show();
            formPrintBillPage.BringToFront();
        }

        private void GetPrintArea(FormPrintBillPage pnl)
        {
            // Create a bitmap of the size of the entire scrollable area
            memoryImg = new Bitmap(pnl.DisplayRectangle.Width, pnl.DisplayRectangle.Height);
            pnl.DrawToBitmap(memoryImg, new System.Drawing.Rectangle(0, 0, pnl.DisplayRectangle.Width, pnl.DisplayRectangle.Height));
        }

        private void printDocumentBill_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Adjust the image size to fit the page
            float scale = Math.Min((float)e.MarginBounds.Width / memoryImg.Width, (float)e.MarginBounds.Height / memoryImg.Height);
            float width = memoryImg.Width * scale;
            float height = memoryImg.Height * scale;

            e.Graphics.DrawImage(memoryImg, 0, 0, width, height);
        }

        private string GenerateUniqueFilePath(string directory, string baseFileName, string extension)
        {
            string filePath = Path.Combine(directory, baseFileName + extension);
            int count = 1;

            while (File.Exists(filePath))
            {
                string tempFileName = $"{baseFileName}({count})";
                filePath = Path.Combine(directory, tempFileName + extension);
                count++;
            }

            return filePath;
        }

        private void SaveToPdf(FormPrintBillPage pnl)
        {
            GetPrintArea(pnl);

            string directory = FormMain.pathExportBill;
            string baseFileName = "Bill_" + invoiceID;
            string filePath = GenerateUniqueFilePath(directory, baseFileName, ".pdf");

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // Create a PDF document with the size of the image
                Document doc = new Document(new iTextSharp.text.Rectangle(memoryImg.Width, memoryImg.Height), 0, 0, 0, 0);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Convert the Bitmap to iTextSharp image and add it to the document
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryImg, System.Drawing.Imaging.ImageFormat.Png);
                img.SetAbsolutePosition(0, 0);
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
            Process printProcess = new Process();
            printProcess.StartInfo = new ProcessStartInfo
            {
                FileName = filePath,
                Verb = "print",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true
            };
            printProcess.Start();
        }

        private void guna2ButtonSave_Click_2(object sender, EventArgs e)
        {
            SaveToPdf(this.printPage);
        }
    }
}
