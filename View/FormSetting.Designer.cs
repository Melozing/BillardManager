namespace BillardManager.View
{
    partial class FormSetting
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
            this.guna2ButtonSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBoxDirectBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.guna2ButtonChoicePath = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2ButtonSignOut
            // 
            this.guna2ButtonSignOut.AutoRoundedCorners = true;
            this.guna2ButtonSignOut.BorderRadius = 20;
            this.guna2ButtonSignOut.CheckedState.Parent = this.guna2ButtonSignOut;
            this.guna2ButtonSignOut.CustomImages.Parent = this.guna2ButtonSignOut;
            this.guna2ButtonSignOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonSignOut.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2ButtonSignOut.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSignOut.HoverState.Parent = this.guna2ButtonSignOut;
            this.guna2ButtonSignOut.Location = new System.Drawing.Point(13, 171);
            this.guna2ButtonSignOut.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2ButtonSignOut.Name = "guna2ButtonSignOut";
            this.guna2ButtonSignOut.ShadowDecoration.Parent = this.guna2ButtonSignOut;
            this.guna2ButtonSignOut.Size = new System.Drawing.Size(118, 43);
            this.guna2ButtonSignOut.TabIndex = 0;
            this.guna2ButtonSignOut.Text = "Sign Out";
            this.guna2ButtonSignOut.Click += new System.EventHandler(this.guna2ButtonSignOut_Click);
            // 
            // guna2TextBoxDirectBill
            // 
            this.guna2TextBoxDirectBill.BorderRadius = 8;
            this.guna2TextBoxDirectBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxDirectBill.DefaultText = "";
            this.guna2TextBoxDirectBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxDirectBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxDirectBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDirectBill.DisabledState.Parent = this.guna2TextBoxDirectBill;
            this.guna2TextBoxDirectBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDirectBill.Enabled = false;
            this.guna2TextBoxDirectBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDirectBill.FocusedState.Parent = this.guna2TextBoxDirectBill;
            this.guna2TextBoxDirectBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDirectBill.HoverState.Parent = this.guna2TextBoxDirectBill;
            this.guna2TextBoxDirectBill.Location = new System.Drawing.Point(13, 73);
            this.guna2TextBoxDirectBill.Margin = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxDirectBill.Name = "guna2TextBoxDirectBill";
            this.guna2TextBoxDirectBill.PasswordChar = '\0';
            this.guna2TextBoxDirectBill.PlaceholderText = "";
            this.guna2TextBoxDirectBill.SelectedText = "";
            this.guna2TextBoxDirectBill.ShadowDecoration.Parent = this.guna2TextBoxDirectBill;
            this.guna2TextBoxDirectBill.Size = new System.Drawing.Size(372, 40);
            this.guna2TextBoxDirectBill.TabIndex = 6;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(10, 49);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(137, 17);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Directory export bills :";
            // 
            // guna2ButtonChoicePath
            // 
            this.guna2ButtonChoicePath.CheckedState.Parent = this.guna2ButtonChoicePath;
            this.guna2ButtonChoicePath.CustomImages.Parent = this.guna2ButtonChoicePath;
            this.guna2ButtonChoicePath.FillColor = System.Drawing.Color.Teal;
            this.guna2ButtonChoicePath.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2ButtonChoicePath.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonChoicePath.HoverState.Parent = this.guna2ButtonChoicePath;
            this.guna2ButtonChoicePath.Image = global::BillardManager.Properties.Resources.folder;
            this.guna2ButtonChoicePath.Location = new System.Drawing.Point(384, 73);
            this.guna2ButtonChoicePath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2ButtonChoicePath.Name = "guna2ButtonChoicePath";
            this.guna2ButtonChoicePath.ShadowDecoration.Parent = this.guna2ButtonChoicePath;
            this.guna2ButtonChoicePath.Size = new System.Drawing.Size(50, 40);
            this.guna2ButtonChoicePath.TabIndex = 8;
            this.guna2ButtonChoicePath.Click += new System.EventHandler(this.guna2ButtonChoicePath_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 479);
            this.ControlBox = false;
            this.Controls.Add(this.guna2ButtonChoicePath);
            this.Controls.Add(this.guna2TextBoxDirectBill);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.guna2ButtonSignOut);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2ButtonSignOut;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxDirectBill;
        private System.Windows.Forms.Label labelUsername;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonChoicePath;
    }
}