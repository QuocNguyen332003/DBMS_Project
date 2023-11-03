namespace DBMS_Project
{
    partial class FormThamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThamGia));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.num_sogiobay = new System.Windows.Forms.NumericUpDown();
            this.btn_reload = new System.Windows.Forms.Button();
            this.cb_vaitro = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_sogiobay = new System.Windows.Forms.CheckBox();
            this.cb_stt = new System.Windows.Forms.CheckBox();
            this.cb_idnhanvien = new System.Windows.Forms.CheckBox();
            this.cb_idchuyenbay = new System.Windows.Forms.CheckBox();
            this.cbb_vaitro = new System.Windows.Forms.ComboBox();
            this.cbb_idnhanvien = new System.Windows.Forms.ComboBox();
            this.cbb_stt1 = new System.Windows.Forms.ComboBox();
            this.cbb_id = new System.Windows.Forms.ComboBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_thamgia = new System.Windows.Forms.DataGridView();
            this.maChuyenBayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioBayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaiTroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thamGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMS_DataSet = new DBMS_Project.DBMS_DataSet();
            this.pnlEnabled = new System.Windows.Forms.Panel();
            this.cbb_stt = new System.Windows.Forms.ComboBox();
            this.cbb_idchuyenbay = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_vaitro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sogiobay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_idnhanvien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thamGiaTableAdapter = new DBMS_Project.DBMS_DataSetTableAdapters.ThamGiaTableAdapter();
            this.pnl_main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sogiobay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thamgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thamGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).BeginInit();
            this.pnlEnabled.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Controls.Add(this.label13);
            this.pnl_main.Controls.Add(this.btn_Cancel);
            this.pnl_main.Controls.Add(this.btn_Delete);
            this.pnl_main.Controls.Add(this.btn_Save);
            this.pnl_main.Controls.Add(this.btn_Edit);
            this.pnl_main.Controls.Add(this.btn_Add);
            this.pnl_main.Controls.Add(this.panel1);
            this.pnl_main.Controls.Add(this.dgv_thamgia);
            this.pnl_main.Controls.Add(this.pnlEnabled);
            this.pnl_main.Location = new System.Drawing.Point(7, 80);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1056, 513);
            this.pnl_main.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(4, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 28);
            this.label13.TabIndex = 92;
            this.label13.Text = "Cập nhật tham gia:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(539, 443);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(139, 46);
            this.btn_Cancel.TabIndex = 65;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(539, 321);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(139, 46);
            this.btn_Delete.TabIndex = 64;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(539, 391);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(139, 46);
            this.btn_Save.TabIndex = 63;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(539, 271);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(139, 46);
            this.btn_Edit.TabIndex = 62;
            this.btn_Edit.Text = "Thay đổi";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(539, 220);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(139, 46);
            this.btn_Add.TabIndex = 61;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.num_sogiobay);
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Controls.Add(this.cb_vaitro);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cb_sogiobay);
            this.panel1.Controls.Add(this.cb_stt);
            this.panel1.Controls.Add(this.cb_idnhanvien);
            this.panel1.Controls.Add(this.cb_idchuyenbay);
            this.panel1.Controls.Add(this.cbb_vaitro);
            this.panel1.Controls.Add(this.cbb_idnhanvien);
            this.panel1.Controls.Add(this.cbb_stt1);
            this.panel1.Controls.Add(this.cbb_id);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(711, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 492);
            this.panel1.TabIndex = 60;
            // 
            // num_sogiobay
            // 
            this.num_sogiobay.Location = new System.Drawing.Point(189, 337);
            this.num_sogiobay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_sogiobay.Name = "num_sogiobay";
            this.num_sogiobay.Size = new System.Drawing.Size(123, 22);
            this.num_sogiobay.TabIndex = 100;
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_reload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reload.Location = new System.Drawing.Point(47, 432);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(120, 53);
            this.btn_reload.TabIndex = 99;
            this.btn_reload.Text = "ReLoad";
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // cb_vaitro
            // 
            this.cb_vaitro.AutoSize = true;
            this.cb_vaitro.Location = new System.Drawing.Point(317, 391);
            this.cb_vaitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_vaitro.Name = "cb_vaitro";
            this.cb_vaitro.Size = new System.Drawing.Size(18, 17);
            this.cb_vaitro.TabIndex = 97;
            this.cb_vaitro.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // cb_sogiobay
            // 
            this.cb_sogiobay.AutoSize = true;
            this.cb_sogiobay.Location = new System.Drawing.Point(317, 341);
            this.cb_sogiobay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_sogiobay.Name = "cb_sogiobay";
            this.cb_sogiobay.Size = new System.Drawing.Size(18, 17);
            this.cb_sogiobay.TabIndex = 96;
            this.cb_sogiobay.UseVisualStyleBackColor = true;
            // 
            // cb_stt
            // 
            this.cb_stt.AutoSize = true;
            this.cb_stt.Location = new System.Drawing.Point(317, 234);
            this.cb_stt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_stt.Name = "cb_stt";
            this.cb_stt.Size = new System.Drawing.Size(18, 17);
            this.cb_stt.TabIndex = 95;
            this.cb_stt.UseVisualStyleBackColor = true;
            // 
            // cb_idnhanvien
            // 
            this.cb_idnhanvien.AutoSize = true;
            this.cb_idnhanvien.Location = new System.Drawing.Point(317, 288);
            this.cb_idnhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_idnhanvien.Name = "cb_idnhanvien";
            this.cb_idnhanvien.Size = new System.Drawing.Size(18, 17);
            this.cb_idnhanvien.TabIndex = 94;
            this.cb_idnhanvien.UseVisualStyleBackColor = true;
            // 
            // cb_idchuyenbay
            // 
            this.cb_idchuyenbay.AutoSize = true;
            this.cb_idchuyenbay.Location = new System.Drawing.Point(317, 185);
            this.cb_idchuyenbay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_idchuyenbay.Name = "cb_idchuyenbay";
            this.cb_idchuyenbay.Size = new System.Drawing.Size(18, 17);
            this.cb_idchuyenbay.TabIndex = 93;
            this.cb_idchuyenbay.UseVisualStyleBackColor = true;
            // 
            // cbb_vaitro
            // 
            this.cbb_vaitro.FormattingEnabled = true;
            this.cbb_vaitro.Location = new System.Drawing.Point(189, 388);
            this.cbb_vaitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_vaitro.Name = "cbb_vaitro";
            this.cbb_vaitro.Size = new System.Drawing.Size(121, 24);
            this.cbb_vaitro.TabIndex = 91;
            // 
            // cbb_idnhanvien
            // 
            this.cbb_idnhanvien.FormattingEnabled = true;
            this.cbb_idnhanvien.Location = new System.Drawing.Point(189, 284);
            this.cbb_idnhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_idnhanvien.Name = "cbb_idnhanvien";
            this.cbb_idnhanvien.Size = new System.Drawing.Size(121, 24);
            this.cbb_idnhanvien.TabIndex = 89;
            // 
            // cbb_stt1
            // 
            this.cbb_stt1.FormattingEnabled = true;
            this.cbb_stt1.Location = new System.Drawing.Point(189, 230);
            this.cbb_stt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_stt1.Name = "cbb_stt1";
            this.cbb_stt1.Size = new System.Drawing.Size(121, 24);
            this.cbb_stt1.TabIndex = 88;
            // 
            // cbb_id
            // 
            this.cbb_id.FormattingEnabled = true;
            this.cbb_id.Location = new System.Drawing.Point(189, 180);
            this.cbb_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_id.Name = "cbb_id";
            this.cbb_id.Size = new System.Drawing.Size(121, 24);
            this.cbb_id.TabIndex = 87;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimKiem.Location = new System.Drawing.Point(192, 432);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(120, 53);
            this.btn_TimKiem.TabIndex = 78;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 28);
            this.label7.TabIndex = 85;
            this.label7.Text = "Vai Trò:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 84;
            this.label5.Text = "Số Giờ Bay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 83;
            this.label4.Text = "Mã NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 81;
            this.label3.Text = "STT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mã chuyến bay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 32);
            this.label6.TabIndex = 80;
            this.label6.Text = "Tìm kiếm:";
            // 
            // dgv_thamgia
            // 
            this.dgv_thamgia.AutoGenerateColumns = false;
            this.dgv_thamgia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.dgv_thamgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thamgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChuyenBayDataGridViewTextBoxColumn,
            this.sTTDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.soGioBayDataGridViewTextBoxColumn,
            this.vaiTroDataGridViewTextBoxColumn});
            this.dgv_thamgia.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_thamgia.DataSource = this.thamGiaBindingSource;
            this.dgv_thamgia.Location = new System.Drawing.Point(9, 4);
            this.dgv_thamgia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_thamgia.Name = "dgv_thamgia";
            this.dgv_thamgia.RowHeadersWidth = 51;
            this.dgv_thamgia.Size = new System.Drawing.Size(693, 206);
            this.dgv_thamgia.TabIndex = 59;
            this.dgv_thamgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thamgia_CellClick);
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
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // soGioBayDataGridViewTextBoxColumn
            // 
            this.soGioBayDataGridViewTextBoxColumn.DataPropertyName = "SoGioBay";
            this.soGioBayDataGridViewTextBoxColumn.HeaderText = "SoGioBay";
            this.soGioBayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soGioBayDataGridViewTextBoxColumn.Name = "soGioBayDataGridViewTextBoxColumn";
            this.soGioBayDataGridViewTextBoxColumn.Width = 125;
            // 
            // vaiTroDataGridViewTextBoxColumn
            // 
            this.vaiTroDataGridViewTextBoxColumn.DataPropertyName = "VaiTro";
            this.vaiTroDataGridViewTextBoxColumn.HeaderText = "VaiTro";
            this.vaiTroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vaiTroDataGridViewTextBoxColumn.Name = "vaiTroDataGridViewTextBoxColumn";
            this.vaiTroDataGridViewTextBoxColumn.Width = 125;
            // 
            // thamGiaBindingSource
            // 
            this.thamGiaBindingSource.DataMember = "ThamGia";
            this.thamGiaBindingSource.DataSource = this.dBMS_DataSet;
            // 
            // dBMS_DataSet
            // 
            this.dBMS_DataSet.DataSetName = "DBMS_DataSet";
            this.dBMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlEnabled
            // 
            this.pnlEnabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEnabled.Controls.Add(this.cbb_stt);
            this.pnlEnabled.Controls.Add(this.cbb_idchuyenbay);
            this.pnlEnabled.Controls.Add(this.label8);
            this.pnlEnabled.Controls.Add(this.txt_vaitro);
            this.pnlEnabled.Controls.Add(this.label9);
            this.pnlEnabled.Controls.Add(this.txt_sogiobay);
            this.pnlEnabled.Controls.Add(this.label10);
            this.pnlEnabled.Controls.Add(this.txt_idnhanvien);
            this.pnlEnabled.Controls.Add(this.label11);
            this.pnlEnabled.Controls.Add(this.label12);
            this.pnlEnabled.Enabled = false;
            this.pnlEnabled.Location = new System.Drawing.Point(55, 241);
            this.pnlEnabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEnabled.Name = "pnlEnabled";
            this.pnlEnabled.Size = new System.Drawing.Size(463, 247);
            this.pnlEnabled.TabIndex = 93;
            // 
            // cbb_stt
            // 
            this.cbb_stt.FormattingEnabled = true;
            this.cbb_stt.Location = new System.Drawing.Point(239, 59);
            this.cbb_stt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_stt.Name = "cbb_stt";
            this.cbb_stt.Size = new System.Drawing.Size(167, 24);
            this.cbb_stt.TabIndex = 95;
            // 
            // cbb_idchuyenbay
            // 
            this.cbb_idchuyenbay.FormattingEnabled = true;
            this.cbb_idchuyenbay.Location = new System.Drawing.Point(239, 15);
            this.cbb_idchuyenbay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_idchuyenbay.Name = "cbb_idchuyenbay";
            this.cbb_idchuyenbay.Size = new System.Drawing.Size(167, 24);
            this.cbb_idchuyenbay.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(33, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 28);
            this.label8.TabIndex = 83;
            this.label8.Text = "Mã chuyến bay:";
            // 
            // txt_vaitro
            // 
            this.txt_vaitro.Location = new System.Drawing.Point(239, 196);
            this.txt_vaitro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_vaitro.Multiline = true;
            this.txt_vaitro.Name = "txt_vaitro";
            this.txt_vaitro.Size = new System.Drawing.Size(167, 36);
            this.txt_vaitro.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 28);
            this.label9.TabIndex = 84;
            this.label9.Text = "STT:";
            // 
            // txt_sogiobay
            // 
            this.txt_sogiobay.Location = new System.Drawing.Point(239, 151);
            this.txt_sogiobay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sogiobay.Multiline = true;
            this.txt_sogiobay.Name = "txt_sogiobay";
            this.txt_sogiobay.Size = new System.Drawing.Size(167, 36);
            this.txt_sogiobay.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 28);
            this.label10.TabIndex = 85;
            this.label10.Text = "Mã NV:";
            // 
            // txt_idnhanvien
            // 
            this.txt_idnhanvien.Location = new System.Drawing.Point(239, 101);
            this.txt_idnhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idnhanvien.Multiline = true;
            this.txt_idnhanvien.Name = "txt_idnhanvien";
            this.txt_idnhanvien.Size = new System.Drawing.Size(167, 36);
            this.txt_idnhanvien.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 28);
            this.label11.TabIndex = 86;
            this.label11.Text = "Số Giờ Bay";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 28);
            this.label12.TabIndex = 87;
            this.label12.Text = "Vai Trò:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM THAM GIA";
            // 
            // thamGiaTableAdapter
            // 
            this.thamGiaTableAdapter.ClearBeforeFill = true;
            // 
            // FormThamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1067, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThamGia";
            this.Text = "FormThamGia";
            this.Load += new System.EventHandler(this.FormThamGia_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sogiobay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thamgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thamGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).EndInit();
            this.pnlEnabled.ResumeLayout(false);
            this.pnlEnabled.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_thamgia;
        private DBMS_DataSet dBMS_DataSet;
        private System.Windows.Forms.BindingSource thamGiaBindingSource;
        private DBMS_DataSetTableAdapters.ThamGiaTableAdapter thamGiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenBayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioBayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaiTroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.CheckBox cb_vaitro;
        private System.Windows.Forms.CheckBox cb_sogiobay;
        private System.Windows.Forms.CheckBox cb_stt;
        private System.Windows.Forms.CheckBox cb_idnhanvien;
        private System.Windows.Forms.CheckBox cb_idchuyenbay;
        private System.Windows.Forms.ComboBox cbb_vaitro;
        private System.Windows.Forms.ComboBox cbb_idnhanvien;
        private System.Windows.Forms.ComboBox cbb_stt1;
        private System.Windows.Forms.ComboBox cbb_id;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_vaitro;
        private System.Windows.Forms.TextBox txt_sogiobay;
        private System.Windows.Forms.TextBox txt_idnhanvien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlEnabled;
        private System.Windows.Forms.ComboBox cbb_stt;
        private System.Windows.Forms.ComboBox cbb_idchuyenbay;
        private System.Windows.Forms.NumericUpDown num_sogiobay;
    }
}