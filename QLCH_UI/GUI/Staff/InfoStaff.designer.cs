namespace QLCH_UI
{
    partial class lb_gioitinh
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnTitle = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dragPnTitle = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InfoStaff = new Guna.UI.WinForms.GunaLinePanel();
            this.lb_loainv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_gioi_tinh = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            this.InfoStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.pnTitle.Controls.Add(this.btnExit);
            this.pnTitle.Controls.Add(this.gunaLabel1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1093, 61);
            this.pnTitle.TabIndex = 20;
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
            this.btnExit.Location = new System.Drawing.Point(1046, 12);
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
            this.gunaLabel1.Location = new System.Drawing.Point(415, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(314, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Thông tin nhân viên";
            // 
            // dragPnTitle
            // 
            this.dragPnTitle.TargetControl = this.pnTitle;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // InfoStaff
            // 
            this.InfoStaff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoStaff.Controls.Add(this.lb_loainv);
            this.InfoStaff.Controls.Add(this.label5);
            this.InfoStaff.Controls.Add(this.lb_email);
            this.InfoStaff.Controls.Add(this.label14);
            this.InfoStaff.Controls.Add(this.lb_taikhoan);
            this.InfoStaff.Controls.Add(this.label17);
            this.InfoStaff.Controls.Add(this.lb_diachi);
            this.InfoStaff.Controls.Add(this.label13);
            this.InfoStaff.Controls.Add(this.lb_gioi_tinh);
            this.InfoStaff.Controls.Add(this.label11);
            this.InfoStaff.Controls.Add(this.lb_tennv);
            this.InfoStaff.Controls.Add(this.lb_sdt);
            this.InfoStaff.Controls.Add(this.lb_ngaysinh);
            this.InfoStaff.Controls.Add(this.lb_manv);
            this.InfoStaff.Controls.Add(this.label4);
            this.InfoStaff.Controls.Add(this.label2);
            this.InfoStaff.Controls.Add(this.label3);
            this.InfoStaff.Controls.Add(this.label1);
            this.InfoStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoStaff.LineBottom = 6;
            this.InfoStaff.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.InfoStaff.LineLeft = 4;
            this.InfoStaff.LineRight = 6;
            this.InfoStaff.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoStaff.Location = new System.Drawing.Point(0, 0);
            this.InfoStaff.Name = "InfoStaff";
            this.InfoStaff.Size = new System.Drawing.Size(1093, 621);
            this.InfoStaff.TabIndex = 21;
            // 
            // lb_loainv
            // 
            this.lb_loainv.AutoSize = true;
            this.lb_loainv.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_loainv.Location = new System.Drawing.Point(326, 227);
            this.lb_loainv.Name = "lb_loainv";
            this.lb_loainv.Size = new System.Drawing.Size(146, 30);
            this.lb_loainv.TabIndex = 147;
            this.lb_loainv.Text = "loại nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 32);
            this.label5.TabIndex = 146;
            this.label5.Text = "Chức vụ";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_email.Location = new System.Drawing.Point(879, 157);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(65, 30);
            this.lb_email.TabIndex = 145;
            this.lb_email.Text = "email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(704, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 32);
            this.label14.TabIndex = 144;
            this.label14.Text = "Email";
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_taikhoan.Location = new System.Drawing.Point(876, 85);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(101, 30);
            this.lb_taikhoan.TabIndex = 143;
            this.lb_taikhoan.Text = "tài khoản";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(701, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 32);
            this.label17.TabIndex = 142;
            this.label17.Text = "Tài khoản";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_diachi.Location = new System.Drawing.Point(327, 505);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(75, 30);
            this.lb_diachi.TabIndex = 141;
            this.lb_diachi.Text = "địa chỉ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(120, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 32);
            this.label13.TabIndex = 140;
            this.label13.Text = "Địa chỉ";
            // 
            // lb_gioi_tinh
            // 
            this.lb_gioi_tinh.AutoSize = true;
            this.lb_gioi_tinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_gioi_tinh.Location = new System.Drawing.Point(327, 367);
            this.lb_gioi_tinh.Name = "lb_gioi_tinh";
            this.lb_gioi_tinh.Size = new System.Drawing.Size(91, 30);
            this.lb_gioi_tinh.TabIndex = 139;
            this.lb_gioi_tinh.Text = "giới tính";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(116, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 32);
            this.label11.TabIndex = 138;
            this.label11.Text = "Giới tính";
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_tennv.Location = new System.Drawing.Point(326, 157);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(143, 30);
            this.lb_tennv.TabIndex = 135;
            this.lb_tennv.Text = "tên nhân viên";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_sdt.Location = new System.Drawing.Point(327, 437);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(137, 30);
            this.lb_sdt.TabIndex = 137;
            this.lb_sdt.Text = "số điện thoại";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_ngaysinh.Location = new System.Drawing.Point(327, 295);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(104, 30);
            this.lb_ngaysinh.TabIndex = 136;
            this.lb_ngaysinh.Text = "ngày sinh";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_manv.Location = new System.Drawing.Point(326, 87);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(142, 30);
            this.lb_manv.TabIndex = 134;
            this.lb_manv.Text = "mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 32);
            this.label4.TabIndex = 133;
            this.label4.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 130;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 132;
            this.label3.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 131;
            this.label1.Text = "Tên nhân viên";
            // 
            // lb_gioitinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 621);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.InfoStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lb_gioitinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoStaff";
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.InfoStaff.ResumeLayout(false);
            this.InfoStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel pnTitle;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLinePanel InfoStaff;
        private System.Windows.Forms.Label lb_loainv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_gioi_tinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_tennv;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDragControl dragPnTitle;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}