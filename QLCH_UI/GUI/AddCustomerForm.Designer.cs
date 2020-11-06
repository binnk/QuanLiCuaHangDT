namespace QLCH_UI.GUI
{
    partial class AddCustomerForm
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
            this.cbxGtinh = new System.Windows.Forms.ComboBox();
            this.lbGtinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.tbxTenKH = new System.Windows.Forms.TextBox();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbNgSinh = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbNgSinh);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.tbxDiaChi);
            this.panel1.Controls.Add(this.lbDiaChi);
            this.panel1.Controls.Add(this.cbxGtinh);
            this.panel1.Controls.Add(this.lbGtinh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxSDT);
            this.panel1.Controls.Add(this.lbSDT);
            this.panel1.Controls.Add(this.tbxTenKH);
            this.panel1.Controls.Add(this.lbTenKH);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 395);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbxGtinh
            // 
            this.cbxGtinh.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxGtinh.FormattingEnabled = true;
            this.cbxGtinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbxGtinh.Location = new System.Drawing.Point(247, 147);
            this.cbxGtinh.Name = "cbxGtinh";
            this.cbxGtinh.Size = new System.Drawing.Size(99, 40);
            this.cbxGtinh.TabIndex = 10;
            // 
            // lbGtinh
            // 
            this.lbGtinh.AutoSize = true;
            this.lbGtinh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGtinh.Location = new System.Drawing.Point(243, 123);
            this.lbGtinh.Name = "lbGtinh";
            this.lbGtinh.Size = new System.Drawing.Size(85, 23);
            this.lbGtinh.TabIndex = 9;
            this.lbGtinh.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 8;
            // 
            // tbxSDT
            // 
            this.tbxSDT.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxSDT.Location = new System.Drawing.Point(24, 233);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(191, 40);
            this.tbxSDT.TabIndex = 7;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(20, 207);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(124, 23);
            this.lbSDT.TabIndex = 6;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // tbxTenKH
            // 
            this.tbxTenKH.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenKH.ForeColor = System.Drawing.Color.Black;
            this.tbxTenKH.Location = new System.Drawing.Point(24, 70);
            this.tbxTenKH.Name = "tbxTenKH";
            this.tbxTenKH.Size = new System.Drawing.Size(322, 40);
            this.tbxTenKH.TabIndex = 5;
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.Location = new System.Drawing.Point(20, 44);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(148, 23);
            this.lbTenKH.TabIndex = 4;
            this.lbTenKH.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm khách hàng";
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiaChi.Location = new System.Drawing.Point(24, 309);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(322, 40);
            this.tbxDiaChi.TabIndex = 12;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(20, 283);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(69, 23);
            this.lbDiaChi.TabIndex = 11;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 14F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 40);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // lbNgSinh
            // 
            this.lbNgSinh.AutoSize = true;
            this.lbNgSinh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgSinh.Location = new System.Drawing.Point(20, 123);
            this.lbNgSinh.Name = "lbNgSinh";
            this.lbNgSinh.Size = new System.Drawing.Size(95, 23);
            this.lbNgSinh.TabIndex = 14;
            this.lbNgSinh.Text = "Ngày sinh";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(125)))), ((int)(((byte)(231)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(273, 498);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 47);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(125)))), ((int)(((byte)(231)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(153, 498);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(124, 47);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(411, 582);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomerForm";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxGtinh;
        private System.Windows.Forms.Label lbGtinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox tbxTenKH;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNgSinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}