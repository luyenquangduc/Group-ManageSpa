namespace ManageSpa.User_Control
{
    partial class SuaThongTinDatCho
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
            this.dataThongTinDatCho = new System.Windows.Forms.DataGridView();
            this.cbGiuong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLieuTrinh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickBegin = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataThongTinDatCho)).BeginInit();
            this.SuspendLayout();
            // 
            // dataThongTinDatCho
            // 
            this.dataThongTinDatCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThongTinDatCho.Location = new System.Drawing.Point(12, 9);
            this.dataThongTinDatCho.Name = "dataThongTinDatCho";
            this.dataThongTinDatCho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataThongTinDatCho.Size = new System.Drawing.Size(545, 357);
            this.dataThongTinDatCho.TabIndex = 0;
            this.dataThongTinDatCho.SelectionChanged += new System.EventHandler(this.dataThongTinDatCho_SelectionChanged);
            // 
            // cbGiuong
            // 
            this.cbGiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGiuong.FormattingEnabled = true;
            this.cbGiuong.Location = new System.Drawing.Point(640, 177);
            this.cbGiuong.Name = "cbGiuong";
            this.cbGiuong.Size = new System.Drawing.Size(155, 21);
            this.cbGiuong.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Giường";
            // 
            // btnLieuTrinh
            // 
            this.btnLieuTrinh.Location = new System.Drawing.Point(640, 59);
            this.btnLieuTrinh.Name = "btnLieuTrinh";
            this.btnLieuTrinh.Size = new System.Drawing.Size(155, 23);
            this.btnLieuTrinh.TabIndex = 33;
            this.btnLieuTrinh.Text = "Chọn liệu trình";
            this.btnLieuTrinh.UseVisualStyleBackColor = true;
            this.btnLieuTrinh.Click += new System.EventHandler(this.btnLieuTrinh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(601, 227);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Kết thúc";
            // 
            // datePickEnd
            // 
            this.datePickEnd.Location = new System.Drawing.Point(640, 136);
            this.datePickEnd.Name = "datePickEnd";
            this.datePickEnd.Size = new System.Drawing.Size(155, 20);
            this.datePickEnd.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Bắt đầu";
            // 
            // datePickBegin
            // 
            this.datePickBegin.Location = new System.Drawing.Point(640, 98);
            this.datePickBegin.Name = "datePickBegin";
            this.datePickBegin.Size = new System.Drawing.Size(155, 20);
            this.datePickBegin.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(640, 18);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(155, 20);
            this.txtSDT.TabIndex = 26;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(734, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // SuaThongTinDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbGiuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLieuTrinh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePickEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickBegin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.dataThongTinDatCho);
            this.Name = "SuaThongTinDatCho";
            this.Size = new System.Drawing.Size(838, 375);
            this.Load += new System.EventHandler(this.SuaThongTinDatCho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataThongTinDatCho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataThongTinDatCho;
        private System.Windows.Forms.ComboBox cbGiuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLieuTrinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickBegin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnXoa;
    }
}
