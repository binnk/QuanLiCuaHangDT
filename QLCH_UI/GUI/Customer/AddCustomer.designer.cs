namespace QLCH_UI
{
    partial class AddCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_luu_customer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_SDT_error = new System.Windows.Forms.Label();
            this.lb_diachi_error = new System.Windows.Forms.Label();
            this.lb_gioitinh_error = new System.Windows.Forms.Label();
            this.lb_makh_error = new System.Windows.Forms.Label();
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(100)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 69);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(143, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 45);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thêm khách hàng";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(254, 633);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 59);
            this.button2.TabIndex = 37;
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
            this.btn_luu_customer.Location = new System.Drawing.Point(398, 633);
            this.btn_luu_customer.Name = "btn_luu_customer";
            this.btn_luu_customer.Size = new System.Drawing.Size(136, 59);
            this.btn_luu_customer.TabIndex = 36;
            this.btn_luu_customer.Text = "Lưu";
            this.btn_luu_customer.UseVisualStyleBackColor = false;
            this.btn_luu_customer.Click += new System.EventHandler(this.btn_luu_customer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_SDT_error);
            this.groupBox1.Controls.Add(this.lb_diachi_error);
            this.groupBox1.Controls.Add(this.lb_gioitinh_error);
            this.groupBox1.Controls.Add(this.lb_makh_error);
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
            this.groupBox1.Location = new System.Drawing.Point(22, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 519);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // lb_SDT_error
            // 
            this.lb_SDT_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_SDT_error.ForeColor = System.Drawing.Color.Red;
            this.lb_SDT_error.Location = new System.Drawing.Point(45, 477);
            this.lb_SDT_error.Name = "lb_SDT_error";
            this.lb_SDT_error.Size = new System.Drawing.Size(417, 42);
            this.lb_SDT_error.TabIndex = 102;
            this.lb_SDT_error.Text = "Số điện thoại không hợp lệ";
            this.lb_SDT_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_SDT_error.Visible = false;
            // 
            // lb_diachi_error
            // 
            this.lb_diachi_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_diachi_error.ForeColor = System.Drawing.Color.Red;
            this.lb_diachi_error.Location = new System.Drawing.Point(45, 477);
            this.lb_diachi_error.Name = "lb_diachi_error";
            this.lb_diachi_error.Size = new System.Drawing.Size(417, 42);
            this.lb_diachi_error.TabIndex = 101;
            this.lb_diachi_error.Text = "Địa chỉ không hợp lệ";
            this.lb_diachi_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_diachi_error.Visible = false;
            // 
            // lb_gioitinh_error
            // 
            this.lb_gioitinh_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_gioitinh_error.ForeColor = System.Drawing.Color.Red;
            this.lb_gioitinh_error.Location = new System.Drawing.Point(45, 477);
            this.lb_gioitinh_error.Name = "lb_gioitinh_error";
            this.lb_gioitinh_error.Size = new System.Drawing.Size(417, 42);
            this.lb_gioitinh_error.TabIndex = 100;
            this.lb_gioitinh_error.Text = "Chọn giới tính";
            this.lb_gioitinh_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_gioitinh_error.Visible = false;
            // 
            // lb_makh_error
            // 
            this.lb_makh_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_makh_error.ForeColor = System.Drawing.Color.Red;
            this.lb_makh_error.Location = new System.Drawing.Point(47, 489);
            this.lb_makh_error.Name = "lb_makh_error";
            this.lb_makh_error.Size = new System.Drawing.Size(417, 42);
            this.lb_makh_error.TabIndex = 99;
            this.lb_makh_error.Text = "Mã khách hàng không hợp lệ";
            this.lb_makh_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_makh_error.Visible = false;
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(568, 717);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_luu_customer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_luu_customer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox tb_dia_chi;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_makh;
        private System.Windows.Forms.Label lb_tenkh_error;
        private System.Windows.Forms.Label lb_gioitinh_error;
        private System.Windows.Forms.Label lb_makh_error;
        private System.Windows.Forms.Label lb_SDT_error;
        private System.Windows.Forms.Label lb_diachi_error;
    }
}