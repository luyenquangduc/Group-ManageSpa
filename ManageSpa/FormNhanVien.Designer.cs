namespace ManageSpa
{
    partial class FormNhanVien
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
            this.pnlNhanVien = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.xemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.themNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNhanVien
            // 
            this.pnlNhanVien.Location = new System.Drawing.Point(0, 27);
            this.pnlNhanVien.Name = "pnlNhanVien";
            this.pnlNhanVien.Size = new System.Drawing.Size(586, 186);
            this.pnlNhanVien.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanVien});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemNhanVien,
            this.themNhanVien});
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(50, 20);
            this.menuNhanVien.Text = "Menu";
            // 
            // xemNhanVien
            // 
            this.xemNhanVien.Name = "xemNhanVien";
            this.xemNhanVien.Size = new System.Drawing.Size(160, 22);
            this.xemNhanVien.Text = "Xem nhân viên";
            this.xemNhanVien.Click += new System.EventHandler(this.xemNhanVien_Click);
            // 
            // themNhanVien
            // 
            this.themNhanVien.Name = "themNhanVien";
            this.themNhanVien.Size = new System.Drawing.Size(160, 22);
            this.themNhanVien.Text = "Thêm nhân viên";
            this.themNhanVien.Click += new System.EventHandler(this.themNhanVien_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 214);
            this.Controls.Add(this.pnlNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNhanVien;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem xemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem themNhanVien;
    }
}