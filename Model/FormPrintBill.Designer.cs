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
            this.guna2ControlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).BeginInit();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Size = new System.Drawing.Size(83, 25);
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
            this.guna2ButtonSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonSave.ShadowDecoration.Parent = this.guna2ButtonSave;
            this.guna2ButtonSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ButtonSave.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
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
            this.guna2PanelTop.Size = new System.Drawing.Size(800, 85);
            this.guna2PanelTop.Controls.SetChildIndex(this.gunaPictureBoxTop, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.labelTop, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.guna2ControlBoxClose, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.guna2ControlBoxMaximize, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.guna2ControlBoxMinimize, 0);
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 380);
            this.guna2PanelBottom.ShadowDecoration.Parent = this.guna2PanelBottom;
            this.guna2PanelBottom.Size = new System.Drawing.Size(800, 70);
            // 
            // guna2ControlBoxMinimize
            // 
            this.guna2ControlBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBoxMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBoxMinimize.HoverState.Parent = this.guna2ControlBoxMinimize;
            this.guna2ControlBoxMinimize.IconColor = System.Drawing.Color.White;
            this.guna2ControlBoxMinimize.Location = new System.Drawing.Point(683, 12);
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
            this.guna2ControlBoxMaximize.Location = new System.Drawing.Point(720, 12);
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
            this.guna2ControlBoxClose.Location = new System.Drawing.Point(757, 12);
            this.guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            this.guna2ControlBoxClose.ShadowDecoration.Parent = this.guna2ControlBoxClose;
            this.guna2ControlBoxClose.Size = new System.Drawing.Size(31, 27);
            this.guna2ControlBoxClose.TabIndex = 5;
            // 
            // FormPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormPrintBill";
            this.Text = "FormPrintBill";
            this.Load += new System.EventHandler(this.FormPrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).EndInit();
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxClose;
    }
}