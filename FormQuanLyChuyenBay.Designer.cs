namespace DBMS_Project
{
    partial class FormQuanLyChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyChuyenBay));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.pnltimkiem = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_QLphandoan = new System.Windows.Forms.Button();
            this.cbb_id = new System.Windows.Forms.ComboBox();
            this.cbb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.cbb_giodi = new System.Windows.Forms.ComboBox();
            this.cbb_ngaydi = new System.Windows.Forms.ComboBox();
            this.cbb_gioden = new System.Windows.Forms.ComboBox();
            this.cbb_ngayden = new System.Windows.Forms.ComboBox();
            this.dgv_chuyenbay = new System.Windows.Forms.DataGridView();
            this.dBMS_DataSet = new DBMS_Project.DBMS_DataSet();
            this.chuyenBayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chuyenBayTableAdapter = new DBMS_Project.DBMS_DataSetTableAdapters.ChuyenBayTableAdapter();
            this.maChuyenBayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_modify = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.nud_giodi = new System.Windows.Forms.NumericUpDown();
            this.nud_phutdi = new System.Windows.Forms.NumericUpDown();
            this.nud_phutden = new System.Windows.Forms.NumericUpDown();
            this.nud_gioden = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlmain.SuspendLayout();
            this.pnltimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenbay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenBayBindingSource)).BeginInit();
            this.pnl_modify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gioden)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHUYẾN BAY";
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.Color.White;
            this.pnlmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmain.Controls.Add(this.pnl_modify);
            this.pnlmain.Controls.Add(this.dgv_chuyenbay);
            this.pnlmain.Controls.Add(this.pnltimkiem);
            this.pnlmain.Location = new System.Drawing.Point(12, 61);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1142, 625);
            this.pnlmain.TabIndex = 1;
            // 
            // pnltimkiem
            // 
            this.pnltimkiem.BackColor = System.Drawing.Color.White;
            this.pnltimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnltimkiem.Controls.Add(this.cbb_ngayden);
            this.pnltimkiem.Controls.Add(this.cbb_gioden);
            this.pnltimkiem.Controls.Add(this.cbb_ngaydi);
            this.pnltimkiem.Controls.Add(this.cbb_giodi);
            this.pnltimkiem.Controls.Add(this.cbb_tinhtrang);
            this.pnltimkiem.Controls.Add(this.cbb_id);
            this.pnltimkiem.Controls.Add(this.btn_QLphandoan);
            this.pnltimkiem.Controls.Add(this.label8);
            this.pnltimkiem.Controls.Add(this.btn_TimKiem);
            this.pnltimkiem.Controls.Add(this.label7);
            this.pnltimkiem.Controls.Add(this.label5);
            this.pnltimkiem.Controls.Add(this.label4);
            this.pnltimkiem.Controls.Add(this.label3);
            this.pnltimkiem.Controls.Add(this.label2);
            this.pnltimkiem.Controls.Add(this.label6);
            this.pnltimkiem.Controls.Add(this.pictureBox1);
            this.pnltimkiem.Location = new System.Drawing.Point(8, 8);
            this.pnltimkiem.Name = "pnltimkiem";
            this.pnltimkiem.Size = new System.Drawing.Size(294, 606);
            this.pnltimkiem.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 59;
            this.label6.Text = "Tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mã chuyến bay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tình trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 61;
            this.label4.Text = "Giờ đi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 62;
            this.label5.Text = "Ngày đi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 28);
            this.label7.TabIndex = 63;
            this.label7.Text = "Giờ đến:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 28);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ngày đến:";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimKiem.Location = new System.Drawing.Point(8, 494);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(255, 43);
            this.btn_TimKiem.TabIndex = 55;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // btn_QLphandoan
            // 
            this.btn_QLphandoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_QLphandoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLphandoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_QLphandoan.Location = new System.Drawing.Point(8, 545);
            this.btn_QLphandoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLphandoan.Name = "btn_QLphandoan";
            this.btn_QLphandoan.Size = new System.Drawing.Size(255, 43);
            this.btn_QLphandoan.TabIndex = 56;
            this.btn_QLphandoan.Text = "Quản lý phân đoạn";
            this.btn_QLphandoan.UseVisualStyleBackColor = false;
            // 
            // cbb_id
            // 
            this.cbb_id.FormattingEnabled = true;
            this.cbb_id.Location = new System.Drawing.Point(164, 190);
            this.cbb_id.Name = "cbb_id";
            this.cbb_id.Size = new System.Drawing.Size(121, 24);
            this.cbb_id.TabIndex = 65;
            // 
            // cbb_tinhtrang
            // 
            this.cbb_tinhtrang.FormattingEnabled = true;
            this.cbb_tinhtrang.Location = new System.Drawing.Point(164, 240);
            this.cbb_tinhtrang.Name = "cbb_tinhtrang";
            this.cbb_tinhtrang.Size = new System.Drawing.Size(121, 24);
            this.cbb_tinhtrang.TabIndex = 66;
            // 
            // cbb_giodi
            // 
            this.cbb_giodi.FormattingEnabled = true;
            this.cbb_giodi.Location = new System.Drawing.Point(164, 290);
            this.cbb_giodi.Name = "cbb_giodi";
            this.cbb_giodi.Size = new System.Drawing.Size(121, 24);
            this.cbb_giodi.TabIndex = 67;
            // 
            // cbb_ngaydi
            // 
            this.cbb_ngaydi.FormattingEnabled = true;
            this.cbb_ngaydi.Location = new System.Drawing.Point(164, 340);
            this.cbb_ngaydi.Name = "cbb_ngaydi";
            this.cbb_ngaydi.Size = new System.Drawing.Size(121, 24);
            this.cbb_ngaydi.TabIndex = 68;
            // 
            // cbb_gioden
            // 
            this.cbb_gioden.FormattingEnabled = true;
            this.cbb_gioden.Location = new System.Drawing.Point(164, 390);
            this.cbb_gioden.Name = "cbb_gioden";
            this.cbb_gioden.Size = new System.Drawing.Size(121, 24);
            this.cbb_gioden.TabIndex = 69;
            // 
            // cbb_ngayden
            // 
            this.cbb_ngayden.FormattingEnabled = true;
            this.cbb_ngayden.Location = new System.Drawing.Point(164, 440);
            this.cbb_ngayden.Name = "cbb_ngayden";
            this.cbb_ngayden.Size = new System.Drawing.Size(121, 24);
            this.cbb_ngayden.TabIndex = 70;
            // 
            // dgv_chuyenbay
            // 
            this.dgv_chuyenbay.AllowUserToResizeColumns = false;
            this.dgv_chuyenbay.AllowUserToResizeRows = false;
            this.dgv_chuyenbay.AutoGenerateColumns = false;
            this.dgv_chuyenbay.BackgroundColor = System.Drawing.Color.White;
            this.dgv_chuyenbay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chuyenbay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChuyenBayDataGridViewTextBoxColumn,
            this.tinhTrangHDDataGridViewTextBoxColumn,
            this.gioDiDataGridViewTextBoxColumn,
            this.ngayDiDataGridViewTextBoxColumn,
            this.gioDenDataGridViewTextBoxColumn,
            this.ngayDenDataGridViewTextBoxColumn});
            this.dgv_chuyenbay.DataSource = this.chuyenBayBindingSource;
            this.dgv_chuyenbay.Location = new System.Drawing.Point(308, 12);
            this.dgv_chuyenbay.Name = "dgv_chuyenbay";
            this.dgv_chuyenbay.RowHeadersVisible = false;
            this.dgv_chuyenbay.RowHeadersWidth = 51;
            this.dgv_chuyenbay.RowTemplate.Height = 24;
            this.dgv_chuyenbay.Size = new System.Drawing.Size(806, 311);
            this.dgv_chuyenbay.TabIndex = 3;
            // 
            // dBMS_DataSet
            // 
            this.dBMS_DataSet.DataSetName = "DBMS_DataSet";
            this.dBMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chuyenBayBindingSource
            // 
            this.chuyenBayBindingSource.DataMember = "ChuyenBay";
            this.chuyenBayBindingSource.DataSource = this.dBMS_DataSet;
            // 
            // chuyenBayTableAdapter
            // 
            this.chuyenBayTableAdapter.ClearBeforeFill = true;
            // 
            // maChuyenBayDataGridViewTextBoxColumn
            // 
            this.maChuyenBayDataGridViewTextBoxColumn.DataPropertyName = "MaChuyenBay";
            this.maChuyenBayDataGridViewTextBoxColumn.HeaderText = "MaChuyenBay";
            this.maChuyenBayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maChuyenBayDataGridViewTextBoxColumn.Name = "maChuyenBayDataGridViewTextBoxColumn";
            this.maChuyenBayDataGridViewTextBoxColumn.Width = 125;
            // 
            // tinhTrangHDDataGridViewTextBoxColumn
            // 
            this.tinhTrangHDDataGridViewTextBoxColumn.DataPropertyName = "TinhTrangHD";
            this.tinhTrangHDDataGridViewTextBoxColumn.HeaderText = "TinhTrangHD";
            this.tinhTrangHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhTrangHDDataGridViewTextBoxColumn.Name = "tinhTrangHDDataGridViewTextBoxColumn";
            this.tinhTrangHDDataGridViewTextBoxColumn.Width = 125;
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
            // pnl_modify
            // 
            this.pnl_modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_modify.Controls.Add(this.label17);
            this.pnl_modify.Controls.Add(this.label16);
            this.pnl_modify.Controls.Add(this.nud_gioden);
            this.pnl_modify.Controls.Add(this.nud_phutden);
            this.pnl_modify.Controls.Add(this.nud_phutdi);
            this.pnl_modify.Controls.Add(this.nud_giodi);
            this.pnl_modify.Controls.Add(this.dateTimePicker2);
            this.pnl_modify.Controls.Add(this.dateTimePicker1);
            this.pnl_modify.Controls.Add(this.label15);
            this.pnl_modify.Controls.Add(this.txt_tinhtrang);
            this.pnl_modify.Controls.Add(this.txt_id);
            this.pnl_modify.Controls.Add(this.btn_huy);
            this.pnl_modify.Controls.Add(this.btn_luu);
            this.pnl_modify.Controls.Add(this.btn_xoa);
            this.pnl_modify.Controls.Add(this.btn_sua);
            this.pnl_modify.Controls.Add(this.btn_them);
            this.pnl_modify.Controls.Add(this.label12);
            this.pnl_modify.Controls.Add(this.label13);
            this.pnl_modify.Controls.Add(this.label14);
            this.pnl_modify.Controls.Add(this.label11);
            this.pnl_modify.Controls.Add(this.label10);
            this.pnl_modify.Controls.Add(this.label9);
            this.pnl_modify.Location = new System.Drawing.Point(308, 329);
            this.pnl_modify.Name = "pnl_modify";
            this.pnl_modify.Size = new System.Drawing.Size(806, 285);
            this.pnl_modify.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(13, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 28);
            this.label9.TabIndex = 71;
            this.label9.Text = "Cập nhật chuyến bay:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(220, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 30);
            this.label10.TabIndex = 72;
            this.label10.Text = "Mã chuyến bay:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 30);
            this.label11.TabIndex = 73;
            this.label11.Text = "Tình trạng:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(546, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 30);
            this.label12.TabIndex = 71;
            this.label12.Text = "Giờ đi:";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(220, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 30);
            this.label13.TabIndex = 72;
            this.label13.Text = "Ngày đi:";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(546, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 30);
            this.label14.TabIndex = 73;
            this.label14.Text = "Giờ đến:";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(220, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 30);
            this.label15.TabIndex = 74;
            this.label15.Text = "Ngày đến:";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(3, 69);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(199, 50);
            this.btn_them.TabIndex = 71;
            this.btn_them.Text = "Tạo chuyến bay";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(3, 123);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(199, 72);
            this.btn_sua.TabIndex = 75;
            this.btn_sua.Text = "Thay đổi thông tin chuyến bay";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(3, 199);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(199, 51);
            this.btn_xoa.TabIndex = 76;
            this.btn_xoa.Text = "Xóa chuyến bay";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Location = new System.Drawing.Point(589, 185);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(203, 43);
            this.btn_luu.TabIndex = 77;
            this.btn_luu.Text = "Lưu thay đổi";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Location = new System.Drawing.Point(589, 232);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(203, 43);
            this.btn_huy.TabIndex = 77;
            this.btn_huy.Text = "Hủy thao tác";
            this.btn_huy.UseVisualStyleBackColor = false;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(380, 60);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(160, 30);
            this.txt_id.TabIndex = 78;
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Location = new System.Drawing.Point(380, 120);
            this.txt_tinhtrang.Multiline = true;
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(160, 30);
            this.txt_tinhtrang.TabIndex = 79;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker1.TabIndex = 82;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(323, 185);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker2.TabIndex = 83;
            // 
            // nud_giodi
            // 
            this.nud_giodi.Location = new System.Drawing.Point(641, 65);
            this.nud_giodi.Name = "nud_giodi";
            this.nud_giodi.Size = new System.Drawing.Size(54, 22);
            this.nud_giodi.TabIndex = 84;
            // 
            // nud_phutdi
            // 
            this.nud_phutdi.Location = new System.Drawing.Point(738, 65);
            this.nud_phutdi.Name = "nud_phutdi";
            this.nud_phutdi.Size = new System.Drawing.Size(54, 22);
            this.nud_phutdi.TabIndex = 85;
            // 
            // nud_phutden
            // 
            this.nud_phutden.Location = new System.Drawing.Point(738, 125);
            this.nud_phutden.Name = "nud_phutden";
            this.nud_phutden.Size = new System.Drawing.Size(54, 22);
            this.nud_phutden.TabIndex = 86;
            // 
            // nud_gioden
            // 
            this.nud_gioden.Location = new System.Drawing.Point(641, 125);
            this.nud_gioden.Name = "nud_gioden";
            this.nud_gioden.Size = new System.Drawing.Size(54, 22);
            this.nud_gioden.TabIndex = 87;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(701, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 30);
            this.label16.TabIndex = 88;
            this.label16.Text = "h";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(701, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 30);
            this.label17.TabIndex = 89;
            this.label17.Text = "h";
            // 
            // FormQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1167, 699);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLyChuyenBay";
            this.Text = "FormQuanLyChuyenBay";
            this.Load += new System.EventHandler(this.FormQuanLyChuyenBay_Load);
            this.pnlmain.ResumeLayout(false);
            this.pnltimkiem.ResumeLayout(false);
            this.pnltimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenbay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenBayBindingSource)).EndInit();
            this.pnl_modify.ResumeLayout(false);
            this.pnl_modify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gioden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Panel pnltimkiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_QLphandoan;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_chuyenbay;
        private System.Windows.Forms.ComboBox cbb_ngayden;
        private System.Windows.Forms.ComboBox cbb_gioden;
        private System.Windows.Forms.ComboBox cbb_ngaydi;
        private System.Windows.Forms.ComboBox cbb_giodi;
        private System.Windows.Forms.ComboBox cbb_tinhtrang;
        private System.Windows.Forms.ComboBox cbb_id;
        private DBMS_DataSet dBMS_DataSet;
        private System.Windows.Forms.BindingSource chuyenBayBindingSource;
        private DBMS_DataSetTableAdapters.ChuyenBayTableAdapter chuyenBayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenBayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnl_modify;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_tinhtrang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nud_gioden;
        private System.Windows.Forms.NumericUpDown nud_phutden;
        private System.Windows.Forms.NumericUpDown nud_phutdi;
        private System.Windows.Forms.NumericUpDown nud_giodi;
    }
}