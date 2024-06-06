namespace BillardManager.Model
{
    partial class FormCheckOut
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
            this.guna2ControlBoxExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2TextBoxBillAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelBillAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBoxReceived = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.guna2TextBoxChange = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).BeginInit();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Location = new System.Drawing.Point(84, 25);
            this.labelTop.Size = new System.Drawing.Size(126, 32);
            this.labelTop.Text = "Check Out";
            // 
            // gunaPictureBoxTop
            // 
            this.gunaPictureBoxTop.Image = global::BillardManager.Properties.Resources.bill;
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
            this.guna2ButtonSave.Click += new System.EventHandler(this.guna2ButtonSave_Click);
            // 
            // guna2ButtonClose
            // 
            this.guna2ButtonClose.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.guna2ButtonClose.CheckedState.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.CustomImages.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2ButtonClose.HoverState.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonClose.ShadowDecoration.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ButtonClose.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2ButtonClose.Click += new System.EventHandler(this.guna2ButtonClose_Click);
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.Controls.Add(this.guna2ControlBoxExit);
            this.guna2PanelTop.ShadowDecoration.Parent = this.guna2PanelTop;
            this.guna2PanelTop.Size = new System.Drawing.Size(731, 85);
            this.guna2PanelTop.Controls.SetChildIndex(this.gunaPictureBoxTop, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.labelTop, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.guna2ControlBoxExit, 0);
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 290);
            this.guna2PanelBottom.ShadowDecoration.Parent = this.guna2PanelBottom;
            this.guna2PanelBottom.Size = new System.Drawing.Size(731, 70);
            // 
            // guna2ControlBoxExit
            // 
            this.guna2ControlBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxExit.Animated = true;
            this.guna2ControlBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ControlBoxExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ControlBoxExit.HoverState.Parent = this.guna2ControlBoxExit;
            this.guna2ControlBoxExit.IconColor = System.Drawing.Color.White;
            this.guna2ControlBoxExit.Location = new System.Drawing.Point(679, 12);
            this.guna2ControlBoxExit.Name = "guna2ControlBoxExit";
            this.guna2ControlBoxExit.ShadowDecoration.Parent = this.guna2ControlBoxExit;
            this.guna2ControlBoxExit.Size = new System.Drawing.Size(39, 34);
            this.guna2ControlBoxExit.TabIndex = 3;
            // 
            // guna2TextBoxBillAmount
            // 
            this.guna2TextBoxBillAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxBillAmount.DefaultText = "";
            this.guna2TextBoxBillAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxBillAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxBillAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxBillAmount.DisabledState.Parent = this.guna2TextBoxBillAmount;
            this.guna2TextBoxBillAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxBillAmount.Enabled = false;
            this.guna2TextBoxBillAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxBillAmount.FocusedState.Parent = this.guna2TextBoxBillAmount;
            this.guna2TextBoxBillAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxBillAmount.HoverState.Parent = this.guna2TextBoxBillAmount;
            this.guna2TextBoxBillAmount.Location = new System.Drawing.Point(12, 119);
            this.guna2TextBoxBillAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBoxBillAmount.Name = "guna2TextBoxBillAmount";
            this.guna2TextBoxBillAmount.PasswordChar = '\0';
            this.guna2TextBoxBillAmount.PlaceholderText = "";
            this.guna2TextBoxBillAmount.SelectedText = "";
            this.guna2TextBoxBillAmount.ShadowDecoration.Parent = this.guna2TextBoxBillAmount;
            this.guna2TextBoxBillAmount.Size = new System.Drawing.Size(315, 46);
            this.guna2TextBoxBillAmount.TabIndex = 6;
            // 
            // labelBillAmount
            // 
            this.labelBillAmount.AutoSize = true;
            this.labelBillAmount.Location = new System.Drawing.Point(8, 91);
            this.labelBillAmount.Name = "labelBillAmount";
            this.labelBillAmount.Size = new System.Drawing.Size(99, 23);
            this.labelBillAmount.TabIndex = 7;
            this.labelBillAmount.Text = "Bill Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Payment Receive";
            // 
            // guna2TextBoxReceived
            // 
            this.guna2TextBoxReceived.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxReceived.DefaultText = "";
            this.guna2TextBoxReceived.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxReceived.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxReceived.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxReceived.DisabledState.Parent = this.guna2TextBoxReceived;
            this.guna2TextBoxReceived.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxReceived.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxReceived.FocusedState.Parent = this.guna2TextBoxReceived;
            this.guna2TextBoxReceived.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxReceived.HoverState.Parent = this.guna2TextBoxReceived;
            this.guna2TextBoxReceived.Location = new System.Drawing.Point(364, 119);
            this.guna2TextBoxReceived.Margin = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxReceived.Name = "guna2TextBoxReceived";
            this.guna2TextBoxReceived.PasswordChar = '\0';
            this.guna2TextBoxReceived.PlaceholderText = "";
            this.guna2TextBoxReceived.SelectedText = "";
            this.guna2TextBoxReceived.ShadowDecoration.Parent = this.guna2TextBoxReceived;
            this.guna2TextBoxReceived.Size = new System.Drawing.Size(354, 46);
            this.guna2TextBoxReceived.TabIndex = 6;
            this.guna2TextBoxReceived.TextChanged += new System.EventHandler(this.guna2TextBoxReceived_TextChanged);
            this.guna2TextBoxReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBoxReceived_KeyPress);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(8, 180);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(69, 23);
            this.labelCategory.TabIndex = 17;
            this.labelCategory.Text = "Change";
            // 
            // guna2TextBoxChange
            // 
            this.guna2TextBoxChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxChange.DefaultText = "";
            this.guna2TextBoxChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxChange.DisabledState.Parent = this.guna2TextBoxChange;
            this.guna2TextBoxChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxChange.Enabled = false;
            this.guna2TextBoxChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxChange.FocusedState.Parent = this.guna2TextBoxChange;
            this.guna2TextBoxChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxChange.HoverState.Parent = this.guna2TextBoxChange;
            this.guna2TextBoxChange.Location = new System.Drawing.Point(12, 208);
            this.guna2TextBoxChange.Margin = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxChange.Name = "guna2TextBoxChange";
            this.guna2TextBoxChange.PasswordChar = '\0';
            this.guna2TextBoxChange.PlaceholderText = "";
            this.guna2TextBoxChange.SelectedText = "";
            this.guna2TextBoxChange.ShadowDecoration.Parent = this.guna2TextBoxChange;
            this.guna2TextBoxChange.Size = new System.Drawing.Size(315, 46);
            this.guna2TextBoxChange.TabIndex = 6;
            // 
            // FormCheckOut
            // 
            this.AcceptButton = this.guna2ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.guna2ButtonClose;
            this.ClientSize = new System.Drawing.Size(731, 360);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.guna2TextBoxReceived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBoxChange);
            this.Controls.Add(this.guna2TextBoxBillAmount);
            this.Controls.Add(this.labelBillAmount);
            this.Name = "FormCheckOut";
            this.Text = "FormCheckOut";
            this.Load += new System.EventHandler(this.FormCheckOut_Load);
            this.Controls.SetChildIndex(this.labelBillAmount, 0);
            this.Controls.SetChildIndex(this.guna2TextBoxBillAmount, 0);
            this.Controls.SetChildIndex(this.guna2TextBoxChange, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.guna2TextBoxReceived, 0);
            this.Controls.SetChildIndex(this.labelCategory, 0);
            this.Controls.SetChildIndex(this.guna2PanelTop, 0);
            this.Controls.SetChildIndex(this.guna2PanelBottom, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).EndInit();
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxExit;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxBillAmount;
        private System.Windows.Forms.Label labelBillAmount;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxReceived;
        private System.Windows.Forms.Label labelCategory;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxChange;
    }
}