namespace ManageSpa.User_Control
{
    partial class LieuTrinh
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
            this.flowLieuTrinh = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLieuTrinh
            // 
            this.flowLieuTrinh.Location = new System.Drawing.Point(0, 0);
            this.flowLieuTrinh.Name = "flowLieuTrinh";
            this.flowLieuTrinh.Size = new System.Drawing.Size(340, 153);
            this.flowLieuTrinh.TabIndex = 0;
            // 
            // LieuTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLieuTrinh);
            this.Name = "LieuTrinh";
            this.Size = new System.Drawing.Size(342, 156);
            this.Load += new System.EventHandler(this.LieuTrinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLieuTrinh;
    }
}
