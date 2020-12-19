namespace QLCH_UI
{
    partial class fEditRepair
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
            this.dragPnTitle = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnTitle = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_loai = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.tb_ghichu = new Guna.UI.WinForms.GunaTextBox();
            this.lb_fault = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.tb_tenmay = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.lb_MD = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.pnTitle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.pnTitle.Size = new System.Drawing.Size(482, 61);
            this.pnTitle.TabIndex = 2;
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
            this.btnExit.Location = new System.Drawing.Point(435, 12);
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
            this.gunaLabel1.Location = new System.Drawing.Point(129, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(219, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Sửa thông tin";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.cb_loai);
            this.groupBox2.Controls.Add(this.gunaLabel8);
            this.groupBox2.Controls.Add(this.tb_ghichu);
            this.groupBox2.Controls.Add(this.lb_fault);
            this.groupBox2.Controls.Add(this.gunaLabel5);
            this.groupBox2.Controls.Add(this.tb_tenmay);
            this.groupBox2.Controls.Add(this.gunaLabel7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(41, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 436);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sửa chữa";
            // 
            // cb_loai
            // 
            this.cb_loai.BackColor = System.Drawing.Color.Transparent;
            this.cb_loai.BaseColor = System.Drawing.Color.White;
            this.cb_loai.BorderColor = System.Drawing.Color.Silver;
            this.cb_loai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loai.FocusedColor = System.Drawing.Color.Empty;
            this.cb_loai.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.cb_loai.ForeColor = System.Drawing.Color.Gray;
            this.cb_loai.FormattingEnabled = true;
            this.cb_loai.ItemHeight = 35;
            this.cb_loai.Items.AddRange(new object[] {
            "Laptop",
            "Dienthoai",
            "Khac"});
            this.cb_loai.Location = new System.Drawing.Point(36, 166);
            this.cb_loai.Name = "cb_loai";
            this.cb_loai.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cb_loai.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_loai.Size = new System.Drawing.Size(317, 41);
            this.cb_loai.TabIndex = 7;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel8.Location = new System.Drawing.Point(33, 135);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(49, 28);
            this.gunaLabel8.TabIndex = 6;
            this.gunaLabel8.Text = "Loại";
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.BaseColor = System.Drawing.Color.White;
            this.tb_ghichu.BorderColor = System.Drawing.Color.Silver;
            this.tb_ghichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ghichu.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_ghichu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.tb_ghichu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_ghichu.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.tb_ghichu.Location = new System.Drawing.Point(36, 281);
            this.tb_ghichu.Multiline = true;
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.PasswordChar = '\0';
            this.tb_ghichu.SelectedText = "";
            this.tb_ghichu.Size = new System.Drawing.Size(316, 90);
            this.tb_ghichu.TabIndex = 5;
            // 
            // lb_fault
            // 
            this.lb_fault.AutoSize = true;
            this.lb_fault.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lb_fault.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_fault.Location = new System.Drawing.Point(33, 391);
            this.lb_fault.Name = "lb_fault";
            this.lb_fault.Size = new System.Drawing.Size(82, 28);
            this.lb_fault.TabIndex = 4;
            this.lb_fault.Text = "Ghi chú";
            this.lb_fault.Visible = false;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(33, 250);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(82, 28);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Ghi chú";
            // 
            // tb_tenmay
            // 
            this.tb_tenmay.BaseColor = System.Drawing.Color.White;
            this.tb_tenmay.BorderColor = System.Drawing.Color.Silver;
            this.tb_tenmay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tenmay.FocusedBaseColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_tenmay.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.tb_tenmay.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_tenmay.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.tb_tenmay.Location = new System.Drawing.Point(37, 80);
            this.tb_tenmay.Name = "tb_tenmay";
            this.tb_tenmay.PasswordChar = '\0';
            this.tb_tenmay.SelectedText = "";
            this.tb_tenmay.Size = new System.Drawing.Size(316, 45);
            this.tb_tenmay.TabIndex = 1;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel7.Location = new System.Drawing.Point(32, 49);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(88, 28);
            this.gunaLabel7.TabIndex = 0;
            this.gunaLabel7.Text = "Tên máy";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(335, 487);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(136, 47);
            this.gunaButton1.TabIndex = 7;
            this.gunaButton1.Text = "Lưu";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(193, 487);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(136, 47);
            this.gunaButton2.TabIndex = 8;
            this.gunaButton2.Text = "Huỷ";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel9.Location = new System.Drawing.Point(45, 492);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(54, 32);
            this.gunaLabel9.TabIndex = 9;
            this.gunaLabel9.Text = "MĐ";
            // 
            // lb_MD
            // 
            this.lb_MD.AutoSize = true;
            this.lb_MD.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_MD.ForeColor = System.Drawing.Color.DimGray;
            this.lb_MD.Location = new System.Drawing.Point(102, 494);
            this.lb_MD.Name = "lb_MD";
            this.lb_MD.Size = new System.Drawing.Size(46, 30);
            this.lb_MD.TabIndex = 10;
            this.lb_MD.Text = "001";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaLinePanel1.Controls.Add(this.lb_MD);
            this.gunaLinePanel1.Controls.Add(this.gunaButton2);
            this.gunaLinePanel1.Controls.Add(this.gunaButton1);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel9);
            this.gunaLinePanel1.Controls.Add(this.groupBox2);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 6;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gunaLinePanel1.LineLeft = 4;
            this.gunaLinePanel1.LineRight = 6;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 61);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(482, 552);
            this.gunaLinePanel1.TabIndex = 3;
            // 
            // fEditRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(482, 613);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fEditRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEditRepair";
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDragControl dragPnTitle;
        private Guna.UI.WinForms.GunaPanel pnTitle;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel lb_MD;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaComboBox cb_loai;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox tb_ghichu;
        private Guna.UI.WinForms.GunaLabel lb_fault;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox tb_tenmay;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
    }
}