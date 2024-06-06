namespace BillardManager.Model
{
    partial class ucBillDetail
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
            this.gunaLabelNum = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabelAmount = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabelPrice = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabelQuantity = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabelName = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaLabelNum
            // 
            this.gunaLabelNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabelNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabelNum.Location = new System.Drawing.Point(0, 0);
            this.gunaLabelNum.Name = "gunaLabelNum";
            this.gunaLabelNum.Size = new System.Drawing.Size(80, 43);
            this.gunaLabelNum.TabIndex = 0;
            this.gunaLabelNum.Text = "Sr#";
            this.gunaLabelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabelAmount
            // 
            this.gunaLabelAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaLabelAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabelAmount.Location = new System.Drawing.Point(772, 0);
            this.gunaLabelAmount.Name = "gunaLabelAmount";
            this.gunaLabelAmount.Size = new System.Drawing.Size(74, 43);
            this.gunaLabelAmount.TabIndex = 4;
            this.gunaLabelAmount.Text = "Amount";
            this.gunaLabelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabelPrice
            // 
            this.gunaLabelPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaLabelPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabelPrice.Location = new System.Drawing.Point(709, 0);
            this.gunaLabelPrice.Name = "gunaLabelPrice";
            this.gunaLabelPrice.Size = new System.Drawing.Size(63, 43);
            this.gunaLabelPrice.TabIndex = 5;
            this.gunaLabelPrice.Text = "Price";
            this.gunaLabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabelQuantity
            // 
            this.gunaLabelQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaLabelQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabelQuantity.Location = new System.Drawing.Point(632, 0);
            this.gunaLabelQuantity.Name = "gunaLabelQuantity";
            this.gunaLabelQuantity.Size = new System.Drawing.Size(77, 43);
            this.gunaLabelQuantity.TabIndex = 6;
            this.gunaLabelQuantity.Text = "Quantity";
            this.gunaLabelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabelName
            // 
            this.gunaLabelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabelName.Location = new System.Drawing.Point(80, 0);
            this.gunaLabelName.Name = "gunaLabelName";
            this.gunaLabelName.Size = new System.Drawing.Size(552, 43);
            this.gunaLabelName.TabIndex = 7;
            this.gunaLabelName.Text = "Name";
            this.gunaLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabelName);
            this.Controls.Add(this.gunaLabelQuantity);
            this.Controls.Add(this.gunaLabelPrice);
            this.Controls.Add(this.gunaLabelAmount);
            this.Controls.Add(this.gunaLabelNum);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucBillDetail";
            this.Size = new System.Drawing.Size(846, 43);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaLabel gunaLabelNum;
        public Guna.UI.WinForms.GunaLabel gunaLabelAmount;
        public Guna.UI.WinForms.GunaLabel gunaLabelPrice;
        public Guna.UI.WinForms.GunaLabel gunaLabelQuantity;
        public Guna.UI.WinForms.GunaLabel gunaLabelName;
    }
}
