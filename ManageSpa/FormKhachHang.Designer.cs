namespace ManageSpa
{
    partial class FormKhachHang
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
            this.menuKhachHang = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.xemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.menuKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuKhachHang.Location = new System.Drawing.Point(0, 0);
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Size = new System.Drawing.Size(587, 24);
            this.menuKhachHang.TabIndex = 0;
            this.menuKhachHang.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themKhachHang,
            this.xemKhachHang});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // themKhachHang
            // 
            this.themKhachHang.Name = "themKhachHang";
            this.themKhachHang.Size = new System.Drawing.Size(170, 22);
            this.themKhachHang.Text = "Thêm khách hàng";
            this.themKhachHang.Click += new System.EventHandler(this.thêmKháchHàngToolStripMenuItem_Click);
            // 
            // xemKhachHang
            // 
            this.xemKhachHang.Name = "xemKhachHang";
            this.xemKhachHang.Size = new System.Drawing.Size(170, 22);
            this.xemKhachHang.Text = "Xem khách hàng";
            this.xemKhachHang.Click += new System.EventHandler(this.xemKháchHàngToolStripMenuItem_Click);
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.Location = new System.Drawing.Point(0, 27);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(586, 111);
            this.pnlKhachHang.TabIndex = 1;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 139);
            this.Controls.Add(this.pnlKhachHang);
            this.Controls.Add(this.menuKhachHang);
            this.MainMenuStrip = this.menuKhachHang;
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.menuKhachHang.ResumeLayout(false);
            this.menuKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themKhachHang;
        private System.Windows.Forms.ToolStripMenuItem xemKhachHang;
        public System.Windows.Forms.Panel pnlKhachHang;
    }
}