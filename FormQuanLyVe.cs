using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBMS_Project.BL;


namespace DBMS_Project
{
    public partial class FormQuanLyVe : Form
    {
        ~FormQuanLyVe() { }

        BL_QuanLyVe db = new BL_QuanLyVe();
        public FormQuanLyVe()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = db.LayDuLieu();
            dgv_QuanLyVe.DataSource = dataTable;
            dgv_QuanLyVe.AutoResizeColumns();
            Reset_Text();
        }

        private void Reset_Text()
        {
            tb_MaVe.ResetText();
            tb_MaHanhKhach.ResetText();
            tb_GiaVe.ResetText();
            tb_SoGhe.ResetText();
            tb_MaChuyenBay.ResetText();
            tb_TenLoaiKhoang.ResetText();
        }

        private void dgv_QuanLyVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_QuanLyVe.CurrentCell.RowIndex;
            if (r < dgv_QuanLyVe.Rows.Count - 1 && r >= 0)
            { 
                tb_MaVe.Text = dgv_QuanLyVe.Rows[r].Cells[0].Value.ToString();
                tb_MaHanhKhach.Text = dgv_QuanLyVe.Rows[r].Cells[1].Value.ToString();
                tb_MaChuyenBay.Text = dgv_QuanLyVe.Rows[r].Cells[2].Value.ToString();
                tb_GiaVe.Text = dgv_QuanLyVe.Rows[r].Cells[3].Value.ToString();
                tb_SoGhe.Text = dgv_QuanLyVe.Rows[r].Cells[4].Value.ToString();
                tb_TenLoaiKhoang.Text = dgv_QuanLyVe.Rows[r].Cells[5].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            string MaVe = tb_MaVe.Text.ToString();
            string MaHanhKhach = tb_MaHanhKhach.Text.ToString();
            string MaChuyenBay = tb_MaChuyenBay.Text.ToString();
            int GiaVe = Convert.ToInt32(tb_GiaVe.Text.ToString());
            int SoGhe = Convert.ToInt32(tb_SoGhe.Text.ToString());
            string TenLoaiKhoang = tb_TenLoaiKhoang.Text.ToString();
            string error = "";
            bool b = db.ThemVe(MaVe, MaHanhKhach, MaChuyenBay, GiaVe, SoGhe, TenLoaiKhoang, ref error);
            if (b)
            {
                MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK);
                LoadData();
            }
            else
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            string MaVe = tb_MaVe.Text.ToString();
            string MaHanhKhach = tb_MaHanhKhach.Text.ToString();
            string MaChuyenBay = tb_MaChuyenBay.Text.ToString();
            int GiaVe = Convert.ToInt32(tb_GiaVe.Text.ToString());
            int SoGhe = Convert.ToInt32(tb_SoGhe.Text.ToString());
            string TenLoaiKhoang = tb_TenLoaiKhoang.Text.ToString();
            string error = "";
            bool b = db.SuaVe(MaVe, MaHanhKhach, MaChuyenBay, GiaVe, SoGhe, TenLoaiKhoang, ref error);
            if (b)
            {
                MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK);
                LoadData();
            }
            else
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            string MaVe = tb_MaVe.Text.ToString();
            string error = "";
            bool b = db.XoaVe(MaVe, ref error);
            if (b)
            {
                MessageBox.Show("Xoá thành công", "Thành công", MessageBoxButtons.OK);
                LoadData();
            }
            else
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            DataTable dataTable = db.ThongKeVe();
            dgv_QuanLyVe_ThongKe.DataSource = dataTable;
            dgv_QuanLyVe_ThongKe.AutoResizeColumns();
        }

        private void btn_QuanLyHanhKhach_Click(object sender, EventArgs e)
        {
            FormQuanLyHanhKhach frmHK = new FormQuanLyHanhKhach();
            this.Hide();
            frmHK.ShowDialog();
            this.Show();
        }
    }
}
