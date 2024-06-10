namespace BillardManager.View
{
    partial class FormBillView
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.guna2DataGridViewCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ItemSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemCategoryDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTop = new System.Windows.Forms.Label();
            this.gunaPictureBoxTop = new Guna.UI.WinForms.GunaPictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCategory)).BeginInit();
            this.guna2PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.guna2DataGridViewCategory);
            this.panelContainer.Controls.Add(this.guna2TextBoxSearch);
            this.panelContainer.Controls.Add(this.guna2PanelTop);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(600, 366);
            this.panelContainer.TabIndex = 0;
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
            this.startTime,
            this.paymentTime,
            this.received,
            this.change,
            this.amount,
            this.ItemCategoryEdit,
            this.ItemCategoryDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridViewCategory.EnableHeadersVisualStyles = false;
            this.guna2DataGridViewCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCategory.Location = new System.Drawing.Point(0, 118);
            this.guna2DataGridViewCategory.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DataGridViewCategory.Name = "guna2DataGridViewCategory";
            this.guna2DataGridViewCategory.ReadOnly = true;
            this.guna2DataGridViewCategory.RowHeadersVisible = false;
            this.guna2DataGridViewCategory.RowHeadersWidth = 51;
            this.guna2DataGridViewCategory.RowTemplate.Height = 40;
            this.guna2DataGridViewCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridViewCategory.Size = new System.Drawing.Size(600, 248);
            this.guna2DataGridViewCategory.TabIndex = 16;
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
            this.ItemSno.FillWeight = 40F;
            this.ItemSno.HeaderText = "Sr#";
            this.ItemSno.MinimumWidth = 40;
            this.ItemSno.Name = "ItemSno";
            this.ItemSno.ReadOnly = true;
            this.ItemSno.Width = 40;
            // 
            // Id
            // 
            this.Id.FillWeight = 60F;
            this.Id.HeaderText = "IdItem";
            this.Id.MinimumWidth = 60;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // startTime
            // 
            this.startTime.FillWeight = 80F;
            this.startTime.HeaderText = "Start time";
            this.startTime.MinimumWidth = 80;
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            // 
            // paymentTime
            // 
            this.paymentTime.FillWeight = 80F;
            this.paymentTime.HeaderText = "Payment Time";
            this.paymentTime.MinimumWidth = 80;
            this.paymentTime.Name = "paymentTime";
            this.paymentTime.ReadOnly = true;
            // 
            // received
            // 
            this.received.FillWeight = 60F;
            this.received.HeaderText = "Received";
            this.received.MinimumWidth = 60;
            this.received.Name = "received";
            this.received.ReadOnly = true;
            // 
            // change
            // 
            this.change.FillWeight = 60F;
            this.change.HeaderText = "Change";
            this.change.MinimumWidth = 60;
            this.change.Name = "change";
            this.change.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.FillWeight = 60F;
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 60;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // ItemCategoryEdit
            // 
            this.ItemCategoryEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemCategoryEdit.FillWeight = 40F;
            this.ItemCategoryEdit.HeaderText = "";
            this.ItemCategoryEdit.Image = global::BillardManager.Properties.Resources.search_icon;
            this.ItemCategoryEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ItemCategoryEdit.MinimumWidth = 30;
            this.ItemCategoryEdit.Name = "ItemCategoryEdit";
            this.ItemCategoryEdit.ReadOnly = true;
            this.ItemCategoryEdit.Width = 30;
            // 
            // ItemCategoryDelete
            // 
            this.ItemCategoryDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemCategoryDelete.FillWeight = 40F;
            this.ItemCategoryDelete.HeaderText = "";
            this.ItemCategoryDelete.Image = global::BillardManager.Properties.Resources.printer1;
            this.ItemCategoryDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ItemCategoryDelete.MinimumWidth = 30;
            this.ItemCategoryDelete.Name = "ItemCategoryDelete";
            this.ItemCategoryDelete.ReadOnly = true;
            this.ItemCategoryDelete.Width = 30;
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
            this.guna2TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearch.FocusedState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearch.HoverState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.IconLeft = global::BillardManager.Properties.Resources.Search;
            this.guna2TextBoxSearch.Location = new System.Drawing.Point(0, 85);
            this.guna2TextBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.guna2TextBoxSearch.Name = "guna2TextBoxSearch";
            this.guna2TextBoxSearch.PasswordChar = '\0';
            this.guna2TextBoxSearch.PlaceholderText = "Search here...";
            this.guna2TextBoxSearch.SelectedText = "";
            this.guna2TextBoxSearch.ShadowDecoration.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.Size = new System.Drawing.Size(600, 33);
            this.guna2TextBoxSearch.TabIndex = 15;
            this.guna2TextBoxSearch.TextChanged += new System.EventHandler(this.guna2TextBoxSearch_TextChanged_1);
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.Controls.Add(this.labelTop);
            this.guna2PanelTop.Controls.Add(this.gunaPictureBoxTop);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.ShadowDecoration.Parent = this.guna2PanelTop;
            this.guna2PanelTop.Size = new System.Drawing.Size(600, 85);
            this.guna2PanelTop.TabIndex = 14;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.BackColor = System.Drawing.Color.Transparent;
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.Location = new System.Drawing.Point(84, 48);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(71, 25);
            this.labelTop.TabIndex = 2;
            this.labelTop.Text = "Bill List";
            // 
            // gunaPictureBoxTop
            // 
            this.gunaPictureBoxTop.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBoxTop.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBoxTop.Image = global::BillardManager.Properties.Resources.bill;
            this.gunaPictureBoxTop.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBoxTop.Name = "gunaPictureBoxTop";
            this.gunaPictureBoxTop.Size = new System.Drawing.Size(66, 64);
            this.gunaPictureBoxTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBoxTop.TabIndex = 1;
            this.gunaPictureBoxTop.TabStop = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BillardManager.Properties.Resources.search_icon;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 30F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::BillardManager.Properties.Resources.printer1;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 30;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // FormBillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBillView";
            this.Text = "FormBillView";
            this.Load += new System.EventHandler(this.FormBillView_Load);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCategory)).EndInit();
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewCategory;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearch;
        public Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        public System.Windows.Forms.Label labelTop;
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBoxTop;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn received;
        private System.Windows.Forms.DataGridViewTextBoxColumn change;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewImageColumn ItemCategoryEdit;
        private System.Windows.Forms.DataGridViewImageColumn ItemCategoryDelete;
    }
}