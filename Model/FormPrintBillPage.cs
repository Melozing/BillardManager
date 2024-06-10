using BiaManager.Script;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
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

        public string cashier;

        private int num = 0;
        private List<Bitmap> pages = new List<Bitmap>();

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
            labelBillCashier.Text = cashier;
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
    SELECT inv_det.Invoice_TotalAmount, 
           tbl_type.TableType_Price, 
           tbl_uinfo.User_FullName 
    FROM invoice_detail inv_det
    INNER JOIN invoice inv ON inv_det.IdInvoice = inv.IdInvoice
    INNER JOIN table_detail tbl_det ON inv.TableID = tbl_det.TableID
    INNER JOIN table_type tbl_type ON tbl_det.TableIDType = tbl_type.TableIDType
    INNER JOIN user_info tbl_uinfo ON inv.IdUser = tbl_uinfo.idUser
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
                            startTime = "Start Time : " + reader.GetDateTime(0).ToString();
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
                            string cashier = reader.GetString(2);

                            amountHourPlay = (totalAmount * hourlyRate).ToString("N0");
                            priceHour = hourlyRate.ToString("N0");
                            totalPlayHour = totalAmount.ToString("N2");
                            labelBillCashier.Text = "The bill cashier : " + cashier;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageFuctionConstans.ErrorOK(ex.ToString());
            }
            finally
            {
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
                "im.item_Price, " +
                "tbl_uinfo.User_FullName " +
                "FROM items_menu im " +
                "JOIN invoice_detail id " +
                "ON im.IdItem = id.IdItem " +
                "JOIN invoice iv " +
                "ON iv.IdInvoice = id.IdInvoice " +
                "JOIN user_info tbl_uinfo " +
                "ON tbl_uinfo.idUser = iv.IdUser " +
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
                    cashier = "The bill cashier : " + row["User_FullName"].ToString();
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
            //printProcess.Start();
        }

        private void SaveToPdf(FormPrintBillPage pnl)
        {
            int pageHeight = 1120; // Chiều cao mặc định cho mỗi trang
            GetPrintArea(pnl, pageHeight);

            string directory = FormMain.pathExportBill;
            string baseFileName = "Bill_" + invoiceID;
            string filePath = GenerateUniqueFilePath(directory, baseFileName, ".pdf");

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document(new iTextSharp.text.Rectangle(pnl.Width, pageHeight), 0, 0, 0, 0);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                foreach (Bitmap page in pages)
                {
                    if (doc.PageNumber > 0)
                    {
                        doc.NewPage();
                    }

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(page, System.Drawing.Imaging.ImageFormat.Png);
                    img.SetAbsolutePosition(0, 0);
                    img.ScaleToFit(pnl.Width, pageHeight); // Đảm bảo ảnh vừa với kích thước trang
                    doc.Add(img);
                }

                doc.Close();
                writer.Close();
            }

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

        private void GetPrintArea(Control pnl, int pageHeight)
        {
            int totalHeight = pnl.DisplayRectangle.Height;
            int pageCount = (int)Math.Ceiling((double)totalHeight / pageHeight);

            pages.Clear();

            for (int i = 0; i < pageCount; i++)
            {
                Bitmap page = new Bitmap(pnl.DisplayRectangle.Width, pageHeight);
                pnl.DrawToBitmap(page, new System.Drawing.Rectangle(0, -i * pageHeight, pnl.DisplayRectangle.Width, totalHeight));
                pages.Add(page);
            }
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
