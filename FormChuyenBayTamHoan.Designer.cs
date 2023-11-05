namespace DBMS_Project
{
    partial class FormChuyenBayTamHoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuyenBayTamHoan));
            this.pnlmain = new System.Windows.Forms.Panel();
            this.pnl_modify = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.nud_phutdi = new System.Windows.Forms.NumericUpDown();
            this.nud_giodi = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_lydo = new System.Windows.Forms.TextBox();
            this.dgv_chuyenbay = new System.Windows.Forms.DataGridView();
            this.maChuyenBayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianTamHoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenBayTamHoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMS_DataSet = new DBMS_Project.DBMS_DataSet();
            this.pnltimkiem = new System.Windows.Forms.Panel();
            this.btn_QLphandoan = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chuyenBayTamHoanTableAdapter = new DBMS_Project.DBMS_DataSetTableAdapters.ChuyenBayTamHoanTableAdapter();
            this.btn_chitiet = new System.Windows.Forms.Button();
            this.pnlmain.SuspendLayout();
            this.pnl_modify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenbay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenBayTamHoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).BeginInit();
            this.pnltimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.Color.White;
            this.pnlmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmain.Controls.Add(this.pnl_modify);
            this.pnlmain.Controls.Add(this.dgv_chuyenbay);
            this.pnlmain.Controls.Add(this.pnltimkiem);
            this.pnlmain.Location = new System.Drawing.Point(27, 66);
            this.pnlmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1165, 469);
            this.pnlmain.TabIndex = 3;
            // 
            // pnl_modify
            // 
            this.pnl_modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_modify.Controls.Add(this.label16);
            this.pnl_modify.Controls.Add(this.txt_id);
            this.pnl_modify.Controls.Add(this.nud_phutdi);
            this.pnl_modify.Controls.Add(this.nud_giodi);
            this.pnl_modify.Controls.Add(this.label11);
            this.pnl_modify.Controls.Add(this.label12);
            this.pnl_modify.Controls.Add(this.label10);
            this.pnl_modify.Controls.Add(this.txt_lydo);
            this.pnl_modify.Enabled = false;
            this.pnl_modify.Location = new System.Drawing.Point(340, 324);
            this.pnl_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_modify.Name = "pnl_modify";
            this.pnl_modify.Size = new System.Drawing.Size(809, 128);
            this.pnl_modify.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(636, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 30);
            this.label16.TabIndex = 88;
            this.label16.Text = "h";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(187, 4);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(253, 36);
            this.txt_id.TabIndex = 78;
            // 
            // nud_phutdi
            // 
            this.nud_phutdi.Location = new System.Drawing.Point(673, 5);
            this.nud_phutdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_phutdi.Name = "nud_phutdi";
            this.nud_phutdi.Size = new System.Drawing.Size(53, 22);
            this.nud_phutdi.TabIndex = 85;
            // 
            // nud_giodi
            // 
            this.nud_giodi.Location = new System.Drawing.Point(568, 5);
            this.nud_giodi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_giodi.Name = "nud_giodi";
            this.nud_giodi.Size = new System.Drawing.Size(53, 22);
            this.nud_giodi.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 37);
            this.label11.TabIndex = 73;
            this.label11.Text = "Lý do:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(461, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 37);
            this.label12.TabIndex = 71;
            this.label12.Text = "Thời Gian:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 37);
            this.label10.TabIndex = 72;
            this.label10.Text = "Mã chuyến bay:";
            // 
            // txt_lydo
            // 
            this.txt_lydo.Location = new System.Drawing.Point(187, 60);
            this.txt_lydo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_lydo.Multiline = true;
            this.txt_lydo.Name = "txt_lydo";
            this.txt_lydo.Size = new System.Drawing.Size(517, 37);
            this.txt_lydo.TabIndex = 79;
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
            this.thoiGianTamHoanDataGridViewTextBoxColumn,
            this.lyDoDataGridViewTextBoxColumn});
            this.dgv_chuyenbay.DataSource = this.chuyenBayTamHoanBindingSource;
            this.dgv_chuyenbay.Location = new System.Drawing.Point(340, 9);
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
            // thoiGianTamHoanDataGridViewTextBoxColumn
            // 
            this.thoiGianTamHoanDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianTamHoan";
            this.thoiGianTamHoanDataGridViewTextBoxColumn.HeaderText = "ThoiGianTamHoan";
            this.thoiGianTamHoanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianTamHoanDataGridViewTextBoxColumn.Name = "thoiGianTamHoanDataGridViewTextBoxColumn";
            // 
            // lyDoDataGridViewTextBoxColumn
            // 
            this.lyDoDataGridViewTextBoxColumn.DataPropertyName = "LyDo";
            this.lyDoDataGridViewTextBoxColumn.HeaderText = "LyDo";
            this.lyDoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lyDoDataGridViewTextBoxColumn.Name = "lyDoDataGridViewTextBoxColumn";
            // 
            // chuyenBayTamHoanBindingSource
            // 
            this.chuyenBayTamHoanBindingSource.DataMember = "ChuyenBayTamHoan";
            this.chuyenBayTamHoanBindingSource.DataSource = this.dBMS_DataSet;
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
            this.pnltimkiem.Controls.Add(this.btn_QLphandoan);
            this.pnltimkiem.Controls.Add(this.btn_xoa);
            this.pnltimkiem.Controls.Add(this.pictureBox1);
            this.pnltimkiem.Controls.Add(this.btn_huy);
            this.pnltimkiem.Controls.Add(this.btn_sua);
            this.pnltimkiem.Controls.Add(this.btn_luu);
            this.pnltimkiem.Location = new System.Drawing.Point(8, 7);
            this.pnltimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltimkiem.Name = "pnltimkiem";
            this.pnltimkiem.Size = new System.Drawing.Size(326, 445);
            this.pnltimkiem.TabIndex = 2;
            // 
            // btn_QLphandoan
            // 
            this.btn_QLphandoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_QLphandoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLphandoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_QLphandoan.Location = new System.Drawing.Point(41, 143);
            this.btn_QLphandoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLphandoan.Name = "btn_QLphandoan";
            this.btn_QLphandoan.Size = new System.Drawing.Size(243, 43);
            this.btn_QLphandoan.TabIndex = 56;
            this.btn_QLphandoan.Text = "Quay lại";
            this.btn_QLphandoan.UseVisualStyleBackColor = false;
            this.btn_QLphandoan.Click += new System.EventHandler(this.btn_QLphandoan_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(41, 237);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(243, 44);
            this.btn_xoa.TabIndex = 76;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Location = new System.Drawing.Point(41, 370);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(243, 43);
            this.btn_huy.TabIndex = 77;
            this.btn_huy.Text = "Hủy thao tác";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(41, 190);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(243, 43);
            this.btn_sua.TabIndex = 75;
            this.btn_sua.Text = "Thay đổi thông tin";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Location = new System.Drawing.Point(41, 321);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(243, 42);
            this.btn_luu.TabIndex = 77;
            this.btn_luu.Text = "Lưu thay đổi";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ CHUYẾN BAY TẠM HOÃN";
            // 
            // chuyenBayTamHoanTableAdapter
            // 
            this.chuyenBayTamHoanTableAdapter.ClearBeforeFill = true;
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_chitiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chitiet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_chitiet.Location = new System.Drawing.Point(1091, 11);
            this.btn_chitiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.Size = new System.Drawing.Size(101, 43);
            this.btn_chitiet.TabIndex = 78;
            this.btn_chitiet.Text = "Chi tiết";
            this.btn_chitiet.UseVisualStyleBackColor = false;
            this.btn_chitiet.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // FormChuyenBayTamHoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1213, 558);
            this.Controls.Add(this.btn_chitiet);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChuyenBayTamHoan";
            this.Text = "FormChuyenBayTamHoan";
            this.Load += new System.EventHandler(this.FormChuyenBayTamHoan_Load);
            this.pnlmain.ResumeLayout(false);
            this.pnl_modify.ResumeLayout(false);
            this.pnl_modify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_phutdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenbay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenBayTamHoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_DataSet)).EndInit();
            this.pnltimkiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Panel pnl_modify;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nud_phutdi;
        private System.Windows.Forms.NumericUpDown nud_giodi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.TextBox txt_lydo;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridView dgv_chuyenbay;
        private System.Windows.Forms.Panel pnltimkiem;
        private System.Windows.Forms.Button btn_QLphandoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DBMS_DataSet dBMS_DataSet;
        private System.Windows.Forms.BindingSource chuyenBayTamHoanBindingSource;
        private DBMS_DataSetTableAdapters.ChuyenBayTamHoanTableAdapter chuyenBayTamHoanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenBayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianTamHoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_chitiet;
    }
}