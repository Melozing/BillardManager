namespace BillardManager.Model
{
    partial class FormTableDetailAdd
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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pic_table = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).BeginInit();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_table)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(84, 31);
            this.labelTop.Size = new System.Drawing.Size(118, 30);
            this.labelTop.Text = "Table detail";
            // 
            // gunaPictureBoxTop
            // 
            this.gunaPictureBoxTop.Image = global::BillardManager.Properties.Resources.pool_table1;
            this.gunaPictureBoxTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // guna2ButtonSave
            // 
            this.guna2ButtonSave.BorderRadius = 10;
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
            this.guna2ButtonSave.Click += new System.EventHandler(this.guna2ButtonSave_Click_1);
            // 
            // guna2ButtonClose
            // 
            this.guna2ButtonClose.BorderRadius = 8;
            this.guna2ButtonClose.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.guna2ButtonClose.CheckedState.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.CustomImages.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2ButtonClose.HoverState.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonClose.Location = new System.Drawing.Point(277, 13);
            this.guna2ButtonClose.ShadowDecoration.Parent = this.guna2ButtonClose;
            this.guna2ButtonClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ButtonClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ButtonClose.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2ButtonClose.Click += new System.EventHandler(this.guna2ButtonClose_Click);
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.ShadowDecoration.Parent = this.guna2PanelTop;
            this.guna2PanelTop.Size = new System.Drawing.Size(427, 85);
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 304);
            this.guna2PanelBottom.ShadowDecoration.Parent = this.guna2PanelBottom;
            this.guna2PanelBottom.Size = new System.Drawing.Size(427, 70);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(24, 116);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(370, 25);
            this.comboBoxCategory.TabIndex = 20;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 88);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(61, 17);
            this.labelCategory.TabIndex = 18;
            this.labelCategory.Text = "Category";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pic_table
            // 
            this.pic_table.Location = new System.Drawing.Point(69, 173);
            this.pic_table.Name = "pic_table";
            this.pic_table.Size = new System.Drawing.Size(259, 109);
            this.pic_table.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_table.TabIndex = 21;
            this.pic_table.TabStop = false;
            // 
            // FormTableDetailAdd
            // 
            this.AcceptButton = this.guna2ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.guna2ButtonClose;
            this.ClientSize = new System.Drawing.Size(427, 374);
            this.Controls.Add(this.pic_table);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Name = "FormTableDetailAdd";
            this.Text = "FormTableDetailAdd";
            this.Load += new System.EventHandler(this.FormTableDetailAdd_Load);
            this.Controls.SetChildIndex(this.guna2PanelTop, 0);
            this.Controls.SetChildIndex(this.guna2PanelBottom, 0);
            this.Controls.SetChildIndex(this.labelCategory, 0);
            this.Controls.SetChildIndex(this.comboBoxCategory, 0);
            this.Controls.SetChildIndex(this.pic_table, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxTop)).EndInit();
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pic_table;
    }
}