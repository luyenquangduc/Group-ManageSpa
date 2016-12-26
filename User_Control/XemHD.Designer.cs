namespace ManageSpa.User_Control
{
    partial class XemHD
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
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDon.Location = new System.Drawing.Point(9, 1);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHoaDon.Size = new System.Drawing.Size(410, 218);
            this.dataHoaDon.TabIndex = 0;
            this.dataHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoaDon_CellDoubleClick);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(442, 17);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(141, 20);
            this.txtTenKhachHang.TabIndex = 1;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // cbTenKH
            // 
            this.cbTenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Location = new System.Drawing.Point(442, 53);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(141, 21);
            this.cbTenKH.TabIndex = 2;
            this.cbTenKH.SelectedIndexChanged += new System.EventHandler(this.cbTenKH_SelectedIndexChanged);
            // 
            // XemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTenKH);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.dataHoaDon);
            this.Name = "XemHD";
            this.Size = new System.Drawing.Size(600, 225);
            this.Load += new System.EventHandler(this.XemHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.ComboBox cbTenKH;
        public System.Windows.Forms.DataGridView dataHoaDon;
    }
}
