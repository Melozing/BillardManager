namespace BillardManager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.gunaPanelSide = new Guna.UI.WinForms.GunaPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaPanelTop = new Guna.UI.WinForms.GunaPanel();
            this.guna2ControlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gunaPanelContent = new Guna.UI.WinForms.GunaPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonTimeTable = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonTableDetail = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonSetting = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonTableManagement = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonBills = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonTable = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonFoodManagement = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonFoodType = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonUserManagement = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaPanelSide.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.gunaPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanelSide
            // 
            this.gunaPanelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.gunaPanelSide.Controls.Add(this.guna2Panel1);
            this.gunaPanelSide.Controls.Add(this.guna2PictureBox1);
            this.gunaPanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanelSide.Location = new System.Drawing.Point(0, 0);
            this.gunaPanelSide.Name = "gunaPanelSide";
            this.gunaPanelSide.Size = new System.Drawing.Size(218, 752);
            this.gunaPanelSide.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.guna2ButtonTimeTable);
            this.guna2Panel1.Controls.Add(this.guna2ButtonTableDetail);
            this.guna2Panel1.Controls.Add(this.guna2ButtonSetting);
            this.guna2Panel1.Controls.Add(this.guna2ButtonHome);
            this.guna2Panel1.Controls.Add(this.guna2ButtonTableManagement);
            this.guna2Panel1.Controls.Add(this.guna2ButtonBills);
            this.guna2Panel1.Controls.Add(this.guna2ButtonUser);
            this.guna2Panel1.Controls.Add(this.guna2ButtonTable);
            this.guna2Panel1.Controls.Add(this.guna2ButtonFoodManagement);
            this.guna2Panel1.Controls.Add(this.guna2ButtonFoodType);
            this.guna2Panel1.Controls.Add(this.guna2ButtonUserManagement);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 139);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(218, 613);
            this.guna2Panel1.TabIndex = 1;
            // 
            // gunaPanelTop
            // 
            this.gunaPanelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanelTop.Controls.Add(this.pictureBox1);
            this.gunaPanelTop.Controls.Add(this.guna2ControlBoxMinimize);
            this.gunaPanelTop.Controls.Add(this.guna2ControlBoxMaximize);
            this.gunaPanelTop.Controls.Add(this.guna2ControlBoxClose);
            this.gunaPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanelTop.Location = new System.Drawing.Point(218, 0);
            this.gunaPanelTop.Name = "gunaPanelTop";
            this.gunaPanelTop.Size = new System.Drawing.Size(751, 62);
            this.gunaPanelTop.TabIndex = 0;
            this.gunaPanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPanelTop_MouseDown);
            // 
            // guna2ControlBoxMinimize
            // 
            this.guna2ControlBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBoxMinimize.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxMinimize.HoverState.Parent = this.guna2ControlBoxMinimize;
            this.guna2ControlBoxMinimize.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBoxMinimize.Location = new System.Drawing.Point(634, 12);
            this.guna2ControlBoxMinimize.Name = "guna2ControlBoxMinimize";
            this.guna2ControlBoxMinimize.ShadowDecoration.Parent = this.guna2ControlBoxMinimize;
            this.guna2ControlBoxMinimize.Size = new System.Drawing.Size(31, 27);
            this.guna2ControlBoxMinimize.TabIndex = 0;
            // 
            // guna2ControlBoxMaximize
            // 
            this.guna2ControlBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBoxMaximize.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxMaximize.HoverState.Parent = this.guna2ControlBoxMaximize;
            this.guna2ControlBoxMaximize.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBoxMaximize.Location = new System.Drawing.Point(671, 12);
            this.guna2ControlBoxMaximize.Name = "guna2ControlBoxMaximize";
            this.guna2ControlBoxMaximize.ShadowDecoration.Parent = this.guna2ControlBoxMaximize;
            this.guna2ControlBoxMaximize.Size = new System.Drawing.Size(31, 27);
            this.guna2ControlBoxMaximize.TabIndex = 0;
            // 
            // guna2ControlBoxClose
            // 
            this.guna2ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxClose.HoverState.Parent = this.guna2ControlBoxClose;
            this.guna2ControlBoxClose.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBoxClose.Location = new System.Drawing.Point(708, 12);
            this.guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            this.guna2ControlBoxClose.ShadowDecoration.Parent = this.guna2ControlBoxClose;
            this.guna2ControlBoxClose.Size = new System.Drawing.Size(31, 27);
            this.guna2ControlBoxClose.TabIndex = 0;
            this.guna2ControlBoxClose.Click += new System.EventHandler(this.guna2ControlBoxClose_Click);
            // 
            // gunaPanelContent
            // 
            this.gunaPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanelContent.Location = new System.Drawing.Point(218, 62);
            this.gunaPanelContent.Name = "gunaPanelContent";
            this.gunaPanelContent.Size = new System.Drawing.Size(751, 690);
            this.gunaPanelContent.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::BillardManager.Properties.Resources.latest;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2Button1.CheckedState.Image = global::BillardManager.Properties.Resources.pool_table__1_;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::BillardManager.Properties.Resources.billiard;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(3, 507);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Reveune Report";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ButtonTimeTable
            // 
            this.guna2ButtonTimeTable.AutoRoundedCorners = true;
            this.guna2ButtonTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonTimeTable.BorderRadius = 21;
            this.guna2ButtonTimeTable.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonTimeTable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonTimeTable.CheckedState.Image = global::BillardManager.Properties.Resources.snooker;
            this.guna2ButtonTimeTable.CheckedState.Parent = this.guna2ButtonTimeTable;
            this.guna2ButtonTimeTable.CustomImages.Parent = this.guna2ButtonTimeTable;
            this.guna2ButtonTimeTable.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonTimeTable.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonTimeTable.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonTimeTable.HoverState.Parent = this.guna2ButtonTimeTable;
            this.guna2ButtonTimeTable.Image = global::BillardManager.Properties.Resources.Time_Machine;
            this.guna2ButtonTimeTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonTimeTable.Location = new System.Drawing.Point(3, 456);
            this.guna2ButtonTimeTable.Name = "guna2ButtonTimeTable";
            this.guna2ButtonTimeTable.ShadowDecoration.Parent = this.guna2ButtonTimeTable;
            this.guna2ButtonTimeTable.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonTimeTable.TabIndex = 3;
            this.guna2ButtonTimeTable.Text = "Time Table";
            this.guna2ButtonTimeTable.Click += new System.EventHandler(this.guna2ButtonTimeTable_Click);
            // 
            // guna2ButtonTableDetail
            // 
            this.guna2ButtonTableDetail.AutoRoundedCorners = true;
            this.guna2ButtonTableDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonTableDetail.BorderRadius = 21;
            this.guna2ButtonTableDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonTableDetail.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonTableDetail.CheckedState.Image = global::BillardManager.Properties.Resources.pool_table__1_;
            this.guna2ButtonTableDetail.CheckedState.Parent = this.guna2ButtonTableDetail;
            this.guna2ButtonTableDetail.CustomImages.Parent = this.guna2ButtonTableDetail;
            this.guna2ButtonTableDetail.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonTableDetail.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonTableDetail.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonTableDetail.HoverState.Parent = this.guna2ButtonTableDetail;
            this.guna2ButtonTableDetail.Image = global::BillardManager.Properties.Resources.billiard;
            this.guna2ButtonTableDetail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonTableDetail.Location = new System.Drawing.Point(3, 408);
            this.guna2ButtonTableDetail.Name = "guna2ButtonTableDetail";
            this.guna2ButtonTableDetail.ShadowDecoration.Parent = this.guna2ButtonTableDetail;
            this.guna2ButtonTableDetail.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonTableDetail.TabIndex = 2;
            this.guna2ButtonTableDetail.Text = "Tables Detail";
            this.guna2ButtonTableDetail.Click += new System.EventHandler(this.guna2ButtonTableDetail_Click);
            // 
            // guna2ButtonSetting
            // 
            this.guna2ButtonSetting.AutoRoundedCorners = true;
            this.guna2ButtonSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonSetting.BorderRadius = 21;
            this.guna2ButtonSetting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonSetting.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonSetting.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonSetting.CheckedState.Image")));
            this.guna2ButtonSetting.CheckedState.Parent = this.guna2ButtonSetting;
            this.guna2ButtonSetting.CustomImages.Parent = this.guna2ButtonSetting;
            this.guna2ButtonSetting.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonSetting.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonSetting.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSetting.HoverState.Parent = this.guna2ButtonSetting;
            this.guna2ButtonSetting.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonSetting.Image")));
            this.guna2ButtonSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonSetting.Location = new System.Drawing.Point(3, 555);
            this.guna2ButtonSetting.Name = "guna2ButtonSetting";
            this.guna2ButtonSetting.ShadowDecoration.Parent = this.guna2ButtonSetting;
            this.guna2ButtonSetting.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonSetting.TabIndex = 1;
            this.guna2ButtonSetting.Text = "Setting";
            this.guna2ButtonSetting.Click += new System.EventHandler(this.guna2ButtonSetting_Click);
            // 
            // guna2ButtonHome
            // 
            this.guna2ButtonHome.AutoRoundedCorners = true;
            this.guna2ButtonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonHome.BorderRadius = 21;
            this.guna2ButtonHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonHome.Checked = true;
            this.guna2ButtonHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonHome.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonHome.CheckedState.Image")));
            this.guna2ButtonHome.CheckedState.Parent = this.guna2ButtonHome;
            this.guna2ButtonHome.CustomImages.Parent = this.guna2ButtonHome;
            this.guna2ButtonHome.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonHome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonHome.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonHome.HoverState.Parent = this.guna2ButtonHome;
            this.guna2ButtonHome.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonHome.Image")));
            this.guna2ButtonHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonHome.Location = new System.Drawing.Point(-31, 2);
            this.guna2ButtonHome.Name = "guna2ButtonHome";
            this.guna2ButtonHome.ShadowDecoration.Parent = this.guna2ButtonHome;
            this.guna2ButtonHome.Size = new System.Drawing.Size(214, 45);
            this.guna2ButtonHome.TabIndex = 1;
            this.guna2ButtonHome.Text = "Home";
            this.guna2ButtonHome.Click += new System.EventHandler(this.guna2ButtonHome_Click);
            // 
            // guna2ButtonTableManagement
            // 
            this.guna2ButtonTableManagement.AutoRoundedCorners = true;
            this.guna2ButtonTableManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonTableManagement.BorderRadius = 21;
            this.guna2ButtonTableManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonTableManagement.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonTableManagement.CheckedState.Image = global::BillardManager.Properties.Resources.snooker;
            this.guna2ButtonTableManagement.CheckedState.Parent = this.guna2ButtonTableManagement;
            this.guna2ButtonTableManagement.CustomImages.Parent = this.guna2ButtonTableManagement;
            this.guna2ButtonTableManagement.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonTableManagement.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonTableManagement.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonTableManagement.HoverState.Parent = this.guna2ButtonTableManagement;
            this.guna2ButtonTableManagement.Image = global::BillardManager.Properties.Resources.snooker__1_;
            this.guna2ButtonTableManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonTableManagement.Location = new System.Drawing.Point(3, 357);
            this.guna2ButtonTableManagement.Name = "guna2ButtonTableManagement";
            this.guna2ButtonTableManagement.ShadowDecoration.Parent = this.guna2ButtonTableManagement;
            this.guna2ButtonTableManagement.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonTableManagement.TabIndex = 1;
            this.guna2ButtonTableManagement.Text = "Tables Management";
            this.guna2ButtonTableManagement.Click += new System.EventHandler(this.guna2ButtonTables_Click);
            // 
            // guna2ButtonBills
            // 
            this.guna2ButtonBills.AutoRoundedCorners = true;
            this.guna2ButtonBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonBills.BorderRadius = 21;
            this.guna2ButtonBills.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonBills.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonBills.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonBills.CheckedState.Image")));
            this.guna2ButtonBills.CheckedState.Parent = this.guna2ButtonBills;
            this.guna2ButtonBills.CustomImages.Parent = this.guna2ButtonBills;
            this.guna2ButtonBills.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonBills.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonBills.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonBills.HoverState.Parent = this.guna2ButtonBills;
            this.guna2ButtonBills.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonBills.Image")));
            this.guna2ButtonBills.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonBills.Location = new System.Drawing.Point(3, 108);
            this.guna2ButtonBills.Name = "guna2ButtonBills";
            this.guna2ButtonBills.ShadowDecoration.Parent = this.guna2ButtonBills;
            this.guna2ButtonBills.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonBills.TabIndex = 1;
            this.guna2ButtonBills.Text = "Bills";
            this.guna2ButtonBills.Click += new System.EventHandler(this.guna2ButtonBills_Click);
            // 
            // guna2ButtonUser
            // 
            this.guna2ButtonUser.AutoRoundedCorners = true;
            this.guna2ButtonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonUser.BorderRadius = 21;
            this.guna2ButtonUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonUser.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonUser.CheckedState.Image")));
            this.guna2ButtonUser.CheckedState.Parent = this.guna2ButtonUser;
            this.guna2ButtonUser.CustomImages.Parent = this.guna2ButtonUser;
            this.guna2ButtonUser.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonUser.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonUser.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonUser.HoverState.Parent = this.guna2ButtonUser;
            this.guna2ButtonUser.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonUser.Image")));
            this.guna2ButtonUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonUser.Location = new System.Drawing.Point(3, 159);
            this.guna2ButtonUser.Name = "guna2ButtonUser";
            this.guna2ButtonUser.ShadowDecoration.Parent = this.guna2ButtonUser;
            this.guna2ButtonUser.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonUser.TabIndex = 1;
            this.guna2ButtonUser.Text = "User";
            this.guna2ButtonUser.Click += new System.EventHandler(this.guna2ButtonUser_Click);
            // 
            // guna2ButtonTable
            // 
            this.guna2ButtonTable.AutoRoundedCorners = true;
            this.guna2ButtonTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonTable.BorderRadius = 21;
            this.guna2ButtonTable.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonTable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonTable.CheckedState.Image = global::BillardManager.Properties.Resources.pool_table;
            this.guna2ButtonTable.CheckedState.Parent = this.guna2ButtonTable;
            this.guna2ButtonTable.CustomImages.Parent = this.guna2ButtonTable;
            this.guna2ButtonTable.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonTable.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonTable.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonTable.HoverState.Parent = this.guna2ButtonTable;
            this.guna2ButtonTable.Image = global::BillardManager.Properties.Resources.billiards__3_;
            this.guna2ButtonTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonTable.Location = new System.Drawing.Point(3, 57);
            this.guna2ButtonTable.Name = "guna2ButtonTable";
            this.guna2ButtonTable.ShadowDecoration.Parent = this.guna2ButtonTable;
            this.guna2ButtonTable.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonTable.TabIndex = 1;
            this.guna2ButtonTable.Text = "Tables";
            this.guna2ButtonTable.Click += new System.EventHandler(this.guna2ButtonTable_Click);
            // 
            // guna2ButtonFoodManagement
            // 
            this.guna2ButtonFoodManagement.AutoRoundedCorners = true;
            this.guna2ButtonFoodManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonFoodManagement.BorderRadius = 21;
            this.guna2ButtonFoodManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonFoodManagement.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonFoodManagement.CheckedState.Image = global::BillardManager.Properties.Resources.food_color;
            this.guna2ButtonFoodManagement.CheckedState.Parent = this.guna2ButtonFoodManagement;
            this.guna2ButtonFoodManagement.CustomImages.Parent = this.guna2ButtonFoodManagement;
            this.guna2ButtonFoodManagement.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonFoodManagement.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonFoodManagement.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonFoodManagement.HoverState.Parent = this.guna2ButtonFoodManagement;
            this.guna2ButtonFoodManagement.Image = global::BillardManager.Properties.Resources.food_white;
            this.guna2ButtonFoodManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonFoodManagement.Location = new System.Drawing.Point(3, 312);
            this.guna2ButtonFoodManagement.Name = "guna2ButtonFoodManagement";
            this.guna2ButtonFoodManagement.ShadowDecoration.Parent = this.guna2ButtonFoodManagement;
            this.guna2ButtonFoodManagement.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonFoodManagement.TabIndex = 1;
            this.guna2ButtonFoodManagement.Text = "Food Management";
            this.guna2ButtonFoodManagement.Click += new System.EventHandler(this.guna2ButtonItem_Click);
            // 
            // guna2ButtonFoodType
            // 
            this.guna2ButtonFoodType.AutoRoundedCorners = true;
            this.guna2ButtonFoodType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonFoodType.BorderRadius = 21;
            this.guna2ButtonFoodType.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonFoodType.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonFoodType.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonFoodType.CheckedState.Image")));
            this.guna2ButtonFoodType.CheckedState.Parent = this.guna2ButtonFoodType;
            this.guna2ButtonFoodType.CustomImages.Parent = this.guna2ButtonFoodType;
            this.guna2ButtonFoodType.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonFoodType.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonFoodType.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonFoodType.HoverState.Parent = this.guna2ButtonFoodType;
            this.guna2ButtonFoodType.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonFoodType.Image")));
            this.guna2ButtonFoodType.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonFoodType.Location = new System.Drawing.Point(3, 261);
            this.guna2ButtonFoodType.Name = "guna2ButtonFoodType";
            this.guna2ButtonFoodType.ShadowDecoration.Parent = this.guna2ButtonFoodType;
            this.guna2ButtonFoodType.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonFoodType.TabIndex = 1;
            this.guna2ButtonFoodType.Text = "Food Type";
            this.guna2ButtonFoodType.Click += new System.EventHandler(this.guna2ButtonMenu_Click);
            // 
            // guna2ButtonUserManagement
            // 
            this.guna2ButtonUserManagement.AutoRoundedCorners = true;
            this.guna2ButtonUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2ButtonUserManagement.BorderRadius = 21;
            this.guna2ButtonUserManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonUserManagement.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2ButtonUserManagement.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonUserManagement.CheckedState.Image")));
            this.guna2ButtonUserManagement.CheckedState.Parent = this.guna2ButtonUserManagement;
            this.guna2ButtonUserManagement.CustomImages.Parent = this.guna2ButtonUserManagement;
            this.guna2ButtonUserManagement.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonUserManagement.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonUserManagement.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonUserManagement.HoverState.Parent = this.guna2ButtonUserManagement;
            this.guna2ButtonUserManagement.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonUserManagement.Image")));
            this.guna2ButtonUserManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2ButtonUserManagement.Location = new System.Drawing.Point(3, 210);
            this.guna2ButtonUserManagement.Name = "guna2ButtonUserManagement";
            this.guna2ButtonUserManagement.ShadowDecoration.Parent = this.guna2ButtonUserManagement;
            this.guna2ButtonUserManagement.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonUserManagement.TabIndex = 1;
            this.guna2ButtonUserManagement.Text = "User Management";
            this.guna2ButtonUserManagement.Click += new System.EventHandler(this.guna2ButtonUserManagement_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.Image = global::BillardManager.Properties.Resources.ico_app;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(218, 139);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 752);
            this.ControlBox = false;
            this.Controls.Add(this.gunaPanelContent);
            this.Controls.Add(this.gunaPanelTop);
            this.Controls.Add(this.gunaPanelSide);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gunaPanelSide.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.gunaPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanelSide;
        private Guna.UI.WinForms.GunaPanel gunaPanelTop;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxClose;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonHome;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonTableManagement;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonFoodType;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUserManagement;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUser;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonBills;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSetting;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonFoodManagement;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonTableDetail;
        public Guna.UI2.WinForms.Guna2Button guna2ButtonTable;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonTimeTable;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanelContent;
    }
}