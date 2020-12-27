namespace LoginUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lCreateAcc = new System.Windows.Forms.LinkLabel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(43, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(43, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 6;
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPass.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.ForeColor = System.Drawing.Color.White;
            this.textPass.HideSelection = false;
            this.textPass.Location = new System.Drawing.Point(88, 195);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(251, 26);
            this.textPass.TabIndex = 1;
            this.textPass.Text = "Password";
            this.textPass.Click += new System.EventHandler(this.textPass_Click);
            this.textPass.Enter += new System.EventHandler(this.textPass_Enter);
            this.textPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textPass_KeyUp);
            this.textPass.Leave += new System.EventHandler(this.textPass_Leave);
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.ForeColor = System.Drawing.Color.White;
            this.textUser.HideSelection = false;
            this.textUser.Location = new System.Drawing.Point(88, 122);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(251, 26);
            this.textUser.TabIndex = 0;
            this.textUser.Text = "Username";
            this.textUser.Click += new System.EventHandler(this.textUser_Click);
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            this.textUser.Enter += new System.EventHandler(this.textUser_Enter);
            this.textUser.Leave += new System.EventHandler(this.textUser_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogin.Location = new System.Drawing.Point(39, 298);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 55);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(60, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Not registered?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lCreateAcc
            // 
            this.lCreateAcc.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lCreateAcc.AutoSize = true;
            this.lCreateAcc.LinkColor = System.Drawing.Color.SteelBlue;
            this.lCreateAcc.Location = new System.Drawing.Point(182, 373);
            this.lCreateAcc.Name = "lCreateAcc";
            this.lCreateAcc.Size = new System.Drawing.Size(140, 20);
            this.lCreateAcc.TabIndex = 13;
            this.lCreateAcc.Text = "Create an account";
            this.lCreateAcc.VisitedLinkColor = System.Drawing.Color.White;
            this.lCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lCreateAcc_LinkClicked);
            // 
            // picUser
            // 
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUser.ErrorImage = null;
            this.picUser.Location = new System.Drawing.Point(43, 116);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(32, 32);
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // picPass
            // 
            this.picPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPass.BackgroundImage")));
            this.picPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPass.Location = new System.Drawing.Point(43, 191);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(32, 32);
            this.picPass.TabIndex = 4;
            this.picPass.TabStop = false;
            // 
            // xLabel
            // 
            this.xLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.xLabel.Location = new System.Drawing.Point(345, 9);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(24, 28);
            this.xLabel.TabIndex = 15;
            this.xLabel.Text = "X";
            this.xLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.xLabel.Click += new System.EventHandler(this.xLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(39, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "username or password incorect\r\n";
            this.label2.Visible = false;
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogin.BackgroundImage")));
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogin.Location = new System.Drawing.Point(132, 12);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(116, 64);
            this.picLogin.TabIndex = 0;
            this.picLogin.TabStop = false;
            this.picLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLogin_MouseDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(381, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.lCreateAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.picLogin);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lCreateAcc;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLogin;
    }
}

