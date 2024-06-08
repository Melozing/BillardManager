using BiaManager.Script;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text.RegularExpressions;
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

        public string totalPlayHour;
        public string priceHour;
        public string amountHourPlay;

        private int num = 0;
        private Bitmap memoryImg;
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
            labelBillCashier.Text = "The bill cashier : " + FormMain.Instance.userFullName;
            labelIDInvoice.Text = "Invoice Code : " + invoiceID;
        }

        public void GetBillInfoByID(string idInvoiceGet)
        {
            invoiceID = idInvoiceGet;
            labelIDInvoice.Text = "Invoice Code: " + invoiceID;
            string queryGet = @"
            SELECT Invoice_time, 
                   Invoice_PaymentTime, 
                   Invoice_Total, 
                   Invoice_Received, 
                   Invoice_Change  
            FROM invoice 
            WHERE IdInvoice = @idInvoice";

            string queryGetHour = @"
            SELECT inv_det.Invoice_TotalAmount, tbl_type.TableType_Price
            FROM invoice_detail inv_det
            INNER JOIN invoice inv ON inv_det.IdInvoice = inv.IdInvoice
            INNER JOIN table_detail tbl_det ON inv.TableID = tbl_det.TableID
            INNER JOIN table_type tbl_type ON tbl_det.TableIDType = tbl_type.TableIDType
            WHERE inv_det.IdInvoice = @idInvoice AND inv_det.IdItem = 'IHour'";

            try
            {
                // Create a new SQL command for the first query
                using (SqlCommand cmd = new SqlCommand(queryGet, MainClass.conn))
                {
                    // Add parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@idInvoice", idInvoiceGet);

                    // Open the connection if it is closed
                    if (MainClass.conn.State == ConnectionState.Closed)
                    {
                        MainClass.conn.Open();
                    }

                    // Execute the command and use SqlDataReader to read the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            startTime = reader.GetDateTime(0).ToString();
                            labelTimeStart.Text = "Start Time : " + startTime;
                            paymentTime = "Payment time : " + reader.GetDateTime(1).ToString();
                            totalMoney = "$ " + reader.GetDecimal(2).ToString("N0");
                            receivedMoney = "$ " + reader.GetDecimal(3).ToString("N0");
                            changeMoney = "$ " + reader.GetDecimal(4).ToString("N0");
                        }
                    }
                }

                // Create a new SQL command for the second query
                using (SqlCommand cmd = new SqlCommand(queryGetHour, MainClass.conn))
                {
                    // Add parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@idInvoice", idInvoiceGet);

                    // Execute the command and use SqlDataReader to read the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double totalAmount = reader.GetDouble(0);
                            int hourlyRate = reader.GetInt32(1);

                            amountHourPlay = (totalAmount * hourlyRate).ToString("N0"); // Total hours played
                            priceHour = hourlyRate.ToString("N0"); // Hourly rate
                            totalPlayHour = totalAmount.ToString("N2"); // Total amount paid for playing hours
                        }
                    }

                    // Close the connection if it is open
                    if (MainClass.conn.State == ConnectionState.Open)
                    {
                        MainClass.conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageFuctionConstans.ErrorOK(ex.ToString());
                if (MainClass.conn.State == ConnectionState.Open)
                {
                    MainClass.conn.Close();
                }
            }
        }

        public void AddHeaderDetailBill()
        {
            panelBillDetail.Controls.Clear();
            var ucTittle = new ucBillDetail();
            ShowItemBill(ucTittle);
            ucTittle.Dock = DockStyle.Top;
            if (float.Parse(amountHourPlay.ToString()) > 0)
            {
                num++;
                var w = new ucBillDetail()
                {
                    PName = "Play time",
                    PPrice = priceHour,
                    PQuantity = totalPlayHour,
                    PAmount = amountHourPlay,
                    PSr = num.ToString()
                };
                ShowItemBill(w);
            }
        }

        public void LoadDataItemBill()
        {
            string query = "SELECT " +
                "iv.Invoice_Status, " +
                "im.IdItem, " +
                "id.Invoice_TotalAmount, " +
                "im.item_Name, " +
                "im.item_Price " +
                "FROM items_menu im " +
                "JOIN invoice_detail id " +
                "ON im.IdItem = id.IdItem " +
                "JOIN invoice iv " +
                "ON iv.IdInvoice = id.IdInvoice " +
                "WHERE iv.IdInvoice = '" + invoiceID + "' " +
                "AND im.IdItem != 'IHour'";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    double totalAmount = 0;
                    num++;
                    int quantity = int.Parse(Regex.Replace(row["Invoice_TotalAmount"].ToString(), @"[^0-9.]", ""));

                    double price = double.Parse(Regex.Replace(row["item_Price"].ToString(), @"[^0-9.]", ""));

                    double itemTotal = quantity * price;
                    totalAmount += itemTotal;
                    var b = new ucBillDetail()
                    {
                        PName = row["item_Name"].ToString(),
                        PPrice = price.ToString("N0"),
                        PQuantity = quantity.ToString(),
                        PAmount = totalAmount.ToString("N0"),
                        PSr = num.ToString()
                    };
                    ShowItemBill(b);
                }
            }
        }

        public void ShowExitBtn()
        {
            pictureBoxExit.Visible = true;
            guna2PictureBoxPrint.Visible = true;
        }

        private void ShowItemBill(ucBillDetail bdt)
        {
            panelBillDetail.Controls.Add(bdt);
            bdt.Show();
            bdt.BringToFront();
            bdt.Dock = DockStyle.Top;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBoxPrint_Click(object sender, EventArgs e)
        {
            SaveToPdf(this);
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
        private void SaveToPdf(FormPrintBillPage pnl)
        {
            GetPrintArea(pnl);

            string directory = FormMain.pathExportBill;
            string baseFileName = "Bill_" + invoiceID;
            string filePath = GenerateUniqueFilePath(directory, baseFileName, ".pdf");

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // Tạo một tài liệu PDF với kích thước của hình ảnh
                iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(0, 0, memoryImg.Width, memoryImg.Height);
                Document doc = new Document(pageSize, 0, 0, 0, 0);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Chuyển đổi Bitmap thành hình ảnh iTextSharp và thêm nó vào tài liệu
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryImg, System.Drawing.Imaging.ImageFormat.Png);
                img.SetAbsolutePosition(0, 0);
                doc.Add(img);

                doc.Close();
                writer.Close();
            }

            // Mở tệp PDF
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

            PrintPdf(filePath);
            this.Close();
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
        private void GetPrintArea(Control pnl)
        {
            // Tính toán chiều cao đầy đủ của panel bao gồm cả phần có thể cuộn
            int scrollableHeight = pnl.DisplayRectangle.Height;

            // Tạo một bitmap với kích thước phù hợp
            memoryImg = new Bitmap(pnl.DisplayRectangle.Width, scrollableHeight);

            // Vẽ toàn bộ nội dung của panel vào bitmap
            pnl.DrawToBitmap(memoryImg, new System.Drawing.Rectangle(0, 0, pnl.DisplayRectangle.Width, scrollableHeight));

            // Vẽ từng điều khiển con của panel vào bitmap
            foreach (Control control in pnl.Controls)
            {
                control.DrawToBitmap(memoryImg, new System.Drawing.Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height));
            }
        }



        private void printDocumentBill_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Điều chỉnh kích thước hình ảnh để phù hợp với trang
            float scale = Math.Min((float)e.MarginBounds.Width / memoryImg.Width, (float)e.MarginBounds.Height / memoryImg.Height);
            float width = memoryImg.Width * scale;
            float height = memoryImg.Height * scale;

            e.Graphics.DrawImage(memoryImg, 0, 0, width, height);
        }


        public void PrintPage(FormPrintBillPage formPrintBillPage)
        {
            formPrintBillPage.TopLevel = false;
            formPrintBillPage.FormBorderStyle = FormBorderStyle.None;
            formPrintBillPage.StartPosition = FormStartPosition.Manual;
            guna2PanelContent.Controls.Clear();
            guna2PanelContent.Controls.Add(formPrintBillPage);
            formPrintBillPage.Show();
            formPrintBillPage.BringToFront();
        }
    }
}
