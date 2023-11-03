namespace DBMS_Project
{
    partial class FormQuanLyVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyVe));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tb_TenLoaiKhoang = new System.Windows.Forms.TextBox();
            this.tb_MaChuyenBay = new System.Windows.Forms.TextBox();
            this.tb_SoGhe = new System.Windows.Forms.TextBox();
            this.tb_MaHanhKhach = new System.Windows.Forms.TextBox();
            this.tb_GiaVe = new System.Windows.Forms.TextBox();
            this.tb_MaVe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_QuanLyVe = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_QuanLyHanhKhach = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.dgv_QuanLyVe_ThongKe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyVe)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyVe_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(669, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ VÉ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.tb_TenLoaiKhoang);
            this.panel1.Controls.Add(this.tb_MaChuyenBay);
            this.panel1.Controls.Add(this.tb_SoGhe);
            this.panel1.Controls.Add(this.tb_MaHanhKhach);
            this.panel1.Controls.Add(this.tb_GiaVe);
            this.panel1.Controls.Add(this.tb_MaVe);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgv_QuanLyVe);
            this.panel1.Location = new System.Drawing.Point(287, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 532);
            this.panel1.TabIndex = 4;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Location = new System.Drawing.Point(690, 462);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(197, 43);
            this.btn_Xoa.TabIndex = 55;
            this.btn_Xoa.Text = "Xoá vé";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sua.Location = new System.Drawing.Point(389, 462);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(197, 43);
            this.btn_Sua.TabIndex = 54;
            this.btn_Sua.Text = "Sửa vé";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.Location = new System.Drawing.Point(79, 462);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(197, 43);
            this.btn_Them.TabIndex = 53;
            this.btn_Them.Text = "Thêm vé";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tb_TenLoaiKhoang
            // 
            this.tb_TenLoaiKhoang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_TenLoaiKhoang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenLoaiKhoang.Location = new System.Drawing.Point(664, 397);
            this.tb_TenLoaiKhoang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TenLoaiKhoang.Multiline = true;
            this.tb_TenLoaiKhoang.Name = "tb_TenLoaiKhoang";
            this.tb_TenLoaiKhoang.Size = new System.Drawing.Size(224, 30);
            this.tb_TenLoaiKhoang.TabIndex = 52;
            // 
            // tb_MaChuyenBay
            // 
            this.tb_MaChuyenBay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_MaChuyenBay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaChuyenBay.Location = new System.Drawing.Point(222, 397);
            this.tb_MaChuyenBay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaChuyenBay.Multiline = true;
            this.tb_MaChuyenBay.Name = "tb_MaChuyenBay";
            this.tb_MaChuyenBay.Size = new System.Drawing.Size(152, 30);
            this.tb_MaChuyenBay.TabIndex = 51;
            // 
            // tb_SoGhe
            // 
            this.tb_SoGhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_SoGhe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoGhe.Location = new System.Drawing.Point(664, 346);
            this.tb_SoGhe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SoGhe.Multiline = true;
            this.tb_SoGhe.Name = "tb_SoGhe";
            this.tb_SoGhe.Size = new System.Drawing.Size(224, 30);
            this.tb_SoGhe.TabIndex = 50;
            // 
            // tb_MaHanhKhach
            // 
            this.tb_MaHanhKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_MaHanhKhach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaHanhKhach.Location = new System.Drawing.Point(664, 300);
            this.tb_MaHanhKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaHanhKhach.Multiline = true;
            this.tb_MaHanhKhach.Name = "tb_MaHanhKhach";
            this.tb_MaHanhKhach.Size = new System.Drawing.Size(224, 30);
            this.tb_MaHanhKhach.TabIndex = 49;
            // 
            // tb_GiaVe
            // 
            this.tb_GiaVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_GiaVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GiaVe.Location = new System.Drawing.Point(222, 346);
            this.tb_GiaVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_GiaVe.Multiline = true;
            this.tb_GiaVe.Name = "tb_GiaVe";
            this.tb_GiaVe.Size = new System.Drawing.Size(152, 30);
            this.tb_GiaVe.TabIndex = 48;
            // 
            // tb_MaVe
            // 
            this.tb_MaVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_MaVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaVe.Location = new System.Drawing.Point(222, 300);
            this.tb_MaVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaVe.Multiline = true;
            this.tb_MaVe.Name = "tb_MaVe";
            this.tb_MaVe.Size = new System.Drawing.Size(152, 30);
            this.tb_MaVe.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 28);
            this.label7.TabIndex = 46;
            this.label7.Text = "Mã chuyến bay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 28);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tên loại khoang:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Số ghế:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mã hành khách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 42;
            this.label3.Text = "Giá vé:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã vé:";
            // 
            // dgv_QuanLyVe
            // 
            this.dgv_QuanLyVe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_QuanLyVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuanLyVe.Location = new System.Drawing.Point(3, 2);
            this.dgv_QuanLyVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_QuanLyVe.Name = "dgv_QuanLyVe";
            this.dgv_QuanLyVe.RowHeadersWidth = 62;
            this.dgv_QuanLyVe.RowTemplate.Height = 28;
            this.dgv_QuanLyVe.Size = new System.Drawing.Size(984, 272);
            this.dgv_QuanLyVe.TabIndex = 0;
            this.dgv_QuanLyVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QuanLyVe_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_QuanLyHanhKhach);
            this.panel2.Controls.Add(this.btn_ThongKe);
            this.panel2.Controls.Add(this.dgv_QuanLyVe_ThongKe);
            this.panel2.Location = new System.Drawing.Point(3, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 532);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // btn_QuanLyHanhKhach
            // 
            this.btn_QuanLyHanhKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_QuanLyHanhKhach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyHanhKhach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_QuanLyHanhKhach.Location = new System.Drawing.Point(23, 443);
            this.btn_QuanLyHanhKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QuanLyHanhKhach.Name = "btn_QuanLyHanhKhach";
            this.btn_QuanLyHanhKhach.Size = new System.Drawing.Size(234, 75);
            this.btn_QuanLyHanhKhach.TabIndex = 55;
            this.btn_QuanLyHanhKhach.Text = "Quản lý hành khách";
            this.btn_QuanLyHanhKhach.UseVisualStyleBackColor = false;
            this.btn_QuanLyHanhKhach.Click += new System.EventHandler(this.btn_QuanLyHanhKhach_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThongKe.Location = new System.Drawing.Point(23, 397);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(234, 43);
            this.btn_ThongKe.TabIndex = 54;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // dgv_QuanLyVe_ThongKe
            // 
            this.dgv_QuanLyVe_ThongKe.AllowUserToResizeColumns = false;
            this.dgv_QuanLyVe_ThongKe.AllowUserToResizeRows = false;
            this.dgv_QuanLyVe_ThongKe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_QuanLyVe_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuanLyVe_ThongKe.Location = new System.Drawing.Point(2, 127);
            this.dgv_QuanLyVe_ThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_QuanLyVe_ThongKe.Name = "dgv_QuanLyVe_ThongKe";
            this.dgv_QuanLyVe_ThongKe.RowHeadersVisible = false;
            this.dgv_QuanLyVe_ThongKe.RowHeadersWidth = 62;
            this.dgv_QuanLyVe_ThongKe.RowTemplate.Height = 28;
            this.dgv_QuanLyVe_ThongKe.Size = new System.Drawing.Size(280, 259);
            this.dgv_QuanLyVe_ThongKe.TabIndex = 53;
            // 
            // FormQuanLyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1295, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuanLyVe";
            this.Text = "FormQuanLyVe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyVe)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyVe_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_QuanLyVe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TenLoaiKhoang;
        private System.Windows.Forms.TextBox tb_MaChuyenBay;
        private System.Windows.Forms.TextBox tb_SoGhe;
        private System.Windows.Forms.TextBox tb_MaHanhKhach;
        private System.Windows.Forms.TextBox tb_GiaVe;
        private System.Windows.Forms.TextBox tb_MaVe;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_QuanLyHanhKhach;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.DataGridView dgv_QuanLyVe_ThongKe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}