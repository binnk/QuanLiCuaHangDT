namespace QLCH_UI
{
    partial class AddStaff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_ten_nv_error = new System.Windows.Forms.Label();
            this.tb_dia_chi = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_luu_customer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Radio_Nu = new System.Windows.Forms.RadioButton();
            this.Radio_Nam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_nv = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_gioi_tinh_error = new System.Windows.Forms.Label();
            this.lb_dia_chi_error = new System.Windows.Forms.Label();
            this.lb_sdt_error = new System.Windows.Forms.Label();
            this.lb_manv_error = new System.Windows.Forms.Label();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_ten_nv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_confirmpassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_password_error = new System.Windows.Forms.Label();
            this.cb_loainv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_loainv_error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(100)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 69);
            this.panel1.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(346, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 45);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thêm nhân viên";
            // 
            // lb_ten_nv_error
            // 
            this.lb_ten_nv_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_ten_nv_error.ForeColor = System.Drawing.Color.Red;
            this.lb_ten_nv_error.Location = new System.Drawing.Point(44, 581);
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
            this.tb_dia_chi.Location = new System.Drawing.Point(48, 534);
            this.tb_dia_chi.Name = "tb_dia_chi";
            this.tb_dia_chi.Size = new System.Drawing.Size(414, 44);
            this.tb_dia_chi.TabIndex = 97;
            this.tb_dia_chi.TextChanged += new System.EventHandler(this.tb_dia_chi_TextChanged);
            // 
            // tb_phone
            // 
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_phone.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_phone.Location = new System.Drawing.Point(49, 442);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(414, 44);
            this.tb_phone.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(44, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 32);
            this.label4.TabIndex = 94;
            this.label4.Text = "Địa chỉ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(615, 660);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 59);
            this.button2.TabIndex = 41;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_luu_customer
            // 
            this.btn_luu_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(100)))), ((int)(((byte)(207)))));
            this.btn_luu_customer.FlatAppearance.BorderSize = 0;
            this.btn_luu_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu_customer.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_luu_customer.ForeColor = System.Drawing.Color.White;
            this.btn_luu_customer.Location = new System.Drawing.Point(759, 660);
            this.btn_luu_customer.Name = "btn_luu_customer";
            this.btn_luu_customer.Size = new System.Drawing.Size(136, 59);
            this.btn_luu_customer.TabIndex = 40;
            this.btn_luu_customer.Text = "Lưu";
            this.btn_luu_customer.UseVisualStyleBackColor = false;
            this.btn_luu_customer.Click += new System.EventHandler(this.btn_luu_customer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(43, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 32);
            this.label6.TabIndex = 92;
            this.label6.Text = "Giới tính";
            // 
            // Radio_Nu
            // 
            this.Radio_Nu.AutoSize = true;
            this.Radio_Nu.Font = new System.Drawing.Font("Arial", 11F);
            this.Radio_Nu.Location = new System.Drawing.Point(306, 287);
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
            this.Radio_Nam.Location = new System.Drawing.Point(199, 286);
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
            this.label3.Location = new System.Drawing.Point(42, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 89;
            this.label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(44, 177);
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
            this.date_nv.Location = new System.Drawing.Point(49, 224);
            this.date_nv.Name = "date_nv";
            this.date_nv.Size = new System.Drawing.Size(325, 44);
            this.date_nv.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_loainv_error);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_loainv);
            this.groupBox1.Controls.Add(this.lb_gioi_tinh_error);
            this.groupBox1.Controls.Add(this.lb_dia_chi_error);
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
            this.groupBox1.Location = new System.Drawing.Point(28, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 655);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // lb_gioi_tinh_error
            // 
            this.lb_gioi_tinh_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_gioi_tinh_error.ForeColor = System.Drawing.Color.Red;
            this.lb_gioi_tinh_error.Location = new System.Drawing.Point(43, 581);
            this.lb_gioi_tinh_error.Name = "lb_gioi_tinh_error";
            this.lb_gioi_tinh_error.Size = new System.Drawing.Size(417, 42);
            this.lb_gioi_tinh_error.TabIndex = 117;
            this.lb_gioi_tinh_error.Text = "Chọn giới tính";
            this.lb_gioi_tinh_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_gioi_tinh_error.Visible = false;
            this.lb_gioi_tinh_error.Click += new System.EventHandler(this.lb_gioi_tinh_error_Click);
            // 
            // lb_dia_chi_error
            // 
            this.lb_dia_chi_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_dia_chi_error.ForeColor = System.Drawing.Color.Red;
            this.lb_dia_chi_error.Location = new System.Drawing.Point(43, 581);
            this.lb_dia_chi_error.Name = "lb_dia_chi_error";
            this.lb_dia_chi_error.Size = new System.Drawing.Size(417, 42);
            this.lb_dia_chi_error.TabIndex = 116;
            this.lb_dia_chi_error.Text = "Địa chỉ không hợp lệ";
            this.lb_dia_chi_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_dia_chi_error.Visible = false;
            this.lb_dia_chi_error.Click += new System.EventHandler(this.lb_dia_chi_error_Click);
            // 
            // lb_sdt_error
            // 
            this.lb_sdt_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_sdt_error.ForeColor = System.Drawing.Color.Red;
            this.lb_sdt_error.Location = new System.Drawing.Point(46, 581);
            this.lb_sdt_error.Name = "lb_sdt_error";
            this.lb_sdt_error.Size = new System.Drawing.Size(417, 42);
            this.lb_sdt_error.TabIndex = 115;
            this.lb_sdt_error.Text = "Số điện thoại không hợp lệ";
            this.lb_sdt_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_sdt_error.Visible = false;
            this.lb_sdt_error.Click += new System.EventHandler(this.lb_sdt_error_Click);
            // 
            // lb_manv_error
            // 
            this.lb_manv_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_manv_error.ForeColor = System.Drawing.Color.Red;
            this.lb_manv_error.Location = new System.Drawing.Point(46, 581);
            this.lb_manv_error.Name = "lb_manv_error";
            this.lb_manv_error.Size = new System.Drawing.Size(417, 42);
            this.lb_manv_error.TabIndex = 114;
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
            // tb_ten_nv
            // 
            this.tb_ten_nv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ten_nv.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_ten_nv.Location = new System.Drawing.Point(49, 127);
            this.tb_ten_nv.Name = "tb_ten_nv";
            this.tb_ten_nv.Size = new System.Drawing.Size(414, 44);
            this.tb_ten_nv.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(696, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 32);
            this.label11.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-6, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 32);
            this.label12.TabIndex = 103;
            this.label12.Text = "Tài khoản";
            // 
            // tb_user
            // 
            this.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_user.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_user.Location = new System.Drawing.Point(0, 76);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(268, 44);
            this.tb_user.TabIndex = 104;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tb_email);
            this.groupBox2.Controls.Add(this.tb_confirmpassword);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_password);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_user);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(615, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 399);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-6, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 32);
            this.label13.TabIndex = 110;
            this.label13.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_email.Location = new System.Drawing.Point(0, 325);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(268, 44);
            this.tb_email.TabIndex = 109;
            // 
            // tb_confirmpassword
            // 
            this.tb_confirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_confirmpassword.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_confirmpassword.Location = new System.Drawing.Point(0, 240);
            this.tb_confirmpassword.Name = "tb_confirmpassword";
            this.tb_confirmpassword.Size = new System.Drawing.Size(268, 44);
            this.tb_confirmpassword.TabIndex = 108;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-6, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 32);
            this.label10.TabIndex = 107;
            this.label10.Text = "Nhập lại mật khẩu";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_password.Location = new System.Drawing.Point(0, 158);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(268, 44);
            this.tb_password.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 105;
            this.label1.Text = "Mật khẩu";
            // 
            // lb_password_error
            // 
            this.lb_password_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_password_error.ForeColor = System.Drawing.Color.Red;
            this.lb_password_error.Location = new System.Drawing.Point(546, 498);
            this.lb_password_error.Name = "lb_password_error";
            this.lb_password_error.Size = new System.Drawing.Size(399, 147);
            this.lb_password_error.TabIndex = 118;
            this.lb_password_error.Text = "Mật khẩu không hợp lệ";
            this.lb_password_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_password_error.Visible = false;
            // 
            // cb_loainv
            // 
            this.cb_loainv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loainv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loainv.FormattingEnabled = true;
            this.cb_loainv.Items.AddRange(new object[] {
            "Bán hàng",
            "Kỹ thuật"});
            this.cb_loainv.Location = new System.Drawing.Point(48, 350);
            this.cb_loainv.Name = "cb_loainv";
            this.cb_loainv.Size = new System.Drawing.Size(413, 40);
            this.cb_loainv.TabIndex = 118;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(44, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 32);
            this.label8.TabIndex = 119;
            this.label8.Text = "Loại nhân viên";
            // 
            // lb_loainv_error
            // 
            this.lb_loainv_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_loainv_error.ForeColor = System.Drawing.Color.Red;
            this.lb_loainv_error.Location = new System.Drawing.Point(45, 592);
            this.lb_loainv_error.Name = "lb_loainv_error";
            this.lb_loainv_error.Size = new System.Drawing.Size(417, 42);
            this.lb_loainv_error.TabIndex = 119;
            this.lb_loainv_error.Text = "Chọn loại nhân viên";
            this.lb_loainv_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_loainv_error.Visible = false;
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(945, 748);
            this.Controls.Add(this.lb_password_error);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_luu_customer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStaff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_ten_nv_error;
        private System.Windows.Forms.TextBox tb_dia_chi;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_luu_customer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Radio_Nu;
        private System.Windows.Forms.RadioButton Radio_Nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_nv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_ten_nv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_confirmpassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_gioi_tinh_error;
        private System.Windows.Forms.Label lb_dia_chi_error;
        private System.Windows.Forms.Label lb_sdt_error;
        private System.Windows.Forms.Label lb_manv_error;
        private System.Windows.Forms.Label lb_password_error;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_loainv;
        private System.Windows.Forms.Label lb_loainv_error;
    }
}