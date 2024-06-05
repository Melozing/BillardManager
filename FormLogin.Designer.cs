namespace BillardManager
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.guna2PanelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNotice = new System.Windows.Forms.Label();
            this.guna2PictureBoxLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.guna2TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.guna2ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelLogin
            // 
            this.guna2PanelLogin.Controls.Add(this.labelNotice);
            this.guna2PanelLogin.Controls.Add(this.guna2PictureBoxLogin);
            this.guna2PanelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2PanelLogin.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelLogin.Name = "guna2PanelLogin";
            this.guna2PanelLogin.ShadowDecoration.Parent = this.guna2PanelLogin;
            this.guna2PanelLogin.Size = new System.Drawing.Size(338, 243);
            this.guna2PanelLogin.TabIndex = 0;
            // 
            // labelNotice
            // 
            this.labelNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.labelNotice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNotice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNotice.Location = new System.Drawing.Point(0, 217);
            this.labelNotice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(338, 26);
            this.labelNotice.TabIndex = 3;
            this.labelNotice.Text = "Please enter user infomation !";
            this.labelNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBoxLogin
            // 
            this.guna2PictureBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBoxLogin.Image")));
            this.guna2PictureBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBoxLogin.Name = "guna2PictureBoxLogin";
            this.guna2PictureBoxLogin.ShadowDecoration.Parent = this.guna2PictureBoxLogin;
            this.guna2PictureBoxLogin.Size = new System.Drawing.Size(338, 243);
            this.guna2PictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBoxLogin.TabIndex = 2;
            this.guna2PictureBoxLogin.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(49, 296);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 23);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // guna2TextBoxUsername
            // 
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
            this.guna2TextBoxUsername.Location = new System.Drawing.Point(52, 316);
            this.guna2TextBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxUsername.Name = "guna2TextBoxUsername";
            this.guna2TextBoxUsername.PasswordChar = '\0';
            this.guna2TextBoxUsername.PlaceholderText = "";
            this.guna2TextBoxUsername.SelectedText = "";
            this.guna2TextBoxUsername.ShadowDecoration.Parent = this.guna2TextBoxUsername;
            this.guna2TextBoxUsername.Size = new System.Drawing.Size(233, 47);
            this.guna2TextBoxUsername.TabIndex = 2;
            // 
            // guna2TextBoxPassword
            // 
            this.guna2TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxPassword.DefaultText = "";
            this.guna2TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPassword.DisabledState.Parent = this.guna2TextBoxPassword;
            this.guna2TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPassword.FocusedState.Parent = this.guna2TextBoxPassword;
            this.guna2TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPassword.HoverState.Parent = this.guna2TextBoxPassword;
            this.guna2TextBoxPassword.Location = new System.Drawing.Point(52, 404);
            this.guna2TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxPassword.Name = "guna2TextBoxPassword";
            this.guna2TextBoxPassword.PasswordChar = '\0';
            this.guna2TextBoxPassword.PlaceholderText = "";
            this.guna2TextBoxPassword.SelectedText = "";
            this.guna2TextBoxPassword.ShadowDecoration.Parent = this.guna2TextBoxPassword;
            this.guna2TextBoxPassword.Size = new System.Drawing.Size(233, 47);
            this.guna2TextBoxPassword.TabIndex = 4;
            this.guna2TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(49, 383);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 23);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // guna2ButtonLogin
            // 
            this.guna2ButtonLogin.AutoRoundedCorners = true;
            this.guna2ButtonLogin.BorderRadius = 20;
            this.guna2ButtonLogin.CheckedState.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.CustomImages.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonLogin.HoverState.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.Location = new System.Drawing.Point(52, 471);
            this.guna2ButtonLogin.Name = "guna2ButtonLogin";
            this.guna2ButtonLogin.ShadowDecoration.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.Size = new System.Drawing.Size(94, 42);
            this.guna2ButtonLogin.TabIndex = 5;
            this.guna2ButtonLogin.Text = "Login";
            this.guna2ButtonLogin.Click += new System.EventHandler(this.guna2ButtonLogin_Click);
            // 
            // guna2ButtonExit
            // 
            this.guna2ButtonExit.AutoRoundedCorners = true;
            this.guna2ButtonExit.BorderRadius = 20;
            this.guna2ButtonExit.CheckedState.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.CustomImages.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2ButtonExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ButtonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonExit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonExit.HoverState.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.Location = new System.Drawing.Point(191, 471);
            this.guna2ButtonExit.Name = "guna2ButtonExit";
            this.guna2ButtonExit.ShadowDecoration.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.Size = new System.Drawing.Size(94, 42);
            this.guna2ButtonExit.TabIndex = 6;
            this.guna2ButtonExit.Text = "Exit";
            this.guna2ButtonExit.Click += new System.EventHandler(this.guna2ButtonExit_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.guna2ButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.guna2ButtonExit;
            this.ClientSize = new System.Drawing.Size(338, 553);
            this.ControlBox = false;
            this.Controls.Add(this.guna2ButtonExit);
            this.Controls.Add(this.guna2ButtonLogin);
            this.Controls.Add(this.guna2TextBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.guna2TextBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.guna2PanelLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.guna2PanelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelLogin;
        private System.Windows.Forms.Label labelUsername;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxUsername;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelNotice;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxLogin;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonLogin;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonExit;
    }
}

