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
            this.guna2PanelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.labelTotalMoney = new System.Windows.Forms.Label();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.panelChange = new System.Windows.Forms.Panel();
            this.labelChangetxt = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.panelReceive = new System.Windows.Forms.Panel();
            this.labelRecivedAmounttxt = new System.Windows.Forms.Label();
            this.labelReceiveAmount = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.panelBillDetail = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelPaymentTime = new System.Windows.Forms.Label();
            this.labelTimeStart = new System.Windows.Forms.Label();
            this.labelTittle = new System.Windows.Forms.Label();
            this.guna2PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.PanelTotal.SuspendLayout();
            this.panelChange.SuspendLayout();
            this.panelReceive.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PanelContent
            // 
            this.guna2PanelContent.AutoSize = true;
            this.guna2PanelContent.Controls.Add(this.pictureBoxExit);
            this.guna2PanelContent.Controls.Add(this.PanelTotal);
            this.guna2PanelContent.Controls.Add(this.guna2Separator2);
            this.guna2PanelContent.Controls.Add(this.panelChange);
            this.guna2PanelContent.Controls.Add(this.panelReceive);
            this.guna2PanelContent.Controls.Add(this.guna2Separator3);
            this.guna2PanelContent.Controls.Add(this.panelBillDetail);
            this.guna2PanelContent.Controls.Add(this.guna2Separator1);
            this.guna2PanelContent.Controls.Add(this.labelPaymentTime);
            this.guna2PanelContent.Controls.Add(this.labelTimeStart);
            this.guna2PanelContent.Controls.Add(this.labelTittle);
            this.guna2PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelContent.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelContent.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PanelContent.Name = "guna2PanelContent";
            this.guna2PanelContent.ShadowDecoration.Parent = this.guna2PanelContent;
            this.guna2PanelContent.Size = new System.Drawing.Size(364, 505);
            this.guna2PanelContent.TabIndex = 6;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExit.Image = global::BillardManager.Properties.Resources.no;
            this.pictureBoxExit.Location = new System.Drawing.Point(312, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(52, 37);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 40;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // PanelTotal
            // 
            this.PanelTotal.Controls.Add(this.labelTotalMoney);
            this.PanelTotal.Controls.Add(this.labelTotalText);
            this.PanelTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTotal.Location = new System.Drawing.Point(0, 204);
            this.PanelTotal.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Padding = new System.Windows.Forms.Padding(8);
            this.PanelTotal.Size = new System.Drawing.Size(364, 42);
            this.PanelTotal.TabIndex = 38;
            // 
            // labelTotalMoney
            // 
            this.labelTotalMoney.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotalMoney.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMoney.Location = new System.Drawing.Point(163, 8);
            this.labelTotalMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalMoney.Name = "labelTotalMoney";
            this.labelTotalMoney.Size = new System.Drawing.Size(193, 26);
            this.labelTotalMoney.TabIndex = 4;
            this.labelTotalMoney.Text = "TotalMoney";
            this.labelTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalText
            // 
            this.labelTotalText.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalText.Location = new System.Drawing.Point(8, 8);
            this.labelTotalText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(193, 26);
            this.labelTotalText.TabIndex = 5;
            this.labelTotalText.Text = "Total :";
            this.labelTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 196);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(364, 8);
            this.guna2Separator2.TabIndex = 37;
            // 
            // panelChange
            // 
            this.panelChange.Controls.Add(this.labelChangetxt);
            this.panelChange.Controls.Add(this.labelChange);
            this.panelChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChange.Location = new System.Drawing.Point(0, 154);
            this.panelChange.Margin = new System.Windows.Forms.Padding(2);
            this.panelChange.Name = "panelChange";
            this.panelChange.Padding = new System.Windows.Forms.Padding(8);
            this.panelChange.Size = new System.Drawing.Size(364, 42);
            this.panelChange.TabIndex = 36;
            // 
            // labelChangetxt
            // 
            this.labelChangetxt.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelChangetxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangetxt.Location = new System.Drawing.Point(163, 8);
            this.labelChangetxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChangetxt.Name = "labelChangetxt";
            this.labelChangetxt.Size = new System.Drawing.Size(193, 26);
            this.labelChangetxt.TabIndex = 4;
            this.labelChangetxt.Text = "TotalChange";
            this.labelChangetxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChange
            // 
            this.labelChange.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelChange.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(8, 8);
            this.labelChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(193, 26);
            this.labelChange.TabIndex = 5;
            this.labelChange.Text = "Change :";
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelReceive
            // 
            this.panelReceive.Controls.Add(this.labelRecivedAmounttxt);
            this.panelReceive.Controls.Add(this.labelReceiveAmount);
            this.panelReceive.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceive.Location = new System.Drawing.Point(0, 112);
            this.panelReceive.Margin = new System.Windows.Forms.Padding(2);
            this.panelReceive.Name = "panelReceive";
            this.panelReceive.Padding = new System.Windows.Forms.Padding(8);
            this.panelReceive.Size = new System.Drawing.Size(364, 42);
            this.panelReceive.TabIndex = 35;
            // 
            // labelRecivedAmounttxt
            // 
            this.labelRecivedAmounttxt.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelRecivedAmounttxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecivedAmounttxt.Location = new System.Drawing.Point(163, 8);
            this.labelRecivedAmounttxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecivedAmounttxt.Name = "labelRecivedAmounttxt";
            this.labelRecivedAmounttxt.Size = new System.Drawing.Size(193, 26);
            this.labelRecivedAmounttxt.TabIndex = 4;
            this.labelRecivedAmounttxt.Text = "TotalReceived";
            this.labelRecivedAmounttxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReceiveAmount
            // 
            this.labelReceiveAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelReceiveAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiveAmount.Location = new System.Drawing.Point(8, 8);
            this.labelReceiveAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReceiveAmount.Name = "labelReceiveAmount";
            this.labelReceiveAmount.Size = new System.Drawing.Size(193, 26);
            this.labelReceiveAmount.TabIndex = 5;
            this.labelReceiveAmount.Text = "Received amount :";
            this.labelReceiveAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator3.Location = new System.Drawing.Point(0, 104);
            this.guna2Separator3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(364, 8);
            this.guna2Separator3.TabIndex = 34;
            // 
            // panelBillDetail
            // 
            this.panelBillDetail.AutoSize = true;
            this.panelBillDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBillDetail.Location = new System.Drawing.Point(0, 104);
            this.panelBillDetail.Margin = new System.Windows.Forms.Padding(2);
            this.panelBillDetail.Name = "panelBillDetail";
            this.panelBillDetail.Size = new System.Drawing.Size(364, 0);
            this.panelBillDetail.TabIndex = 33;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 96);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(364, 8);
            this.guna2Separator1.TabIndex = 17;
            // 
            // labelPaymentTime
            // 
            this.labelPaymentTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPaymentTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentTime.Location = new System.Drawing.Point(0, 68);
            this.labelPaymentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPaymentTime.Name = "labelPaymentTime";
            this.labelPaymentTime.Size = new System.Drawing.Size(364, 28);
            this.labelPaymentTime.TabIndex = 10;
            this.labelPaymentTime.Text = "Payment Time";
            this.labelPaymentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimeStart
            // 
            this.labelTimeStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTimeStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeStart.Location = new System.Drawing.Point(0, 40);
            this.labelTimeStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeStart.Name = "labelTimeStart";
            this.labelTimeStart.Size = new System.Drawing.Size(364, 28);
            this.labelTimeStart.TabIndex = 9;
            this.labelTimeStart.Text = "Time Start";
            this.labelTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTittle
            // 
            this.labelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTittle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.Location = new System.Drawing.Point(0, 0);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(364, 40);
            this.labelTittle.TabIndex = 8;
            this.labelTittle.Text = "RECEIPT";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrintBillPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 505);
            this.Controls.Add(this.guna2PanelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrintBillPage";
            this.Text = "FormPrintBillPage";
            this.Load += new System.EventHandler(this.FormPrintBillPage_Load);
            this.guna2PanelContent.ResumeLayout(false);
            this.guna2PanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.PanelTotal.ResumeLayout(false);
            this.panelChange.ResumeLayout(false);
            this.panelReceive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPaymentTime;
        private System.Windows.Forms.Label labelTimeStart;
        private System.Windows.Forms.Label labelTittle;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2Panel guna2PanelContent;
        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.Label labelTotalMoney;
        private System.Windows.Forms.Label labelTotalText;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Panel panelChange;
        private System.Windows.Forms.Label labelChangetxt;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Panel panelReceive;
        private System.Windows.Forms.Label labelRecivedAmounttxt;
        private System.Windows.Forms.Label labelReceiveAmount;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Panel panelBillDetail;
        private System.Windows.Forms.PictureBox pictureBoxExit;
    }
}