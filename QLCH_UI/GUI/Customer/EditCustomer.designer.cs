namespace QLCH_UI
{
    partial class EditCustomer
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
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_gioitinh_error = new System.Windows.Forms.Label();
            this.lb_SDT_error = new System.Windows.Forms.Label();
            this.lb_diachi_error = new System.Windows.Forms.Label();
            this.lb_tenkh_error = new System.Windows.Forms.Label();
            this.tb_dia_chi = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_makh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Radio_Nu = new System.Windows.Forms.RadioButton();
            this.Radio_Nam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_kh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ten_kh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI.WinForms.GunaButton();
            this.btn_luu_customer = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dragPnTitle = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnTitle = new Guna.UI.WinForms.GunaPanel();
            this.gunaLinePanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.gunaLinePanel1.Size = new System.Drawing.Size(568, 656);
            this.gunaLinePanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_gioitinh_error);
            this.groupBox1.Controls.Add(this.lb_SDT_error);
            this.groupBox1.Controls.Add(this.lb_diachi_error);
            this.groupBox1.Controls.Add(this.lb_tenkh_error);
            this.groupBox1.Controls.Add(this.tb_dia_chi);
            this.groupBox1.Controls.Add(this.tb_phone);
            this.groupBox1.Controls.Add(this.tb_makh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Radio_Nu);
            this.groupBox1.Controls.Add(this.Radio_Nam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date_kh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_ten_kh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 519);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // lb_gioitinh_error
            // 
            this.lb_gioitinh_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_gioitinh_error.ForeColor = System.Drawing.Color.Red;
            this.lb_gioitinh_error.Location = new System.Drawing.Point(45, 474);
            this.lb_gioitinh_error.Name = "lb_gioitinh_error";
            this.lb_gioitinh_error.Size = new System.Drawing.Size(417, 42);
            this.lb_gioitinh_error.TabIndex = 101;
            this.lb_gioitinh_error.Text = "Chọn giới tính";
            this.lb_gioitinh_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_gioitinh_error.Visible = false;
            // 
            // lb_SDT_error
            // 
            this.lb_SDT_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_SDT_error.ForeColor = System.Drawing.Color.Red;
            this.lb_SDT_error.Location = new System.Drawing.Point(45, 474);
            this.lb_SDT_error.Name = "lb_SDT_error";
            this.lb_SDT_error.Size = new System.Drawing.Size(417, 42);
            this.lb_SDT_error.TabIndex = 103;
            this.lb_SDT_error.Text = "Số điện thoại không hợp lệ";
            this.lb_SDT_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_SDT_error.Visible = false;
            // 
            // lb_diachi_error
            // 
            this.lb_diachi_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_diachi_error.ForeColor = System.Drawing.Color.Red;
            this.lb_diachi_error.Location = new System.Drawing.Point(47, 474);
            this.lb_diachi_error.Name = "lb_diachi_error";
            this.lb_diachi_error.Size = new System.Drawing.Size(417, 42);
            this.lb_diachi_error.TabIndex = 102;
            this.lb_diachi_error.Text = "Địa chỉ không hợp lệ";
            this.lb_diachi_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_diachi_error.Visible = false;
            // 
            // lb_tenkh_error
            // 
            this.lb_tenkh_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_tenkh_error.ForeColor = System.Drawing.Color.Red;
            this.lb_tenkh_error.Location = new System.Drawing.Point(46, 474);
            this.lb_tenkh_error.Name = "lb_tenkh_error";
            this.lb_tenkh_error.Size = new System.Drawing.Size(417, 42);
            this.lb_tenkh_error.TabIndex = 98;
            this.lb_tenkh_error.Text = "Tên khách hàng không hợp lệ";
            this.lb_tenkh_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_tenkh_error.Visible = false;
            // 
            // tb_dia_chi
            // 
            this.tb_dia_chi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dia_chi.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_dia_chi.Location = new System.Drawing.Point(49, 418);
            this.tb_dia_chi.Name = "tb_dia_chi";
            this.tb_dia_chi.Size = new System.Drawing.Size(414, 44);
            this.tb_dia_chi.TabIndex = 97;
            // 
            // tb_phone
            // 
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_phone.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_phone.Location = new System.Drawing.Point(49, 336);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(414, 44);
            this.tb_phone.TabIndex = 96;
            // 
            // tb_makh
            // 
            this.tb_makh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_makh.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_makh.Location = new System.Drawing.Point(50, 129);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.ReadOnly = true;
            this.tb_makh.Size = new System.Drawing.Size(414, 44);
            this.tb_makh.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(43, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 32);
            this.label4.TabIndex = 94;
            this.label4.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(44, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 32);
            this.label6.TabIndex = 92;
            this.label6.Text = "Giới tính";
            // 
            // Radio_Nu
            // 
            this.Radio_Nu.AutoSize = true;
            this.Radio_Nu.Font = new System.Drawing.Font("Arial", 11F);
            this.Radio_Nu.Location = new System.Drawing.Point(311, 259);
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
            this.Radio_Nam.Location = new System.Drawing.Point(221, 259);
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
            this.label3.Location = new System.Drawing.Point(44, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 89;
            this.label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(44, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 32);
            this.label5.TabIndex = 87;
            this.label5.Text = "Ngày sinh";
            // 
            // date_kh
            // 
            this.date_kh.CalendarFont = new System.Drawing.Font("Arial", 16F);
            this.date_kh.CustomFormat = "dd/MM/yyyy";
            this.date_kh.Font = new System.Drawing.Font("Arial", 16F);
            this.date_kh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_kh.Location = new System.Drawing.Point(50, 206);
            this.date_kh.Name = "date_kh";
            this.date_kh.Size = new System.Drawing.Size(325, 44);
            this.date_kh.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 84;
            this.label1.Text = "Mã khách hàng";
            // 
            // tb_ten_kh
            // 
            this.tb_ten_kh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ten_kh.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_ten_kh.Location = new System.Drawing.Point(49, 55);
            this.tb_ten_kh.Name = "tb_ten_kh";
            this.tb_ten_kh.Size = new System.Drawing.Size(414, 44);
            this.tb_ten_kh.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên khách hàng";
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
            this.btnHuy.Location = new System.Drawing.Point(267, 584);
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
            this.btn_luu_customer.Location = new System.Drawing.Point(404, 584);
            this.btn_luu_customer.Name = "btn_luu_customer";
            this.btn_luu_customer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btn_luu_customer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_luu_customer.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_luu_customer.OnHoverImage = null;
            this.btn_luu_customer.OnPressedColor = System.Drawing.Color.Black;
            this.btn_luu_customer.Radius = 5;
            this.btn_luu_customer.Size = new System.Drawing.Size(136, 47);
            this.btn_luu_customer.TabIndex = 7;
            this.btn_luu_customer.Text = "Lưu";
            this.btn_luu_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_luu_customer.Click += new System.EventHandler(this.btn_luu_customer_Click_1);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
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
            this.btnExit.Location = new System.Drawing.Point(521, 12);
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
            this.gunaLabel1.Location = new System.Drawing.Point(148, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(290, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Thay đổi thông tin";
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
            this.pnTitle.Size = new System.Drawing.Size(568, 61);
            this.pnTitle.TabIndex = 4;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(568, 717);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_gioitinh_error;
        private System.Windows.Forms.Label lb_SDT_error;
        private System.Windows.Forms.Label lb_diachi_error;
        private System.Windows.Forms.Label lb_tenkh_error;
        private System.Windows.Forms.TextBox tb_dia_chi;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_makh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Radio_Nu;
        private System.Windows.Forms.RadioButton Radio_Nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_kh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ten_kh;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnHuy;
        private Guna.UI.WinForms.GunaButton btn_luu_customer;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel pnTitle;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDragControl dragPnTitle;
    }
}