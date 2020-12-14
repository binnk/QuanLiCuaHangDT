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
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.icBtnXoa = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel11.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel11.Location = new System.Drawing.Point(149, 5);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(129, 28);
            this.gunaLabel11.TabIndex = 8;
            this.gunaLabel11.Text = "Tên linh kiện";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(14, 5);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 28);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Mã LK";
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
            // 
            // UC_UI_DS_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.icBtnXoa);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.gunaLabel2);
            this.Name = "UC_UI_DS_Item";
            this.Size = new System.Drawing.Size(502, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private FontAwesome.Sharp.IconButton icBtnXoa;
    }
}
