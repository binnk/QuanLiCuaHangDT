namespace QLCH_UI
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.label11 = new System.Windows.Forms.Label();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_soluong_error = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sl = new System.Windows.Forms.TextBox();
            this.lb_masp_error = new System.Windows.Forms.Label();
            this.cb_loaisp = new System.Windows.Forms.ComboBox();
            this.tb_giaban = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_gianhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_tensp_error = new System.Windows.Forms.Label();
            this.tb_masp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ten_sp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_giaban_error = new System.Windows.Forms.Label();
            this.lb_gianhap_error = new System.Windows.Forms.Label();
            this.lb_loaisp_error = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI.WinForms.GunaButton();
            this.btn_luu_customer = new Guna.UI.WinForms.GunaButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragPnTitle = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnTitle = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaLinePanel1.Controls.Add(this.label11);
            this.gunaLinePanel1.Controls.Add(this.gunaLinePanel2);
            this.gunaLinePanel1.Controls.Add(this.groupBox1);
            this.gunaLinePanel1.Controls.Add(this.btnHuy);
            this.gunaLinePanel1.Controls.Add(this.btn_luu_customer);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 6;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gunaLinePanel1.LineLeft = 4;
            this.gunaLinePanel1.LineRight = 6;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 61);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1014, 621);
            this.gunaLinePanel1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(761, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 32);
            this.label11.TabIndex = 120;
            this.label11.Text = "Thêm ảnh";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.pictureBox1);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(666, 41);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(285, 393);
            this.gunaLinePanel2.TabIndex = 121;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_soluong_error);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_sl);
            this.groupBox1.Controls.Add(this.lb_masp_error);
            this.groupBox1.Controls.Add(this.cb_loaisp);
            this.groupBox1.Controls.Add(this.tb_giaban);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_gianhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_tensp_error);
            this.groupBox1.Controls.Add(this.tb_masp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_ten_sp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_giaban_error);
            this.groupBox1.Controls.Add(this.lb_gianhap_error);
            this.groupBox1.Controls.Add(this.lb_loaisp_error);
            this.groupBox1.Location = new System.Drawing.Point(71, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 579);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            // 
            // lb_soluong_error
            // 
            this.lb_soluong_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_soluong_error.ForeColor = System.Drawing.Color.Red;
            this.lb_soluong_error.Location = new System.Drawing.Point(46, 537);
            this.lb_soluong_error.Name = "lb_soluong_error";
            this.lb_soluong_error.Size = new System.Drawing.Size(417, 42);
            this.lb_soluong_error.TabIndex = 111;
            this.lb_soluong_error.Text = "Số lượng không hợp lệ";
            this.lb_soluong_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_soluong_error.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(45, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 32);
            this.label4.TabIndex = 113;
            this.label4.Text = "Số lượng tồn kho";
            // 
            // tb_sl
            // 
            this.tb_sl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sl.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_sl.Location = new System.Drawing.Point(50, 470);
            this.tb_sl.Name = "tb_sl";
            this.tb_sl.Size = new System.Drawing.Size(414, 44);
            this.tb_sl.TabIndex = 112;
            // 
            // lb_masp_error
            // 
            this.lb_masp_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_masp_error.ForeColor = System.Drawing.Color.Red;
            this.lb_masp_error.Location = new System.Drawing.Point(47, 534);
            this.lb_masp_error.Name = "lb_masp_error";
            this.lb_masp_error.Size = new System.Drawing.Size(417, 42);
            this.lb_masp_error.TabIndex = 110;
            this.lb_masp_error.Text = "Mã sản phẩm không hợp lệ";
            this.lb_masp_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_masp_error.Visible = false;
            // 
            // cb_loaisp
            // 
            this.cb_loaisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loaisp.FormattingEnabled = true;
            this.cb_loaisp.Items.AddRange(new object[] {
            "Laptop",
            "Điện thoại",
            "Linh kiện",
            "Phụ kiện",
            "Khác"});
            this.cb_loaisp.Location = new System.Drawing.Point(50, 211);
            this.cb_loaisp.Name = "cb_loaisp";
            this.cb_loaisp.Size = new System.Drawing.Size(414, 40);
            this.cb_loaisp.TabIndex = 109;
            // 
            // tb_giaban
            // 
            this.tb_giaban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_giaban.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_giaban.Location = new System.Drawing.Point(50, 373);
            this.tb_giaban.Name = "tb_giaban";
            this.tb_giaban.Size = new System.Drawing.Size(414, 44);
            this.tb_giaban.TabIndex = 106;
            this.tb_giaban.TextChanged += new System.EventHandler(this.tb_giaban_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(43, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 32);
            this.label9.TabIndex = 105;
            this.label9.Text = "Giá bán";
            // 
            // tb_gianhap
            // 
            this.tb_gianhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_gianhap.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_gianhap.Location = new System.Drawing.Point(49, 291);
            this.tb_gianhap.Name = "tb_gianhap";
            this.tb_gianhap.Size = new System.Drawing.Size(414, 44);
            this.tb_gianhap.TabIndex = 104;
            this.tb_gianhap.TextChanged += new System.EventHandler(this.tb_gianhap_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(44, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 32);
            this.label6.TabIndex = 103;
            this.label6.Text = "Giá nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(45, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 99;
            this.label3.Text = "Loại sản phẩm";
            // 
            // lb_tensp_error
            // 
            this.lb_tensp_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_tensp_error.ForeColor = System.Drawing.Color.Red;
            this.lb_tensp_error.Location = new System.Drawing.Point(41, 527);
            this.lb_tensp_error.Name = "lb_tensp_error";
            this.lb_tensp_error.Size = new System.Drawing.Size(417, 42);
            this.lb_tensp_error.TabIndex = 98;
            this.lb_tensp_error.Text = "Tên sản phẩm không hợp lệ";
            this.lb_tensp_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_tensp_error.Visible = false;
            // 
            // tb_masp
            // 
            this.tb_masp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_masp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_masp.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_masp.Location = new System.Drawing.Point(50, 129);
            this.tb_masp.Name = "tb_masp";
            this.tb_masp.ReadOnly = true;
            this.tb_masp.Size = new System.Drawing.Size(414, 44);
            this.tb_masp.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 84;
            this.label1.Text = "Mã sản phẩm";
            // 
            // tb_ten_sp
            // 
            this.tb_ten_sp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ten_sp.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_ten_sp.Location = new System.Drawing.Point(49, 55);
            this.tb_ten_sp.Name = "tb_ten_sp";
            this.tb_ten_sp.Size = new System.Drawing.Size(414, 44);
            this.tb_ten_sp.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên sản phẩm";
            // 
            // lb_giaban_error
            // 
            this.lb_giaban_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_giaban_error.ForeColor = System.Drawing.Color.Red;
            this.lb_giaban_error.Location = new System.Drawing.Point(41, 534);
            this.lb_giaban_error.Name = "lb_giaban_error";
            this.lb_giaban_error.Size = new System.Drawing.Size(417, 42);
            this.lb_giaban_error.TabIndex = 111;
            this.lb_giaban_error.Text = "Giá bán không hợp lệ";
            this.lb_giaban_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_giaban_error.Visible = false;
            // 
            // lb_gianhap_error
            // 
            this.lb_gianhap_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_gianhap_error.ForeColor = System.Drawing.Color.Red;
            this.lb_gianhap_error.Location = new System.Drawing.Point(47, 534);
            this.lb_gianhap_error.Name = "lb_gianhap_error";
            this.lb_gianhap_error.Size = new System.Drawing.Size(417, 38);
            this.lb_gianhap_error.TabIndex = 110;
            this.lb_gianhap_error.Text = "Giá nhập không hợp lệ";
            this.lb_gianhap_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_gianhap_error.Visible = false;
            // 
            // lb_loaisp_error
            // 
            this.lb_loaisp_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_loaisp_error.ForeColor = System.Drawing.Color.Red;
            this.lb_loaisp_error.Location = new System.Drawing.Point(47, 527);
            this.lb_loaisp_error.Name = "lb_loaisp_error";
            this.lb_loaisp_error.Size = new System.Drawing.Size(417, 42);
            this.lb_loaisp_error.TabIndex = 110;
            this.lb_loaisp_error.Text = "Chọn loại sản phẩm";
            this.lb_loaisp_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_loaisp_error.Visible = false;
            // 
            // btnHuy
            // 
            this.btnHuy.AnimationHoverSpeed = 0.07F;
            this.btnHuy.AnimationSpeed = 0.03F;
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnHuy.BorderColor = System.Drawing.Color.Black;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = null;
            this.btnHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuy.Location = new System.Drawing.Point(666, 558);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Radius = 5;
            this.btnHuy.Size = new System.Drawing.Size(136, 47);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_luu_customer
            // 
            this.btn_luu_customer.AnimationHoverSpeed = 0.07F;
            this.btn_luu_customer.AnimationSpeed = 0.03F;
            this.btn_luu_customer.BackColor = System.Drawing.Color.Transparent;
            this.btn_luu_customer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btn_luu_customer.BorderColor = System.Drawing.Color.Black;
            this.btn_luu_customer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_luu_customer.FocusedColor = System.Drawing.Color.Empty;
            this.btn_luu_customer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_luu_customer.ForeColor = System.Drawing.Color.White;
            this.btn_luu_customer.Image = null;
            this.btn_luu_customer.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_luu_customer.Location = new System.Drawing.Point(808, 558);
            this.btn_luu_customer.Name = "btn_luu_customer";
            this.btn_luu_customer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btn_luu_customer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_luu_customer.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_luu_customer.OnHoverImage = null;
            this.btn_luu_customer.OnPressedColor = System.Drawing.Color.Black;
            this.btn_luu_customer.Radius = 5;
            this.btn_luu_customer.Size = new System.Drawing.Size(136, 47);
            this.btn_luu_customer.TabIndex = 7;
            this.btn_luu_customer.Text = "Thêm";
            this.btn_luu_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_luu_customer.Click += new System.EventHandler(this.btn_luu_customer_Click_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dragPnTitle
            // 
            this.dragPnTitle.TargetControl = this.pnTitle;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.pnTitle.Controls.Add(this.btnExit);
            this.pnTitle.Controls.Add(this.gunaLabel1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1014, 61);
            this.pnTitle.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnExit.IconSize = 32;
            this.btnExit.Location = new System.Drawing.Point(967, 12);
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
            this.gunaLabel1.Location = new System.Drawing.Point(425, 7);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(253, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Thêm sản phẩm";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1014, 682);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_soluong_error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sl;
        private System.Windows.Forms.Label lb_masp_error;
        private System.Windows.Forms.ComboBox cb_loaisp;
        private System.Windows.Forms.TextBox tb_giaban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_gianhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_tensp_error;
        private System.Windows.Forms.TextBox tb_masp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ten_sp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_giaban_error;
        private System.Windows.Forms.Label lb_gianhap_error;
        private System.Windows.Forms.Label lb_loaisp_error;
        private Guna.UI.WinForms.GunaButton btnHuy;
        private Guna.UI.WinForms.GunaButton btn_luu_customer;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI.WinForms.GunaDragControl dragPnTitle;
        private Guna.UI.WinForms.GunaPanel pnTitle;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}