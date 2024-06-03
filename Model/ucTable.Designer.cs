namespace BillardManager.Model
{
    partial class ucTable
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
            this.PanelTableName = new System.Windows.Forms.Panel();
            this.LabelTableName = new System.Windows.Forms.Label();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.guna2ButtonStart = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBoxTable = new System.Windows.Forms.PictureBox();
            this.PanelTableName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTableName
            // 
            this.PanelTableName.BackColor = System.Drawing.Color.DarkGreen;
            this.PanelTableName.Controls.Add(this.LabelTableName);
            this.PanelTableName.Controls.Add(this.pictureBoxStatus);
            this.PanelTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTableName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelTableName.Location = new System.Drawing.Point(0, 0);
            this.PanelTableName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTableName.Name = "PanelTableName";
            this.PanelTableName.Size = new System.Drawing.Size(164, 39);
            this.PanelTableName.TabIndex = 4;
            // 
            // LabelTableName
            // 
            this.LabelTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LabelTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTableName.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LabelTableName.Location = new System.Drawing.Point(0, 0);
            this.LabelTableName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTableName.Name = "LabelTableName";
            this.LabelTableName.Size = new System.Drawing.Size(121, 39);
            this.LabelTableName.TabIndex = 2;
            this.LabelTableName.Text = "Table 1";
            this.LabelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBoxStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxStatus.Image = global::BillardManager.Properties.Resources.Status_Empty;
            this.pictureBoxStatus.Location = new System.Drawing.Point(121, 0);
            this.pictureBoxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(43, 39);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatus.TabIndex = 1;
            this.pictureBoxStatus.TabStop = false;
            // 
            // guna2ButtonStart
            // 
            this.guna2ButtonStart.BorderThickness = 1;
            this.guna2ButtonStart.CheckedState.Parent = this.guna2ButtonStart;
            this.guna2ButtonStart.CustomBorderColor = System.Drawing.Color.LightPink;
            this.guna2ButtonStart.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.guna2ButtonStart.CustomImages.Parent = this.guna2ButtonStart;
            this.guna2ButtonStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ButtonStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ButtonStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonStart.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonStart.HoverState.Parent = this.guna2ButtonStart;
            this.guna2ButtonStart.Location = new System.Drawing.Point(0, 149);
            this.guna2ButtonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ButtonStart.Name = "guna2ButtonStart";
            this.guna2ButtonStart.ShadowDecoration.Parent = this.guna2ButtonStart;
            this.guna2ButtonStart.Size = new System.Drawing.Size(164, 28);
            this.guna2ButtonStart.TabIndex = 6;
            this.guna2ButtonStart.Text = "START";
            this.guna2ButtonStart.Click += new System.EventHandler(this.guna2ButtonStart_Click);
            // 
            // PictureBoxTable
            // 
            this.PictureBoxTable.BackColor = System.Drawing.Color.IndianRed;
            this.PictureBoxTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureBoxTable.Image = global::BillardManager.Properties.Resources.pocketBilliards;
            this.PictureBoxTable.Location = new System.Drawing.Point(0, 39);
            this.PictureBoxTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxTable.Name = "PictureBoxTable";
            this.PictureBoxTable.Size = new System.Drawing.Size(164, 110);
            this.PictureBoxTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTable.TabIndex = 5;
            this.PictureBoxTable.TabStop = false;
            // 
            // ucTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ButtonStart);
            this.Controls.Add(this.PictureBoxTable);
            this.Controls.Add(this.PanelTableName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucTable";
            this.Size = new System.Drawing.Size(164, 177);
            this.PanelTableName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelTableName;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.Label LabelTableName;
        private System.Windows.Forms.PictureBox PictureBoxTable;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonStart;
    }
}
