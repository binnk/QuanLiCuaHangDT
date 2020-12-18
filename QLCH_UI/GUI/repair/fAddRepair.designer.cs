namespace QLCH_UI
{
    partial class fAddRepair
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
            this.pnTitle = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dragPnTitle = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.lb_fault = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CB_Loai = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.tb_Ghichu = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.Tb_Tenmay = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateTimePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.CB_gioitinh = new Guna.UI.WinForms.GunaComboBox();
            this.tb_Diachi = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.tb_SDT = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.tb_Hoten = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pnTitle.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.pnTitle.Controls.Add(this.btnExit);
            this.pnTitle.Controls.Add(this.gunaLabel1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(845, 61);
            this.pnTitle.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(798, 12);
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
            this.gunaLabel1.Location = new System.Drawing.Point(317, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(247, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Thêm thông tin";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // dragPnTitle
            // 
            this.dragPnTitle.TargetControl = this.pnTitle;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaLinePanel1.Controls.Add(this.gunaButton2);
            this.gunaLinePanel1.Controls.Add(this.lb_fault);
            this.gunaLinePanel1.Controls.Add(this.gunaButton1);
            this.gunaLinePanel1.Controls.Add(this.groupBox2);
            this.gunaLinePanel1.Controls.Add(this.groupBox1);
            this.gunaLinePanel1.LineBottom = 6;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gunaLinePanel1.LineLeft = 4;
            this.gunaLinePanel1.LineRight = 6;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 61);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(845, 584);
            this.gunaLinePanel1.TabIndex = 1;
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
            this.gunaButton2.Location = new System.Drawing.Point(486, 519);
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
            // lb_fault
            // 
            this.lb_fault.AutoSize = true;
            this.lb_fault.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lb_fault.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_fault.Location = new System.Drawing.Point(56, 519);
            this.lb_fault.Name = "lb_fault";
            this.lb_fault.Size = new System.Drawing.Size(55, 28);
            this.lb_fault.TabIndex = 4;
            this.lb_fault.Text = "Fault";
            this.lb_fault.Visible = false;
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
            this.gunaButton1.Location = new System.Drawing.Point(650, 519);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(136, 47);
            this.gunaButton1.TabIndex = 7;
            this.gunaButton1.Text = "Thêm";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.CB_Loai);
            this.groupBox2.Controls.Add(this.gunaLabel8);
            this.groupBox2.Controls.Add(this.tb_Ghichu);
            this.groupBox2.Controls.Add(this.gunaLabel5);
            this.groupBox2.Controls.Add(this.Tb_Tenmay);
            this.groupBox2.Controls.Add(this.gunaLabel7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(433, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 490);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sửa chữa";
            // 
            // CB_Loai
            // 
            this.CB_Loai.BackColor = System.Drawing.Color.Transparent;
            this.CB_Loai.BaseColor = System.Drawing.Color.White;
            this.CB_Loai.BorderColor = System.Drawing.Color.Silver;
            this.CB_Loai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Loai.FocusedColor = System.Drawing.Color.Empty;
            this.CB_Loai.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.CB_Loai.ForeColor = System.Drawing.Color.Gray;
            this.CB_Loai.FormattingEnabled = true;
            this.CB_Loai.ItemHeight = 35;
            this.CB_Loai.Items.AddRange(new object[] {
            "Laptop",
            "Dienthoai",
            "Khac"});
            this.CB_Loai.Location = new System.Drawing.Point(36, 166);
            this.CB_Loai.Name = "CB_Loai";
            this.CB_Loai.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.CB_Loai.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CB_Loai.Size = new System.Drawing.Size(317, 41);
            this.CB_Loai.TabIndex = 7;
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
            // tb_Ghichu
            // 
            this.tb_Ghichu.BaseColor = System.Drawing.Color.White;
            this.tb_Ghichu.BorderColor = System.Drawing.Color.Silver;
            this.tb_Ghichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Ghichu.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_Ghichu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.tb_Ghichu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Ghichu.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.tb_Ghichu.Location = new System.Drawing.Point(36, 298);
            this.tb_Ghichu.Multiline = true;
            this.tb_Ghichu.Name = "tb_Ghichu";
            this.tb_Ghichu.PasswordChar = '\0';
            this.tb_Ghichu.SelectedText = "";
            this.tb_Ghichu.Size = new System.Drawing.Size(316, 186);
            this.tb_Ghichu.TabIndex = 5;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(33, 247);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(82, 28);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Ghi chú";
            // 
            // Tb_Tenmay
            // 
            this.Tb_Tenmay.BaseColor = System.Drawing.Color.White;
            this.Tb_Tenmay.BorderColor = System.Drawing.Color.Silver;
            this.Tb_Tenmay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tb_Tenmay.FocusedBaseColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tb_Tenmay.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.Tb_Tenmay.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Tb_Tenmay.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.Tb_Tenmay.Location = new System.Drawing.Point(37, 80);
            this.Tb_Tenmay.Name = "Tb_Tenmay";
            this.Tb_Tenmay.PasswordChar = '\0';
            this.Tb_Tenmay.SelectedText = "";
            this.Tb_Tenmay.Size = new System.Drawing.Size(316, 45);
            this.Tb_Tenmay.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.DateTimePicker);
            this.groupBox1.Controls.Add(this.CB_gioitinh);
            this.groupBox1.Controls.Add(this.tb_Diachi);
            this.groupBox1.Controls.Add(this.gunaLabel9);
            this.groupBox1.Controls.Add(this.gunaLabel6);
            this.groupBox1.Controls.Add(this.gunaLabel4);
            this.groupBox1.Controls.Add(this.tb_SDT);
            this.groupBox1.Controls.Add(this.gunaLabel3);
            this.groupBox1.Controls.Add(this.tb_Hoten);
            this.groupBox1.Controls.Add(this.gunaLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 490);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.BaseColor = System.Drawing.Color.White;
            this.DateTimePicker.BorderColor = System.Drawing.Color.Silver;
            this.DateTimePicker.CustomFormat = null;
            this.DateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.ForeColor = System.Drawing.Color.Gray;
            this.DateTimePicker.Location = new System.Drawing.Point(35, 254);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateTimePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker.OnPressedColor = System.Drawing.Color.Black;
            this.DateTimePicker.Size = new System.Drawing.Size(317, 40);
            this.DateTimePicker.TabIndex = 8;
            this.DateTimePicker.Text = "Thursday, December 17, 2020";
            this.DateTimePicker.Value = new System.DateTime(2020, 12, 17, 17, 37, 55, 262);
            // 
            // CB_gioitinh
            // 
            this.CB_gioitinh.BackColor = System.Drawing.Color.Transparent;
            this.CB_gioitinh.BaseColor = System.Drawing.Color.White;
            this.CB_gioitinh.BorderColor = System.Drawing.Color.Silver;
            this.CB_gioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_gioitinh.FocusedColor = System.Drawing.Color.Empty;
            this.CB_gioitinh.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.CB_gioitinh.ForeColor = System.Drawing.Color.Gray;
            this.CB_gioitinh.FormattingEnabled = true;
            this.CB_gioitinh.ItemHeight = 35;
            this.CB_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.CB_gioitinh.Location = new System.Drawing.Point(33, 344);
            this.CB_gioitinh.Name = "CB_gioitinh";
            this.CB_gioitinh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.CB_gioitinh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CB_gioitinh.Size = new System.Drawing.Size(317, 41);
            this.CB_gioitinh.TabIndex = 7;
            // 
            // tb_Diachi
            // 
            this.tb_Diachi.BaseColor = System.Drawing.Color.White;
            this.tb_Diachi.BorderColor = System.Drawing.Color.Silver;
            this.tb_Diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Diachi.FocusedBaseColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Diachi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.tb_Diachi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Diachi.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.tb_Diachi.Location = new System.Drawing.Point(34, 436);
            this.tb_Diachi.Name = "tb_Diachi";
            this.tb_Diachi.PasswordChar = '\0';
            this.tb_Diachi.SelectedText = "";
            this.tb_Diachi.Size = new System.Drawing.Size(316, 45);
            this.tb_Diachi.TabIndex = 5;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel9.Location = new System.Drawing.Point(30, 223);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(103, 28);
            this.gunaLabel9.TabIndex = 4;
            this.gunaLabel9.Text = "Ngày sinh";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel6.Location = new System.Drawing.Point(34, 313);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(94, 28);
            this.gunaLabel6.TabIndex = 4;
            this.gunaLabel6.Text = "Giới Tính";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(34, 405);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(73, 28);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Địa chỉ";
            // 
            // tb_SDT
            // 
            this.tb_SDT.BaseColor = System.Drawing.Color.White;
            this.tb_SDT.BorderColor = System.Drawing.Color.Silver;
            this.tb_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SDT.FocusedBaseColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_SDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.tb_SDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_SDT.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.tb_SDT.Location = new System.Drawing.Point(35, 166);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.PasswordChar = '\0';
            this.tb_SDT.SelectedText = "";
            this.tb_SDT.Size = new System.Drawing.Size(316, 45);
            this.tb_SDT.TabIndex = 3;
            this.tb_SDT.TextChanged += new System.EventHandler(this.tb_SDT_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel3.Location = new System.Drawing.Point(30, 135);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(133, 28);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Số điện thoại";
            // 
            // tb_Hoten
            // 
            this.tb_Hoten.BaseColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Hoten.BorderColor = System.Drawing.Color.Silver;
            this.tb_Hoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Hoten.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_Hoten.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.tb_Hoten.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Hoten.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.tb_Hoten.Location = new System.Drawing.Point(35, 80);
            this.tb_Hoten.Name = "tb_Hoten";
            this.tb_Hoten.PasswordChar = '\0';
            this.tb_Hoten.SelectedText = "";
            this.tb_Hoten.Size = new System.Drawing.Size(316, 45);
            this.tb_Hoten.TabIndex = 1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(30, 49);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(75, 28);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Họ tên";
            // 
            // fAddRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(845, 651);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.pnTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddRepair";
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnTitle;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaDragControl dragPnTitle;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaTextBox tb_Diachi;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox tb_SDT;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox tb_Hoten;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaTextBox tb_Ghichu;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox Tb_Tenmay;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaComboBox CB_Loai;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel lb_fault;
        private Guna.UI.WinForms.GunaComboBox CB_gioitinh;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaDateTimePicker DateTimePicker;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
    }
}