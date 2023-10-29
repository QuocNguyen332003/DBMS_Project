namespace DBMS_Project
{
    partial class FormQuanLyMayBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyMayBay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Quanlymaybay = new System.Windows.Forms.DataGridView();
            this.SoHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiMayBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Capnhat = new System.Windows.Forms.Panel();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tinhtrang = new System.Windows.Forms.TextBox();
            this.tb_tongsoghe = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.tb_sohieu = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_Timkiem = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.tb_timtinhtrang = new System.Windows.Forms.TextBox();
            this.tb_timtongsoghe = new System.Windows.Forms.TextBox();
            this.tb_timten = new System.Windows.Forms.TextBox();
            this.tb_timsohieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quanlymaybay)).BeginInit();
            this.pnl_Capnhat.SuspendLayout();
            this.pnl_Timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgv_Quanlymaybay);
            this.panel1.Controls.Add(this.pnl_Capnhat);
            this.panel1.Controls.Add(this.pnl_Timkiem);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 517);
            this.panel1.TabIndex = 0;
            // 
            // dgv_Quanlymaybay
            // 
            this.dgv_Quanlymaybay.AllowUserToResizeColumns = false;
            this.dgv_Quanlymaybay.AllowUserToResizeRows = false;
            this.dgv_Quanlymaybay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Quanlymaybay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Quanlymaybay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHieu,
            this.TenLoaiMayBay,
            this.TongSoGhe,
            this.TinhTrangHD});
            this.dgv_Quanlymaybay.Location = new System.Drawing.Point(351, 3);
            this.dgv_Quanlymaybay.Name = "dgv_Quanlymaybay";
            this.dgv_Quanlymaybay.RowHeadersVisible = false;
            this.dgv_Quanlymaybay.RowHeadersWidth = 51;
            this.dgv_Quanlymaybay.RowTemplate.Height = 24;
            this.dgv_Quanlymaybay.Size = new System.Drawing.Size(846, 238);
            this.dgv_Quanlymaybay.TabIndex = 58;
            // 
            // SoHieu
            // 
            this.SoHieu.HeaderText = "Số hiệu";
            this.SoHieu.MinimumWidth = 6;
            this.SoHieu.Name = "SoHieu";
            this.SoHieu.Width = 125;
            // 
            // TenLoaiMayBay
            // 
            this.TenLoaiMayBay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiMayBay.HeaderText = "Tên loại máy bay";
            this.TenLoaiMayBay.MinimumWidth = 6;
            this.TenLoaiMayBay.Name = "TenLoaiMayBay";
            // 
            // TongSoGhe
            // 
            this.TongSoGhe.HeaderText = "Tổng số ghế";
            this.TongSoGhe.MinimumWidth = 6;
            this.TongSoGhe.Name = "TongSoGhe";
            this.TongSoGhe.Width = 125;
            // 
            // TinhTrangHD
            // 
            this.TinhTrangHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrangHD.HeaderText = "Tình trạng hoạt ";
            this.TinhTrangHD.MinimumWidth = 6;
            this.TinhTrangHD.Name = "TinhTrangHD";
            // 
            // pnl_Capnhat
            // 
            this.pnl_Capnhat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Capnhat.Controls.Add(this.btn_huy);
            this.pnl_Capnhat.Controls.Add(this.label10);
            this.pnl_Capnhat.Controls.Add(this.label9);
            this.pnl_Capnhat.Controls.Add(this.label8);
            this.pnl_Capnhat.Controls.Add(this.label7);
            this.pnl_Capnhat.Controls.Add(this.tb_tinhtrang);
            this.pnl_Capnhat.Controls.Add(this.tb_tongsoghe);
            this.pnl_Capnhat.Controls.Add(this.tb_ten);
            this.pnl_Capnhat.Controls.Add(this.btn_luu);
            this.pnl_Capnhat.Controls.Add(this.tb_sohieu);
            this.pnl_Capnhat.Controls.Add(this.btn_sua);
            this.pnl_Capnhat.Controls.Add(this.btn_xoa);
            this.pnl_Capnhat.Controls.Add(this.btn_them);
            this.pnl_Capnhat.Controls.Add(this.label6);
            this.pnl_Capnhat.Location = new System.Drawing.Point(351, 247);
            this.pnl_Capnhat.Name = "pnl_Capnhat";
            this.pnl_Capnhat.Size = new System.Drawing.Size(846, 263);
            this.pnl_Capnhat.TabIndex = 57;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Location = new System.Drawing.Point(642, 201);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(197, 43);
            this.btn_huy.TabIndex = 35;
            this.btn_huy.Text = "Hủy thao tác";
            this.btn_huy.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(215, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 28);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tình trạng HĐ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(229, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tổng số ghế:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 28);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tên loại MB:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Số hiệu:";
            // 
            // tb_tinhtrang
            // 
            this.tb_tinhtrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_tinhtrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tinhtrang.Location = new System.Drawing.Point(379, 205);
            this.tb_tinhtrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tinhtrang.Multiline = true;
            this.tb_tinhtrang.Name = "tb_tinhtrang";
            this.tb_tinhtrang.Size = new System.Drawing.Size(239, 30);
            this.tb_tinhtrang.TabIndex = 34;
            // 
            // tb_tongsoghe
            // 
            this.tb_tongsoghe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_tongsoghe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tongsoghe.Location = new System.Drawing.Point(379, 159);
            this.tb_tongsoghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tongsoghe.Multiline = true;
            this.tb_tongsoghe.Name = "tb_tongsoghe";
            this.tb_tongsoghe.Size = new System.Drawing.Size(239, 30);
            this.tb_tongsoghe.TabIndex = 33;
            // 
            // tb_ten
            // 
            this.tb_ten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_ten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten.Location = new System.Drawing.Point(379, 110);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ten.Multiline = true;
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(239, 30);
            this.tb_ten.TabIndex = 32;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Location = new System.Drawing.Point(642, 144);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(197, 43);
            this.btn_luu.TabIndex = 31;
            this.btn_luu.Text = "Lưu thay đổi";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // tb_sohieu
            // 
            this.tb_sohieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_sohieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sohieu.Location = new System.Drawing.Point(379, 64);
            this.tb_sohieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sohieu.Multiline = true;
            this.tb_sohieu.Name = "tb_sohieu";
            this.tb_sohieu.Size = new System.Drawing.Size(239, 30);
            this.tb_sohieu.TabIndex = 28;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(8, 199);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(197, 43);
            this.btn_sua.TabIndex = 30;
            this.btn_sua.Text = "Thay đổi thông tin";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(8, 135);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(197, 43);
            this.btn_xoa.TabIndex = 29;
            this.btn_xoa.Text = "Xóa máy bay";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(8, 76);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(197, 43);
            this.btn_them.TabIndex = 28;
            this.btn_them.Text = "Thêm máy bay";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cập nhật máy bay";
            // 
            // pnl_Timkiem
            // 
            this.pnl_Timkiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Timkiem.Controls.Add(this.button1);
            this.pnl_Timkiem.Controls.Add(this.btn_Tim);
            this.pnl_Timkiem.Controls.Add(this.tb_timtinhtrang);
            this.pnl_Timkiem.Controls.Add(this.tb_timtongsoghe);
            this.pnl_Timkiem.Controls.Add(this.tb_timten);
            this.pnl_Timkiem.Controls.Add(this.tb_timsohieu);
            this.pnl_Timkiem.Controls.Add(this.label5);
            this.pnl_Timkiem.Controls.Add(this.label4);
            this.pnl_Timkiem.Controls.Add(this.label3);
            this.pnl_Timkiem.Controls.Add(this.label2);
            this.pnl_Timkiem.Controls.Add(this.lb_id);
            this.pnl_Timkiem.Controls.Add(this.pictureBox1);
            this.pnl_Timkiem.Location = new System.Drawing.Point(3, 3);
            this.pnl_Timkiem.Name = "pnl_Timkiem";
            this.pnl_Timkiem.Size = new System.Drawing.Size(342, 507);
            this.pnl_Timkiem.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(8, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 43);
            this.button1.TabIndex = 27;
            this.button1.Text = "Quản lý khoang máy bay";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Tim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tim.Location = new System.Drawing.Point(8, 409);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(318, 43);
            this.btn_Tim.TabIndex = 16;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = false;
            // 
            // tb_timtinhtrang
            // 
            this.tb_timtinhtrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_timtinhtrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timtinhtrang.Location = new System.Drawing.Point(148, 358);
            this.tb_timtinhtrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_timtinhtrang.Multiline = true;
            this.tb_timtinhtrang.Name = "tb_timtinhtrang";
            this.tb_timtinhtrang.Size = new System.Drawing.Size(178, 30);
            this.tb_timtinhtrang.TabIndex = 26;
            // 
            // tb_timtongsoghe
            // 
            this.tb_timtongsoghe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_timtongsoghe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timtongsoghe.Location = new System.Drawing.Point(148, 295);
            this.tb_timtongsoghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_timtongsoghe.Multiline = true;
            this.tb_timtongsoghe.Name = "tb_timtongsoghe";
            this.tb_timtongsoghe.Size = new System.Drawing.Size(178, 30);
            this.tb_timtongsoghe.TabIndex = 25;
            // 
            // tb_timten
            // 
            this.tb_timten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_timten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timten.Location = new System.Drawing.Point(148, 237);
            this.tb_timten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_timten.Multiline = true;
            this.tb_timten.Name = "tb_timten";
            this.tb_timten.Size = new System.Drawing.Size(178, 30);
            this.tb_timten.TabIndex = 24;
            // 
            // tb_timsohieu
            // 
            this.tb_timsohieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_timsohieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timsohieu.Location = new System.Drawing.Point(148, 173);
            this.tb_timsohieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_timsohieu.Multiline = true;
            this.tb_timsohieu.Name = "tb_timsohieu";
            this.tb_timsohieu.Size = new System.Drawing.Size(178, 30);
            this.tb_timsohieu.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-4, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tình trạng HĐ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tổng số ghế:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên loại MB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số hiệu:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(109, 125);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(100, 28);
            this.lb_id.TabIndex = 18;
            this.lb_id.Text = "Tìm kiếm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(467, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ MÁY BAY";
            // 
            // FormQuanLyMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1229, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLyMayBay";
            this.Text = "FormQuanLyMayBay";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quanlymaybay)).EndInit();
            this.pnl_Capnhat.ResumeLayout(false);
            this.pnl_Capnhat.PerformLayout();
            this.pnl_Timkiem.ResumeLayout(false);
            this.pnl_Timkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Quanlymaybay;
        private System.Windows.Forms.Panel pnl_Capnhat;
        private System.Windows.Forms.Panel pnl_Timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiMayBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangHD;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_timtinhtrang;
        private System.Windows.Forms.TextBox tb_timtongsoghe;
        private System.Windows.Forms.TextBox tb_timten;
        private System.Windows.Forms.TextBox tb_timsohieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tinhtrang;
        private System.Windows.Forms.TextBox tb_tongsoghe;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox tb_sohieu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}