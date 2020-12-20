namespace QLCH_UI
{
    partial class UC_ItemOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lb_trigia = new Guna.UI.WinForms.GunaLabel();
            this.lb_makh = new Guna.UI.WinForms.GunaLabel();
            this.lb_manv = new Guna.UI.WinForms.GunaLabel();
            this.lb_ngayhd = new Guna.UI.WinForms.GunaLabel();
            this.lb_madh = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lb_trigia);
            this.gunaLinePanel1.Controls.Add(this.lb_makh);
            this.gunaLinePanel1.Controls.Add(this.lb_manv);
            this.gunaLinePanel1.Controls.Add(this.lb_ngayhd);
            this.gunaLinePanel1.Controls.Add(this.lb_madh);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1515, 50);
            this.gunaLinePanel1.TabIndex = 1;
            this.gunaLinePanel1.Click += new System.EventHandler(this.gunaLinePanel1_Click);
            this.gunaLinePanel1.MouseEnter += new System.EventHandler(this.gunaLinePanel1_MouseEnter);
            this.gunaLinePanel1.MouseLeave += new System.EventHandler(this.gunaLinePanel1_MouseLeave);
            // 
            // lb_trigia
            // 
            this.lb_trigia.AutoSize = true;
            this.lb_trigia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trigia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lb_trigia.Location = new System.Drawing.Point(1232, 15);
            this.lb_trigia.Name = "lb_trigia";
            this.lb_trigia.Size = new System.Drawing.Size(65, 25);
            this.lb_trigia.TabIndex = 11;
            this.lb_trigia.Text = "Trị giá";
            this.lb_trigia.Click += new System.EventHandler(this.gunaLabel7_Click);
            // 
            // lb_makh
            // 
            this.lb_makh.AutoSize = true;
            this.lb_makh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_makh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lb_makh.Location = new System.Drawing.Point(916, 14);
            this.lb_makh.Name = "lb_makh";
            this.lb_makh.Size = new System.Drawing.Size(143, 25);
            this.lb_makh.TabIndex = 10;
            this.lb_makh.Text = "Mã khách hàng";
            this.lb_makh.Click += new System.EventHandler(this.gunaLabel5_Click);
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lb_manv.Location = new System.Drawing.Point(615, 14);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(128, 25);
            this.lb_manv.TabIndex = 9;
            this.lb_manv.Text = "Mã nhân viên";
            this.lb_manv.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // lb_ngayhd
            // 
            this.lb_ngayhd.AutoSize = true;
            this.lb_ngayhd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayhd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lb_ngayhd.Location = new System.Drawing.Point(326, 14);
            this.lb_ngayhd.Name = "lb_ngayhd";
            this.lb_ngayhd.Size = new System.Drawing.Size(128, 25);
            this.lb_ngayhd.TabIndex = 8;
            this.lb_ngayhd.Text = "Ngày tạo đơn";
            this.lb_ngayhd.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // lb_madh
            // 
            this.lb_madh.AutoSize = true;
            this.lb_madh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lb_madh.Location = new System.Drawing.Point(90, 14);
            this.lb_madh.Name = "lb_madh";
            this.lb_madh.Size = new System.Drawing.Size(125, 25);
            this.lb_madh.TabIndex = 7;
            this.lb_madh.Text = "Mã đơn hàng";
            this.lb_madh.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // UC_ItemOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "UC_ItemOrder";
            this.Size = new System.Drawing.Size(1515, 51);
            this.MouseEnter += new System.EventHandler(this.UC_ItemOrder_MouseEnter);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel lb_trigia;
        private Guna.UI.WinForms.GunaLabel lb_makh;
        private Guna.UI.WinForms.GunaLabel lb_manv;
        private Guna.UI.WinForms.GunaLabel lb_ngayhd;
        private Guna.UI.WinForms.GunaLabel lb_madh;
    }
}
