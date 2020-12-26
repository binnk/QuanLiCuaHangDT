namespace QLCH_UI
{
    partial class InfoProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoProduct));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.dragPnTitle = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnTitle = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_giasp = new System.Windows.Forms.Label();
            this.lb_loaisp = new System.Windows.Forms.Label();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.lb_masp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnExit.IconSize = 32;
            this.btnExit.Location = new System.Drawing.Point(1046, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
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
            this.pnTitle.Size = new System.Drawing.Size(1093, 61);
            this.pnTitle.TabIndex = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(425, 7);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(313, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Thông tin sản phẩm";
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
            this.gunaLinePanel1.Controls.Add(this.gunaLinePanel2);
            this.gunaLinePanel1.Controls.Add(this.lb_giasp);
            this.gunaLinePanel1.Controls.Add(this.lb_loaisp);
            this.gunaLinePanel1.Controls.Add(this.lb_tensp);
            this.gunaLinePanel1.Controls.Add(this.lb_masp);
            this.gunaLinePanel1.Controls.Add(this.label4);
            this.gunaLinePanel1.Controls.Add(this.label3);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Controls.Add(this.label2);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 6;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gunaLinePanel1.LineLeft = 4;
            this.gunaLinePanel1.LineRight = 6;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 61);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1093, 498);
            this.gunaLinePanel1.TabIndex = 11;
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
            this.gunaLinePanel2.Location = new System.Drawing.Point(731, 43);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(310, 413);
            this.gunaLinePanel2.TabIndex = 131;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // lb_giasp
            // 
            this.lb_giasp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_giasp.Location = new System.Drawing.Point(262, 316);
            this.lb_giasp.Name = "lb_giasp";
            this.lb_giasp.Size = new System.Drawing.Size(463, 31);
            this.lb_giasp.TabIndex = 130;
            this.lb_giasp.Text = "giá sản phẩm";
            // 
            // lb_loaisp
            // 
            this.lb_loaisp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_loaisp.Location = new System.Drawing.Point(262, 249);
            this.lb_loaisp.Name = "lb_loaisp";
            this.lb_loaisp.Size = new System.Drawing.Size(463, 31);
            this.lb_loaisp.TabIndex = 129;
            this.lb_loaisp.Text = "loại sản phẩm";
            // 
            // lb_tensp
            // 
            this.lb_tensp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_tensp.Location = new System.Drawing.Point(262, 178);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(463, 31);
            this.lb_tensp.TabIndex = 128;
            this.lb_tensp.Text = "tên sản phẩm";
            // 
            // lb_masp
            // 
            this.lb_masp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_masp.Location = new System.Drawing.Point(262, 103);
            this.lb_masp.Name = "lb_masp";
            this.lb_masp.Size = new System.Drawing.Size(463, 31);
            this.lb_masp.TabIndex = 127;
            this.lb_masp.Text = "mã sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 32);
            this.label4.TabIndex = 126;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 32);
            this.label3.TabIndex = 125;
            this.label3.Text = "Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 124;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 123;
            this.label2.Text = "Mã sản phẩm";
            // 
            // InfoProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1093, 559);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Arial", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoProduct";
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_giasp;
        private System.Windows.Forms.Label lb_loaisp;
        private System.Windows.Forms.Label lb_tensp;
        private System.Windows.Forms.Label lb_masp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaPanel pnTitle;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDragControl dragPnTitle;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}