namespace DBMS_Project
{
    partial class FormQuanLyHanhKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyHanhKhach));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ReLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_TimKiem_SDT = new System.Windows.Forms.TextBox();
            this.tb_TimKiem_HoTen = new System.Windows.Forms.TextBox();
            this.tb_TimKiem_MaHanhKhach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_TimKiem_CCCD = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.tb_CCCD = new System.Windows.Forms.TextBox();
            this.tb_MaHanhKhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_QuanLyHanhKhach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dBMS_DataSet = new DBMS_Project.DBMS_DataSet();
            this.hanhKhachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hanhKhachTableAdapter = new DBMS_Project.DBMS_DataSetTableAdapters.HanhKhachTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_cccd = new System.Windows.Forms.RadioButton();
            this.rb_mahk = new System.Windows.Forms.RadioButton();
            this.rb_hoten = new System.Windows.Forms.RadioButton();
            this.rb_sdt = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyHanhKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanhKhachBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tb_TimKiem_SDT);
            this.panel2.Controls.Add(this.tb_TimKiem_HoTen);
            this.panel2.Controls.Add(this.tb_TimKiem_MaHanhKhach);
            this.panel2.Controls.Add(this.tb_TimKiem_CCCD);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_ReLoad);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_TimKiem);
            this.panel2.Location = new System.Drawing.Point(22, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 515);
            this.panel2.TabIndex = 6;
            // 
            // btn_ReLoad
            // 
            this.btn_ReLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_ReLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ReLoad.Location = new System.Drawing.Point(28, 461);
            this.btn_ReLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ReLoad.Name = "btn_ReLoad";
            this.btn_ReLoad.Size = new System.Drawing.Size(234, 43);
            this.btn_ReLoad.TabIndex = 65;
            this.btn_ReLoad.Text = "Reload";
            this.btn_ReLoad.UseVisualStyleBackColor = false;
            this.btn_ReLoad.Click += new System.EventHandler(this.btn_ReLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // tb_TimKiem_SDT
            // 
            this.tb_TimKiem_SDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_TimKiem_SDT.Enabled = false;
            this.tb_TimKiem_SDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem_SDT.Location = new System.Drawing.Point(8, 373);
            this.tb_TimKiem_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiem_SDT.Multiline = true;
            this.tb_TimKiem_SDT.Name = "tb_TimKiem_SDT";
            this.tb_TimKiem_SDT.Size = new System.Drawing.Size(242, 30);
            this.tb_TimKiem_SDT.TabIndex = 63;
            // 
            // tb_TimKiem_HoTen
            // 
            this.tb_TimKiem_HoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_TimKiem_HoTen.Enabled = false;
            this.tb_TimKiem_HoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem_HoTen.Location = new System.Drawing.Point(8, 301);
            this.tb_TimKiem_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiem_HoTen.Multiline = true;
            this.tb_TimKiem_HoTen.Name = "tb_TimKiem_HoTen";
            this.tb_TimKiem_HoTen.Size = new System.Drawing.Size(242, 30);
            this.tb_TimKiem_HoTen.TabIndex = 62;
            // 
            // tb_TimKiem_MaHanhKhach
            // 
            this.tb_TimKiem_MaHanhKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_TimKiem_MaHanhKhach.Enabled = false;
            this.tb_TimKiem_MaHanhKhach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem_MaHanhKhach.Location = new System.Drawing.Point(8, 231);
            this.tb_TimKiem_MaHanhKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiem_MaHanhKhach.Multiline = true;
            this.tb_TimKiem_MaHanhKhach.Name = "tb_TimKiem_MaHanhKhach";
            this.tb_TimKiem_MaHanhKhach.Size = new System.Drawing.Size(242, 30);
            this.tb_TimKiem_MaHanhKhach.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 28);
            this.label9.TabIndex = 60;
            this.label9.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 28);
            this.label8.TabIndex = 59;
            this.label8.Text = "Họ tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 28);
            this.label6.TabIndex = 58;
            this.label6.Text = "Căn cước công dân:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 28);
            this.label7.TabIndex = 57;
            this.label7.Text = "Mã hành khách:";
            // 
            // tb_TimKiem_CCCD
            // 
            this.tb_TimKiem_CCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_TimKiem_CCCD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem_CCCD.Location = new System.Drawing.Point(8, 156);
            this.tb_TimKiem_CCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiem_CCCD.Multiline = true;
            this.tb_TimKiem_CCCD.Name = "tb_TimKiem_CCCD";
            this.tb_TimKiem_CCCD.Size = new System.Drawing.Size(242, 30);
            this.tb_TimKiem_CCCD.TabIndex = 56;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimKiem.Location = new System.Drawing.Point(28, 414);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(234, 43);
            this.btn_TimKiem.TabIndex = 54;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.tb_SDT);
            this.panel1.Controls.Add(this.tb_HoTen);
            this.panel1.Controls.Add(this.tb_CCCD);
            this.panel1.Controls.Add(this.tb_MaHanhKhach);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgv_QuanLyHanhKhach);
            this.panel1.Location = new System.Drawing.Point(316, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 516);
            this.panel1.TabIndex = 7;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Location = new System.Drawing.Point(620, 456);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(208, 43);
            this.btn_Xoa.TabIndex = 55;
            this.btn_Xoa.Text = "Xoá hành khách";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sua.Location = new System.Drawing.Point(306, 456);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(239, 43);
            this.btn_Sua.TabIndex = 54;
            this.btn_Sua.Text = "Thay đổi thông tin";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.Location = new System.Drawing.Point(19, 456);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(203, 43);
            this.btn_Them.TabIndex = 53;
            this.btn_Them.Text = "Thêm hành khách";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tb_SDT
            // 
            this.tb_SDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_SDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SDT.Location = new System.Drawing.Point(633, 380);
            this.tb_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SDT.Multiline = true;
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(239, 30);
            this.tb_SDT.TabIndex = 50;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_HoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HoTen.Location = new System.Drawing.Point(633, 317);
            this.tb_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_HoTen.Multiline = true;
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(239, 30);
            this.tb_HoTen.TabIndex = 49;
            // 
            // tb_CCCD
            // 
            this.tb_CCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_CCCD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CCCD.Location = new System.Drawing.Point(222, 379);
            this.tb_CCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CCCD.Multiline = true;
            this.tb_CCCD.Name = "tb_CCCD";
            this.tb_CCCD.Size = new System.Drawing.Size(203, 30);
            this.tb_CCCD.TabIndex = 48;
            // 
            // tb_MaHanhKhach
            // 
            this.tb_MaHanhKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_MaHanhKhach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaHanhKhach.Location = new System.Drawing.Point(222, 316);
            this.tb_MaHanhKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaHanhKhach.Multiline = true;
            this.tb_MaHanhKhach.Name = "tb_MaHanhKhach";
            this.tb_MaHanhKhach.Size = new System.Drawing.Size(203, 30);
            this.tb_MaHanhKhach.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 42;
            this.label3.Text = "Căn cước công dân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã hành khách:";
            // 
            // dgv_QuanLyHanhKhach
            // 
            this.dgv_QuanLyHanhKhach.AllowUserToResizeColumns = false;
            this.dgv_QuanLyHanhKhach.AllowUserToResizeRows = false;
            this.dgv_QuanLyHanhKhach.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_QuanLyHanhKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuanLyHanhKhach.Location = new System.Drawing.Point(16, 7);
            this.dgv_QuanLyHanhKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_QuanLyHanhKhach.Name = "dgv_QuanLyHanhKhach";
            this.dgv_QuanLyHanhKhach.RowHeadersVisible = false;
            this.dgv_QuanLyHanhKhach.RowHeadersWidth = 62;
            this.dgv_QuanLyHanhKhach.RowTemplate.Height = 28;
            this.dgv_QuanLyHanhKhach.Size = new System.Drawing.Size(856, 272);
            this.dgv_QuanLyHanhKhach.TabIndex = 0;
            this.dgv_QuanLyHanhKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QuanLyHanhKhach_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ HÀNH KHÁCH";
            // 
            // dBMS_DataSet
            // 
            this.dBMS_DataSet.DataSetName = "DBMS_DataSet";
            this.dBMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hanhKhachBindingSource
            // 
            this.hanhKhachBindingSource.DataMember = "HanhKhach";
            this.hanhKhachBindingSource.DataSource = this.dBMS_DataSet;
            // 
            // hanhKhachTableAdapter
            // 
            this.hanhKhachTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rb_sdt);
            this.panel3.Controls.Add(this.rb_hoten);
            this.panel3.Controls.Add(this.rb_mahk);
            this.panel3.Controls.Add(this.rb_cccd);
            this.panel3.Location = new System.Drawing.Point(236, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(49, 271);
            this.panel3.TabIndex = 66;
            // 
            // rb_cccd
            // 
            this.rb_cccd.AutoSize = true;
            this.rb_cccd.Checked = true;
            this.rb_cccd.Location = new System.Drawing.Point(29, 24);
            this.rb_cccd.Name = "rb_cccd";
            this.rb_cccd.Size = new System.Drawing.Size(17, 16);
            this.rb_cccd.TabIndex = 0;
            this.rb_cccd.TabStop = true;
            this.rb_cccd.UseVisualStyleBackColor = true;
            this.rb_cccd.CheckedChanged += new System.EventHandler(this.rb_cccd_CheckedChanged);
            // 
            // rb_mahk
            // 
            this.rb_mahk.AutoSize = true;
            this.rb_mahk.Location = new System.Drawing.Point(29, 99);
            this.rb_mahk.Name = "rb_mahk";
            this.rb_mahk.Size = new System.Drawing.Size(17, 16);
            this.rb_mahk.TabIndex = 1;
            this.rb_mahk.TabStop = true;
            this.rb_mahk.UseVisualStyleBackColor = true;
            this.rb_mahk.CheckedChanged += new System.EventHandler(this.rb_mahk_CheckedChanged);
            // 
            // rb_hoten
            // 
            this.rb_hoten.AutoSize = true;
            this.rb_hoten.Location = new System.Drawing.Point(29, 169);
            this.rb_hoten.Name = "rb_hoten";
            this.rb_hoten.Size = new System.Drawing.Size(17, 16);
            this.rb_hoten.TabIndex = 2;
            this.rb_hoten.TabStop = true;
            this.rb_hoten.UseVisualStyleBackColor = true;
            this.rb_hoten.CheckedChanged += new System.EventHandler(this.rb_hoten_CheckedChanged);
            // 
            // rb_sdt
            // 
            this.rb_sdt.AutoSize = true;
            this.rb_sdt.Location = new System.Drawing.Point(29, 241);
            this.rb_sdt.Name = "rb_sdt";
            this.rb_sdt.Size = new System.Drawing.Size(17, 16);
            this.rb_sdt.TabIndex = 3;
            this.rb_sdt.TabStop = true;
            this.rb_sdt.UseVisualStyleBackColor = true;
            this.rb_sdt.CheckedChanged += new System.EventHandler(this.rb_sdt_CheckedChanged);
            // 
            // FormQuanLyHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1220, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuanLyHanhKhach";
            this.Text = "FormQuanLyHanhKhach";
            this.Load += new System.EventHandler(this.FormQuanLyHanhKhach_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyHanhKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanhKhachBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.TextBox tb_CCCD;
        private System.Windows.Forms.TextBox tb_MaHanhKhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_QuanLyHanhKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TimKiem_CCCD;
        private System.Windows.Forms.TextBox tb_TimKiem_SDT;
        private System.Windows.Forms.TextBox tb_TimKiem_HoTen;
        private System.Windows.Forms.TextBox tb_TimKiem_MaHanhKhach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DBMS_DataSet dBMS_DataSet;
        private System.Windows.Forms.BindingSource hanhKhachBindingSource;
        private DBMS_DataSetTableAdapters.HanhKhachTableAdapter hanhKhachTableAdapter;
        private System.Windows.Forms.Button btn_ReLoad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rb_sdt;
        private System.Windows.Forms.RadioButton rb_hoten;
        private System.Windows.Forms.RadioButton rb_mahk;
        private System.Windows.Forms.RadioButton rb_cccd;
    }
}