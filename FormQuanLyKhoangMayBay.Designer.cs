namespace DBMS_Project
{
    partial class FormQuanLyKhoangMayBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyKhoangMayBay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_khoangmaybay = new System.Windows.Forms.DataGridView();
            this.SoHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiMayBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKhoang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_khoangmaybay = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_tongsoghe = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tenloaikhoang = new System.Windows.Forms.TextBox();
            this.tb_makhoang = new System.Windows.Forms.TextBox();
            this.tb_tenmaybay = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.tb_sohieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoangmaybay)).BeginInit();
            this.pnl_khoangmaybay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgv_khoangmaybay);
            this.panel1.Controls.Add(this.pnl_khoangmaybay);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 537);
            this.panel1.TabIndex = 0;
            // 
            // dgv_khoangmaybay
            // 
            this.dgv_khoangmaybay.AllowUserToResizeColumns = false;
            this.dgv_khoangmaybay.AllowUserToResizeRows = false;
            this.dgv_khoangmaybay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_khoangmaybay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khoangmaybay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHieu,
            this.TenLoaiMayBay,
            this.MaKhoang,
            this.TenLoaiKhoang,
            this.TongSoGhe});
            this.dgv_khoangmaybay.Location = new System.Drawing.Point(15, 14);
            this.dgv_khoangmaybay.Name = "dgv_khoangmaybay";
            this.dgv_khoangmaybay.RowHeadersVisible = false;
            this.dgv_khoangmaybay.RowHeadersWidth = 51;
            this.dgv_khoangmaybay.RowTemplate.Height = 24;
            this.dgv_khoangmaybay.Size = new System.Drawing.Size(902, 199);
            this.dgv_khoangmaybay.TabIndex = 1;
            // 
            // SoHieu
            // 
            this.SoHieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoHieu.HeaderText = "Số hiệu";
            this.SoHieu.MinimumWidth = 6;
            this.SoHieu.Name = "SoHieu";
            // 
            // TenLoaiMayBay
            // 
            this.TenLoaiMayBay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiMayBay.HeaderText = "Tên loại máy bay";
            this.TenLoaiMayBay.MinimumWidth = 6;
            this.TenLoaiMayBay.Name = "TenLoaiMayBay";
            // 
            // MaKhoang
            // 
            this.MaKhoang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKhoang.HeaderText = "Mã khoang";
            this.MaKhoang.MinimumWidth = 6;
            this.MaKhoang.Name = "MaKhoang";
            // 
            // TenLoaiKhoang
            // 
            this.TenLoaiKhoang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiKhoang.HeaderText = "Tên loại khoang";
            this.TenLoaiKhoang.MinimumWidth = 6;
            this.TenLoaiKhoang.Name = "TenLoaiKhoang";
            // 
            // TongSoGhe
            // 
            this.TongSoGhe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongSoGhe.HeaderText = "Tổng số ghế";
            this.TongSoGhe.MinimumWidth = 6;
            this.TongSoGhe.Name = "TongSoGhe";
            // 
            // pnl_khoangmaybay
            // 
            this.pnl_khoangmaybay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_khoangmaybay.Controls.Add(this.label3);
            this.pnl_khoangmaybay.Controls.Add(this.label2);
            this.pnl_khoangmaybay.Controls.Add(this.pictureBox1);
            this.pnl_khoangmaybay.Controls.Add(this.tb_tongsoghe);
            this.pnl_khoangmaybay.Controls.Add(this.btn_huy);
            this.pnl_khoangmaybay.Controls.Add(this.btn_them);
            this.pnl_khoangmaybay.Controls.Add(this.label9);
            this.pnl_khoangmaybay.Controls.Add(this.btn_xoa);
            this.pnl_khoangmaybay.Controls.Add(this.label8);
            this.pnl_khoangmaybay.Controls.Add(this.btn_sua);
            this.pnl_khoangmaybay.Controls.Add(this.label7);
            this.pnl_khoangmaybay.Controls.Add(this.tb_tenloaikhoang);
            this.pnl_khoangmaybay.Controls.Add(this.tb_makhoang);
            this.pnl_khoangmaybay.Controls.Add(this.tb_tenmaybay);
            this.pnl_khoangmaybay.Controls.Add(this.btn_luu);
            this.pnl_khoangmaybay.Controls.Add(this.tb_sohieu);
            this.pnl_khoangmaybay.Controls.Add(this.label6);
            this.pnl_khoangmaybay.Location = new System.Drawing.Point(15, 231);
            this.pnl_khoangmaybay.Name = "pnl_khoangmaybay";
            this.pnl_khoangmaybay.Size = new System.Drawing.Size(902, 286);
            this.pnl_khoangmaybay.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tên loại khoang:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã khoang:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(653, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // tb_tongsoghe
            // 
            this.tb_tongsoghe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_tongsoghe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tongsoghe.Location = new System.Drawing.Point(392, 241);
            this.tb_tongsoghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tongsoghe.Multiline = true;
            this.tb_tongsoghe.Name = "tb_tongsoghe";
            this.tb_tongsoghe.Size = new System.Drawing.Size(239, 30);
            this.tb_tongsoghe.TabIndex = 50;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Location = new System.Drawing.Point(681, 226);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(197, 43);
            this.btn_huy.TabIndex = 49;
            this.btn_huy.Text = "Hủy thao tác";
            this.btn_huy.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(17, 73);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(197, 43);
            this.btn_them.TabIndex = 42;
            this.btn_them.Text = "Thêm khoang ";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 28);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tổng số ghế:";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(17, 132);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(197, 43);
            this.btn_xoa.TabIndex = 43;
            this.btn_xoa.Text = "Xóa khoang ";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 28);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tên loại MB:";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(17, 196);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(197, 43);
            this.btn_sua.TabIndex = 44;
            this.btn_sua.Text = "Thay đổi thông tin";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 28);
            this.label7.TabIndex = 40;
            this.label7.Text = "Số hiệu:";
            // 
            // tb_tenloaikhoang
            // 
            this.tb_tenloaikhoang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_tenloaikhoang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenloaikhoang.Location = new System.Drawing.Point(392, 193);
            this.tb_tenloaikhoang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tenloaikhoang.Multiline = true;
            this.tb_tenloaikhoang.Name = "tb_tenloaikhoang";
            this.tb_tenloaikhoang.Size = new System.Drawing.Size(239, 30);
            this.tb_tenloaikhoang.TabIndex = 48;
            // 
            // tb_makhoang
            // 
            this.tb_makhoang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_makhoang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_makhoang.Location = new System.Drawing.Point(392, 146);
            this.tb_makhoang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_makhoang.Multiline = true;
            this.tb_makhoang.Name = "tb_makhoang";
            this.tb_makhoang.Size = new System.Drawing.Size(239, 30);
            this.tb_makhoang.TabIndex = 47;
            // 
            // tb_tenmaybay
            // 
            this.tb_tenmaybay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_tenmaybay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenmaybay.Location = new System.Drawing.Point(392, 97);
            this.tb_tenmaybay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tenmaybay.Multiline = true;
            this.tb_tenmaybay.Name = "tb_tenmaybay";
            this.tb_tenmaybay.Size = new System.Drawing.Size(239, 30);
            this.tb_tenmaybay.TabIndex = 46;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Location = new System.Drawing.Point(681, 167);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(197, 43);
            this.btn_luu.TabIndex = 45;
            this.btn_luu.Text = "Lưu thay đổi";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // tb_sohieu
            // 
            this.tb_sohieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_sohieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sohieu.Location = new System.Drawing.Point(392, 51);
            this.tb_sohieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sohieu.Multiline = true;
            this.tb_sohieu.Name = "tb_sohieu";
            this.tb_sohieu.Size = new System.Drawing.Size(239, 30);
            this.tb_sohieu.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 28);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cập nhật khoang máy bay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(343, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ KHOANG MÁY BAY";
            // 
            // FormQuanLyKhoangMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(965, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLyKhoangMayBay";
            this.Text = "FormQuanLyKhoangMayBay";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoangmaybay)).EndInit();
            this.pnl_khoangmaybay.ResumeLayout(false);
            this.pnl_khoangmaybay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_khoangmaybay;
        private System.Windows.Forms.Panel pnl_khoangmaybay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiMayBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKhoang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoGhe;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tenloaikhoang;
        private System.Windows.Forms.TextBox tb_makhoang;
        private System.Windows.Forms.TextBox tb_tenmaybay;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox tb_sohieu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tongsoghe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}