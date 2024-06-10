namespace BillardManager.Model
{
    partial class FormStaffAdd
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
            this.components = new System.ComponentModel.Container();
            this.guna2TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.guna2TextBoxFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.guna2TextBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBankAccountNumber = new System.Windows.Forms.Label();
            this.guna2TextBoxBankAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelBankName = new System.Windows.Forms.Label();
            this.guna2ComboBoxBankName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).BeginInit();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(84, 44);
            this.labelTop.Size = new System.Drawing.Size(77, 32);
            this.labelTop.Text = "Staffs";
            // 
            // gunaPictureBoxTop
            // 
            this.gunaPictureBoxTop.Image = global::BillardManager.Properties.Resources.management;
            this.gunaPictureBoxTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // guna2ButtonSave
            // 
            this.guna2ButtonSave.BorderRadius = 8;
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
            this.guna2ButtonClose.BorderRadius = 8;
            this.guna2ButtonClose.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.guna2ButtonClose.CheckedState.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.CustomImages.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2ButtonClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2ButtonClose.HoverState.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonClose.Location = new System.Drawing.Point(541, 13);
            this.guna2ButtonClose.ShadowDecoration.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ButtonClose.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2ButtonClose.Click += new System.EventHandler(this.guna2ButtonClose_Click);
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2PanelTop.ShadowDecoration.Parent = this.guna2PanelTop;
            this.guna2PanelTop.Size = new System.Drawing.Size(691, 85);
            this.guna2PanelTop.TabIndex = 6;
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 380);
            this.guna2PanelBottom.ShadowDecoration.Parent = this.guna2PanelBottom;
            this.guna2PanelBottom.Size = new System.Drawing.Size(691, 70);
            this.guna2PanelBottom.TabIndex = 5;
            // 
            // guna2TextBoxUsername
            // 
            this.guna2TextBoxUsername.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBoxUsername.BorderRadius = 10;
            this.guna2TextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxUsername.DefaultText = "";
            this.guna2TextBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxUsername.DisabledState.Parent = this.guna2TextBoxUsername;
            this.guna2TextBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxUsername.FocusedState.Parent = this.guna2TextBoxUsername;
            this.guna2TextBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxUsername.HoverState.Parent = this.guna2TextBoxUsername;
            this.guna2TextBoxUsername.Location = new System.Drawing.Point(22, 126);
            this.guna2TextBoxUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.guna2TextBoxUsername.Name = "guna2TextBoxUsername";
            this.guna2TextBoxUsername.PasswordChar = '\0';
            this.guna2TextBoxUsername.PlaceholderText = "";
            this.guna2TextBoxUsername.SelectedText = "";
            this.guna2TextBoxUsername.ShadowDecoration.Parent = this.guna2TextBoxUsername;
            this.guna2TextBoxUsername.Size = new System.Drawing.Size(280, 35);
            this.guna2TextBoxUsername.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(19, 105);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(67, 17);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username";
            // 
            // guna2TextBoxFullName
            // 
            this.guna2TextBoxFullName.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBoxFullName.BorderRadius = 10;
            this.guna2TextBoxFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxFullName.DefaultText = "";
            this.guna2TextBoxFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxFullName.DisabledState.Parent = this.guna2TextBoxFullName;
            this.guna2TextBoxFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxFullName.FocusedState.Parent = this.guna2TextBoxFullName;
            this.guna2TextBoxFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxFullName.HoverState.Parent = this.guna2TextBoxFullName;
            this.guna2TextBoxFullName.Location = new System.Drawing.Point(361, 126);
            this.guna2TextBoxFullName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBoxFullName.Name = "guna2TextBoxFullName";
            this.guna2TextBoxFullName.PasswordChar = '\0';
            this.guna2TextBoxFullName.PlaceholderText = "";
            this.guna2TextBoxFullName.SelectedText = "";
            this.guna2TextBoxFullName.ShadowDecoration.Parent = this.guna2TextBoxFullName;
            this.guna2TextBoxFullName.Size = new System.Drawing.Size(309, 35);
            this.guna2TextBoxFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(358, 105);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(66, 17);
            this.labelFullName.TabIndex = 5;
            this.labelFullName.Text = "Full Name";
            // 
            // guna2TextBoxPhone
            // 
            this.guna2TextBoxPhone.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBoxPhone.BorderRadius = 10;
            this.guna2TextBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxPhone.DefaultText = "";
            this.guna2TextBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPhone.DisabledState.Parent = this.guna2TextBoxPhone;
            this.guna2TextBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPhone.FocusedState.Parent = this.guna2TextBoxPhone;
            this.guna2TextBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPhone.HoverState.Parent = this.guna2TextBoxPhone;
            this.guna2TextBoxPhone.Location = new System.Drawing.Point(22, 189);
            this.guna2TextBoxPhone.Margin = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxPhone.Name = "guna2TextBoxPhone";
            this.guna2TextBoxPhone.PasswordChar = '\0';
            this.guna2TextBoxPhone.PlaceholderText = "";
            this.guna2TextBoxPhone.SelectedText = "";
            this.guna2TextBoxPhone.ShadowDecoration.Parent = this.guna2TextBoxPhone;
            this.guna2TextBoxPhone.Size = new System.Drawing.Size(280, 35);
            this.guna2TextBoxPhone.TabIndex = 2;
            this.guna2TextBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBoxBankAccountNumber_KeyPress);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(21, 165);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(44, 17);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone";
            // 
            // labelBankAccountNumber
            // 
            this.labelBankAccountNumber.AutoSize = true;
            this.labelBankAccountNumber.Location = new System.Drawing.Point(19, 231);
            this.labelBankAccountNumber.Name = "labelBankAccountNumber";
            this.labelBankAccountNumber.Size = new System.Drawing.Size(137, 17);
            this.labelBankAccountNumber.TabIndex = 5;
            this.labelBankAccountNumber.Text = "Bank Account Number";
            // 
            // guna2TextBoxBankAccountNumber
            // 
            this.guna2TextBoxBankAccountNumber.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBoxBankAccountNumber.BorderRadius = 10;
            this.guna2TextBoxBankAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxBankAccountNumber.DefaultText = "";
            this.guna2TextBoxBankAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxBankAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxBankAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxBankAccountNumber.DisabledState.Parent = this.guna2TextBoxBankAccountNumber;
            this.guna2TextBoxBankAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxBankAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxBankAccountNumber.FocusedState.Parent = this.guna2TextBoxBankAccountNumber;
            this.guna2TextBoxBankAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxBankAccountNumber.HoverState.Parent = this.guna2TextBoxBankAccountNumber;
            this.guna2TextBoxBankAccountNumber.Location = new System.Drawing.Point(22, 257);
            this.guna2TextBoxBankAccountNumber.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.guna2TextBoxBankAccountNumber.Name = "guna2TextBoxBankAccountNumber";
            this.guna2TextBoxBankAccountNumber.PasswordChar = '\0';
            this.guna2TextBoxBankAccountNumber.PlaceholderText = "";
            this.guna2TextBoxBankAccountNumber.SelectedText = "";
            this.guna2TextBoxBankAccountNumber.ShadowDecoration.Parent = this.guna2TextBoxBankAccountNumber;
            this.guna2TextBoxBankAccountNumber.Size = new System.Drawing.Size(280, 35);
            this.guna2TextBoxBankAccountNumber.TabIndex = 3;
            this.guna2TextBoxBankAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBoxBankAccountNumber_KeyPress);
            // 
            // labelBankName
            // 
            this.labelBankName.AutoSize = true;
            this.labelBankName.Location = new System.Drawing.Point(358, 231);
            this.labelBankName.Name = "labelBankName";
            this.labelBankName.Size = new System.Drawing.Size(74, 17);
            this.labelBankName.TabIndex = 5;
            this.labelBankName.Text = "Bank Name";
            // 
            // guna2ComboBoxBankName
            // 
            this.guna2ComboBoxBankName.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxBankName.BorderColor = System.Drawing.Color.Black;
            this.guna2ComboBoxBankName.BorderRadius = 10;
            this.guna2ComboBoxBankName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxBankName.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBoxBankName.FocusedState.Parent = this.guna2ComboBoxBankName;
            this.guna2ComboBoxBankName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxBankName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBoxBankName.FormattingEnabled = true;
            this.guna2ComboBoxBankName.HoverState.Parent = this.guna2ComboBoxBankName;
            this.guna2ComboBoxBankName.ItemHeight = 30;
            this.guna2ComboBoxBankName.ItemsAppearance.Parent = this.guna2ComboBoxBankName;
            this.guna2ComboBoxBankName.Location = new System.Drawing.Point(361, 257);
            this.guna2ComboBoxBankName.Name = "guna2ComboBoxBankName";
            this.guna2ComboBoxBankName.ShadowDecoration.Parent = this.guna2ComboBoxBankName;
            this.guna2ComboBoxBankName.Size = new System.Drawing.Size(297, 36);
            this.guna2ComboBoxBankName.TabIndex = 7;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FormStaffAdd
            // 
            this.AcceptButton = this.guna2ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.guna2ButtonClose;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.guna2ComboBoxBankName);
            this.Controls.Add(this.guna2TextBoxBankAccountNumber);
            this.Controls.Add(this.guna2TextBoxPhone);
            this.Controls.Add(this.labelBankName);
            this.Controls.Add(this.labelBankAccountNumber);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.guna2TextBoxFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.guna2TextBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Name = "FormStaffAdd";
            this.Text = "FormStaffAdd";
            this.Controls.SetChildIndex(this.guna2PanelTop, 0);
            this.Controls.SetChildIndex(this.guna2PanelBottom, 0);
            this.Controls.SetChildIndex(this.labelUsername, 0);
            this.Controls.SetChildIndex(this.guna2TextBoxUsername, 0);
            this.Controls.SetChildIndex(this.labelFullName, 0);
            this.Controls.SetChildIndex(this.guna2TextBoxFullName, 0);
            this.Controls.SetChildIndex(this.labelPhone, 0);
            this.Controls.SetChildIndex(this.labelBankAccountNumber, 0);
            this.Controls.SetChildIndex(this.labelBankName, 0);
            this.Controls.SetChildIndex(this.guna2TextBoxPhone, 0);
            this.Controls.SetChildIndex(this.guna2TextBoxBankAccountNumber, 0);
            this.Controls.SetChildIndex(this.guna2ComboBoxBankName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).EndInit();
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelBankAccountNumber;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxBankAccountNumber;
        private System.Windows.Forms.Label labelBankName;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxBankName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}