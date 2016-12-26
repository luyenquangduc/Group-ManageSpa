namespace ManageSpa.User_Control
{
    partial class XoaTaiKhoan
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
            this.dtTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTaiKhoan
            // 
            this.dtTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTaiKhoan.Location = new System.Drawing.Point(0, 2);
            this.dtTaiKhoan.Name = "dtTaiKhoan";
            this.dtTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTaiKhoan.Size = new System.Drawing.Size(358, 181);
            this.dtTaiKhoan.TabIndex = 0;
            this.dtTaiKhoan.SelectionChanged += new System.EventHandler(this.dtTaiKhoan_SelectionChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(383, 158);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // XoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtTaiKhoan);
            this.Name = "XoaTaiKhoan";
            this.Size = new System.Drawing.Size(463, 184);
            this.Load += new System.EventHandler(this.XoaTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        internal System.Windows.Forms.DataGridView dtTaiKhoan;
    }
}
