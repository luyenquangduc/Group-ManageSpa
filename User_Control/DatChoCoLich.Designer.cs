namespace ManageSpa.User_Control
{
    partial class DatChoCoLich
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.datePickBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickEnd = new System.Windows.Forms.DateTimePicker();
            this.btnDatCho = new System.Windows.Forms.Button();
            this.dataKhachHangHomNay = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataKhachHangNgayMai = new System.Windows.Forms.DataGridView();
            this.btnLieuTrinh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGiuong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHangHomNay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHangNgayMai)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(78, 46);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(155, 20);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // datePickBegin
            // 
            this.datePickBegin.Location = new System.Drawing.Point(78, 126);
            this.datePickBegin.Name = "datePickBegin";
            this.datePickBegin.Size = new System.Drawing.Size(155, 20);
            this.datePickBegin.TabIndex = 10;
            this.datePickBegin.ValueChanged += new System.EventHandler(this.datePickBegin_ValueChanged);
            this.datePickBegin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.datePickBegin_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kết thúc";
            // 
            // datePickEnd
            // 
            this.datePickEnd.Enabled = false;
            this.datePickEnd.Location = new System.Drawing.Point(78, 164);
            this.datePickEnd.Name = "datePickEnd";
            this.datePickEnd.Size = new System.Drawing.Size(155, 20);
            this.datePickEnd.TabIndex = 12;
            // 
            // btnDatCho
            // 
            this.btnDatCho.Location = new System.Drawing.Point(158, 256);
            this.btnDatCho.Name = "btnDatCho";
            this.btnDatCho.Size = new System.Drawing.Size(75, 23);
            this.btnDatCho.TabIndex = 14;
            this.btnDatCho.Text = "Đặt chỗ";
            this.btnDatCho.UseVisualStyleBackColor = true;
            this.btnDatCho.Click += new System.EventHandler(this.btnDatCho_Click);
            // 
            // dataKhachHangHomNay
            // 
            this.dataKhachHangHomNay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhachHangHomNay.Location = new System.Drawing.Point(287, 30);
            this.dataKhachHangHomNay.Name = "dataKhachHangHomNay";
            this.dataKhachHangHomNay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKhachHangHomNay.Size = new System.Drawing.Size(545, 130);
            this.dataKhachHangHomNay.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Khách hàng hôm nay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Khách hàng ngày mai";
            // 
            // dataKhachHangNgayMai
            // 
            this.dataKhachHangNgayMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhachHangNgayMai.Location = new System.Drawing.Point(287, 232);
            this.dataKhachHangNgayMai.Name = "dataKhachHangNgayMai";
            this.dataKhachHangNgayMai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKhachHangNgayMai.Size = new System.Drawing.Size(545, 130);
            this.dataKhachHangNgayMai.TabIndex = 19;
            // 
            // btnLieuTrinh
            // 
            this.btnLieuTrinh.Location = new System.Drawing.Point(78, 87);
            this.btnLieuTrinh.Name = "btnLieuTrinh";
            this.btnLieuTrinh.Size = new System.Drawing.Size(155, 23);
            this.btnLieuTrinh.TabIndex = 23;
            this.btnLieuTrinh.Text = "Chọn liệu trình";
            this.btnLieuTrinh.UseVisualStyleBackColor = true;
            this.btnLieuTrinh.Click += new System.EventHandler(this.btnLieuTrinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Giường";
            // 
            // cbGiuong
            // 
            this.cbGiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGiuong.FormattingEnabled = true;
            this.cbGiuong.Location = new System.Drawing.Point(78, 205);
            this.cbGiuong.Name = "cbGiuong";
            this.cbGiuong.Size = new System.Drawing.Size(155, 21);
            this.cbGiuong.TabIndex = 25;
            // 
            // DatChoCoLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbGiuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLieuTrinh);
            this.Controls.Add(this.dataKhachHangNgayMai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataKhachHangHomNay);
            this.Controls.Add(this.btnDatCho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePickEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickBegin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSDT);
            this.Name = "DatChoCoLich";
            this.Size = new System.Drawing.Size(838, 375);
            this.Load += new System.EventHandler(this.DatChoCoLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHangHomNay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHangNgayMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker datePickBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickEnd;
        private System.Windows.Forms.Button btnDatCho;
        private System.Windows.Forms.DataGridView dataKhachHangHomNay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataKhachHangNgayMai;
        private System.Windows.Forms.Button btnLieuTrinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGiuong;

    }
}
