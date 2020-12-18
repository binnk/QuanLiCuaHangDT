namespace QLCH_UI
{
    public partial class MainTechnicianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTechnicianForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLinhKien = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSuaChua = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnTongQuan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelMenu.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(258, 145);
            this.panel1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnExit.IconSize = 32;
            this.btnExit.Location = new System.Drawing.Point(1546, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimize.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnMinimize.IconSize = 32;
            this.btnMinimize.Location = new System.Drawing.Point(1470, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximize.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnMaximize.IconSize = 32;
            this.btnMaximize.Location = new System.Drawing.Point(1508, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Rotation = 0D;
            this.btnMaximize.Size = new System.Drawing.Size(32, 32);
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.btnLinhKien);
            this.panelMenu.Controls.Add(this.btnSuaChua);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnTongQuan);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(258, 853);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnLinhKien
            // 
            this.btnLinhKien.AnimationHoverSpeed = 0.07F;
            this.btnLinhKien.AnimationSpeed = 0.03F;
            this.btnLinhKien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnLinhKien.BorderColor = System.Drawing.Color.Black;
            this.btnLinhKien.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnLinhKien.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnLinhKien.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLinhKien.CheckedForeColor = System.Drawing.Color.White;
            this.btnLinhKien.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLinhKien.CheckedImage")));
            this.btnLinhKien.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLinhKien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLinhKien.FocusedColor = System.Drawing.Color.Empty;
            this.btnLinhKien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLinhKien.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLinhKien.Image = ((System.Drawing.Image)(resources.GetObject("btnLinhKien.Image")));
            this.btnLinhKien.ImageOffsetX = 4;
            this.btnLinhKien.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLinhKien.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLinhKien.Location = new System.Drawing.Point(38, 382);
            this.btnLinhKien.Name = "btnLinhKien";
            this.btnLinhKien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnLinhKien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLinhKien.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLinhKien.OnHoverImage = null;
            this.btnLinhKien.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLinhKien.OnPressedColor = System.Drawing.Color.Black;
            this.btnLinhKien.Size = new System.Drawing.Size(180, 64);
            this.btnLinhKien.TabIndex = 8;
            this.btnLinhKien.Text = "Linh kiện";
            this.btnLinhKien.Click += new System.EventHandler(this.btnLinhKien_Click);
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.AnimationHoverSpeed = 0.07F;
            this.btnSuaChua.AnimationSpeed = 0.03F;
            this.btnSuaChua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnSuaChua.BorderColor = System.Drawing.Color.Black;
            this.btnSuaChua.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnSuaChua.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnSuaChua.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSuaChua.CheckedForeColor = System.Drawing.Color.White;
            this.btnSuaChua.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSuaChua.CheckedImage")));
            this.btnSuaChua.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSuaChua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaChua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaChua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSuaChua.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaChua.Image")));
            this.btnSuaChua.ImageOffsetX = 4;
            this.btnSuaChua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSuaChua.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSuaChua.Location = new System.Drawing.Point(38, 292);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnSuaChua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaChua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaChua.OnHoverImage = null;
            this.btnSuaChua.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSuaChua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaChua.Size = new System.Drawing.Size(180, 64);
            this.btnSuaChua.TabIndex = 7;
            this.btnSuaChua.Text = "Sửa chữa";
            this.btnSuaChua.Click += new System.EventHandler(this.btnSuaChua_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.AnimationHoverSpeed = 0.07F;
            this.btnTongQuan.AnimationSpeed = 0.03F;
            this.btnTongQuan.BaseColor = System.Drawing.Color.Empty;
            this.btnTongQuan.BorderColor = System.Drawing.Color.Black;
            this.btnTongQuan.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnTongQuan.Checked = true;
            this.btnTongQuan.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnTongQuan.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTongQuan.CheckedForeColor = System.Drawing.Color.White;
            this.btnTongQuan.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnTongQuan.CheckedImage")));
            this.btnTongQuan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTongQuan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTongQuan.FocusedColor = System.Drawing.Color.Empty;
            this.btnTongQuan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTongQuan.ForeColor = System.Drawing.Color.DarkGray;
            this.btnTongQuan.Image = ((System.Drawing.Image)(resources.GetObject("btnTongQuan.Image")));
            this.btnTongQuan.ImageOffsetX = 4;
            this.btnTongQuan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTongQuan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTongQuan.Location = new System.Drawing.Point(38, 201);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnTongQuan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTongQuan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTongQuan.OnHoverImage = null;
            this.btnTongQuan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTongQuan.OnPressedColor = System.Drawing.Color.Black;
            this.btnTongQuan.Size = new System.Drawing.Size(180, 64);
            this.btnTongQuan.TabIndex = 4;
            this.btnTongQuan.Text = "Tổng quan";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panelChildForm);
            this.bunifuGradientPanel1.Controls.Add(this.gunaPanel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(258, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1593, 853);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 71);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1593, 782);
            this.panelChildForm.TabIndex = 13;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btnMaximize);
            this.gunaPanel1.Controls.Add(this.btnMinimize);
            this.gunaPanel1.Controls.Add(this.btnExit);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1593, 71);
            this.gunaPanel1.TabIndex = 12;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.gunaPanel1;
            // 
            // MainTechnicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1851, 853);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainTechnicianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI.WinForms.GunaAdvenceButton btnTongQuan;
        private Guna.UI.WinForms.GunaAdvenceButton btnLinhKien;
        private Guna.UI.WinForms.GunaAdvenceButton btnSuaChua;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

