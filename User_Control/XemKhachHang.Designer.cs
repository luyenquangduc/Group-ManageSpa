namespace ManageSpa.User_Control
{
    partial class XemKhachHang
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
            this.txtKyTuTimKiem = new System.Windows.Forms.TextBox();
            this.dataKhachHang = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChon = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.ofdThemHinhAnh = new System.Windows.Forms.OpenFileDialog();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKyTuTimKiem
            // 
            this.txtKyTuTimKiem.Location = new System.Drawing.Point(540, 94);
            this.txtKyTuTimKiem.Name = "txtKyTuTimKiem";
            this.txtKyTuTimKiem.Size = new System.Drawing.Size(142, 20);
            this.txtKyTuTimKiem.TabIndex = 1;
            this.txtKyTuTimKiem.TextChanged += new System.EventHandler(this.txtKyTuTimKiem_TextChanged);
            // 
            // dataKhachHang
            // 
            this.dataKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhachHang.Location = new System.Drawing.Point(0, 2);
            this.dataKhachHang.MultiSelect = false;
            this.dataKhachHang.Name = "dataKhachHang";
            this.dataKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKhachHang.Size = new System.Drawing.Size(533, 329);
            this.dataKhachHang.TabIndex = 15;
            this.dataKhachHang.SelectionChanged += new System.EventHandler(this.dataKhachHang_SelectionChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(490, 120);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Location = new System.Drawing.Point(548, 73);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(47, 13);
            this.lblTuKhoa.TabIndex = 19;
            this.lblTuKhoa.Text = "Từ khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chọn chế độ";
            // 
            // cbChon
            // 
            this.cbChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChon.FormattingEnabled = true;
            this.cbChon.Location = new System.Drawing.Point(540, 33);
            this.cbChon.Name = "cbChon";
            this.cbChon.Size = new System.Drawing.Size(126, 21);
            this.cbChon.TabIndex = 0;
            this.cbChon.SelectedValueChanged += new System.EventHandler(this.cbChon_SelectedValueChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(76, 73);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(132, 20);
            this.txtSDT.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(340, 73);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(240, 20);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaKH);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 156);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(114, 37);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(0, 13);
            this.lblMaKH.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "SDT";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(390, 30);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(190, 20);
            this.txtTenKhachHang.TabIndex = 5;
            // 
            // ofdThemHinhAnh
            // 
            this.ofdThemHinhAnh.FileName = "openFileDialog1";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(624, 136);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(58, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // XemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtKyTuTimKiem);
            this.Controls.Add(this.dataKhachHang);
            this.Controls.Add(this.lblTuKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "XemKhachHang";
            this.Size = new System.Drawing.Size(685, 500);
            this.Load += new System.EventHandler(this.XemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKyTuTimKiem;
        private System.Windows.Forms.DataGridView dataKhachHang;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChon;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.OpenFileDialog ofdThemHinhAnh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblMaKH;
    }
}
