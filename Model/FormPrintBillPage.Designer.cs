namespace BillardManager.Model
{
    partial class FormPrintBillPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrintBillPage));
            this.guna2PanelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBoxPrint = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.labelTotalMoney = new System.Windows.Forms.Label();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.panelChange = new System.Windows.Forms.Panel();
            this.labelChangetxt = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.panelReceive = new System.Windows.Forms.Panel();
            this.labelRecivedAmounttxt = new System.Windows.Forms.Label();
            this.labelReceiveAmount = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.panelBillDetail = new System.Windows.Forms.Panel();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelPaymentTime = new System.Windows.Forms.Label();
            this.labelTimeStart = new System.Windows.Forms.Label();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelBillCashier = new System.Windows.Forms.Label();
            this.labelIDInvoice = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelTittle = new System.Windows.Forms.Label();
            this.printDocumentBill = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogBill = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxPrint)).BeginInit();
            this.PanelTotal.SuspendLayout();
            this.panelChange.SuspendLayout();
            this.panelReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelContent
            // 
            this.guna2PanelContent.AutoSize = true;
            this.guna2PanelContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2PanelContent.Controls.Add(this.guna2PictureBoxPrint);
            this.guna2PanelContent.Controls.Add(this.PanelTotal);
            this.guna2PanelContent.Controls.Add(this.panelChange);
            this.guna2PanelContent.Controls.Add(this.panelReceive);
            this.guna2PanelContent.Controls.Add(this.guna2Separator2);
            this.guna2PanelContent.Controls.Add(this.panelBillDetail);
            this.guna2PanelContent.Controls.Add(this.guna2Separator3);
            this.guna2PanelContent.Controls.Add(this.labelPaymentTime);
            this.guna2PanelContent.Controls.Add(this.labelTimeStart);
            this.guna2PanelContent.Controls.Add(this.guna2Separator4);
            this.guna2PanelContent.Controls.Add(this.labelBillCashier);
            this.guna2PanelContent.Controls.Add(this.labelIDInvoice);
            this.guna2PanelContent.Controls.Add(this.pictureBoxExit);
            this.guna2PanelContent.Controls.Add(this.guna2Separator1);
            this.guna2PanelContent.Controls.Add(this.labelTittle);
            this.guna2PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelContent.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PanelContent.Name = "guna2PanelContent";
            this.guna2PanelContent.ShadowDecoration.Parent = this.guna2PanelContent;
            this.guna2PanelContent.Size = new System.Drawing.Size(485, 622);
            this.guna2PanelContent.TabIndex = 6;
            // 
            // guna2PictureBoxPrint
            // 
            this.guna2PictureBoxPrint.Image = global::BillardManager.Properties.Resources.printer;
            this.guna2PictureBoxPrint.Location = new System.Drawing.Point(370, 3);
            this.guna2PictureBoxPrint.Name = "guna2PictureBoxPrint";
            this.guna2PictureBoxPrint.ShadowDecoration.Parent = this.guna2PictureBoxPrint;
            this.guna2PictureBoxPrint.Size = new System.Drawing.Size(51, 41);
            this.guna2PictureBoxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBoxPrint.TabIndex = 67;
            this.guna2PictureBoxPrint.TabStop = false;
            this.guna2PictureBoxPrint.Visible = false;
            this.guna2PictureBoxPrint.Click += new System.EventHandler(this.guna2PictureBoxPrint_Click);
            // 
            // PanelTotal
            // 
            this.PanelTotal.Controls.Add(this.labelTotalMoney);
            this.PanelTotal.Controls.Add(this.labelTotalText);
            this.PanelTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTotal.Location = new System.Drawing.Point(0, 329);
            this.PanelTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.PanelTotal.Size = new System.Drawing.Size(485, 52);
            this.PanelTotal.TabIndex = 66;
            // 
            // labelTotalMoney
            // 
            this.labelTotalMoney.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotalMoney.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMoney.Location = new System.Drawing.Point(217, 10);
            this.labelTotalMoney.Name = "labelTotalMoney";
            this.labelTotalMoney.Size = new System.Drawing.Size(257, 32);
            this.labelTotalMoney.TabIndex = 4;
            this.labelTotalMoney.Text = "TotalMoney";
            this.labelTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalText
            // 
            this.labelTotalText.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalText.Location = new System.Drawing.Point(11, 10);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(257, 32);
            this.labelTotalText.TabIndex = 5;
            this.labelTotalText.Text = "Total :";
            this.labelTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChange
            // 
            this.panelChange.Controls.Add(this.labelChangetxt);
            this.panelChange.Controls.Add(this.labelChange);
            this.panelChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChange.Location = new System.Drawing.Point(0, 277);
            this.panelChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChange.Name = "panelChange";
            this.panelChange.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelChange.Size = new System.Drawing.Size(485, 52);
            this.panelChange.TabIndex = 65;
            // 
            // labelChangetxt
            // 
            this.labelChangetxt.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelChangetxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangetxt.Location = new System.Drawing.Point(217, 10);
            this.labelChangetxt.Name = "labelChangetxt";
            this.labelChangetxt.Size = new System.Drawing.Size(257, 32);
            this.labelChangetxt.TabIndex = 4;
            this.labelChangetxt.Text = "TotalChange";
            this.labelChangetxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChange
            // 
            this.labelChange.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelChange.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(11, 10);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(257, 32);
            this.labelChange.TabIndex = 5;
            this.labelChange.Text = "Change :";
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelReceive
            // 
            this.panelReceive.Controls.Add(this.labelRecivedAmounttxt);
            this.panelReceive.Controls.Add(this.labelReceiveAmount);
            this.panelReceive.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceive.Location = new System.Drawing.Point(0, 225);
            this.panelReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelReceive.Name = "panelReceive";
            this.panelReceive.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelReceive.Size = new System.Drawing.Size(485, 52);
            this.panelReceive.TabIndex = 64;
            // 
            // labelRecivedAmounttxt
            // 
            this.labelRecivedAmounttxt.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelRecivedAmounttxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecivedAmounttxt.Location = new System.Drawing.Point(217, 10);
            this.labelRecivedAmounttxt.Name = "labelRecivedAmounttxt";
            this.labelRecivedAmounttxt.Size = new System.Drawing.Size(257, 32);
            this.labelRecivedAmounttxt.TabIndex = 4;
            this.labelRecivedAmounttxt.Text = "TotalReceived";
            this.labelRecivedAmounttxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReceiveAmount
            // 
            this.labelReceiveAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelReceiveAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiveAmount.Location = new System.Drawing.Point(11, 10);
            this.labelReceiveAmount.Name = "labelReceiveAmount";
            this.labelReceiveAmount.Size = new System.Drawing.Size(257, 32);
            this.labelReceiveAmount.TabIndex = 5;
            this.labelReceiveAmount.Text = "Received amount :";
            this.labelReceiveAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 215);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(485, 10);
            this.guna2Separator2.TabIndex = 63;
            // 
            // panelBillDetail
            // 
            this.panelBillDetail.AutoSize = true;
            this.panelBillDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBillDetail.Location = new System.Drawing.Point(0, 215);
            this.panelBillDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBillDetail.Name = "panelBillDetail";
            this.panelBillDetail.Size = new System.Drawing.Size(485, 0);
            this.panelBillDetail.TabIndex = 62;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator3.Location = new System.Drawing.Point(0, 205);
            this.guna2Separator3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(485, 10);
            this.guna2Separator3.TabIndex = 61;
            // 
            // labelPaymentTime
            // 
            this.labelPaymentTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPaymentTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentTime.Location = new System.Drawing.Point(0, 171);
            this.labelPaymentTime.Name = "labelPaymentTime";
            this.labelPaymentTime.Size = new System.Drawing.Size(485, 34);
            this.labelPaymentTime.TabIndex = 60;
            this.labelPaymentTime.Text = "Payment Time";
            this.labelPaymentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimeStart
            // 
            this.labelTimeStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTimeStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeStart.Location = new System.Drawing.Point(0, 137);
            this.labelTimeStart.Name = "labelTimeStart";
            this.labelTimeStart.Size = new System.Drawing.Size(485, 34);
            this.labelTimeStart.TabIndex = 59;
            this.labelTimeStart.Text = "Time Start";
            this.labelTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator4.Location = new System.Drawing.Point(0, 127);
            this.guna2Separator4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(485, 10);
            this.guna2Separator4.TabIndex = 58;
            // 
            // labelBillCashier
            // 
            this.labelBillCashier.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBillCashier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillCashier.Location = new System.Drawing.Point(0, 93);
            this.labelBillCashier.Name = "labelBillCashier";
            this.labelBillCashier.Size = new System.Drawing.Size(485, 34);
            this.labelBillCashier.TabIndex = 57;
            this.labelBillCashier.Text = "The bill cashier:";
            this.labelBillCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIDInvoice
            // 
            this.labelIDInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIDInvoice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDInvoice.Location = new System.Drawing.Point(0, 59);
            this.labelIDInvoice.Name = "labelIDInvoice";
            this.labelIDInvoice.Size = new System.Drawing.Size(485, 34);
            this.labelIDInvoice.TabIndex = 41;
            this.labelIDInvoice.Text = "Invoice Code:";
            this.labelIDInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExit.Image = global::BillardManager.Properties.Resources.no;
            this.pictureBoxExit.Location = new System.Drawing.Point(416, 0);
            this.pictureBoxExit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(69, 46);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 40;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Visible = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 49);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(485, 10);
            this.guna2Separator1.TabIndex = 17;
            // 
            // labelTittle
            // 
            this.labelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTittle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.Location = new System.Drawing.Point(0, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(485, 49);
            this.labelTittle.TabIndex = 8;
            this.labelTittle.Text = "RECEIPT";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printPreviewDialogBill
            // 
            this.printPreviewDialogBill.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBill.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBill.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogBill.Enabled = true;
            this.printPreviewDialogBill.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogBill.Icon")));
            this.printPreviewDialogBill.Name = "printPreviewDialogBill";
            this.printPreviewDialogBill.Visible = false;
            // 
            // FormPrintBillPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(485, 622);
            this.Controls.Add(this.guna2PanelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrintBillPage";
            this.Text = "FormPrintBillPage";
            this.Load += new System.EventHandler(this.FormPrintBillPage_Load);
            this.guna2PanelContent.ResumeLayout(false);
            this.guna2PanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxPrint)).EndInit();
            this.PanelTotal.ResumeLayout(false);
            this.panelChange.ResumeLayout(false);
            this.panelReceive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTittle;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2Panel guna2PanelContent;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label labelIDInvoice;
        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.Label labelTotalMoney;
        private System.Windows.Forms.Label labelTotalText;
        private System.Windows.Forms.Panel panelChange;
        private System.Windows.Forms.Label labelChangetxt;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Panel panelReceive;
        private System.Windows.Forms.Label labelRecivedAmounttxt;
        private System.Windows.Forms.Label labelReceiveAmount;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Panel panelBillDetail;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label labelPaymentTime;
        private System.Windows.Forms.Label labelTimeStart;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private System.Windows.Forms.Label labelBillCashier;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxPrint;
        private System.Drawing.Printing.PrintDocument printDocumentBill;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogBill;
    }
}