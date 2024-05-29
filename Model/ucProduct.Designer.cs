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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2PictureBoxProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProduct = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBoxProduct);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.panel1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(183, 182);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // guna2PictureBoxProduct
            // 
            this.guna2PictureBoxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBoxProduct.Image = global::BillardManager.Properties.Resources.food_color;
            this.guna2PictureBoxProduct.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBoxProduct.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBoxProduct.Name = "guna2PictureBoxProduct";
            this.guna2PictureBoxProduct.ShadowDecoration.Parent = this.guna2PictureBoxProduct;
            this.guna2PictureBoxProduct.Size = new System.Drawing.Size(183, 120);
            this.guna2PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBoxProduct.TabIndex = 4;
            this.guna2PictureBoxProduct.TabStop = false;
            this.guna2PictureBoxProduct.Click += new System.EventHandler(this.guna2PictureBoxProduct_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 120);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(183, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 52);
            this.panel1.TabIndex = 1;
            // 
            // labelProduct
            // 
            this.labelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProduct.Location = new System.Drawing.Point(0, 0);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(183, 52);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Product Name";
            this.labelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(183, 182);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProduct;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxProduct;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
