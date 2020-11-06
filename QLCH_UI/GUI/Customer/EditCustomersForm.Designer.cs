namespace QLCH_UI
{
    partial class EditCustomersForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ten_kh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_makh = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.date_kh = new System.Windows.Forms.DateTimePicker();
            this.lb_makh_customer_erro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Radio_Nam = new System.Windows.Forms.RadioButton();
            this.Radio_Nu = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_phone = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lb_sdt_customer_erro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_dia_chi = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_luu_customer = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.lb_tenkh_erro = new System.Windows.Forms.Label();
            this.lb_diachi_erro = new System.Windows.Forms.Label();
            this.lb_gioi_tinh_erro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khách hàng";
            // 
            // tb_ten_kh
            // 
            this.tb_ten_kh.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten_kh.Location = new System.Drawing.Point(45, 62);
            this.tb_ten_kh.Name = "tb_ten_kh";
            this.tb_ten_kh.Size = new System.Drawing.Size(340, 30);
            this.tb_ten_kh.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã khách hàng";
            // 
            // tb_makh
            // 
            this.tb_makh.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_makh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_makh.Location = new System.Drawing.Point(45, 193);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.ReadOnly = true;
            this.tb_makh.Size = new System.Drawing.Size(130, 30);
            this.tb_makh.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày sinh";
            // 
            // date_kh
            // 
            this.date_kh.Location = new System.Drawing.Point(248, 193);
            this.date_kh.Name = "date_kh";
            this.date_kh.Size = new System.Drawing.Size(312, 26);
            this.date_kh.TabIndex = 11;
            // 
            // lb_makh_customer_erro
            // 
            this.lb_makh_customer_erro.AutoSize = true;
            this.lb_makh_customer_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_makh_customer_erro.ForeColor = System.Drawing.Color.Red;
            this.lb_makh_customer_erro.Location = new System.Drawing.Point(40, 249);
            this.lb_makh_customer_erro.Name = "lb_makh_customer_erro";
            this.lb_makh_customer_erro.Size = new System.Drawing.Size(264, 25);
            this.lb_makh_customer_erro.TabIndex = 17;
            this.lb_makh_customer_erro.Text = "Mã khách hàng không hợp lệ";
            this.lb_makh_customer_erro.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giới tính";
            // 
            // Radio_Nam
            // 
            this.Radio_Nam.AutoSize = true;
            this.Radio_Nam.Location = new System.Drawing.Point(192, 299);
            this.Radio_Nam.Name = "Radio_Nam";
            this.Radio_Nam.Size = new System.Drawing.Size(67, 24);
            this.Radio_Nam.TabIndex = 19;
            this.Radio_Nam.TabStop = true;
            this.Radio_Nam.Text = "Nam";
            this.Radio_Nam.UseVisualStyleBackColor = true;
            // 
            // Radio_Nu
            // 
            this.Radio_Nu.AutoSize = true;
            this.Radio_Nu.Location = new System.Drawing.Point(331, 301);
            this.Radio_Nu.Name = "Radio_Nu";
            this.Radio_Nu.Size = new System.Drawing.Size(54, 24);
            this.Radio_Nu.TabIndex = 20;
            this.Radio_Nu.TabStop = true;
            this.Radio_Nu.Text = "Nữ";
            this.Radio_Nu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số điện thoại";
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.White;
            this.tb_phone.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_phone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(45, 440);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(340, 30);
            this.tb_phone.TabIndex = 22;
            this.tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_phone_KeyPress);
            // 
            // lb_sdt_customer_erro
            // 
            this.lb_sdt_customer_erro.AutoSize = true;
            this.lb_sdt_customer_erro.BackColor = System.Drawing.SystemColors.Control;
            this.lb_sdt_customer_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt_customer_erro.ForeColor = System.Drawing.Color.Red;
            this.lb_sdt_customer_erro.Location = new System.Drawing.Point(40, 492);
            this.lb_sdt_customer_erro.Name = "lb_sdt_customer_erro";
            this.lb_sdt_customer_erro.Size = new System.Drawing.Size(243, 25);
            this.lb_sdt_customer_erro.TabIndex = 23;
            this.lb_sdt_customer_erro.Text = "Số điện thoại không hợp lệ";
            this.lb_sdt_customer_erro.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Địa chỉ";
            // 
            // tb_dia_chi
            // 
            this.tb_dia_chi.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_dia_chi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dia_chi.Location = new System.Drawing.Point(45, 583);
            this.tb_dia_chi.Name = "tb_dia_chi";
            this.tb_dia_chi.Size = new System.Drawing.Size(340, 30);
            this.tb_dia_chi.TabIndex = 25;
            // 
            // btn_luu_customer
            // 
            this.btn_luu_customer.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu_customer.Location = new System.Drawing.Point(45, 677);
            this.btn_luu_customer.Name = "btn_luu_customer";
            this.btn_luu_customer.Size = new System.Drawing.Size(136, 59);
            this.btn_luu_customer.TabIndex = 26;
            this.btn_luu_customer.Text = "Lưu";
            this.btn_luu_customer.UseVisualStyleBackColor = true;
            this.btn_luu_customer.Click += new System.EventHandler(this.btn_luu_customer_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(247, 677);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(138, 59);
            this.btn_huy.TabIndex = 27;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_tenkh_erro
            // 
            this.lb_tenkh_erro.AutoSize = true;
            this.lb_tenkh_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkh_erro.ForeColor = System.Drawing.Color.Red;
            this.lb_tenkh_erro.Location = new System.Drawing.Point(40, 109);
            this.lb_tenkh_erro.Name = "lb_tenkh_erro";
            this.lb_tenkh_erro.Size = new System.Drawing.Size(271, 25);
            this.lb_tenkh_erro.TabIndex = 28;
            this.lb_tenkh_erro.Text = "Tên khách hàng không hợp lệ";
            this.lb_tenkh_erro.Visible = false;
            // 
            // lb_diachi_erro
            // 
            this.lb_diachi_erro.AutoSize = true;
            this.lb_diachi_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachi_erro.ForeColor = System.Drawing.Color.Red;
            this.lb_diachi_erro.Location = new System.Drawing.Point(40, 634);
            this.lb_diachi_erro.Name = "lb_diachi_erro";
            this.lb_diachi_erro.Size = new System.Drawing.Size(188, 25);
            this.lb_diachi_erro.TabIndex = 29;
            this.lb_diachi_erro.Text = "Địa chỉ không hợp lệ";
            this.lb_diachi_erro.Visible = false;
            // 
            // lb_gioi_tinh_erro
            // 
            this.lb_gioi_tinh_erro.AutoSize = true;
            this.lb_gioi_tinh_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gioi_tinh_erro.ForeColor = System.Drawing.Color.Red;
            this.lb_gioi_tinh_erro.Location = new System.Drawing.Point(40, 344);
            this.lb_gioi_tinh_erro.Name = "lb_gioi_tinh_erro";
            this.lb_gioi_tinh_erro.Size = new System.Drawing.Size(131, 25);
            this.lb_gioi_tinh_erro.TabIndex = 30;
            this.lb_gioi_tinh_erro.Text = "Chọn giới tính";
            this.lb_gioi_tinh_erro.Visible = false;
            // 
            // EditCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 760);
            this.Controls.Add(this.lb_gioi_tinh_erro);
            this.Controls.Add(this.lb_diachi_erro);
            this.Controls.Add(this.lb_tenkh_erro);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu_customer);
            this.Controls.Add(this.tb_dia_chi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_sdt_customer_erro);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Radio_Nu);
            this.Controls.Add(this.Radio_Nam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_makh_customer_erro);
            this.Controls.Add(this.date_kh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_makh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ten_kh);
            this.Controls.Add(this.label2);
            this.Name = "EditCustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCustomersForm";
            this.Load += new System.EventHandler(this.EditCustomersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ten_kh;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_makh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_kh;
        private System.Windows.Forms.Label lb_makh_customer_erro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Radio_Nam;
        private System.Windows.Forms.RadioButton Radio_Nu;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_phone;
        private System.Windows.Forms.Label lb_sdt_customer_erro;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_dia_chi;
        private System.Windows.Forms.Button btn_luu_customer;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label lb_tenkh_erro;
        private System.Windows.Forms.Label lb_diachi_erro;
        private System.Windows.Forms.Label lb_gioi_tinh_erro;
    }
}