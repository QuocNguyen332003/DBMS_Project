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
            this.pnl_modify = new System.Windows.Forms.Panel();
            this.btnTamHoan = new System.Windows.Forms.Button();
            this.pnlEnabled = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_gioden = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nud_phutden = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nud_phutdi = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nud_giodi = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_ngaydi = new System.Windows.Forms.DateTimePicker();
            this.btn_luu = new System.Windows.Forms.Button();
            this.dtpngayden = new System.Windows.Forms.DateTimePicker();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_chuyenbay = new System.Windows.Forms.DataGridView();
            this.maChuyenBayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenBayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMS_DataSet = new DBMS_Project.DBMS_DataSet();
            this.pnltimkiem = new System.Windows.Forms.Panel();
            this.btn_QLTamHoan = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.cb_ngayden = new System.Windows.Forms.CheckBox();
            this.cb_gioden = new System.Windows.Forms.CheckBox();
            this.btn_QLphandoan = new System.Windows.Forms.Button();
            this.cb_ngaydi = new System.Windows.Forms.CheckBox();
            this.cb_tt = new System.Windows.Forms.CheckBox();
            this.cb_giodi = new System.Windows.Forms.CheckBox();
            this.cb_id = new System.Windows.Forms.CheckBox();
            this.cbb_ngayden = new System.Windows.Forms.ComboBox();
            this.cbb_gioden = new System.Windows.Forms.ComboBox();
            this.cbb_ngaydi = new System.Windows.Forms.ComboBox();
            this.cbb_giodi = new System.Windows.Forms.ComboBox();
            this.cbb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.cbb_id = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chuyenBayTableAdapter = new DBMS_Project.DBMS_DataSetTableAdapters.ChuyenBayTableAdapter();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.pnlmain.SuspendLayout();
            this.pnl_modify.SuspendLayout();
            this.pnlEnabled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gioden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenbay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenBayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).BeginInit();
            this.pnltimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 38);
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
            this.pnlmain.Location = new System.Drawing.Point(12, 62);
            this.pnlmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1165, 681);
            this.pnlmain.TabIndex = 1;
            // 
            // pnl_modify
            // 
            this.pnl_modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_modify.Controls.Add(this.label9);
            this.pnl_modify.Controls.Add(this.btnTamHoan);
            this.pnl_modify.Controls.Add(this.pnlEnabled);
            this.pnl_modify.Controls.Add(this.btn_xoa);
            this.pnl_modify.Controls.Add(this.btn_sua);
            this.pnl_modify.Controls.Add(this.btn_them);
            this.pnl_modify.Location = new System.Drawing.Point(340, 324);
            this.pnl_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_modify.Name = "pnl_modify";
            this.pnl_modify.Size = new System.Drawing.Size(809, 328);
            this.pnl_modify.TabIndex = 4;
            // 
            // btnTamHoan
            // 
            this.btnTamHoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnTamHoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamHoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTamHoan.Location = new System.Drawing.Point(8, 267);
            this.btnTamHoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTamHoan.Name = "btnTamHoan";
            this.btnTamHoan.Size = new System.Drawing.Size(199, 50);
            this.btnTamHoan.TabIndex = 77;
            this.btnTamHoan.Text = "Tạm hoãn";
            this.btnTamHoan.UseVisualStyleBackColor = false;
            this.btnTamHoan.Click += new System.EventHandler(this.btnTamHoan_Click);
            // 
            // pnlEnabled
            // 
            this.pnlEnabled.Controls.Add(this.label17);
            this.pnlEnabled.Controls.Add(this.txt_id);
            this.pnlEnabled.Controls.Add(this.label16);
            this.pnlEnabled.Controls.Add(this.label10);
            this.pnlEnabled.Controls.Add(this.nud_gioden);
            this.pnlEnabled.Controls.Add(this.label11);
            this.pnlEnabled.Controls.Add(this.nud_phutden);
            this.pnlEnabled.Controls.Add(this.label14);
            this.pnlEnabled.Controls.Add(this.nud_phutdi);
            this.pnlEnabled.Controls.Add(this.label13);
            this.pnlEnabled.Controls.Add(this.nud_giodi);
            this.pnlEnabled.Controls.Add(this.label12);
            this.pnlEnabled.Controls.Add(this.dtp_ngaydi);
            this.pnlEnabled.Controls.Add(this.btn_luu);
            this.pnlEnabled.Controls.Add(this.dtpngayden);
            this.pnlEnabled.Controls.Add(this.btn_huy);
            this.pnlEnabled.Controls.Add(this.label15);
            this.pnlEnabled.Controls.Add(this.txt_tinhtrang);
            this.pnlEnabled.Enabled = false;
            this.pnlEnabled.Location = new System.Drawing.Point(209, 28);
            this.pnlEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEnabled.Name = "pnlEnabled";
            this.pnlEnabled.Size = new System.Drawing.Size(600, 322);
            this.pnlEnabled.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(490, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 30);
            this.label17.TabIndex = 89;
            this.label17.Text = "h";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(52, 56);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(253, 36);
            this.txt_id.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(490, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 30);
            this.label16.TabIndex = 88;
            this.label16.Text = "h";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 37);
            this.label10.TabIndex = 72;
            this.label10.Text = "Mã chuyến bay:";
            // 
            // nud_gioden
            // 
            this.nud_gioden.Location = new System.Drawing.Point(431, 119);
            this.nud_gioden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_gioden.Name = "nud_gioden";
            this.nud_gioden.Size = new System.Drawing.Size(53, 22);
            this.nud_gioden.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 37);
            this.label11.TabIndex = 73;
            this.label11.Text = "Tình trạng:";
            // 
            // nud_phutden
            // 
            this.nud_phutden.Location = new System.Drawing.Point(531, 119);
            this.nud_phutden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_phutden.Name = "nud_phutden";
            this.nud_phutden.Size = new System.Drawing.Size(53, 22);
            this.nud_phutden.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(312, 112);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 37);
            this.label14.TabIndex = 73;
            this.label14.Text = "Giờ đến:";
            // 
            // nud_phutdi
            // 
            this.nud_phutdi.Location = new System.Drawing.Point(531, 50);
            this.nud_phutdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_phutdi.Name = "nud_phutdi";
            this.nud_phutdi.Size = new System.Drawing.Size(53, 22);
            this.nud_phutdi.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 192);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 37);
            this.label13.TabIndex = 72;
            this.label13.Text = "Ngày đi:";
            // 
            // nud_giodi
            // 
            this.nud_giodi.Location = new System.Drawing.Point(431, 50);
            this.nud_giodi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_giodi.Name = "nud_giodi";
            this.nud_giodi.Size = new System.Drawing.Size(53, 22);
            this.nud_giodi.TabIndex = 84;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(327, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 37);
            this.label12.TabIndex = 71;
            this.label12.Text = "Giờ đi:";
            // 
            // dtp_ngaydi
            // 
            this.dtp_ngaydi.Location = new System.Drawing.Point(116, 197);
            this.dtp_ngaydi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ngaydi.Name = "dtp_ngaydi";
            this.dtp_ngaydi.Size = new System.Drawing.Size(232, 22);
            this.dtp_ngaydi.TabIndex = 83;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Location = new System.Drawing.Point(382, 157);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(191, 53);
            this.btn_luu.TabIndex = 77;
            this.btn_luu.Text = "Lưu thay đổi";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // dtpngayden
            // 
            this.dtpngayden.Location = new System.Drawing.Point(116, 245);
            this.dtpngayden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpngayden.Name = "dtpngayden";
            this.dtpngayden.Size = new System.Drawing.Size(232, 22);
            this.dtpngayden.TabIndex = 82;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Location = new System.Drawing.Point(382, 216);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(191, 53);
            this.btn_huy.TabIndex = 77;
            this.btn_huy.Text = "Hủy thao tác";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 30);
            this.label15.TabIndex = 74;
            this.label15.Text = "Ngày đến:";
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Location = new System.Drawing.Point(52, 145);
            this.txt_tinhtrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tinhtrang.Multiline = true;
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(253, 37);
            this.txt_tinhtrang.TabIndex = 79;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(8, 213);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(199, 50);
            this.btn_xoa.TabIndex = 76;
            this.btn_xoa.Text = "Xóa chuyến bay";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(3, 104);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(199, 71);
            this.btn_sua.TabIndex = 75;
            this.btn_sua.Text = "Thay đổi thông tin chuyến bay";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(3, 55);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(199, 50);
            this.btn_them.TabIndex = 71;
            this.btn_them.Text = "Tạo chuyến bay";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(15, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 28);
            this.label9.TabIndex = 71;
            this.label9.Text = "Cập nhật chuyến bay:";
            // 
            // dgv_chuyenbay
            // 
            this.dgv_chuyenbay.AllowUserToResizeColumns = false;
            this.dgv_chuyenbay.AllowUserToResizeRows = false;
            this.dgv_chuyenbay.AutoGenerateColumns = false;
            this.dgv_chuyenbay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgv_chuyenbay.Location = new System.Drawing.Point(340, 7);
            this.dgv_chuyenbay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_chuyenbay.Name = "dgv_chuyenbay";
            this.dgv_chuyenbay.RowHeadersVisible = false;
            this.dgv_chuyenbay.RowHeadersWidth = 51;
            this.dgv_chuyenbay.RowTemplate.Height = 24;
            this.dgv_chuyenbay.Size = new System.Drawing.Size(809, 311);
            this.dgv_chuyenbay.TabIndex = 3;
            this.dgv_chuyenbay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chuyenbay_CellClick);
            // 
            // maChuyenBayDataGridViewTextBoxColumn
            // 
            this.maChuyenBayDataGridViewTextBoxColumn.DataPropertyName = "MaChuyenBay";
            this.maChuyenBayDataGridViewTextBoxColumn.HeaderText = "MaChuyenBay";
            this.maChuyenBayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maChuyenBayDataGridViewTextBoxColumn.Name = "maChuyenBayDataGridViewTextBoxColumn";
            // 
            // tinhTrangHDDataGridViewTextBoxColumn
            // 
            this.tinhTrangHDDataGridViewTextBoxColumn.DataPropertyName = "TinhTrangHD";
            this.tinhTrangHDDataGridViewTextBoxColumn.HeaderText = "TinhTrangHD";
            this.tinhTrangHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhTrangHDDataGridViewTextBoxColumn.Name = "tinhTrangHDDataGridViewTextBoxColumn";
            // 
            // gioDiDataGridViewTextBoxColumn
            // 
            this.gioDiDataGridViewTextBoxColumn.DataPropertyName = "GioDi";
            this.gioDiDataGridViewTextBoxColumn.HeaderText = "GioDi";
            this.gioDiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioDiDataGridViewTextBoxColumn.Name = "gioDiDataGridViewTextBoxColumn";
            // 
            // ngayDiDataGridViewTextBoxColumn
            // 
            this.ngayDiDataGridViewTextBoxColumn.DataPropertyName = "NgayDi";
            this.ngayDiDataGridViewTextBoxColumn.HeaderText = "NgayDi";
            this.ngayDiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDiDataGridViewTextBoxColumn.Name = "ngayDiDataGridViewTextBoxColumn";
            // 
            // gioDenDataGridViewTextBoxColumn
            // 
            this.gioDenDataGridViewTextBoxColumn.DataPropertyName = "GioDen";
            this.gioDenDataGridViewTextBoxColumn.HeaderText = "GioDen";
            this.gioDenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioDenDataGridViewTextBoxColumn.Name = "gioDenDataGridViewTextBoxColumn";
            // 
            // ngayDenDataGridViewTextBoxColumn
            // 
            this.ngayDenDataGridViewTextBoxColumn.DataPropertyName = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.HeaderText = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDenDataGridViewTextBoxColumn.Name = "ngayDenDataGridViewTextBoxColumn";
            // 
            // chuyenBayBindingSource
            // 
            this.chuyenBayBindingSource.DataMember = "ChuyenBay";
            this.chuyenBayBindingSource.DataSource = this.dBMS_DataSet;
            // 
            // dBMS_DataSet
            // 
            this.dBMS_DataSet.DataSetName = "DBMS_DataSet";
            this.dBMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnltimkiem
            // 
            this.pnltimkiem.BackColor = System.Drawing.Color.White;
            this.pnltimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnltimkiem.Controls.Add(this.btn_thongke);
            this.pnltimkiem.Controls.Add(this.btn_QLTamHoan);
            this.pnltimkiem.Controls.Add(this.btn_reload);
            this.pnltimkiem.Controls.Add(this.cb_ngayden);
            this.pnltimkiem.Controls.Add(this.cb_gioden);
            this.pnltimkiem.Controls.Add(this.btn_QLphandoan);
            this.pnltimkiem.Controls.Add(this.cb_ngaydi);
            this.pnltimkiem.Controls.Add(this.cb_tt);
            this.pnltimkiem.Controls.Add(this.cb_giodi);
            this.pnltimkiem.Controls.Add(this.cb_id);
            this.pnltimkiem.Controls.Add(this.cbb_ngayden);
            this.pnltimkiem.Controls.Add(this.cbb_gioden);
            this.pnltimkiem.Controls.Add(this.cbb_ngaydi);
            this.pnltimkiem.Controls.Add(this.cbb_giodi);
            this.pnltimkiem.Controls.Add(this.cbb_tinhtrang);
            this.pnltimkiem.Controls.Add(this.cbb_id);
            this.pnltimkiem.Controls.Add(this.label8);
            this.pnltimkiem.Controls.Add(this.btn_TimKiem);
            this.pnltimkiem.Controls.Add(this.label7);
            this.pnltimkiem.Controls.Add(this.label5);
            this.pnltimkiem.Controls.Add(this.label4);
            this.pnltimkiem.Controls.Add(this.label3);
            this.pnltimkiem.Controls.Add(this.label2);
            this.pnltimkiem.Controls.Add(this.label6);
            this.pnltimkiem.Controls.Add(this.pictureBox1);
            this.pnltimkiem.Location = new System.Drawing.Point(8, 7);
            this.pnltimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltimkiem.Name = "pnltimkiem";
            this.pnltimkiem.Size = new System.Drawing.Size(326, 645);
            this.pnltimkiem.TabIndex = 2;
            // 
            // btn_QLTamHoan
            // 
            this.btn_QLTamHoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_QLTamHoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTamHoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_QLTamHoan.Location = new System.Drawing.Point(161, 132);
            this.btn_QLTamHoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLTamHoan.Name = "btn_QLTamHoan";
            this.btn_QLTamHoan.Size = new System.Drawing.Size(152, 74);
            this.btn_QLTamHoan.TabIndex = 78;
            this.btn_QLTamHoan.Text = "Quản Lý CB Tạm Hoãn";
            this.btn_QLTamHoan.UseVisualStyleBackColor = false;
            this.btn_QLTamHoan.Click += new System.EventHandler(this.btn_QLTamHoan_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_reload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reload.Location = new System.Drawing.Point(14, 553);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(147, 43);
            this.btn_reload.TabIndex = 77;
            this.btn_reload.Text = "ReLoad";
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // cb_ngayden
            // 
            this.cb_ngayden.AutoSize = true;
            this.cb_ngayden.Location = new System.Drawing.Point(295, 519);
            this.cb_ngayden.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ngayden.Name = "cb_ngayden";
            this.cb_ngayden.Size = new System.Drawing.Size(18, 17);
            this.cb_ngayden.TabIndex = 76;
            this.cb_ngayden.UseVisualStyleBackColor = true;
            // 
            // cb_gioden
            // 
            this.cb_gioden.AutoSize = true;
            this.cb_gioden.Location = new System.Drawing.Point(295, 468);
            this.cb_gioden.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gioden.Name = "cb_gioden";
            this.cb_gioden.Size = new System.Drawing.Size(18, 17);
            this.cb_gioden.TabIndex = 75;
            this.cb_gioden.UseVisualStyleBackColor = true;
            // 
            // btn_QLphandoan
            // 
            this.btn_QLphandoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_QLphandoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLphandoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_QLphandoan.Location = new System.Drawing.Point(11, 132);
            this.btn_QLphandoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLphandoan.Name = "btn_QLphandoan";
            this.btn_QLphandoan.Size = new System.Drawing.Size(147, 74);
            this.btn_QLphandoan.TabIndex = 56;
            this.btn_QLphandoan.Text = "Quản lý phân đoạn";
            this.btn_QLphandoan.UseVisualStyleBackColor = false;
            this.btn_QLphandoan.Click += new System.EventHandler(this.btn_QLphandoan_Click);
            // 
            // cb_ngaydi
            // 
            this.cb_ngaydi.AutoSize = true;
            this.cb_ngaydi.Location = new System.Drawing.Point(295, 418);
            this.cb_ngaydi.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ngaydi.Name = "cb_ngaydi";
            this.cb_ngaydi.Size = new System.Drawing.Size(18, 17);
            this.cb_ngaydi.TabIndex = 74;
            this.cb_ngaydi.UseVisualStyleBackColor = true;
            // 
            // cb_tt
            // 
            this.cb_tt.AutoSize = true;
            this.cb_tt.Location = new System.Drawing.Point(295, 318);
            this.cb_tt.Margin = new System.Windows.Forms.Padding(4);
            this.cb_tt.Name = "cb_tt";
            this.cb_tt.Size = new System.Drawing.Size(18, 17);
            this.cb_tt.TabIndex = 73;
            this.cb_tt.UseVisualStyleBackColor = true;
            // 
            // cb_giodi
            // 
            this.cb_giodi.AutoSize = true;
            this.cb_giodi.Location = new System.Drawing.Point(295, 368);
            this.cb_giodi.Margin = new System.Windows.Forms.Padding(4);
            this.cb_giodi.Name = "cb_giodi";
            this.cb_giodi.Size = new System.Drawing.Size(18, 17);
            this.cb_giodi.TabIndex = 72;
            this.cb_giodi.UseVisualStyleBackColor = true;
            // 
            // cb_id
            // 
            this.cb_id.AutoSize = true;
            this.cb_id.Location = new System.Drawing.Point(295, 268);
            this.cb_id.Margin = new System.Windows.Forms.Padding(4);
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(18, 17);
            this.cb_id.TabIndex = 71;
            this.cb_id.UseVisualStyleBackColor = true;
            // 
            // cbb_ngayden
            // 
            this.cbb_ngayden.FormattingEnabled = true;
            this.cbb_ngayden.Location = new System.Drawing.Point(167, 519);
            this.cbb_ngayden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_ngayden.Name = "cbb_ngayden";
            this.cbb_ngayden.Size = new System.Drawing.Size(121, 24);
            this.cbb_ngayden.TabIndex = 70;
            // 
            // cbb_gioden
            // 
            this.cbb_gioden.FormattingEnabled = true;
            this.cbb_gioden.Location = new System.Drawing.Point(167, 468);
            this.cbb_gioden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_gioden.Name = "cbb_gioden";
            this.cbb_gioden.Size = new System.Drawing.Size(121, 24);
            this.cbb_gioden.TabIndex = 69;
            // 
            // cbb_ngaydi
            // 
            this.cbb_ngaydi.FormattingEnabled = true;
            this.cbb_ngaydi.Location = new System.Drawing.Point(167, 418);
            this.cbb_ngaydi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_ngaydi.Name = "cbb_ngaydi";
            this.cbb_ngaydi.Size = new System.Drawing.Size(121, 24);
            this.cbb_ngaydi.TabIndex = 68;
            // 
            // cbb_giodi
            // 
            this.cbb_giodi.FormattingEnabled = true;
            this.cbb_giodi.Location = new System.Drawing.Point(167, 368);
            this.cbb_giodi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_giodi.Name = "cbb_giodi";
            this.cbb_giodi.Size = new System.Drawing.Size(121, 24);
            this.cbb_giodi.TabIndex = 67;
            // 
            // cbb_tinhtrang
            // 
            this.cbb_tinhtrang.FormattingEnabled = true;
            this.cbb_tinhtrang.Location = new System.Drawing.Point(167, 318);
            this.cbb_tinhtrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_tinhtrang.Name = "cbb_tinhtrang";
            this.cbb_tinhtrang.Size = new System.Drawing.Size(121, 24);
            this.cbb_tinhtrang.TabIndex = 66;
            // 
            // cbb_id
            // 
            this.cbb_id.FormattingEnabled = true;
            this.cbb_id.Location = new System.Drawing.Point(167, 268);
            this.cbb_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_id.Name = "cbb_id";
            this.cbb_id.Size = new System.Drawing.Size(121, 24);
            this.cbb_id.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 520);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(167, 553);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(136, 43);
            this.btn_TimKiem.TabIndex = 55;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 28);
            this.label7.TabIndex = 63;
            this.label7.Text = "Giờ đến:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 62;
            this.label5.Text = "Ngày đi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 61;
            this.label4.Text = "Giờ đi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tình trạng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mã chuyến bay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 59;
            this.label6.Text = "Tìm kiếm:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // chuyenBayTableAdapter
            // 
            this.chuyenBayTableAdapter.ClearBeforeFill = true;
            // 
            // btn_thongke
            // 
            this.btn_thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_thongke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_thongke.Location = new System.Drawing.Point(-1, 600);
            this.btn_thongke.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(326, 43);
            this.btn_thongke.TabIndex = 79;
            this.btn_thongke.Text = "Số lượng chuyến bay theo ngày";
            this.btn_thongke.UseVisualStyleBackColor = false;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // FormQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1192, 766);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuanLyChuyenBay";
            this.Text = "FormQuanLyChuyenBay";
            this.Load += new System.EventHandler(this.FormQuanLyChuyenBay_Load);
            this.pnlmain.ResumeLayout(false);
            this.pnl_modify.ResumeLayout(false);
            this.pnl_modify.PerformLayout();
            this.pnlEnabled.ResumeLayout(false);
            this.pnlEnabled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gioden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenbay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenBayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).EndInit();
            this.pnltimkiem.ResumeLayout(false);
            this.pnltimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtp_ngaydi;
        private System.Windows.Forms.DateTimePicker dtpngayden;
        private System.Windows.Forms.TextBox txt_tinhtrang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nud_gioden;
        private System.Windows.Forms.NumericUpDown nud_phutden;
        private System.Windows.Forms.NumericUpDown nud_phutdi;
        private System.Windows.Forms.NumericUpDown nud_giodi;
        private System.Windows.Forms.CheckBox cb_ngaydi;
        private System.Windows.Forms.CheckBox cb_tt;
        private System.Windows.Forms.CheckBox cb_giodi;
        private System.Windows.Forms.CheckBox cb_id;
        private System.Windows.Forms.CheckBox cb_ngayden;
        private System.Windows.Forms.CheckBox cb_gioden;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Panel pnlEnabled;
        private System.Windows.Forms.Button btnTamHoan;
        private System.Windows.Forms.Button btn_QLTamHoan;
        private System.Windows.Forms.Button btn_thongke;
    }
}