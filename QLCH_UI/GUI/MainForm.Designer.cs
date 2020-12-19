namespace QLCH_UI
{
    public partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProducts = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.panelManage = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.itemWareHouseManage = new FontAwesome.Sharp.IconButton();
            this.itemEmployeeManage = new FontAwesome.Sharp.IconButton();
            this.btnManage = new FontAwesome.Sharp.IconButton();
            this.btnCustomers = new FontAwesome.Sharp.IconButton();
            this.btnCartP = new FontAwesome.Sharp.IconButton();
            this.btnOrders = new FontAwesome.Sharp.IconButton();
            this.iconBtnHome = new FontAwesome.Sharp.IconButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelChildForm = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(258, 145);
            this.panel1.TabIndex = 6;
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProducts.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnProducts.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.IconSize = 35;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 265);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProducts.Rotation = 0D;
            this.btnProducts.Size = new System.Drawing.Size(258, 60);
            this.btnProducts.TabIndex = 11;
            this.btnProducts.Text = "  Sản phẩm";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(1561, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimize.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(1515, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximize.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(1539, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Rotation = 0D;
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(258, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1593, 73);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.panelManage);
            this.panelMenu.Controls.Add(this.btnManage);
            this.panelMenu.Controls.Add(this.btnCustomers);
            this.panelMenu.Controls.Add(this.btnCartP);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.iconBtnHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(258, 853);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnReport.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReport.IconSize = 35;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 685);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReport.Rotation = 0D;
            this.btnReport.Size = new System.Drawing.Size(258, 60);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "  Báo cáo";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panelManage
            // 
            this.panelManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panelManage.Controls.Add(this.iconButton1);
            this.panelManage.Controls.Add(this.itemWareHouseManage);
            this.panelManage.Controls.Add(this.itemEmployeeManage);
            this.panelManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManage.Location = new System.Drawing.Point(0, 505);
            this.panelManage.Name = "panelManage";
            this.panelManage.Size = new System.Drawing.Size(258, 180);
            this.panelManage.TabIndex = 12;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 120);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(258, 60);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = " Quản lí nhập hàng";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // itemWareHouseManage
            // 
            this.itemWareHouseManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemWareHouseManage.FlatAppearance.BorderSize = 0;
            this.itemWareHouseManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemWareHouseManage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.itemWareHouseManage.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemWareHouseManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.itemWareHouseManage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.itemWareHouseManage.IconColor = System.Drawing.Color.Gainsboro;
            this.itemWareHouseManage.IconSize = 35;
            this.itemWareHouseManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemWareHouseManage.Location = new System.Drawing.Point(0, 60);
            this.itemWareHouseManage.Name = "itemWareHouseManage";
            this.itemWareHouseManage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.itemWareHouseManage.Rotation = 0D;
            this.itemWareHouseManage.Size = new System.Drawing.Size(258, 60);
            this.itemWareHouseManage.TabIndex = 9;
            this.itemWareHouseManage.Text = " Quản lí kho";
            this.itemWareHouseManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemWareHouseManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itemWareHouseManage.UseVisualStyleBackColor = true;
            this.itemWareHouseManage.Click += new System.EventHandler(this.itemWareHouseManage_Click);
            // 
            // itemEmployeeManage
            // 
            this.itemEmployeeManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemEmployeeManage.FlatAppearance.BorderSize = 0;
            this.itemEmployeeManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemEmployeeManage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.itemEmployeeManage.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemEmployeeManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.itemEmployeeManage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.itemEmployeeManage.IconColor = System.Drawing.Color.Gainsboro;
            this.itemEmployeeManage.IconSize = 35;
            this.itemEmployeeManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemEmployeeManage.Location = new System.Drawing.Point(0, 0);
            this.itemEmployeeManage.Name = "itemEmployeeManage";
            this.itemEmployeeManage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.itemEmployeeManage.Rotation = 0D;
            this.itemEmployeeManage.Size = new System.Drawing.Size(258, 60);
            this.itemEmployeeManage.TabIndex = 8;
            this.itemEmployeeManage.Text = " Quản lí nhân viên";
            this.itemEmployeeManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemEmployeeManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itemEmployeeManage.UseVisualStyleBackColor = true;
            this.itemEmployeeManage.Click += new System.EventHandler(this.itemEmployeeManage_Click);
            // 
            // btnManage
            // 
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnManage.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManage.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnManage.IconColor = System.Drawing.Color.Gainsboro;
            this.btnManage.IconSize = 35;
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.Location = new System.Drawing.Point(0, 445);
            this.btnManage.Name = "btnManage";
            this.btnManage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnManage.Rotation = 0D;
            this.btnManage.Size = new System.Drawing.Size(258, 60);
            this.btnManage.TabIndex = 13;
            this.btnManage.Text = "  Quản lí";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCustomers.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnCustomers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnCustomers.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCustomers.IconSize = 35;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 385);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCustomers.Rotation = 0D;
            this.btnCustomers.Size = new System.Drawing.Size(258, 60);
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.Text = "  Khách hàng";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnCartP
            // 
            this.btnCartP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCartP.FlatAppearance.BorderSize = 0;
            this.btnCartP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartP.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCartP.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCartP.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnCartP.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCartP.IconSize = 35;
            this.btnCartP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartP.Location = new System.Drawing.Point(0, 325);
            this.btnCartP.Name = "btnCartP";
            this.btnCartP.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCartP.Rotation = 0D;
            this.btnCartP.Size = new System.Drawing.Size(258, 60);
            this.btnCartP.TabIndex = 3;
            this.btnCartP.Text = "  Đơn hàng";
            this.btnCartP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCartP.UseVisualStyleBackColor = true;
            this.btnCartP.Click += new System.EventHandler(this.btnCartP_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOrders.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrders.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnOrders.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrders.IconSize = 35;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 205);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrders.Rotation = 0D;
            this.btnOrders.Size = new System.Drawing.Size(258, 60);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "  Bán hàng";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // iconBtnHome
            // 
            this.iconBtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnHome.FlatAppearance.BorderSize = 0;
            this.iconBtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnHome.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconBtnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnHome.IconSize = 35;
            this.iconBtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnHome.Location = new System.Drawing.Point(0, 145);
            this.iconBtnHome.Name = "iconBtnHome";
            this.iconBtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnHome.Rotation = 0D;
            this.iconBtnHome.Size = new System.Drawing.Size(258, 60);
            this.iconBtnHome.TabIndex = 1;
            this.iconBtnHome.Text = "  Tổng quan";
            this.iconBtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnHome.UseVisualStyleBackColor = true;
            this.iconBtnHome.Click += new System.EventHandler(this.iconBtnHome_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChildForm.BackgroundImage")));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panelChildForm.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panelChildForm.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panelChildForm.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panelChildForm.Location = new System.Drawing.Point(258, 73);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Quality = 10;
            this.panelChildForm.Size = new System.Drawing.Size(1593, 780);
            this.panelChildForm.TabIndex = 3;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1851, 853);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panelTitle.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnCartP;
        private FontAwesome.Sharp.IconButton iconBtnHome;
        private FontAwesome.Sharp.IconButton btnCustomers;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private FontAwesome.Sharp.IconButton btnProducts;
        private FontAwesome.Sharp.IconButton btnOrders;
        private FontAwesome.Sharp.IconButton btnManage;
        private System.Windows.Forms.Panel panelManage;
        private FontAwesome.Sharp.IconButton itemWareHouseManage;
        private FontAwesome.Sharp.IconButton itemEmployeeManage;
        private FontAwesome.Sharp.IconButton btnReport;
        private Bunifu.Framework.UI.BunifuGradientPanel panelChildForm;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

