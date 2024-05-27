namespace BillardManager.Admin
{
    partial class SampleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleView));
            this.guna2TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ImageButtonAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.SuspendLayout();
            // 
            // guna2TextBoxSearch
            // 
            this.guna2TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxSearch.DefaultText = "";
            this.guna2TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearch.DisabledState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearch.FocusedState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearch.HoverState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxSearch.IconLeft")));
            this.guna2TextBoxSearch.Location = new System.Drawing.Point(468, 49);
            this.guna2TextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxSearch.Name = "guna2TextBoxSearch";
            this.guna2TextBoxSearch.PasswordChar = '\0';
            this.guna2TextBoxSearch.PlaceholderText = "Search here...";
            this.guna2TextBoxSearch.SelectedText = "";
            this.guna2TextBoxSearch.ShadowDecoration.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.Size = new System.Drawing.Size(200, 35);
            this.guna2TextBoxSearch.TabIndex = 0;
            this.guna2TextBoxSearch.TextChanged += new System.EventHandler(this.guna2TextBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // guna2ImageButtonAdd
            // 
            this.guna2ImageButtonAdd.CheckedState.Parent = this.guna2ImageButtonAdd;
            this.guna2ImageButtonAdd.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.guna2ImageButtonAdd.HoverState.Parent = this.guna2ImageButtonAdd;
            this.guna2ImageButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButtonAdd.Image")));
            this.guna2ImageButtonAdd.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButtonAdd.Location = new System.Drawing.Point(25, 48);
            this.guna2ImageButtonAdd.Name = "guna2ImageButtonAdd";
            this.guna2ImageButtonAdd.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButtonAdd.PressedState.Parent = this.guna2ImageButtonAdd;
            this.guna2ImageButtonAdd.Size = new System.Drawing.Size(55, 55);
            this.guna2ImageButtonAdd.TabIndex = 3;
            this.guna2ImageButtonAdd.Click += new System.EventHandler(this.guna2ImageButtonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Header Text";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(25, 109);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(643, 13);
            this.guna2Separator1.TabIndex = 5;
            // 
            // SampleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 513);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ImageButtonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBoxSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SampleView";
            this.Text = "SampleView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearch;
        public Guna.UI2.WinForms.Guna2ImageButton guna2ImageButtonAdd;
        public System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}