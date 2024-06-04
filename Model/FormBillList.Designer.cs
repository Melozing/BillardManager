namespace BillardManager.Model
{
    partial class FormBillList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridViewCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ItemSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemCategoryDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).BeginInit();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Size = new System.Drawing.Size(88, 32);
            this.labelTop.Text = "Bill List";
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
            this.guna2PanelTop.ShadowDecoration.Parent = this.guna2PanelTop;
            this.guna2PanelTop.Size = new System.Drawing.Size(800, 85);
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 450);
            this.guna2PanelBottom.ShadowDecoration.Parent = this.guna2PanelBottom;
            this.guna2PanelBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // guna2DataGridViewCategory
            // 
            this.guna2DataGridViewCategory.AllowUserToAddRows = false;
            this.guna2DataGridViewCategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridViewCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.guna2DataGridViewCategory.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridViewCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridViewCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewCategory.ColumnHeadersHeight = 40;
            this.guna2DataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemSno,
            this.Id,
            this.name,
            this.Price,
            this.categoryName,
            this.categoryID,
            this.ItemCategoryEdit,
            this.ItemCategoryDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridViewCategory.EnableHeadersVisualStyles = false;
            this.guna2DataGridViewCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCategory.Location = new System.Drawing.Point(0, 85);
            this.guna2DataGridViewCategory.Name = "guna2DataGridViewCategory";
            this.guna2DataGridViewCategory.ReadOnly = true;
            this.guna2DataGridViewCategory.RowHeadersVisible = false;
            this.guna2DataGridViewCategory.RowHeadersWidth = 51;
            this.guna2DataGridViewCategory.RowTemplate.Height = 40;
            this.guna2DataGridViewCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridViewCategory.Size = new System.Drawing.Size(800, 365);
            this.guna2DataGridViewCategory.TabIndex = 11;
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
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridViewCategory_CellClick);
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
            // name
            // 
            this.name.FillWeight = 130F;
            this.name.HeaderText = "Table Name";
            this.name.MinimumWidth = 130;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 150F;
            this.Price.HeaderText = "Start Time";
            this.Price.MinimumWidth = 150;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Total";
            this.categoryName.MinimumWidth = 100;
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // categoryID
            // 
            this.categoryID.HeaderText = "Time Checkout";
            this.categoryID.MinimumWidth = 100;
            this.categoryID.Name = "categoryID";
            this.categoryID.ReadOnly = true;
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
            // FormBillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2DataGridViewCategory);
            this.Name = "FormBillList";
            this.Text = "FormBillList";
            this.Controls.SetChildIndex(this.guna2PanelTop, 0);
            this.Controls.SetChildIndex(this.guna2PanelBottom, 0);
            this.Controls.SetChildIndex(this.guna2DataGridViewCategory, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).EndInit();
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewImageColumn ItemCategoryEdit;
        private System.Windows.Forms.DataGridViewImageColumn ItemCategoryDelete;
    }
}