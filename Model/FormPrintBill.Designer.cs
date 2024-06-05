namespace BillardManager.Model
{
    partial class FormPrintBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrintBill));
            this.guna2ControlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.printDocumentBill = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogBill = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2PanelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBillDetail = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).BeginInit();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelBottom.SuspendLayout();
            this.guna2PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Size = new System.Drawing.Size(102, 32);
            this.labelTop.Text = "Print bill";
            // 
            // gunaPictureBoxTop
            // 
            this.gunaPictureBoxTop.Image = global::BillardManager.Properties.Resources.printer;
            this.gunaPictureBoxTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // guna2ButtonSave
            // 
            this.guna2ButtonSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.guna2ButtonSave.CheckedState.Parent = this.guna2ButtonSave;
            this.guna2ButtonSave.CustomImages.Parent = this.guna2ButtonSave;
            this.guna2ButtonSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna2ButtonSave.HoverState.Parent = this.guna2ButtonSave;
            this.guna2ButtonSave.Image = global::BillardManager.Properties.Resources.printer;
            this.guna2ButtonSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonSave.ShadowDecoration.Parent = this.guna2ButtonSave;
            this.guna2ButtonSave.Text = "PRINT";
            this.guna2ButtonSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ButtonSave.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2ButtonSave.Click += new System.EventHandler(this.guna2ButtonSave_Click_1);
            // 
            // guna2ButtonClose
            // 
            this.guna2ButtonClose.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.guna2ButtonClose.CheckedState.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.CustomImages.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna2ButtonClose.HoverState.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonClose.ShadowDecoration.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ButtonClose.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.Controls.Add(this.guna2ControlBoxMinimize);
            this.guna2PanelTop.Controls.Add(this.guna2ControlBoxMaximize);
            this.guna2PanelTop.Controls.Add(this.guna2ControlBoxClose);
            this.guna2PanelTop.ShadowDecoration.Parent = this.guna2PanelTop;
            this.guna2PanelTop.Size = new System.Drawing.Size(609, 85);
            this.guna2PanelTop.Controls.SetChildIndex(this.gunaPictureBoxTop, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.labelTop, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.guna2ControlBoxClose, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.guna2ControlBoxMaximize, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.guna2ControlBoxMinimize, 0);
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 665);
            this.guna2PanelBottom.ShadowDecoration.Parent = this.guna2PanelBottom;
            this.guna2PanelBottom.Size = new System.Drawing.Size(609, 70);
            // 
            // guna2ControlBoxMinimize
            // 
            this.guna2ControlBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBoxMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBoxMinimize.HoverState.Parent = this.guna2ControlBoxMinimize;
            this.guna2ControlBoxMinimize.IconColor = System.Drawing.Color.White;
            this.guna2ControlBoxMinimize.Location = new System.Drawing.Point(492, 12);
            this.guna2ControlBoxMinimize.Name = "guna2ControlBoxMinimize";
            this.guna2ControlBoxMinimize.ShadowDecoration.Parent = this.guna2ControlBoxMinimize;
            this.guna2ControlBoxMinimize.Size = new System.Drawing.Size(31, 27);
            this.guna2ControlBoxMinimize.TabIndex = 3;
            // 
            // guna2ControlBoxMaximize
            // 
            this.guna2ControlBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBoxMaximize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBoxMaximize.HoverState.Parent = this.guna2ControlBoxMaximize;
            this.guna2ControlBoxMaximize.IconColor = System.Drawing.Color.White;
            this.guna2ControlBoxMaximize.Location = new System.Drawing.Point(529, 12);
            this.guna2ControlBoxMaximize.Name = "guna2ControlBoxMaximize";
            this.guna2ControlBoxMaximize.ShadowDecoration.Parent = this.guna2ControlBoxMaximize;
            this.guna2ControlBoxMaximize.Size = new System.Drawing.Size(31, 27);
            this.guna2ControlBoxMaximize.TabIndex = 4;
            // 
            // guna2ControlBoxClose
            // 
            this.guna2ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBoxClose.HoverState.Parent = this.guna2ControlBoxClose;
            this.guna2ControlBoxClose.IconColor = System.Drawing.Color.White;
            this.guna2ControlBoxClose.Location = new System.Drawing.Point(566, 12);
            this.guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            this.guna2ControlBoxClose.ShadowDecoration.Parent = this.guna2ControlBoxClose;
            this.guna2ControlBoxClose.Size = new System.Drawing.Size(31, 27);
            this.guna2ControlBoxClose.TabIndex = 5;
            // 
            // printDocumentBill
            // 
            this.printDocumentBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentBill_PrintPage);
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
            // guna2PanelContent
            // 
            this.guna2PanelContent.AutoScroll = true;
            this.guna2PanelContent.Controls.Add(this.panelBillDetail);
            this.guna2PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelContent.Location = new System.Drawing.Point(0, 85);
            this.guna2PanelContent.Name = "guna2PanelContent";
            this.guna2PanelContent.ShadowDecoration.Parent = this.guna2PanelContent;
            this.guna2PanelContent.Size = new System.Drawing.Size(609, 580);
            this.guna2PanelContent.TabIndex = 5;
            // 
            // panelBillDetail
            // 
            this.panelBillDetail.AutoSize = true;
            this.panelBillDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBillDetail.Location = new System.Drawing.Point(0, 0);
            this.panelBillDetail.Name = "panelBillDetail";
            this.panelBillDetail.Size = new System.Drawing.Size(609, 0);
            this.panelBillDetail.TabIndex = 11;
            // 
            // FormPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 735);
            this.Controls.Add(this.guna2PanelContent);
            this.Name = "FormPrintBill";
            this.Text = "FormPrintBill";
            this.Load += new System.EventHandler(this.FormPrintBill_Load);
            this.Controls.SetChildIndex(this.guna2PanelTop, 0);
            this.Controls.SetChildIndex(this.guna2PanelBottom, 0);
            this.Controls.SetChildIndex(this.guna2PanelContent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).EndInit();
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelBottom.ResumeLayout(false);
            this.guna2PanelContent.ResumeLayout(false);
            this.guna2PanelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxClose;
        private System.Drawing.Printing.PrintDocument printDocumentBill;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogBill;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelContent;
        private System.Windows.Forms.Panel panelBillDetail;
    }
}