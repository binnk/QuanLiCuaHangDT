namespace QLCH_UI
{
    partial class EditStaff
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnHuy = new Guna.UI.WinForms.GunaButton();
            this.btn_luu_customer = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dragPnTitle = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnTitle = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_email_error = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_loainv_error = new System.Windows.Forms.Label();
            this.cb_loainv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_dia_chi_error = new System.Windows.Forms.Label();
            this.lb_gioi_tinh_error = new System.Windows.Forms.Label();
            this.lb_sdt_error = new System.Windows.Forms.Label();
            this.lb_manv_error = new System.Windows.Forms.Label();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_ten_nv_error = new System.Windows.Forms.Label();
            this.tb_dia_chi = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Radio_Nu = new System.Windows.Forms.RadioButton();
            this.Radio_Nam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_nv = new System.Windows.Forms.DateTimePicker();
            this.tb_ten_nv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaLinePanel1.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaLinePanel1.Controls.Add(this.groupBox2);
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
            this.gunaLinePanel1.Size = new System.Drawing.Size(945, 687);
            this.gunaLinePanel1.TabIndex = 19;
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
            this.btnHuy.Location = new System.Drawing.Point(632, 608);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Radius = 5;
            this.btnHuy.Size = new System.Drawing.Size(136, 47);
            this.btnHuy.TabIndex = 126;
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
            this.btn_luu_customer.Location = new System.Drawing.Point(770, 608);
            this.btn_luu_customer.Name = "btn_luu_customer";
            this.btn_luu_customer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btn_luu_customer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_luu_customer.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_luu_customer.OnHoverImage = null;
            this.btn_luu_customer.OnPressedColor = System.Drawing.Color.Black;
            this.btn_luu_customer.Radius = 5;
            this.btn_luu_customer.Size = new System.Drawing.Size(136, 47);
            this.btn_luu_customer.TabIndex = 125;
            this.btn_luu_customer.Text = "Xác nhận";
            this.btn_luu_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_luu_customer.Click += new System.EventHandler(this.btn_luu_customer_Click_1);
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
            this.btnExit.Location = new System.Drawing.Point(898, 12);
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
            this.gunaLabel1.Location = new System.Drawing.Point(315, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(371, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Sửa thông tin nhân viên";
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
            this.pnTitle.Size = new System.Drawing.Size(945, 61);
            this.pnTitle.TabIndex = 18;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_email_error);
            this.groupBox2.Controls.Add(this.tb_email);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_user);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(626, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 221);
            this.groupBox2.TabIndex = 128;
            this.groupBox2.TabStop = false;
            // 
            // lb_email_error
            // 
            this.lb_email_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_email_error.ForeColor = System.Drawing.Color.Red;
            this.lb_email_error.Location = new System.Drawing.Point(0, 177);
            this.lb_email_error.Name = "lb_email_error";
            this.lb_email_error.Size = new System.Drawing.Size(280, 42);
            this.lb_email_error.TabIndex = 121;
            this.lb_email_error.Text = "email không hợp lệ";
            this.lb_email_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_email_error.Visible = false;
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_email.Location = new System.Drawing.Point(6, 127);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(268, 44);
            this.tb_email.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 105;
            this.label1.Text = "Email";
            // 
            // tb_user
            // 
            this.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_user.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_user.Location = new System.Drawing.Point(6, 48);
            this.tb_user.Name = "tb_user";
            this.tb_user.ReadOnly = true;
            this.tb_user.Size = new System.Drawing.Size(268, 44);
            this.tb_user.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 32);
            this.label12.TabIndex = 103;
            this.label12.Text = "Tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_loainv_error);
            this.groupBox1.Controls.Add(this.cb_loainv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lb_dia_chi_error);
            this.groupBox1.Controls.Add(this.lb_gioi_tinh_error);
            this.groupBox1.Controls.Add(this.lb_sdt_error);
            this.groupBox1.Controls.Add(this.lb_manv_error);
            this.groupBox1.Controls.Add(this.tb_manv);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_ten_nv_error);
            this.groupBox1.Controls.Add(this.tb_dia_chi);
            this.groupBox1.Controls.Add(this.tb_phone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Radio_Nu);
            this.groupBox1.Controls.Add(this.Radio_Nam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date_nv);
            this.groupBox1.Controls.Add(this.tb_ten_nv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 623);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            // 
            // lb_loainv_error
            // 
            this.lb_loainv_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_loainv_error.ForeColor = System.Drawing.Color.Red;
            this.lb_loainv_error.Location = new System.Drawing.Point(47, 564);
            this.lb_loainv_error.Name = "lb_loainv_error";
            this.lb_loainv_error.Size = new System.Drawing.Size(417, 42);
            this.lb_loainv_error.TabIndex = 120;
            this.lb_loainv_error.Text = "Chọn loại nhân viên";
            this.lb_loainv_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_loainv_error.Visible = false;
            // 
            // cb_loainv
            // 
            this.cb_loainv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loainv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loainv.FormattingEnabled = true;
            this.cb_loainv.Items.AddRange(new object[] {
            "Bán hàng",
            "Kỹ thuật"});
            this.cb_loainv.Location = new System.Drawing.Point(48, 212);
            this.cb_loainv.Name = "cb_loainv";
            this.cb_loainv.Size = new System.Drawing.Size(413, 40);
            this.cb_loainv.TabIndex = 122;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 32);
            this.label8.TabIndex = 121;
            this.label8.Text = "Loại nhân viên";
            // 
            // lb_dia_chi_error
            // 
            this.lb_dia_chi_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_dia_chi_error.ForeColor = System.Drawing.Color.Red;
            this.lb_dia_chi_error.Location = new System.Drawing.Point(44, 564);
            this.lb_dia_chi_error.Name = "lb_dia_chi_error";
            this.lb_dia_chi_error.Size = new System.Drawing.Size(417, 42);
            this.lb_dia_chi_error.TabIndex = 120;
            this.lb_dia_chi_error.Text = "Địa chỉ không hợp lệ";
            this.lb_dia_chi_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_dia_chi_error.Visible = false;
            // 
            // lb_gioi_tinh_error
            // 
            this.lb_gioi_tinh_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_gioi_tinh_error.ForeColor = System.Drawing.Color.Red;
            this.lb_gioi_tinh_error.Location = new System.Drawing.Point(45, 553);
            this.lb_gioi_tinh_error.Name = "lb_gioi_tinh_error";
            this.lb_gioi_tinh_error.Size = new System.Drawing.Size(417, 42);
            this.lb_gioi_tinh_error.TabIndex = 120;
            this.lb_gioi_tinh_error.Text = "Chọn giới tính";
            this.lb_gioi_tinh_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_gioi_tinh_error.Visible = false;
            // 
            // lb_sdt_error
            // 
            this.lb_sdt_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_sdt_error.ForeColor = System.Drawing.Color.Red;
            this.lb_sdt_error.Location = new System.Drawing.Point(45, 553);
            this.lb_sdt_error.Name = "lb_sdt_error";
            this.lb_sdt_error.Size = new System.Drawing.Size(417, 42);
            this.lb_sdt_error.TabIndex = 120;
            this.lb_sdt_error.Text = "Số điện thoại không hợp lệ";
            this.lb_sdt_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_sdt_error.Visible = false;
            // 
            // lb_manv_error
            // 
            this.lb_manv_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_manv_error.ForeColor = System.Drawing.Color.Red;
            this.lb_manv_error.Location = new System.Drawing.Point(46, 553);
            this.lb_manv_error.Name = "lb_manv_error";
            this.lb_manv_error.Size = new System.Drawing.Size(417, 42);
            this.lb_manv_error.TabIndex = 120;
            this.lb_manv_error.Text = "Mã nhân viên không hợp lệ";
            this.lb_manv_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_manv_error.Visible = false;
            // 
            // tb_manv
            // 
            this.tb_manv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_manv.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_manv.Location = new System.Drawing.Point(48, 48);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.ReadOnly = true;
            this.tb_manv.Size = new System.Drawing.Size(414, 44);
            this.tb_manv.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 32);
            this.label9.TabIndex = 101;
            this.label9.Text = "Mã nhân viên";
            // 
            // lb_ten_nv_error
            // 
            this.lb_ten_nv_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_ten_nv_error.ForeColor = System.Drawing.Color.Red;
            this.lb_ten_nv_error.Location = new System.Drawing.Point(45, 564);
            this.lb_ten_nv_error.Name = "lb_ten_nv_error";
            this.lb_ten_nv_error.Size = new System.Drawing.Size(417, 42);
            this.lb_ten_nv_error.TabIndex = 98;
            this.lb_ten_nv_error.Text = "Tên nhân viên không hợp lệ";
            this.lb_ten_nv_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_ten_nv_error.Visible = false;
            // 
            // tb_dia_chi
            // 
            this.tb_dia_chi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dia_chi.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_dia_chi.Location = new System.Drawing.Point(48, 506);
            this.tb_dia_chi.Name = "tb_dia_chi";
            this.tb_dia_chi.Size = new System.Drawing.Size(414, 44);
            this.tb_dia_chi.TabIndex = 97;
            // 
            // tb_phone
            // 
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_phone.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_phone.Location = new System.Drawing.Point(47, 424);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(414, 44);
            this.tb_phone.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(42, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 32);
            this.label4.TabIndex = 94;
            this.label4.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(41, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 32);
            this.label6.TabIndex = 92;
            this.label6.Text = "Giới tính";
            // 
            // Radio_Nu
            // 
            this.Radio_Nu.AutoSize = true;
            this.Radio_Nu.Font = new System.Drawing.Font("Arial", 11F);
            this.Radio_Nu.Location = new System.Drawing.Point(305, 357);
            this.Radio_Nu.Name = "Radio_Nu";
            this.Radio_Nu.Size = new System.Drawing.Size(68, 29);
            this.Radio_Nu.TabIndex = 91;
            this.Radio_Nu.TabStop = true;
            this.Radio_Nu.Text = "Nữ";
            this.Radio_Nu.UseVisualStyleBackColor = true;
            // 
            // Radio_Nam
            // 
            this.Radio_Nam.AutoSize = true;
            this.Radio_Nam.Font = new System.Drawing.Font("Arial", 11F);
            this.Radio_Nam.Location = new System.Drawing.Point(201, 357);
            this.Radio_Nam.Name = "Radio_Nam";
            this.Radio_Nam.Size = new System.Drawing.Size(83, 29);
            this.Radio_Nam.TabIndex = 90;
            this.Radio_Nam.TabStop = true;
            this.Radio_Nam.Text = "Nam";
            this.Radio_Nam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(41, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 89;
            this.label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(41, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 32);
            this.label5.TabIndex = 87;
            this.label5.Text = "Ngày sinh";
            // 
            // date_nv
            // 
            this.date_nv.CalendarFont = new System.Drawing.Font("Arial", 16F);
            this.date_nv.CustomFormat = "dd/MM/yyyy";
            this.date_nv.Font = new System.Drawing.Font("Arial", 16F);
            this.date_nv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_nv.Location = new System.Drawing.Point(47, 307);
            this.date_nv.Name = "date_nv";
            this.date_nv.Size = new System.Drawing.Size(325, 44);
            this.date_nv.TabIndex = 86;
            // 
            // tb_ten_nv
            // 
            this.tb_ten_nv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ten_nv.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_ten_nv.Location = new System.Drawing.Point(50, 130);
            this.tb_ten_nv.Name = "tb_ten_nv";
            this.tb_ten_nv.Size = new System.Drawing.Size(414, 44);
            this.tb_ten_nv.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên nhân viên";
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(945, 748);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStaff";
            this.Load += new System.EventHandler(this.EditStaff_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_email_error;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_loainv_error;
        private System.Windows.Forms.ComboBox cb_loainv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_dia_chi_error;
        private System.Windows.Forms.Label lb_gioi_tinh_error;
        private System.Windows.Forms.Label lb_sdt_error;
        private System.Windows.Forms.Label lb_manv_error;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_ten_nv_error;
        private System.Windows.Forms.TextBox tb_dia_chi;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Radio_Nu;
        private System.Windows.Forms.RadioButton Radio_Nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_nv;
        private System.Windows.Forms.TextBox tb_ten_nv;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnHuy;
        private Guna.UI.WinForms.GunaButton btn_luu_customer;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDragControl dragPnTitle;
        private Guna.UI.WinForms.GunaPanel pnTitle;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}