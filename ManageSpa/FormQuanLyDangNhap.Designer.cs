namespace ManageSpa
{
    partial class FormQuanLyDangNhap
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
            this.pnlQuanLyDangNhap = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlQuanLyDangNhap
            // 
            this.pnlQuanLyDangNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlQuanLyDangNhap.Name = "pnlQuanLyDangNhap";
            this.pnlQuanLyDangNhap.Size = new System.Drawing.Size(672, 265);
            this.pnlQuanLyDangNhap.TabIndex = 0;
            // 
            // FormQuanLyDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 267);
            this.Controls.Add(this.pnlQuanLyDangNhap);
            this.Name = "FormQuanLyDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đăng nhập";
            this.Load += new System.EventHandler(this.FormQuanLyDangNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuanLyDangNhap;
    }
}