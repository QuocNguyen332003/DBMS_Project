namespace DBMS_Project
{
    partial class FormThongKeNV
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
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_thongke = new System.Windows.Forms.ComboBox();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongke.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Location = new System.Drawing.Point(9, 41);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.Size = new System.Drawing.Size(762, 386);
            this.dgv_thongke.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_thongke);
            this.panel1.Controls.Add(this.cbb_thongke);
            this.panel1.Controls.Add(this.dgv_thongke);
            this.panel1.Location = new System.Drawing.Point(4, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 432);
            this.panel1.TabIndex = 1;
            // 
            // cbb_thongke
            // 
            this.cbb_thongke.FormattingEnabled = true;
            this.cbb_thongke.Items.AddRange(new object[] {
            "Xem lịch sử tham gia chuyến bay của nhân viên",
            "Xem bảng thống kê số giờ bay và lương của nhân viên"});
            this.cbb_thongke.Location = new System.Drawing.Point(384, 13);
            this.cbb_thongke.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_thongke.Name = "cbb_thongke";
            this.cbb_thongke.Size = new System.Drawing.Size(278, 21);
            this.cbb_thongke.TabIndex = 93;
            this.cbb_thongke.Text = "Xem lịch sử tham gia chuyến bay của nhân viên";
            // 
            // btn_thongke
            // 
            this.btn_thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btn_thongke.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.White;
            this.btn_thongke.Location = new System.Drawing.Point(678, 8);
            this.btn_thongke.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(93, 30);
            this.btn_thongke.TabIndex = 95;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = false;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "BẢNG THỐNG KÊ NHÂN SỰ";
            // 
            // FormThongKeNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(786, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormThongKeNV";
            this.Text = "FormThongKeNV";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbb_thongke;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Label label1;
    }
}