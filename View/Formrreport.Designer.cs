namespace BillardManager.View
{
    partial class Formrreport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.chartColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewInvoices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnViewInvoice = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblDailyRevenue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonthlyRevenue = new System.Windows.Forms.Label();
            this.guna2Panel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel
            // 
            this.guna2Panel.BackColor = System.Drawing.Color.LimeGreen;
            this.guna2Panel.BorderRadius = 10;
            this.guna2Panel.BorderThickness = 1;
            this.guna2Panel.Controls.Add(this.lblDailyRevenue);
            this.guna2Panel.Location = new System.Drawing.Point(48, 342);
            this.guna2Panel.Name = "guna2Panel";
            this.guna2Panel.ShadowDecoration.Parent = this.guna2Panel;
            this.guna2Panel.Size = new System.Drawing.Size(206, 111);
            this.guna2Panel.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.lblMonthlyRevenue);
            this.guna2Panel2.Location = new System.Drawing.Point(278, 342);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(206, 111);
            this.guna2Panel2.TabIndex = 1;
            // 
            // chartColumn
            // 
            chartArea5.Name = "ChartArea1";
            this.chartColumn.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartColumn.Legends.Add(legend5);
            this.chartColumn.Location = new System.Drawing.Point(501, 342);
            this.chartColumn.Name = "chartColumn";
            this.chartColumn.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartColumn.Series.Add(series5);
            this.chartColumn.Size = new System.Drawing.Size(506, 372);
            this.chartColumn.TabIndex = 2;
            this.chartColumn.Text = "chart1";
            // 
            // chartPie
            // 
            this.chartPie.BackColor = System.Drawing.Color.Transparent;
            this.chartPie.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPie.Legends.Add(legend6);
            this.chartPie.Location = new System.Drawing.Point(278, 500);
            this.chartPie.Name = "chartPie";
            this.chartPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartPie.Series.Add(series6);
            this.chartPie.Size = new System.Drawing.Size(206, 245);
            this.chartPie.TabIndex = 3;
            this.chartPie.Text = "chart2";
            // 
            // dataGridViewInvoices
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridViewInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewInvoices.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInvoices.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewInvoices.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewInvoices.EnableHeadersVisualStyles = false;
            this.dataGridViewInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewInvoices.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.RowHeadersVisible = false;
            this.dataGridViewInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(1019, 336);
            this.dataGridViewInvoices.TabIndex = 4;
            this.dataGridViewInvoices.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewInvoices.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewInvoices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewInvoices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewInvoices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewInvoices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewInvoices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewInvoices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewInvoices.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridViewInvoices.ThemeStyle.ReadOnly = false;
            this.dataGridViewInvoices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewInvoices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewInvoices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewInvoices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewInvoices.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewInvoices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewInvoices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.CheckedState.Parent = this.btnViewInvoice;
            this.btnViewInvoice.HoverState.Image = global::BillardManager.Properties.Resources.Billiard_VTC;
            this.btnViewInvoice.HoverState.Parent = this.btnViewInvoice;
            this.btnViewInvoice.Image = global::BillardManager.Properties.Resources.Billiard_VTC;
            this.btnViewInvoice.ImageSize = new System.Drawing.Size(100, 100);
            this.btnViewInvoice.Location = new System.Drawing.Point(72, 519);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.PressedState.Parent = this.btnViewInvoice;
            this.btnViewInvoice.Size = new System.Drawing.Size(150, 150);
            this.btnViewInvoice.TabIndex = 6;
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // lblDailyRevenue
            // 
            this.lblDailyRevenue.AutoSize = true;
            this.lblDailyRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyRevenue.ForeColor = System.Drawing.Color.White;
            this.lblDailyRevenue.Location = new System.Drawing.Point(58, 43);
            this.lblDailyRevenue.Name = "lblDailyRevenue";
            this.lblDailyRevenue.Size = new System.Drawing.Size(76, 25);
            this.lblDailyRevenue.TabIndex = 0;
            this.lblDailyRevenue.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Revenue today";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total revenue this month";
            // 
            // lblMonthlyRevenue
            // 
            this.lblMonthlyRevenue.AutoSize = true;
            this.lblMonthlyRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyRevenue.ForeColor = System.Drawing.Color.Black;
            this.lblMonthlyRevenue.Location = new System.Drawing.Point(65, 43);
            this.lblMonthlyRevenue.Name = "lblMonthlyRevenue";
            this.lblMonthlyRevenue.Size = new System.Drawing.Size(76, 25);
            this.lblMonthlyRevenue.TabIndex = 1;
            this.lblMonthlyRevenue.Text = "label1";
            // 
            // Formrreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 757);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewInvoice);
            this.Controls.Add(this.dataGridViewInvoices);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.chartColumn);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formrreport";
            this.Text = "Formrreport";
            this.Load += new System.EventHandler(this.Formrreport_Load);
            this.guna2Panel.ResumeLayout(false);
            this.guna2Panel.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumn;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewInvoices;
        private Guna.UI2.WinForms.Guna2ImageButton btnViewInvoice;
        private System.Windows.Forms.Label lblDailyRevenue;
        private System.Windows.Forms.Label lblMonthlyRevenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}