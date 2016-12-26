namespace ManageSpa
{
    partial class FormQuanTri
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
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnNVDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(28, 28);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(102, 56);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Location = new System.Drawing.Point(195, 28);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(102, 56);
            this.btnTaiKhoan.TabIndex = 0;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(362, 28);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(102, 56);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNVDN
            // 
            this.btnNVDN.Location = new System.Drawing.Point(529, 28);
            this.btnNVDN.Name = "btnNVDN";
            this.btnNVDN.Size = new System.Drawing.Size(102, 56);
            this.btnNVDN.TabIndex = 1;
            this.btnNVDN.Text = "Nhân viên đăng nhập";
            this.btnNVDN.UseVisualStyleBackColor = true;
            this.btnNVDN.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormQuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 108);
            this.Controls.Add(this.btnNVDN);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnTaiKhoan);
            this.Controls.Add(this.btnNhanVien);
            this.Name = "FormQuanTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị";
            this.Load += new System.EventHandler(this.FormQuanTri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnNVDN;
    }
}