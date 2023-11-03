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
            this.pnl_khoangmaybay = new System.Windows.Forms.Panel();
            this.btn_Quaylai = new System.Windows.Forms.Button();
            this.pnl_thongso = new System.Windows.Forms.Panel();
            this.btn_huy = new System.Windows.Forms.Button();
            this.tb_tenloaimaybay = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tenloaikhoang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tongsoghe = new System.Windows.Forms.TextBox();
            this.tb_makhoang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_khoangmaybay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sohieu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnl_khoangmaybay.SuspendLayout();
            this.pnl_thongso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoangmaybay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnl_khoangmaybay);
            this.panel1.Controls.Add(this.dgv_khoangmaybay);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 537);
            this.panel1.TabIndex = 0;
            // 
            // pnl_khoangmaybay
            // 
            this.pnl_khoangmaybay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_khoangmaybay.Controls.Add(this.btn_Quaylai);
            this.pnl_khoangmaybay.Controls.Add(this.pnl_thongso);
            this.pnl_khoangmaybay.Controls.Add(this.btn_them);
            this.pnl_khoangmaybay.Controls.Add(this.btn_xoa);
            this.pnl_khoangmaybay.Controls.Add(this.btn_sua);
            this.pnl_khoangmaybay.Controls.Add(this.label6);
            this.pnl_khoangmaybay.Location = new System.Drawing.Point(15, 231);
            this.pnl_khoangmaybay.Name = "pnl_khoangmaybay";
            this.pnl_khoangmaybay.Size = new System.Drawing.Size(921, 299);
            this.pnl_khoangmaybay.TabIndex = 0;
            // 
            // btn_Quaylai
            // 
            this.btn_Quaylai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Quaylai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quaylai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Quaylai.Location = new System.Drawing.Point(10, 249);
            this.btn_Quaylai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quaylai.Name = "btn_Quaylai";
            this.btn_Quaylai.Size = new System.Drawing.Size(190, 56);
            this.btn_Quaylai.TabIndex = 46;
            this.btn_Quaylai.Text = "Quay lại";
            this.btn_Quaylai.UseVisualStyleBackColor = false;
            this.btn_Quaylai.Click += new System.EventHandler(this.btn_Quaylai_Click);
            // 
            // pnl_thongso
            // 
            this.pnl_thongso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_thongso.Controls.Add(this.btn_huy);
            this.pnl_thongso.Controls.Add(this.tb_tenloaimaybay);
            this.pnl_thongso.Controls.Add(this.btn_luu);
            this.pnl_thongso.Controls.Add(this.label8);
            this.pnl_thongso.Controls.Add(this.label9);
            this.pnl_thongso.Controls.Add(this.pictureBox1);
            this.pnl_thongso.Controls.Add(this.label7);
            this.pnl_thongso.Controls.Add(this.tb_sohieu);
            this.pnl_thongso.Controls.Add(this.tb_tenloaikhoang);
            this.pnl_thongso.Controls.Add(this.label3);
            this.pnl_thongso.Controls.Add(this.tb_tongsoghe);
            this.pnl_thongso.Controls.Add(this.tb_makhoang);
            this.pnl_thongso.Controls.Add(this.label2);
            this.pnl_thongso.Enabled = false;
            this.pnl_thongso.Location = new System.Drawing.Point(220, 42);
            this.pnl_thongso.Name = "pnl_thongso";
            this.pnl_thongso.Size = new System.Drawing.Size(684, 250);
            this.pnl_thongso.TabIndex = 45;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Location = new System.Drawing.Point(470, 190);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(182, 56);
            this.btn_huy.TabIndex = 49;
            this.btn_huy.Text = "Hủy ";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // tb_tenloaimaybay
            // 
            this.tb_tenloaimaybay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_tenloaimaybay.Enabled = false;
            this.tb_tenloaimaybay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenloaimaybay.Location = new System.Drawing.Point(177, 59);
            this.tb_tenloaimaybay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tenloaimaybay.Multiline = true;
            this.tb_tenloaimaybay.Name = "tb_tenloaimaybay";
            this.tb_tenloaimaybay.Size = new System.Drawing.Size(239, 30);
            this.tb_tenloaimaybay.TabIndex = 46;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Location = new System.Drawing.Point(470, 125);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(182, 56);
            this.btn_luu.TabIndex = 45;
            this.btn_luu.Text = "Lưu ";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 28);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tên loại MB:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 28);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tổng số ghế:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 28);
            this.label7.TabIndex = 40;
            this.label7.Text = "Số hiệu:";
            // 
            // tb_tenloaikhoang
            // 
            this.tb_tenloaikhoang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_tenloaikhoang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenloaikhoang.Location = new System.Drawing.Point(177, 155);
            this.tb_tenloaikhoang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tenloaikhoang.Multiline = true;
            this.tb_tenloaikhoang.Name = "tb_tenloaikhoang";
            this.tb_tenloaikhoang.Size = new System.Drawing.Size(239, 30);
            this.tb_tenloaikhoang.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tên loại khoang:";
            // 
            // tb_tongsoghe
            // 
            this.tb_tongsoghe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_tongsoghe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tongsoghe.Location = new System.Drawing.Point(177, 203);
            this.tb_tongsoghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tongsoghe.Multiline = true;
            this.tb_tongsoghe.Name = "tb_tongsoghe";
            this.tb_tongsoghe.Size = new System.Drawing.Size(239, 30);
            this.tb_tongsoghe.TabIndex = 50;
            // 
            // tb_makhoang
            // 
            this.tb_makhoang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_makhoang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_makhoang.Location = new System.Drawing.Point(177, 108);
            this.tb_makhoang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_makhoang.Multiline = true;
            this.tb_makhoang.Name = "tb_makhoang";
            this.tb_makhoang.Size = new System.Drawing.Size(239, 30);
            this.tb_makhoang.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã khoang:";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(10, 57);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(190, 56);
            this.btn_them.TabIndex = 42;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(10, 177);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(190, 56);
            this.btn_xoa.TabIndex = 43;
            this.btn_xoa.Text = "Xóa ";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(10, 117);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(190, 56);
            this.btn_sua.TabIndex = 44;
            this.btn_sua.Text = "Thay đổi";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
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
            // dgv_khoangmaybay
            // 
            this.dgv_khoangmaybay.AllowUserToResizeColumns = false;
            this.dgv_khoangmaybay.AllowUserToResizeRows = false;
            this.dgv_khoangmaybay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khoangmaybay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_khoangmaybay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_khoangmaybay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khoangmaybay.Location = new System.Drawing.Point(15, 13);
            this.dgv_khoangmaybay.Name = "dgv_khoangmaybay";
            this.dgv_khoangmaybay.RowHeadersVisible = false;
            this.dgv_khoangmaybay.RowHeadersWidth = 51;
            this.dgv_khoangmaybay.RowTemplate.Height = 24;
            this.dgv_khoangmaybay.Size = new System.Drawing.Size(921, 199);
            this.dgv_khoangmaybay.TabIndex = 1;
            this.dgv_khoangmaybay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khoangmaybay_CellClick);
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
            // tb_sohieu
            // 
            this.tb_sohieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_sohieu.Enabled = false;
            this.tb_sohieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sohieu.Location = new System.Drawing.Point(177, 13);
            this.tb_sohieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sohieu.Multiline = true;
            this.tb_sohieu.Name = "tb_sohieu";
            this.tb_sohieu.Size = new System.Drawing.Size(239, 30);
            this.tb_sohieu.TabIndex = 41;
            // 
            // FormQuanLyKhoangMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(974, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuanLyKhoangMayBay";
            this.Text = "FormQuanLyKhoangMayBay";
            this.Load += new System.EventHandler(this.FormQuanLyKhoangMayBay_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_khoangmaybay.ResumeLayout(false);
            this.pnl_khoangmaybay.PerformLayout();
            this.pnl_thongso.ResumeLayout(false);
            this.pnl_thongso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoangmaybay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_khoangmaybay;
        private System.Windows.Forms.Panel pnl_khoangmaybay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tenloaikhoang;
        private System.Windows.Forms.TextBox tb_makhoang;
        private System.Windows.Forms.TextBox tb_tenloaimaybay;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tongsoghe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Panel pnl_thongso;
        private System.Windows.Forms.Button btn_Quaylai;
        private System.Windows.Forms.TextBox tb_sohieu;
    }
}