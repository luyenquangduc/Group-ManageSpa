namespace ManageSpa.User_Control
{
    partial class ThongKeDangNhap
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
            this.dataLanDangNhap = new System.Windows.Forms.DataGridView();
            this.cbTenNhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLanDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLanDangNhap
            // 
            this.dataLanDangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLanDangNhap.Location = new System.Drawing.Point(225, 3);
            this.dataLanDangNhap.Name = "dataLanDangNhap";
            this.dataLanDangNhap.Size = new System.Drawing.Size(444, 262);
            this.dataLanDangNhap.TabIndex = 0;
            // 
            // cbTenNhanVien
            // 
            this.cbTenNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenNhanVien.FormattingEnabled = true;
            this.cbTenNhanVien.Location = new System.Drawing.Point(18, 42);
            this.cbTenNhanVien.Name = "cbTenNhanVien";
            this.cbTenNhanVien.Size = new System.Drawing.Size(179, 21);
            this.cbTenNhanVien.TabIndex = 1;
            this.cbTenNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbTenNhanVien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhân viên";
            // 
            // ThongKeDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTenNhanVien);
            this.Controls.Add(this.dataLanDangNhap);
            this.Name = "ThongKeDangNhap";
            this.Size = new System.Drawing.Size(672, 265);
            this.Load += new System.EventHandler(this.ThongKeDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLanDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataLanDangNhap;
        private System.Windows.Forms.ComboBox cbTenNhanVien;
        private System.Windows.Forms.Label label1;
    }
}
