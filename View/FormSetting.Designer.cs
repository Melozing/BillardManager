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
            this.SuspendLayout();
            // 
            // guna2ButtonSignOut
            // 
            this.guna2ButtonSignOut.AutoRoundedCorners = true;
            this.guna2ButtonSignOut.BorderRadius = 29;
            this.guna2ButtonSignOut.CheckedState.Parent = this.guna2ButtonSignOut;
            this.guna2ButtonSignOut.CustomImages.Parent = this.guna2ButtonSignOut;
            this.guna2ButtonSignOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonSignOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonSignOut.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSignOut.HoverState.Parent = this.guna2ButtonSignOut;
            this.guna2ButtonSignOut.Location = new System.Drawing.Point(320, 95);
            this.guna2ButtonSignOut.Name = "guna2ButtonSignOut";
            this.guna2ButtonSignOut.ShadowDecoration.Parent = this.guna2ButtonSignOut;
            this.guna2ButtonSignOut.Size = new System.Drawing.Size(143, 60);
            this.guna2ButtonSignOut.TabIndex = 0;
            this.guna2ButtonSignOut.Text = "Sign Out";
            this.guna2ButtonSignOut.Click += new System.EventHandler(this.guna2ButtonSignOut_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.guna2ButtonSignOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2ButtonSignOut;
    }
}