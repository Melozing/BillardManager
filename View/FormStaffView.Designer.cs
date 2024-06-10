namespace BillardManager.View
{
    partial class FormStaffView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridViewCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ItemSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_BankAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemCategoryDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.Text = "Add Staff";
            // 
            // guna2TextBoxSearch
            // 
            this.guna2TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearch.DisabledState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearch.FocusedState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearch.HoverState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.IconLeft = global::BillardManager.Properties.Resources.Search1;
            this.guna2TextBoxSearch.ShadowDecoration.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.Size = new System.Drawing.Size(488, 39);
            this.guna2TextBoxSearch.TextChanged += new System.EventHandler(this.guna2TextBoxSearch_TextChanged);
            // 
            // guna2ImageButtonAdd
            // 
            this.guna2ImageButtonAdd.CheckedState.Parent = this.guna2ImageButtonAdd;
            this.guna2ImageButtonAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna2ImageButtonAdd.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.guna2ImageButtonAdd.HoverState.Parent = this.guna2ImageButtonAdd;
            this.guna2ImageButtonAdd.Image = global::BillardManager.Properties.Resources.Plus_Math;
            this.guna2ImageButtonAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ImageButtonAdd.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButtonAdd.PressedState.Parent = this.guna2ImageButtonAdd;
            this.guna2ImageButtonAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ImageButtonAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ImageButtonAdd.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2ImageButtonAdd.Click += new System.EventHandler(this.guna2ImageButtonAdd_Click);
            // 
            // guna2DataGridViewCategory
            // 
            this.guna2DataGridViewCategory.AllowUserToAddRows = false;
            this.guna2DataGridViewCategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridViewCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.guna2DataGridViewCategory.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridViewCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridViewCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridViewCategory.ColumnHeadersHeight = 40;
            this.guna2DataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemSno,
            this.Id,
            this.Username,
            this.User_FullName,
            this.User_Phone,
            this.User_BankAccountNumber,
            this.User_BankName,
            this.ItemCategoryEdit,
            this.ItemCategoryDelete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewCategory.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridViewCategory.EnableHeadersVisualStyles = false;
            this.guna2DataGridViewCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCategory.Location = new System.Drawing.Point(0, 119);
            this.guna2DataGridViewCategory.Name = "guna2DataGridViewCategory";
            this.guna2DataGridViewCategory.ReadOnly = true;
            this.guna2DataGridViewCategory.RowHeadersVisible = false;
            this.guna2DataGridViewCategory.RowHeadersWidth = 51;
            this.guna2DataGridViewCategory.RowTemplate.Height = 40;
            this.guna2DataGridViewCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridViewCategory.Size = new System.Drawing.Size(800, 331);
            this.guna2DataGridViewCategory.TabIndex = 9;
            this.guna2DataGridViewCategory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridViewCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewCategory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2DataGridViewCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewCategory.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridViewCategory.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridViewCategory_CellContentClick);
            // 
            // ItemSno
            // 
            this.ItemSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemSno.FillWeight = 70F;
            this.ItemSno.HeaderText = "Sr#";
            this.ItemSno.MinimumWidth = 70;
            this.ItemSno.Name = "ItemSno";
            this.ItemSno.ReadOnly = true;
            this.ItemSno.Width = 70;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.HeaderText = "IdItem";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 48;
            // 
            // Username
            // 
            this.Username.FillWeight = 130F;
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 130;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // User_FullName
            // 
            this.User_FullName.FillWeight = 150F;
            this.User_FullName.HeaderText = "Full Name";
            this.User_FullName.MinimumWidth = 150;
            this.User_FullName.Name = "User_FullName";
            this.User_FullName.ReadOnly = true;
            // 
            // User_Phone
            // 
            this.User_Phone.HeaderText = "Phone";
            this.User_Phone.MinimumWidth = 100;
            this.User_Phone.Name = "User_Phone";
            this.User_Phone.ReadOnly = true;
            // 
            // User_BankAccountNumber
            // 
            this.User_BankAccountNumber.HeaderText = "Bank Number";
            this.User_BankAccountNumber.MinimumWidth = 100;
            this.User_BankAccountNumber.Name = "User_BankAccountNumber";
            this.User_BankAccountNumber.ReadOnly = true;
            // 
            // User_BankName
            // 
            this.User_BankName.HeaderText = "Bank Name";
            this.User_BankName.MinimumWidth = 100;
            this.User_BankName.Name = "User_BankName";
            this.User_BankName.ReadOnly = true;
            // 
            // ItemCategoryEdit
            // 
            this.ItemCategoryEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemCategoryEdit.FillWeight = 30F;
            this.ItemCategoryEdit.HeaderText = "";
            this.ItemCategoryEdit.Image = global::BillardManager.Properties.Resources.edit_24x24;
            this.ItemCategoryEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ItemCategoryEdit.MinimumWidth = 30;
            this.ItemCategoryEdit.Name = "ItemCategoryEdit";
            this.ItemCategoryEdit.ReadOnly = true;
            this.ItemCategoryEdit.Width = 50;
            // 
            // ItemCategoryDelete
            // 
            this.ItemCategoryDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemCategoryDelete.FillWeight = 30F;
            this.ItemCategoryDelete.HeaderText = "";
            this.ItemCategoryDelete.Image = global::BillardManager.Properties.Resources.delete_24x24;
            this.ItemCategoryDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ItemCategoryDelete.MinimumWidth = 30;
            this.ItemCategoryDelete.Name = "ItemCategoryDelete";
            this.ItemCategoryDelete.ReadOnly = true;
            this.ItemCategoryDelete.Width = 50;
            // 
            // FormStaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2DataGridViewCategory);
            this.Name = "FormStaffView";
            this.Text = "FormStaffView";
            this.Load += new System.EventHandler(this.FormStaffView_Load);
            this.Controls.SetChildIndex(this.guna2DataGridViewCategory, 0);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_BankAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_BankName;
        private System.Windows.Forms.DataGridViewImageColumn ItemCategoryEdit;
        private System.Windows.Forms.DataGridViewImageColumn ItemCategoryDelete;
    }
}