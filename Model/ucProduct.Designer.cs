namespace BillardManager.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2ShadowPanelContainer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2PanelImg = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBoxProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanelContainer.SuspendLayout();
            this.guna2PanelImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxProduct)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanelContainer
            // 
            this.guna2ShadowPanelContainer.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanelContainer.Controls.Add(this.guna2PanelImg);
            this.guna2ShadowPanelContainer.Controls.Add(this.panelBottom);
            this.guna2ShadowPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanelContainer.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanelContainer.Name = "guna2ShadowPanelContainer";
            this.guna2ShadowPanelContainer.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanelContainer.Size = new System.Drawing.Size(183, 182);
            this.guna2ShadowPanelContainer.TabIndex = 0;
            // 
            // guna2PanelImg
            // 
            this.guna2PanelImg.Controls.Add(this.guna2PictureBoxProduct);
            this.guna2PanelImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelImg.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelImg.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PanelImg.Name = "guna2PanelImg";
            this.guna2PanelImg.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.guna2PanelImg.ShadowDecoration.Parent = this.guna2PanelImg;
            this.guna2PanelImg.Size = new System.Drawing.Size(183, 130);
            this.guna2PanelImg.TabIndex = 4;
            // 
            // guna2PictureBoxProduct
            // 
            this.guna2PictureBoxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBoxProduct.Image = global::BillardManager.Properties.Resources.food_color;
            this.guna2PictureBoxProduct.Location = new System.Drawing.Point(5, 5);
            this.guna2PictureBoxProduct.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PictureBoxProduct.Name = "guna2PictureBoxProduct";
            this.guna2PictureBoxProduct.ShadowDecoration.Parent = this.guna2PictureBoxProduct;
            this.guna2PictureBoxProduct.Size = new System.Drawing.Size(173, 125);
            this.guna2PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBoxProduct.TabIndex = 7;
            this.guna2PictureBoxProduct.TabStop = false;
            this.guna2PictureBoxProduct.Click += new System.EventHandler(this.guna2PictureBoxProduct_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.labelPrice);
            this.panelBottom.Controls.Add(this.labelProduct);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 130);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(183, 52);
            this.panelBottom.TabIndex = 1;
            this.panelBottom.Click += new System.EventHandler(this.guna2PictureBoxProduct_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelPrice.Location = new System.Drawing.Point(102, 0);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(81, 52);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "$ 25000";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProduct
            // 
            this.labelProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(0, 0);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(104, 52);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Product Name";
            this.labelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanelContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(183, 182);
            this.guna2ShadowPanelContainer.ResumeLayout(false);
            this.guna2PanelImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxProduct)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanelContainer;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelPrice;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelImg;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxProduct;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
