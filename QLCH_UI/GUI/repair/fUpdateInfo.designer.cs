namespace QLCH_UI
{
    partial class fUpdateInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUpdateInfo));
            this.pnTitle = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dragPnTitle = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lb_tongtien = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.rbLoi = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.fpn_ItemsLinhKien = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.tbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_NgayNhan = new Guna.UI.WinForms.GunaLabel();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.rbThanhToan = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.rbChuaSua = new Guna.UI.WinForms.GunaRadioButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.rbDangSua = new Guna.UI.WinForms.GunaRadioButton();
            this.ic_TinhTrang = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.rbDaXong = new Guna.UI.WinForms.GunaRadioButton();
            this.pnTitle.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_TinhTrang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.pnTitle.Controls.Add(this.btnExit);
            this.pnTitle.Controls.Add(this.gunaLabel1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(588, 61);
            this.pnTitle.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnExit.IconSize = 32;
            this.btnExit.Location = new System.Drawing.Point(541, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(208, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(167, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Trạng thái";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // dragPnTitle
            // 
            this.dragPnTitle.TargetControl = this.pnTitle;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaLinePanel1.Controls.Add(this.lb_tongtien);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel3);
            this.gunaLinePanel1.Controls.Add(this.guna2CirclePictureBox4);
            this.gunaLinePanel1.Controls.Add(this.rbLoi);
            this.gunaLinePanel1.Controls.Add(this.gunaLinePanel2);
            this.gunaLinePanel1.Controls.Add(this.guna2CirclePictureBox3);
            this.gunaLinePanel1.Controls.Add(this.rbThanhToan);
            this.gunaLinePanel1.Controls.Add(this.gunaButton1);
            this.gunaLinePanel1.Controls.Add(this.gunaButton2);
            this.gunaLinePanel1.Controls.Add(this.guna2CirclePictureBox2);
            this.gunaLinePanel1.Controls.Add(this.rbChuaSua);
            this.gunaLinePanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.gunaLinePanel1.Controls.Add(this.rbDangSua);
            this.gunaLinePanel1.Controls.Add(this.ic_TinhTrang);
            this.gunaLinePanel1.Controls.Add(this.rbDaXong);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 6;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gunaLinePanel1.LineLeft = 4;
            this.gunaLinePanel1.LineRight = 6;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(588, 464);
            this.gunaLinePanel1.TabIndex = 7;
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lb_tongtien.ForeColor = System.Drawing.Color.Black;
            this.lb_tongtien.Location = new System.Drawing.Point(124, 393);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(83, 28);
            this.lb_tongtien.TabIndex = 38;
            this.lb_tongtien.Text = "300,000";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel3.Location = new System.Drawing.Point(12, 393);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(94, 25);
            this.gunaLabel3.TabIndex = 37;
            this.gunaLabel3.Text = "Tổng tiền";
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox4.Image")));
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(491, 85);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.ShadowDecoration.Parent = this.guna2CirclePictureBox4;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(49, 48);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox4.TabIndex = 36;
            this.guna2CirclePictureBox4.TabStop = false;
            // 
            // rbLoi
            // 
            this.rbLoi.BaseColor = System.Drawing.SystemColors.Control;
            this.rbLoi.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbLoi.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbLoi.FillColor = System.Drawing.Color.White;
            this.rbLoi.Location = new System.Drawing.Point(507, 139);
            this.rbLoi.Name = "rbLoi";
            this.rbLoi.Size = new System.Drawing.Size(20, 20);
            this.rbLoi.TabIndex = 35;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.fpn_ItemsLinhKien);
            this.gunaLinePanel2.Controls.Add(this.btnThem);
            this.gunaLinePanel2.Controls.Add(this.tbTimKiem);
            this.gunaLinePanel2.Controls.Add(this.lb_NgayNhan);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.DimGray;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(9, 165);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(564, 190);
            this.gunaLinePanel2.TabIndex = 33;
            // 
            // fpn_ItemsLinhKien
            // 
            this.fpn_ItemsLinhKien.Location = new System.Drawing.Point(29, 62);
            this.fpn_ItemsLinhKien.Name = "fpn_ItemsLinhKien";
            this.fpn_ItemsLinhKien.Size = new System.Drawing.Size(502, 123);
            this.fpn_ItemsLinhKien.TabIndex = 26;
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(229)))), ((int)(((byte)(126)))));
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageOffsetX = -10;
            this.btnThem.ImageSize = new System.Drawing.Size(32, 32);
            this.btnThem.Location = new System.Drawing.Point(505, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(152)))), ((int)(((byte)(84)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Radius = 10;
            this.btnThem.Size = new System.Drawing.Size(32, 32);
            this.btnThem.TabIndex = 25;
            this.btnThem.TextOffsetX = -5;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTimKiem.BorderRadius = 15;
            this.tbTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimKiem.DefaultText = "";
            this.tbTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimKiem.DisabledState.Parent = this.tbTimKiem;
            this.tbTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimKiem.FocusedState.Parent = this.tbTimKiem;
            this.tbTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbTimKiem.ForeColor = System.Drawing.Color.DimGray;
            this.tbTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimKiem.HoverState.Parent = this.tbTimKiem;
            this.tbTimKiem.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.tbTimKiem.IconLeftSize = new System.Drawing.Size(32, 32);
            this.tbTimKiem.Location = new System.Drawing.Point(305, 15);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(6);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.PasswordChar = '\0';
            this.tbTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbTimKiem.PlaceholderText = "Tên linh kiện";
            this.tbTimKiem.SelectedText = "";
            this.tbTimKiem.ShadowDecoration.Parent = this.tbTimKiem;
            this.tbTimKiem.Size = new System.Drawing.Size(191, 35);
            this.tbTimKiem.TabIndex = 24;
            this.tbTimKiem.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lb_NgayNhan
            // 
            this.lb_NgayNhan.AutoSize = true;
            this.lb_NgayNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayNhan.ForeColor = System.Drawing.Color.Gray;
            this.lb_NgayNhan.Location = new System.Drawing.Point(24, 20);
            this.lb_NgayNhan.Name = "lb_NgayNhan";
            this.lb_NgayNhan.Size = new System.Drawing.Size(89, 25);
            this.lb_NgayNhan.TabIndex = 21;
            this.lb_NgayNhan.Text = "Linh kiện";
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(382, 85);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.ShadowDecoration.Parent = this.guna2CirclePictureBox3;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(49, 48);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 32;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // rbThanhToan
            // 
            this.rbThanhToan.BaseColor = System.Drawing.SystemColors.Control;
            this.rbThanhToan.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbThanhToan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbThanhToan.FillColor = System.Drawing.Color.White;
            this.rbThanhToan.Location = new System.Drawing.Point(398, 139);
            this.rbThanhToan.Name = "rbThanhToan";
            this.rbThanhToan.Size = new System.Drawing.Size(20, 20);
            this.rbThanhToan.TabIndex = 31;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(461, 393);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(97, 36);
            this.gunaButton1.TabIndex = 30;
            this.gunaButton1.Text = "Lưu";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(345, 393);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(97, 36);
            this.gunaButton2.TabIndex = 29;
            this.gunaButton2.Text = "Huỷ";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(50, 85);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(49, 48);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 26;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // rbChuaSua
            // 
            this.rbChuaSua.BaseColor = System.Drawing.SystemColors.Control;
            this.rbChuaSua.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbChuaSua.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbChuaSua.FillColor = System.Drawing.Color.White;
            this.rbChuaSua.Location = new System.Drawing.Point(65, 139);
            this.rbChuaSua.Name = "rbChuaSua";
            this.rbChuaSua.Size = new System.Drawing.Size(20, 20);
            this.rbChuaSua.TabIndex = 25;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(158, 85);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(49, 48);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 24;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // rbDangSua
            // 
            this.rbDangSua.BaseColor = System.Drawing.SystemColors.Control;
            this.rbDangSua.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbDangSua.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbDangSua.FillColor = System.Drawing.Color.White;
            this.rbDangSua.Location = new System.Drawing.Point(174, 139);
            this.rbDangSua.Name = "rbDangSua";
            this.rbDangSua.Size = new System.Drawing.Size(20, 20);
            this.rbDangSua.TabIndex = 23;
            // 
            // ic_TinhTrang
            // 
            this.ic_TinhTrang.Image = ((System.Drawing.Image)(resources.GetObject("ic_TinhTrang.Image")));
            this.ic_TinhTrang.Location = new System.Drawing.Point(267, 85);
            this.ic_TinhTrang.Name = "ic_TinhTrang";
            this.ic_TinhTrang.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ic_TinhTrang.ShadowDecoration.Parent = this.ic_TinhTrang;
            this.ic_TinhTrang.Size = new System.Drawing.Size(49, 48);
            this.ic_TinhTrang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ic_TinhTrang.TabIndex = 22;
            this.ic_TinhTrang.TabStop = false;
            // 
            // rbDaXong
            // 
            this.rbDaXong.BaseColor = System.Drawing.SystemColors.Control;
            this.rbDaXong.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbDaXong.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbDaXong.FillColor = System.Drawing.Color.White;
            this.rbDaXong.Location = new System.Drawing.Point(283, 139);
            this.rbDaXong.Name = "rbDaXong";
            this.rbDaXong.Size = new System.Drawing.Size(20, 20);
            this.rbDaXong.TabIndex = 21;
            // 
            // fUpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(588, 464);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fUpdateInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fUpdateInfo";
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_TinhTrang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnTitle;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaDragControl dragPnTitle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI.WinForms.GunaRadioButton rbChuaSua;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI.WinForms.GunaRadioButton rbDangSua;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ic_TinhTrang;
        private Guna.UI.WinForms.GunaRadioButton rbDaXong;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI.WinForms.GunaRadioButton rbThanhToan;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.FlowLayoutPanel fpn_ItemsLinhKien;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI2.WinForms.Guna2TextBox tbTimKiem;
        private Guna.UI.WinForms.GunaLabel lb_NgayNhan;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private Guna.UI.WinForms.GunaRadioButton rbLoi;
        private Guna.UI.WinForms.GunaLabel lb_tongtien;
    }
}