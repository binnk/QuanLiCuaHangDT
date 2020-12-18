namespace QLCH_UI
{
    partial class fSelectEdit
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
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnThayDoi = new Guna.UI.WinForms.GunaButton();
            this.btnCapNhat = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.btnExit);
            this.gunaLinePanel1.Controls.Add(this.btnThayDoi);
            this.gunaLinePanel1.Controls.Add(this.btnCapNhat);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 6;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaLinePanel1.LineLeft = 6;
            this.gunaLinePanel1.LineRight = 6;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 6;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(397, 228);
            this.gunaLinePanel1.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(345, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(40, 26);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.AnimationHoverSpeed = 0.07F;
            this.btnThayDoi.AnimationSpeed = 0.03F;
            this.btnThayDoi.BackColor = System.Drawing.Color.Transparent;
            this.btnThayDoi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnThayDoi.BorderColor = System.Drawing.Color.Black;
            this.btnThayDoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThayDoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnThayDoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnThayDoi.Image = null;
            this.btnThayDoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThayDoi.Location = new System.Drawing.Point(43, 121);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnThayDoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThayDoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThayDoi.OnHoverImage = null;
            this.btnThayDoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnThayDoi.Radius = 10;
            this.btnThayDoi.Size = new System.Drawing.Size(310, 66);
            this.btnThayDoi.TabIndex = 9;
            this.btnThayDoi.Text = "Thay đổi thông tin";
            this.btnThayDoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AnimationHoverSpeed = 0.07F;
            this.btnCapNhat.AnimationSpeed = 0.03F;
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapNhat.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = null;
            this.btnCapNhat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapNhat.Location = new System.Drawing.Point(43, 43);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnCapNhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapNhat.OnHoverImage = null;
            this.btnCapNhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapNhat.Radius = 10;
            this.btnCapNhat.Size = new System.Drawing.Size(310, 66);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật trạng thái";
            this.btnCapNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // fSelectEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 228);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSelectEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fSelectEdit";
            this.gunaLinePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaButton btnThayDoi;
        private Guna.UI.WinForms.GunaButton btnCapNhat;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}