namespace DBMS_Project
{
    partial class FormQLTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnltaikhoan = new System.Windows.Forms.Panel();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.pnltaikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // pnltaikhoan
            // 
            this.pnltaikhoan.BackColor = System.Drawing.Color.White;
            this.pnltaikhoan.Controls.Add(this.btn_xoa);
            this.pnltaikhoan.Controls.Add(this.btn_them);
            this.pnltaikhoan.Controls.Add(this.cbb_loai);
            this.pnltaikhoan.Controls.Add(this.label2);
            this.pnltaikhoan.Controls.Add(this.txt_pass);
            this.pnltaikhoan.Controls.Add(this.txt_user);
            this.pnltaikhoan.Controls.Add(this.dgv_taikhoan);
            this.pnltaikhoan.Controls.Add(this.label11);
            this.pnltaikhoan.Controls.Add(this.label10);
            this.pnltaikhoan.Location = new System.Drawing.Point(13, 51);
            this.pnltaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.pnltaikhoan.Name = "pnltaikhoan";
            this.pnltaikhoan.Size = new System.Drawing.Size(538, 526);
            this.pnltaikhoan.TabIndex = 6;
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.AllowUserToResizeColumns = false;
            this.dgv_taikhoan.AllowUserToResizeRows = false;
            this.dgv_taikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_taikhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Location = new System.Drawing.Point(3, 2);
            this.dgv_taikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.RowHeadersVisible = false;
            this.dgv_taikhoan.RowHeadersWidth = 51;
            this.dgv_taikhoan.RowTemplate.Height = 24;
            this.dgv_taikhoan.Size = new System.Drawing.Size(532, 311);
            this.dgv_taikhoan.TabIndex = 4;
            this.dgv_taikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taikhoan_CellClick);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(144, 332);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(201, 36);
            this.txt_user.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 331);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 37);
            this.label10.TabIndex = 80;
            this.label10.Text = "Username:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 402);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 37);
            this.label11.TabIndex = 81;
            this.label11.Text = "Password:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(144, 391);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(201, 37);
            this.txt_pass.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 37);
            this.label2.TabIndex = 84;
            this.label2.Text = "Loại:";
            // 
            // cbb_loai
            // 
            this.cbb_loai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_loai.FormattingEnabled = true;
            this.cbb_loai.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cbb_loai.Location = new System.Drawing.Point(144, 460);
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(121, 36);
            this.cbb_loai.TabIndex = 85;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(314, 449);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(199, 50);
            this.btn_them.TabIndex = 72;
            this.btn_them.Text = "Tạo tài khoản";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(378, 357);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(135, 50);
            this.btn_xoa.TabIndex = 86;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // FormQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(568, 590);
            this.Controls.Add(this.pnltaikhoan);
            this.Controls.Add(this.label1);
            this.Name = "FormQLTaiKhoan";
            this.Text = "FormQLTaiKhoan";
            this.Load += new System.EventHandler(this.FormQLTaiKhoan_Load);
            this.pnltaikhoan.ResumeLayout(false);
            this.pnltaikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnltaikhoan;
        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
    }
}