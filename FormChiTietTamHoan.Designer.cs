namespace DBMS_Project.BL
{
    partial class FormChiTietTamHoan
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
            this.dgv_chuyenbay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenbay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_chuyenbay
            // 
            this.dgv_chuyenbay.AllowUserToResizeColumns = false;
            this.dgv_chuyenbay.AllowUserToResizeRows = false;
            this.dgv_chuyenbay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chuyenbay.BackgroundColor = System.Drawing.Color.White;
            this.dgv_chuyenbay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chuyenbay.Location = new System.Drawing.Point(12, 49);
            this.dgv_chuyenbay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_chuyenbay.Name = "dgv_chuyenbay";
            this.dgv_chuyenbay.RowHeadersVisible = false;
            this.dgv_chuyenbay.RowHeadersWidth = 51;
            this.dgv_chuyenbay.RowTemplate.Height = 24;
            this.dgv_chuyenbay.Size = new System.Drawing.Size(1066, 339);
            this.dgv_chuyenbay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "CHI TIẾT TẠM HOÃN";
            // 
            // FormChiTietTamHoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1089, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_chuyenbay);
            this.Name = "FormChiTietTamHoan";
            this.Text = "FormChiTietTamHoan";
            this.Load += new System.EventHandler(this.FormChiTietTamHoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenbay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chuyenbay;
        private System.Windows.Forms.Label label1;
    }
}