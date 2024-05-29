namespace BillardManager.Model
{
    partial class FormPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTittle = new System.Windows.Forms.Label();
            this.guna2PictureBoxExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.guna2DataGridViewCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTotalMoneyNum = new System.Windows.Forms.Label();
            this.ItemSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxLogo)).BeginInit();
            this.guna2PanelBottom.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCategory)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.Controls.Add(this.labelTittle);
            this.guna2PanelTop.Controls.Add(this.guna2PictureBoxExit);
            this.guna2PanelTop.Controls.Add(this.guna2PictureBoxLogo);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.ShadowDecoration.Parent = this.guna2PanelTop;
            this.guna2PanelTop.Size = new System.Drawing.Size(1138, 130);
            this.guna2PanelTop.TabIndex = 0;
            // 
            // labelTittle
            // 
            this.labelTittle.BackColor = System.Drawing.Color.Transparent;
            this.labelTittle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.Color.White;
            this.labelTittle.Location = new System.Drawing.Point(100, 0);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(54, 130);
            this.labelTittle.TabIndex = 1;
            this.labelTittle.Text = "POS";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBoxExit
            // 
            this.guna2PictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PictureBoxExit.Image = global::BillardManager.Properties.Resources.turn_off;
            this.guna2PictureBoxExit.Location = new System.Drawing.Point(1038, 0);
            this.guna2PictureBoxExit.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBoxExit.Name = "guna2PictureBoxExit";
            this.guna2PictureBoxExit.ShadowDecoration.Parent = this.guna2PictureBoxExit;
            this.guna2PictureBoxExit.Size = new System.Drawing.Size(100, 130);
            this.guna2PictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBoxExit.TabIndex = 0;
            this.guna2PictureBoxExit.TabStop = false;
            this.guna2PictureBoxExit.Click += new System.EventHandler(this.guna2PictureBoxExit_Click);
            // 
            // guna2PictureBoxLogo
            // 
            this.guna2PictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBoxLogo.Image")));
            this.guna2PictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBoxLogo.Name = "guna2PictureBoxLogo";
            this.guna2PictureBoxLogo.ShadowDecoration.Parent = this.guna2PictureBoxLogo;
            this.guna2PictureBoxLogo.Size = new System.Drawing.Size(100, 130);
            this.guna2PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBoxLogo.TabIndex = 0;
            this.guna2PictureBoxLogo.TabStop = false;
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Controls.Add(this.guna2Panel1);
            this.guna2PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2PanelBottom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 449);
            this.guna2PanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelBottom.Name = "guna2PanelBottom";
            this.guna2PanelBottom.ShadowDecoration.Parent = this.guna2PanelBottom;
            this.guna2PanelBottom.Size = new System.Drawing.Size(1138, 122);
            this.guna2PanelBottom.TabIndex = 0;
            // 
            // flowLayoutPanelCategory
            // 
            this.flowLayoutPanelCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelCategory.Location = new System.Drawing.Point(0, 130);
            this.flowLayoutPanelCategory.Name = "flowLayoutPanelCategory";
            this.flowLayoutPanelCategory.Size = new System.Drawing.Size(154, 319);
            this.flowLayoutPanelCategory.TabIndex = 1;
            // 
            // flowLayoutPanelProduct
            // 
            this.flowLayoutPanelProduct.AutoScroll = true;
            this.flowLayoutPanelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProduct.Location = new System.Drawing.Point(0, 41);
            this.flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            this.flowLayoutPanelProduct.Size = new System.Drawing.Size(585, 278);
            this.flowLayoutPanelProduct.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BillardManager.Properties.Resources.delete_24x24;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
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
            this.guna2TextBoxSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxSearch.IconLeft")));
            this.guna2TextBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.guna2TextBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.guna2TextBoxSearch.Name = "guna2TextBoxSearch";
            this.guna2TextBoxSearch.PasswordChar = '\0';
            this.guna2TextBoxSearch.PlaceholderText = "Search here...";
            this.guna2TextBoxSearch.SelectedText = "";
            this.guna2TextBoxSearch.ShadowDecoration.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.Size = new System.Drawing.Size(585, 41);
            this.guna2TextBoxSearch.TabIndex = 10;
            this.guna2TextBoxSearch.TextChanged += new System.EventHandler(this.guna2TextBoxSearch_TextChanged);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.flowLayoutPanelProduct);
            this.panelCenter.Controls.Add(this.guna2TextBoxSearch);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(154, 130);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(585, 319);
            this.panelCenter.TabIndex = 12;
            // 
            // guna2DataGridViewCategory
            // 
            this.guna2DataGridViewCategory.AllowUserToAddRows = false;
            this.guna2DataGridViewCategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridViewCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.guna2DataGridViewCategory.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridViewCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridViewCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridViewCategory.ColumnHeadersHeight = 40;
            this.guna2DataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemSno,
            this.Id,
            this.NameProduct,
            this.Quantity,
            this.Price,
            this.Amount,
            this.ItemCategoryDelete});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewCategory.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridViewCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2DataGridViewCategory.EnableHeadersVisualStyles = false;
            this.guna2DataGridViewCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCategory.Location = new System.Drawing.Point(739, 130);
            this.guna2DataGridViewCategory.Name = "guna2DataGridViewCategory";
            this.guna2DataGridViewCategory.ReadOnly = true;
            this.guna2DataGridViewCategory.RowHeadersVisible = false;
            this.guna2DataGridViewCategory.RowHeadersWidth = 51;
            this.guna2DataGridViewCategory.RowTemplate.Height = 40;
            this.guna2DataGridViewCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridViewCategory.Size = new System.Drawing.Size(399, 319);
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
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewCategory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.guna2DataGridViewCategory_CellFormatting);
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(0, 0);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(97, 122);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.labelTotalMoneyNum);
            this.guna2Panel1.Controls.Add(this.labelTotal);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(581, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(557, 122);
            this.guna2Panel1.TabIndex = 2;
            // 
            // labelTotalMoneyNum
            // 
            this.labelTotalMoneyNum.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalMoneyNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalMoneyNum.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMoneyNum.ForeColor = System.Drawing.Color.White;
            this.labelTotalMoneyNum.Location = new System.Drawing.Point(97, 0);
            this.labelTotalMoneyNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalMoneyNum.Name = "labelTotalMoneyNum";
            this.labelTotalMoneyNum.Size = new System.Drawing.Size(460, 122);
            this.labelTotalMoneyNum.TabIndex = 1;
            this.labelTotalMoneyNum.Text = "0.00";
            this.labelTotalMoneyNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Id.HeaderText = "IdItem";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // NameProduct
            // 
            this.NameProduct.FillWeight = 50F;
            this.NameProduct.HeaderText = "Name";
            this.NameProduct.MinimumWidth = 50;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 30F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 30;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 30F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 30;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 30F;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 30;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
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
            this.ItemCategoryDelete.Width = 30;
            // 
            // FormPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 571);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.guna2DataGridViewCategory);
            this.Controls.Add(this.flowLayoutPanelCategory);
            this.Controls.Add(this.guna2PanelBottom);
            this.Controls.Add(this.guna2PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPOS";
            this.Text = "FormPOSMain";
            this.Load += new System.EventHandler(this.Formpos_Load);
            this.guna2PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxLogo)).EndInit();
            this.guna2PanelBottom.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCategory)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelBottom;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxLogo;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProduct;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxExit;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearch;
        private System.Windows.Forms.Panel panelCenter;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewCategory;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label labelTotalMoneyNum;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewImageColumn ItemCategoryDelete;
    }
}