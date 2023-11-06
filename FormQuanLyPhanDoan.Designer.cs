namespace DBMS_Project
{
    partial class FormQuanLyPhanDoan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyPhanDoan));
            this.pnlmain = new System.Windows.Forms.Panel();
            this.pnl_modify = new System.Windows.Forms.Panel();
            this.pnlEnabled = new System.Windows.Forms.Panel();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.cbb_SoHieu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_stt = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_sanbayden = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbb_sanbaydi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtp_ngayden = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtp_ngaydi = new System.Windows.Forms.DateTimePicker();
            this.nud_gioden = new System.Windows.Forms.NumericUpDown();
            this.nud_giodi = new System.Windows.Forms.NumericUpDown();
            this.nud_phutden = new System.Windows.Forms.NumericUpDown();
            this.nud_phutdi = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_phandoan = new System.Windows.Forms.DataGridView();
            this.maChuyenBayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiMayBayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSanBayKhoiHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSanBayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanDoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMS_DataSet = new DBMS_Project.DBMS_DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.phanDoanTableAdapter = new DBMS_Project.DBMS_DataSetTableAdapters.PhanDoanTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlmain.SuspendLayout();
            this.pnl_modify.SuspendLayout();
            this.pnlEnabled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gioden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phandoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanDoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.Color.White;
            this.pnlmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmain.Controls.Add(this.pnl_modify);
            this.pnlmain.Controls.Add(this.dgv_phandoan);
            this.pnlmain.Location = new System.Drawing.Point(12, 51);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1326, 639);
            this.pnlmain.TabIndex = 3;
            // 
            // pnl_modify
            // 
            this.pnl_modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_modify.Controls.Add(this.pnlEnabled);
            this.pnl_modify.Controls.Add(this.pictureBox1);
            this.pnl_modify.Controls.Add(this.btn_xoa);
            this.pnl_modify.Controls.Add(this.btn_sua);
            this.pnl_modify.Controls.Add(this.btn_them);
            this.pnl_modify.Location = new System.Drawing.Point(15, 329);
            this.pnl_modify.Name = "pnl_modify";
            this.pnl_modify.Size = new System.Drawing.Size(1293, 293);
            this.pnl_modify.TabIndex = 4;
            // 
            // pnlEnabled
            // 
            this.pnlEnabled.Controls.Add(this.button1);
            this.pnlEnabled.Controls.Add(this.cbb_loai);
            this.pnlEnabled.Controls.Add(this.cbb_SoHieu);
            this.pnlEnabled.Controls.Add(this.label9);
            this.pnlEnabled.Controls.Add(this.label10);
            this.pnlEnabled.Controls.Add(this.nud_stt);
            this.pnlEnabled.Controls.Add(this.label11);
            this.pnlEnabled.Controls.Add(this.cbb_sanbayden);
            this.pnlEnabled.Controls.Add(this.label14);
            this.pnlEnabled.Controls.Add(this.cbb_sanbaydi);
            this.pnlEnabled.Controls.Add(this.label13);
            this.pnlEnabled.Controls.Add(this.label12);
            this.pnlEnabled.Controls.Add(this.label5);
            this.pnlEnabled.Controls.Add(this.btn_luu);
            this.pnlEnabled.Controls.Add(this.label4);
            this.pnlEnabled.Controls.Add(this.btn_huy);
            this.pnlEnabled.Controls.Add(this.label3);
            this.pnlEnabled.Controls.Add(this.txt_id);
            this.pnlEnabled.Controls.Add(this.label2);
            this.pnlEnabled.Controls.Add(this.label15);
            this.pnlEnabled.Controls.Add(this.label17);
            this.pnlEnabled.Controls.Add(this.dtp_ngayden);
            this.pnlEnabled.Controls.Add(this.label16);
            this.pnlEnabled.Controls.Add(this.dtp_ngaydi);
            this.pnlEnabled.Controls.Add(this.nud_gioden);
            this.pnlEnabled.Controls.Add(this.nud_giodi);
            this.pnlEnabled.Controls.Add(this.nud_phutden);
            this.pnlEnabled.Controls.Add(this.nud_phutdi);
            this.pnlEnabled.Enabled = false;
            this.pnlEnabled.Location = new System.Drawing.Point(221, 0);
            this.pnlEnabled.Name = "pnlEnabled";
            this.pnlEnabled.Size = new System.Drawing.Size(1067, 288);
            this.pnlEnabled.TabIndex = 5;
            // 
            // cbb_loai
            // 
            this.cbb_loai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_loai.FormattingEnabled = true;
            this.cbb_loai.Location = new System.Drawing.Point(214, 124);
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(248, 36);
            this.cbb_loai.TabIndex = 101;
            this.cbb_loai.SelectedIndexChanged += new System.EventHandler(this.cbb_loai_SelectedValueChanged);
            // 
            // cbb_SoHieu
            // 
            this.cbb_SoHieu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_SoHieu.FormattingEnabled = true;
            this.cbb_SoHieu.Location = new System.Drawing.Point(854, 59);
            this.cbb_SoHieu.Name = "cbb_SoHieu";
            this.cbb_SoHieu.Size = new System.Drawing.Size(160, 36);
            this.cbb_SoHieu.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(29, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 28);
            this.label9.TabIndex = 71;
            this.label9.Text = "Cập nhật phân đoạn:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 30);
            this.label10.TabIndex = 72;
            this.label10.Text = "Mã chuyến bay:";
            // 
            // nud_stt
            // 
            this.nud_stt.Enabled = false;
            this.nud_stt.Location = new System.Drawing.Point(530, 74);
            this.nud_stt.Name = "nud_stt";
            this.nud_stt.Size = new System.Drawing.Size(54, 22);
            this.nud_stt.TabIndex = 99;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 30);
            this.label11.TabIndex = 73;
            this.label11.Text = "Tên loại máy bay:";
            // 
            // cbb_sanbayden
            // 
            this.cbb_sanbayden.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_sanbayden.FormattingEnabled = true;
            this.cbb_sanbayden.Location = new System.Drawing.Point(214, 246);
            this.cbb_sanbayden.Name = "cbb_sanbayden";
            this.cbb_sanbayden.Size = new System.Drawing.Size(160, 36);
            this.cbb_sanbayden.TabIndex = 98;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(415, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 30);
            this.label14.TabIndex = 73;
            this.label14.Text = "Giờ đến:";
            // 
            // cbb_sanbaydi
            // 
            this.cbb_sanbaydi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_sanbaydi.FormattingEnabled = true;
            this.cbb_sanbaydi.Location = new System.Drawing.Point(214, 183);
            this.cbb_sanbaydi.Name = "cbb_sanbaydi";
            this.cbb_sanbaydi.Size = new System.Drawing.Size(160, 36);
            this.cbb_sanbaydi.TabIndex = 97;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(706, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 30);
            this.label13.TabIndex = 72;
            this.label13.Text = "Ngày đi:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(415, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 30);
            this.label12.TabIndex = 71;
            this.label12.Text = "Giờ đi:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 30);
            this.label5.TabIndex = 93;
            this.label5.Text = "Mã sân bay đi:";
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Location = new System.Drawing.Point(711, 224);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(159, 46);
            this.btn_luu.TabIndex = 77;
            this.btn_luu.Text = "Lưu thay đổi";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 30);
            this.label4.TabIndex = 92;
            this.label4.Text = "Mã sân bay đến:";
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Location = new System.Drawing.Point(893, 224);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(171, 45);
            this.btn_huy.TabIndex = 77;
            this.btn_huy.Text = "Hủy thao tác";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(706, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 91;
            this.label3.Text = "Số hiệu:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(214, 66);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(160, 30);
            this.txt_id.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 90;
            this.label2.Text = "STT:";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(706, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 30);
            this.label15.TabIndex = 74;
            this.label15.Text = "Ngày đến:";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(590, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 30);
            this.label17.TabIndex = 89;
            this.label17.Text = "h";
            // 
            // dtp_ngayden
            // 
            this.dtp_ngayden.Location = new System.Drawing.Point(832, 185);
            this.dtp_ngayden.Name = "dtp_ngayden";
            this.dtp_ngayden.Size = new System.Drawing.Size(232, 22);
            this.dtp_ngayden.TabIndex = 82;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(590, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 30);
            this.label16.TabIndex = 88;
            this.label16.Text = "h";
            // 
            // dtp_ngaydi
            // 
            this.dtp_ngaydi.Location = new System.Drawing.Point(832, 129);
            this.dtp_ngaydi.Name = "dtp_ngaydi";
            this.dtp_ngaydi.Size = new System.Drawing.Size(232, 22);
            this.dtp_ngaydi.TabIndex = 83;
            // 
            // nud_gioden
            // 
            this.nud_gioden.Location = new System.Drawing.Point(530, 248);
            this.nud_gioden.Name = "nud_gioden";
            this.nud_gioden.Size = new System.Drawing.Size(54, 22);
            this.nud_gioden.TabIndex = 87;
            // 
            // nud_giodi
            // 
            this.nud_giodi.Location = new System.Drawing.Point(530, 188);
            this.nud_giodi.Name = "nud_giodi";
            this.nud_giodi.Size = new System.Drawing.Size(54, 22);
            this.nud_giodi.TabIndex = 84;
            // 
            // nud_phutden
            // 
            this.nud_phutden.Location = new System.Drawing.Point(627, 248);
            this.nud_phutden.Name = "nud_phutden";
            this.nud_phutden.Size = new System.Drawing.Size(54, 22);
            this.nud_phutden.TabIndex = 86;
            // 
            // nud_phutdi
            // 
            this.nud_phutdi.Location = new System.Drawing.Point(627, 188);
            this.nud_phutdi.Name = "nud_phutdi";
            this.nud_phutdi.Size = new System.Drawing.Size(54, 22);
            this.nud_phutdi.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(14, 232);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(200, 45);
            this.btn_xoa.TabIndex = 76;
            this.btn_xoa.Text = "Xóa phân đoạn";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(14, 158);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(199, 72);
            this.btn_sua.TabIndex = 75;
            this.btn_sua.Text = "Thay đổi thông tin phân đoạn";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(14, 113);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(200, 45);
            this.btn_them.TabIndex = 71;
            this.btn_them.Text = "Thêm phân đoạn";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_phandoan
            // 
            this.dgv_phandoan.AllowUserToResizeColumns = false;
            this.dgv_phandoan.AllowUserToResizeRows = false;
            this.dgv_phandoan.AutoGenerateColumns = false;
            this.dgv_phandoan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_phandoan.ColumnHeadersHeight = 29;
            this.dgv_phandoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChuyenBayDataGridViewTextBoxColumn,
            this.sTTDataGridViewTextBoxColumn,
            this.soHieuDataGridViewTextBoxColumn,
            this.tenLoaiMayBayDataGridViewTextBoxColumn,
            this.maSanBayKhoiHanhDataGridViewTextBoxColumn,
            this.gioDiDataGridViewTextBoxColumn,
            this.ngayDiDataGridViewTextBoxColumn,
            this.maSanBayDenDataGridViewTextBoxColumn,
            this.gioDenDataGridViewTextBoxColumn,
            this.ngayDenDataGridViewTextBoxColumn});
            this.dgv_phandoan.DataSource = this.phanDoanBindingSource;
            this.dgv_phandoan.Location = new System.Drawing.Point(15, 12);
            this.dgv_phandoan.Name = "dgv_phandoan";
            this.dgv_phandoan.RowHeadersVisible = false;
            this.dgv_phandoan.RowHeadersWidth = 51;
            this.dgv_phandoan.RowTemplate.Height = 24;
            this.dgv_phandoan.Size = new System.Drawing.Size(1293, 311);
            this.dgv_phandoan.TabIndex = 3;
            this.dgv_phandoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phandoan_CellClick);
            // 
            // maChuyenBayDataGridViewTextBoxColumn
            // 
            this.maChuyenBayDataGridViewTextBoxColumn.DataPropertyName = "MaChuyenBay";
            this.maChuyenBayDataGridViewTextBoxColumn.HeaderText = "MaChuyenBay";
            this.maChuyenBayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maChuyenBayDataGridViewTextBoxColumn.Name = "maChuyenBayDataGridViewTextBoxColumn";
            this.maChuyenBayDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // soHieuDataGridViewTextBoxColumn
            // 
            this.soHieuDataGridViewTextBoxColumn.DataPropertyName = "SoHieu";
            this.soHieuDataGridViewTextBoxColumn.HeaderText = "SoHieu";
            this.soHieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soHieuDataGridViewTextBoxColumn.Name = "soHieuDataGridViewTextBoxColumn";
            this.soHieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenLoaiMayBayDataGridViewTextBoxColumn
            // 
            this.tenLoaiMayBayDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiMayBay";
            this.tenLoaiMayBayDataGridViewTextBoxColumn.HeaderText = "TenLoaiMayBay";
            this.tenLoaiMayBayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiMayBayDataGridViewTextBoxColumn.Name = "tenLoaiMayBayDataGridViewTextBoxColumn";
            this.tenLoaiMayBayDataGridViewTextBoxColumn.Width = 125;
            // 
            // maSanBayKhoiHanhDataGridViewTextBoxColumn
            // 
            this.maSanBayKhoiHanhDataGridViewTextBoxColumn.DataPropertyName = "MaSanBayKhoiHanh";
            this.maSanBayKhoiHanhDataGridViewTextBoxColumn.HeaderText = "MaSanBayKhoiHanh";
            this.maSanBayKhoiHanhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSanBayKhoiHanhDataGridViewTextBoxColumn.Name = "maSanBayKhoiHanhDataGridViewTextBoxColumn";
            this.maSanBayKhoiHanhDataGridViewTextBoxColumn.Width = 150;
            // 
            // gioDiDataGridViewTextBoxColumn
            // 
            this.gioDiDataGridViewTextBoxColumn.DataPropertyName = "GioDi";
            this.gioDiDataGridViewTextBoxColumn.HeaderText = "GioDi";
            this.gioDiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioDiDataGridViewTextBoxColumn.Name = "gioDiDataGridViewTextBoxColumn";
            this.gioDiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayDiDataGridViewTextBoxColumn
            // 
            this.ngayDiDataGridViewTextBoxColumn.DataPropertyName = "NgayDi";
            this.ngayDiDataGridViewTextBoxColumn.HeaderText = "NgayDi";
            this.ngayDiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDiDataGridViewTextBoxColumn.Name = "ngayDiDataGridViewTextBoxColumn";
            this.ngayDiDataGridViewTextBoxColumn.Width = 125;
            // 
            // maSanBayDenDataGridViewTextBoxColumn
            // 
            this.maSanBayDenDataGridViewTextBoxColumn.DataPropertyName = "MaSanBayDen";
            this.maSanBayDenDataGridViewTextBoxColumn.HeaderText = "MaSanBayDen";
            this.maSanBayDenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSanBayDenDataGridViewTextBoxColumn.Name = "maSanBayDenDataGridViewTextBoxColumn";
            this.maSanBayDenDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioDenDataGridViewTextBoxColumn
            // 
            this.gioDenDataGridViewTextBoxColumn.DataPropertyName = "GioDen";
            this.gioDenDataGridViewTextBoxColumn.HeaderText = "GioDen";
            this.gioDenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioDenDataGridViewTextBoxColumn.Name = "gioDenDataGridViewTextBoxColumn";
            this.gioDenDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayDenDataGridViewTextBoxColumn
            // 
            this.ngayDenDataGridViewTextBoxColumn.DataPropertyName = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.HeaderText = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDenDataGridViewTextBoxColumn.Name = "ngayDenDataGridViewTextBoxColumn";
            this.ngayDenDataGridViewTextBoxColumn.Width = 125;
            // 
            // phanDoanBindingSource
            // 
            this.phanDoanBindingSource.DataMember = "PhanDoan";
            this.phanDoanBindingSource.DataSource = this.dBMS_DataSet;
            // 
            // dBMS_DataSet
            // 
            this.dBMS_DataSet.DataSetName = "DBMS_DataSet";
            this.dBMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ PHÂN ĐOẠN";
            // 
            // phanDoanTableAdapter
            // 
            this.phanDoanTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.button1.Location = new System.Drawing.Point(468, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 36);
            this.button1.TabIndex = 102;
            this.button1.Text = "Xem công ty";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormQuanLyPhanDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1350, 704);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuanLyPhanDoan";
            this.Text = "FormQuanLyPhanDoan";
            this.Load += new System.EventHandler(this.FormQuanLyPhanDoan_Load);
            this.pnlmain.ResumeLayout(false);
            this.pnl_modify.ResumeLayout(false);
            this.pnlEnabled.ResumeLayout(false);
            this.pnlEnabled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gioden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phandoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanDoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Panel pnl_modify;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nud_gioden;
        private System.Windows.Forms.NumericUpDown nud_phutden;
        private System.Windows.Forms.NumericUpDown nud_phutdi;
        private System.Windows.Forms.NumericUpDown nud_giodi;
        private System.Windows.Forms.DateTimePicker dtp_ngaydi;
        private System.Windows.Forms.DateTimePicker dtp_ngayden;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_phandoan;
        private System.Windows.Forms.Label label1;
        private DBMS_DataSet dBMS_DataSet;
        private System.Windows.Forms.BindingSource phanDoanBindingSource;
        private DBMS_DataSetTableAdapters.PhanDoanTableAdapter phanDoanTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenBayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiMayBayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanBayKhoiHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanBayDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown nud_stt;
        private System.Windows.Forms.ComboBox cbb_sanbayden;
        private System.Windows.Forms.ComboBox cbb_sanbaydi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlEnabled;
        private System.Windows.Forms.ComboBox cbb_SoHieu;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.Button button1;
    }
}