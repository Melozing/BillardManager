namespace BillardManager.Model
{
    partial class FormFoodAdd
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
            this.guna2TextBoxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.guna2TextBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.guna2CirclePictureBoxFood = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ButtonBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.comboBoxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).BeginInit();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.Black;
            this.labelTop.Location = new System.Drawing.Point(84, 44);
            this.labelTop.Size = new System.Drawing.Size(135, 32);
            this.labelTop.Text = "Add Dishes";
            // 
            // gunaPictureBoxTop
            // 
            this.gunaPictureBoxTop.Image = global::BillardManager.Properties.Resources.food_color;
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
            this.guna2ButtonSave.Location = new System.Drawing.Point(15, 13);
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
            this.guna2ButtonClose.Location = new System.Drawing.Point(536, 13);
            this.guna2ButtonClose.ShadowDecoration.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ButtonClose.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2ButtonClose.Click += new System.EventHandler(this.guna2ButtonClose_Click);
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.Controls.Add(this.guna2ControlBox1);
            this.guna2PanelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2PanelTop.ShadowDecoration.Parent = this.guna2PanelTop;
            this.guna2PanelTop.Size = new System.Drawing.Size(676, 85);
            this.guna2PanelTop.Controls.SetChildIndex(this.gunaPictureBoxTop, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.labelTop, 0);
            this.guna2PanelTop.Controls.SetChildIndex(this.guna2ControlBox1, 0);
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 387);
            this.guna2PanelBottom.ShadowDecoration.Parent = this.guna2PanelBottom;
            this.guna2PanelBottom.Size = new System.Drawing.Size(676, 70);
            // 
            // guna2TextBoxPrice
            // 
            this.guna2TextBoxPrice.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBoxPrice.BorderRadius = 10;
            this.guna2TextBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxPrice.DefaultText = "";
            this.guna2TextBoxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPrice.DisabledState.Parent = this.guna2TextBoxPrice;
            this.guna2TextBoxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPrice.FocusedState.Parent = this.guna2TextBoxPrice;
            this.guna2TextBoxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPrice.HoverState.Parent = this.guna2TextBoxPrice;
            this.guna2TextBoxPrice.Location = new System.Drawing.Point(268, 258);
            this.guna2TextBoxPrice.Margin = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxPrice.Name = "guna2TextBoxPrice";
            this.guna2TextBoxPrice.PasswordChar = '\0';
            this.guna2TextBoxPrice.PlaceholderText = "Enter name";
            this.guna2TextBoxPrice.SelectedText = "";
            this.guna2TextBoxPrice.ShadowDecoration.Parent = this.guna2TextBoxPrice;
            this.guna2TextBoxPrice.Size = new System.Drawing.Size(327, 38);
            this.guna2TextBoxPrice.TabIndex = 7;
            this.guna2TextBoxPrice.TextChanged += new System.EventHandler(this.guna2TextBoxPrice_TextChanged);
            this.guna2TextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBoxPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(264, 234);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 17);
            this.labelPrice.TabIndex = 14;
            this.labelPrice.Text = "Price";
            // 
            // guna2TextBoxName
            // 
            this.guna2TextBoxName.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBoxName.BorderRadius = 10;
            this.guna2TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxName.DefaultText = "";
            this.guna2TextBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxName.DisabledState.Parent = this.guna2TextBoxName;
            this.guna2TextBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxName.FocusedState.Parent = this.guna2TextBoxName;
            this.guna2TextBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxName.HoverState.Parent = this.guna2TextBoxName;
            this.guna2TextBoxName.Location = new System.Drawing.Point(268, 118);
            this.guna2TextBoxName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBoxName.Name = "guna2TextBoxName";
            this.guna2TextBoxName.PasswordChar = '\0';
            this.guna2TextBoxName.PlaceholderText = "Enter name";
            this.guna2TextBoxName.SelectedText = "";
            this.guna2TextBoxName.ShadowDecoration.Parent = this.guna2TextBoxName;
            this.guna2TextBoxName.Size = new System.Drawing.Size(327, 35);
            this.guna2TextBoxName.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(263, 96);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 17);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(261, 166);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(61, 17);
            this.labelCategory.TabIndex = 13;
            this.labelCategory.Text = "Category";
            // 
            // guna2CirclePictureBoxFood
            // 
            this.guna2CirclePictureBoxFood.Image = global::BillardManager.Properties.Resources.food_add;
            this.guna2CirclePictureBoxFood.Location = new System.Drawing.Point(26, 110);
            this.guna2CirclePictureBoxFood.Name = "guna2CirclePictureBoxFood";
            this.guna2CirclePictureBoxFood.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxFood.ShadowDecoration.Parent = this.guna2CirclePictureBoxFood;
            this.guna2CirclePictureBoxFood.Size = new System.Drawing.Size(194, 170);
            this.guna2CirclePictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBoxFood.TabIndex = 17;
            this.guna2CirclePictureBoxFood.TabStop = false;
            // 
            // guna2ButtonBrowse
            // 
            this.guna2ButtonBrowse.AutoRoundedCorners = true;
            this.guna2ButtonBrowse.BorderRadius = 24;
            this.guna2ButtonBrowse.CheckedState.Parent = this.guna2ButtonBrowse;
            this.guna2ButtonBrowse.CustomImages.Parent = this.guna2ButtonBrowse;
            this.guna2ButtonBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2ButtonBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonBrowse.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonBrowse.HoverState.Parent = this.guna2ButtonBrowse;
            this.guna2ButtonBrowse.Location = new System.Drawing.Point(26, 303);
            this.guna2ButtonBrowse.Name = "guna2ButtonBrowse";
            this.guna2ButtonBrowse.ShadowDecoration.Parent = this.guna2ButtonBrowse;
            this.guna2ButtonBrowse.Size = new System.Drawing.Size(193, 51);
            this.guna2ButtonBrowse.TabIndex = 18;
            this.guna2ButtonBrowse.Text = "Browse";
            this.guna2ButtonBrowse.Click += new System.EventHandler(this.guna2ButtonBrowse_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCategory.BorderColor = System.Drawing.Color.Black;
            this.comboBoxCategory.BorderRadius = 10;
            this.comboBoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxCategory.FocusedState.Parent = this.comboBoxCategory;
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.HoverState.Parent = this.comboBoxCategory;
            this.comboBoxCategory.ItemHeight = 30;
            this.comboBoxCategory.ItemsAppearance.Parent = this.comboBoxCategory;
            this.comboBoxCategory.Location = new System.Drawing.Point(268, 186);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.ShadowDecoration.Parent = this.comboBoxCategory;
            this.comboBoxCategory.Size = new System.Drawing.Size(327, 36);
            this.comboBoxCategory.TabIndex = 19;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(628, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // FormFoodAdd
            // 
            this.AcceptButton = this.guna2ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.guna2ButtonClose;
            this.ClientSize = new System.Drawing.Size(676, 457);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.guna2ButtonBrowse);
            this.Controls.Add(this.guna2CirclePictureBoxFood);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.guna2TextBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.guna2TextBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormFoodAdd";
            this.Text = "FormFoodAdd";
            this.Load += new System.EventHandler(this.FormFoodAdd_Load);
            this.Controls.SetChildIndex(this.guna2PanelTop, 0);
            this.Controls.SetChildIndex(this.guna2PanelBottom, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.guna2TextBoxName, 0);
            this.Controls.SetChildIndex(this.labelPrice, 0);
            this.Controls.SetChildIndex(this.guna2TextBoxPrice, 0);
            this.Controls.SetChildIndex(this.labelCategory, 0);
            this.Controls.SetChildIndex(this.guna2CirclePictureBoxFood, 0);
            this.Controls.SetChildIndex(this.guna2ButtonBrowse, 0);
            this.Controls.SetChildIndex(this.comboBoxCategory, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).EndInit();
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategory;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxFood;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonBrowse;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCategory;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}