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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_luu_customer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(100)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 69);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(403, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 45);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thêm sản phẩm";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(53, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 470);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // lb_masp_error
            // 
            this.lb_masp_error.Font = new System.Drawing.Font("Arial", 10F);
            this.lb_masp_error.ForeColor = System.Drawing.Color.Red;
            this.lb_masp_error.Location = new System.Drawing.Point(47, 420);
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
            this.tb_gianhap.Location = new System.Drawing.Point(50, 291);
            this.tb_gianhap.Name = "tb_gianhap";
            this.tb_gianhap.Size = new System.Drawing.Size(414, 44);
            this.tb_gianhap.TabIndex = 104;
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
            this.lb_tensp_error.Location = new System.Drawing.Point(43, 420);
            this.lb_tensp_error.Name = "lb_tensp_error";
            this.lb_tensp_error.Size = new System.Drawing.Size(417, 42);
            this.lb_tensp_error.TabIndex = 98;
            this.lb_tensp_error.Text = "Tên sản phẩm không hợp lệ";
            this.lb_tensp_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_tensp_error.Visible = false;
            this.lb_tensp_error.Click += new System.EventHandler(this.lb_tensp_error_Click);
            // 
            // tb_masp
            // 
            this.tb_masp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_masp.Font = new System.Drawing.Font("Arial", 16F);
            this.tb_masp.Location = new System.Drawing.Point(50, 129);
            this.tb_masp.Name = "tb_masp";
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
            this.lb_giaban_error.Location = new System.Drawing.Point(41, 420);
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
            this.lb_gianhap_error.Location = new System.Drawing.Point(47, 420);
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
            this.lb_loaisp_error.Location = new System.Drawing.Point(47, 420);
            this.lb_loaisp_error.Name = "lb_loaisp_error";
            this.lb_loaisp_error.Size = new System.Drawing.Size(417, 42);
            this.lb_loaisp_error.TabIndex = 110;
            this.lb_loaisp_error.Text = "Chọn loại sản phẩm";
            this.lb_loaisp_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_loaisp_error.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(646, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 59);
            this.button2.TabIndex = 42;
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
            this.btn_luu_customer.Location = new System.Drawing.Point(790, 597);
            this.btn_luu_customer.Name = "btn_luu_customer";
            this.btn_luu_customer.Size = new System.Drawing.Size(136, 59);
            this.btn_luu_customer.TabIndex = 41;
            this.btn_luu_customer.Text = "Lưu";
            this.btn_luu_customer.UseVisualStyleBackColor = false;
            this.btn_luu_customer.Click += new System.EventHandler(this.btn_luu_customer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(729, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 32);
            this.label11.TabIndex = 109;
            this.label11.Text = "Thêm ảnh";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(646, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1014, 682);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_luu_customer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_tensp_error;
        private System.Windows.Forms.TextBox tb_masp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ten_sp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_giaban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_gianhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_luu_customer;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_loaisp;
        private System.Windows.Forms.Label lb_masp_error;
        private System.Windows.Forms.Label lb_loaisp_error;
        private System.Windows.Forms.Label lb_gianhap_error;
        private System.Windows.Forms.Label lb_giaban_error;
    }
}