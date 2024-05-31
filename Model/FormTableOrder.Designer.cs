namespace BillardManager.Model
{
    partial class FormTableOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableOrder));
            this.panelCenter = new System.Windows.Forms.Panel();
            this.flowLayoutPanelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaContextMenuStrip = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.showActiveTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInactiveTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCenter.SuspendLayout();
            this.gunaContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.flowLayoutPanelProduct);
            this.panelCenter.Controls.Add(this.guna2TextBoxSearch);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(800, 450);
            this.panelCenter.TabIndex = 13;
            // 
            // flowLayoutPanelProduct
            // 
            this.flowLayoutPanelProduct.AutoScroll = true;
            this.flowLayoutPanelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProduct.Location = new System.Drawing.Point(0, 41);
            this.flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            this.flowLayoutPanelProduct.Size = new System.Drawing.Size(800, 409);
            this.flowLayoutPanelProduct.TabIndex = 1;
            this.flowLayoutPanelProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanelProduct_MouseDown);
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
            this.guna2TextBoxSearch.Size = new System.Drawing.Size(800, 41);
            this.guna2TextBoxSearch.TabIndex = 10;
            this.guna2TextBoxSearch.TextChanged += new System.EventHandler(this.guna2TextBoxSearch_TextChanged);
            // 
            // gunaContextMenuStrip
            // 
            this.gunaContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showActiveTablesToolStripMenuItem,
            this.showInactiveTablesToolStripMenuItem,
            this.showAllTablesToolStripMenuItem});
            this.gunaContextMenuStrip.Name = "gunaContextMenuStrip";
            this.gunaContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip.Size = new System.Drawing.Size(205, 76);
            // 
            // showActiveTablesToolStripMenuItem
            // 
            this.showActiveTablesToolStripMenuItem.Name = "showActiveTablesToolStripMenuItem";
            this.showActiveTablesToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.showActiveTablesToolStripMenuItem.Text = "Show empty tables";
            this.showActiveTablesToolStripMenuItem.Click += new System.EventHandler(this.showActiveTablesToolStripMenuItem_Click);
            // 
            // showInactiveTablesToolStripMenuItem
            // 
            this.showInactiveTablesToolStripMenuItem.Name = "showInactiveTablesToolStripMenuItem";
            this.showInactiveTablesToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.showInactiveTablesToolStripMenuItem.Text = "Show active tables";
            this.showInactiveTablesToolStripMenuItem.Click += new System.EventHandler(this.showInactiveTablesToolStripMenuItem_Click);
            // 
            // showAllTablesToolStripMenuItem
            // 
            this.showAllTablesToolStripMenuItem.Name = "showAllTablesToolStripMenuItem";
            this.showAllTablesToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.showAllTablesToolStripMenuItem.Text = "Show All Tables";
            this.showAllTablesToolStripMenuItem.Click += new System.EventHandler(this.showAllTablesToolStripMenuItem_Click);
            // 
            // FormTableOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCenter);
            this.Name = "FormTableOrder";
            this.Text = "FormTableOrder";
            this.Load += new System.EventHandler(this.FormTableOrder_Load);
            this.panelCenter.ResumeLayout(false);
            this.gunaContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProduct;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearch;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showActiveTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInactiveTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllTablesToolStripMenuItem;
    }
}