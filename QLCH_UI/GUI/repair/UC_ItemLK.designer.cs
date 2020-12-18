namespace QLCH_UI
{
    partial class UC_UI_DS_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UI_DS_Item));
            this.lb_tenlk = new Guna.UI.WinForms.GunaLabel();
            this.lb_malk = new Guna.UI.WinForms.GunaLabel();
            this.icBtnXoa = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lb_tenlk
            // 
            this.lb_tenlk.AutoSize = true;
            this.lb_tenlk.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lb_tenlk.ForeColor = System.Drawing.Color.Black;
            this.lb_tenlk.Location = new System.Drawing.Point(149, 5);
            this.lb_tenlk.Name = "lb_tenlk";
            this.lb_tenlk.Size = new System.Drawing.Size(129, 28);
            this.lb_tenlk.TabIndex = 8;
            this.lb_tenlk.Text = "Tên linh kiện";
            // 
            // lb_malk
            // 
            this.lb_malk.AutoSize = true;
            this.lb_malk.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lb_malk.ForeColor = System.Drawing.Color.DimGray;
            this.lb_malk.Location = new System.Drawing.Point(14, 5);
            this.lb_malk.Name = "lb_malk";
            this.lb_malk.Size = new System.Drawing.Size(68, 28);
            this.lb_malk.TabIndex = 7;
            this.lb_malk.Text = "Mã LK";
            // 
            // icBtnXoa
            // 
            this.icBtnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icBtnXoa.BackgroundImage")));
            this.icBtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icBtnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.icBtnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icBtnXoa.IconColor = System.Drawing.Color.Black;
            this.icBtnXoa.IconSize = 16;
            this.icBtnXoa.Location = new System.Drawing.Point(450, 2);
            this.icBtnXoa.Name = "icBtnXoa";
            this.icBtnXoa.Rotation = 0D;
            this.icBtnXoa.Size = new System.Drawing.Size(32, 32);
            this.icBtnXoa.TabIndex = 26;
            this.icBtnXoa.UseVisualStyleBackColor = true;
            this.icBtnXoa.Click += new System.EventHandler(this.icBtnXoa_Click);
            // 
            // UC_UI_DS_Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.icBtnXoa);
            this.Controls.Add(this.lb_tenlk);
            this.Controls.Add(this.lb_malk);
            this.Name = "UC_UI_DS_Item";
            this.Size = new System.Drawing.Size(502, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lb_tenlk;
        private Guna.UI.WinForms.GunaLabel lb_malk;
        private FontAwesome.Sharp.IconButton icBtnXoa;
    }
}
