namespace QLCH_UI
{
    partial class InfoCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoCustomer));
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.icExit = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_makh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_tenkh.Location = new System.Drawing.Point(229, 188);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(160, 30);
            this.lb_tenkh.TabIndex = 99;
            this.lb_tenkh.Text = "tên khách hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(100)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.icExit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 69);
            this.panel1.TabIndex = 92;
            // 
            // icExit
            // 
            this.icExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(100)))), ((int)(((byte)(207)))));
            this.icExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icExit.BackgroundImage")));
            this.icExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icExit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icExit.IconColor = System.Drawing.SystemColors.ControlText;
            this.icExit.IconSize = 48;
            this.icExit.Location = new System.Drawing.Point(873, 9);
            this.icExit.Name = "icExit";
            this.icExit.Size = new System.Drawing.Size(48, 48);
            this.icExit.TabIndex = 106;
            this.icExit.TabStop = false;
            this.icExit.Click += new System.EventHandler(this.icExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(300, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 45);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thông tin khách hàng";
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_SDT.Location = new System.Drawing.Point(229, 257);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(137, 30);
            this.lb_SDT.TabIndex = 101;
            this.lb_SDT.Text = "số điện thoại";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_ngaysinh.Location = new System.Drawing.Point(785, 113);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(104, 30);
            this.lb_ngaysinh.TabIndex = 100;
            this.lb_ngaysinh.Text = "ngày sinh";
            // 
            // lb_makh
            // 
            this.lb_makh.AutoSize = true;
            this.lb_makh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_makh.Location = new System.Drawing.Point(229, 113);
            this.lb_makh.Name = "lb_makh";
            this.lb_makh.Size = new System.Drawing.Size(159, 30);
            this.lb_makh.TabIndex = 98;
            this.lb_makh.Text = "mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 32);
            this.label4.TabIndex = 97;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 95;
            this.label3.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 94;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 93;
            this.label2.Text = "Mã khách hàng";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_gioitinh.Location = new System.Drawing.Point(785, 190);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(91, 30);
            this.lb_gioitinh.TabIndex = 103;
            this.lb_gioitinh.Text = "giới tính";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(625, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 32);
            this.label11.TabIndex = 102;
            this.label11.Text = "Giới tính";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_diachi.Location = new System.Drawing.Point(229, 323);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(75, 30);
            this.lb_diachi.TabIndex = 105;
            this.lb_diachi.Text = "địa chỉ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 32);
            this.label13.TabIndex = 104;
            this.label13.Text = "Địa chỉ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label14.Location = new System.Drawing.Point(229, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 30);
            this.label14.TabIndex = 107;
            this.label14.Text = "doanh thu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 32);
            this.label15.TabIndex = 106;
            this.label15.Text = "Doanh thu";
            // 
            // InfoCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(933, 456);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lb_diachi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lb_gioitinh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_tenkh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_SDT);
            this.Controls.Add(this.lb_ngaysinh);
            this.Controls.Add(this.lb_makh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tenkh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label lb_makh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconPictureBox icExit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}