namespace ManageSpa
{
    partial class FormDatCho
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
            this.pnlDatCho = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThongTinItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.suaThongTinItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatCho
            // 
            this.pnlDatCho.Location = new System.Drawing.Point(2, 28);
            this.pnlDatCho.Name = "pnlDatCho";
            this.pnlDatCho.Size = new System.Drawing.Size(838, 383);
            this.pnlDatCho.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThongTinItemMenu,
            this.suaThongTinItemMenu});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // xemThongTinItemMenu
            // 
            this.xemThongTinItemMenu.Name = "xemThongTinItemMenu";
            this.xemThongTinItemMenu.Size = new System.Drawing.Size(193, 22);
            this.xemThongTinItemMenu.Text = "Đặt chỗ";
            this.xemThongTinItemMenu.Click += new System.EventHandler(this.xemThongTinItemMenu_Click);
            // 
            // suaThongTinItemMenu
            // 
            this.suaThongTinItemMenu.Name = "suaThongTinItemMenu";
            this.suaThongTinItemMenu.Size = new System.Drawing.Size(193, 22);
            this.suaThongTinItemMenu.Text = "Xem thông tin đặt chỗ";
            this.suaThongTinItemMenu.Click += new System.EventHandler(this.suaThongTinItemMenu_Click);
            // 
            // FormDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 411);
            this.Controls.Add(this.pnlDatCho);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormDatCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt chỗ";
            this.Load += new System.EventHandler(this.FormDatCho_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatCho;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThongTinItemMenu;
        private System.Windows.Forms.ToolStripMenuItem suaThongTinItemMenu;
    }
}