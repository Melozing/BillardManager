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
            this.components = new System.ComponentModel.Container();
            this.PanelTableName = new System.Windows.Forms.Panel();
            this.LabelTableName = new Guna.UI.WinForms.GunaLabel();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.guna2ButtonStart = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PictureBoxTable = new System.Windows.Forms.PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PanelTableName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTableName
            // 
            this.PanelTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PanelTableName.Controls.Add(this.LabelTableName);
            this.PanelTableName.Controls.Add(this.pictureBoxStatus);
            this.PanelTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTableName.ForeColor = System.Drawing.Color.White;
            this.PanelTableName.Location = new System.Drawing.Point(0, 0);
            this.PanelTableName.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTableName.Name = "PanelTableName";
            this.PanelTableName.Size = new System.Drawing.Size(123, 37);
            this.PanelTableName.TabIndex = 4;
            // 
            // LabelTableName
            // 
            this.LabelTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelTableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTableName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTableName.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.LabelTableName.ForeColor = System.Drawing.Color.White;
            this.LabelTableName.Location = new System.Drawing.Point(0, 0);
            this.LabelTableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTableName.Name = "LabelTableName";
            this.LabelTableName.Size = new System.Drawing.Size(91, 37);
            this.LabelTableName.TabIndex = 8;
            this.LabelTableName.Text = "gunaLabel1";
            this.LabelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.BackColor = System.Drawing.Color.White;
            this.pictureBoxStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxStatus.Image = global::BillardManager.Properties.Resources.Status_Empty;
            this.pictureBoxStatus.Location = new System.Drawing.Point(91, 0);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(32, 37);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStatus.TabIndex = 1;
            this.pictureBoxStatus.TabStop = false;
            // 
            // guna2ButtonStart
            // 
            this.guna2ButtonStart.BackColor = System.Drawing.Color.White;
            this.guna2ButtonStart.BorderRadius = 15;
            this.guna2ButtonStart.BorderThickness = 1;
            this.guna2ButtonStart.CheckedState.Parent = this.guna2ButtonStart;
            this.guna2ButtonStart.CustomBorderColor = System.Drawing.Color.White;
            this.guna2ButtonStart.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.guna2ButtonStart.CustomImages.Parent = this.guna2ButtonStart;
            this.guna2ButtonStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ButtonStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2ButtonStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonStart.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonStart.HoverState.Parent = this.guna2ButtonStart;
            this.guna2ButtonStart.Location = new System.Drawing.Point(0, 121);
            this.guna2ButtonStart.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ButtonStart.Name = "guna2ButtonStart";
            this.guna2ButtonStart.ShadowDecoration.Parent = this.guna2ButtonStart;
            this.guna2ButtonStart.Size = new System.Drawing.Size(123, 23);
            this.guna2ButtonStart.TabIndex = 6;
            this.guna2ButtonStart.Text = "START";
            this.guna2ButtonStart.Click += new System.EventHandler(this.guna2ButtonStart_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // PictureBoxTable
            // 
            this.PictureBoxTable.BackColor = System.Drawing.Color.White;
            this.PictureBoxTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxTable.Image = global::BillardManager.Properties.Resources.pocketBilliards;
            this.PictureBoxTable.Location = new System.Drawing.Point(0, 37);
            this.PictureBoxTable.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBoxTable.Name = "PictureBoxTable";
            this.PictureBoxTable.Size = new System.Drawing.Size(123, 84);
            this.PictureBoxTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTable.TabIndex = 7;
            this.PictureBoxTable.TabStop = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.PanelTableName;
            // 
            // ucTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PictureBoxTable);
            this.Controls.Add(this.guna2ButtonStart);
            this.Controls.Add(this.PanelTableName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucTable";
            this.Size = new System.Drawing.Size(123, 144);
            this.PanelTableName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelTableName;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonStart;
        private System.Windows.Forms.PictureBox PictureBoxTable;
        private Guna.UI.WinForms.GunaLabel LabelTableName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
