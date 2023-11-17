using DBMS_Project.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class FormQuanLyHanhKhach : Form
    {
        BL_QuanLyHanhKhach db = new BL_QuanLyHanhKhach();
        public FormQuanLyHanhKhach()
        {
            InitializeComponent();
            LoadData();
        }

        ~FormQuanLyHanhKhach() { }

        private void LoadData()
        {
            DataTable dataTable = db.LayDuLieu();
            dgv_QuanLyHanhKhach.DataSource = dataTable;
            Reset_Text();
        }

        private void Reset_Text()
        {
            tb_MaHanhKhach.ResetText();
            tb_HoTen.ResetText();
            tb_CCCD.ResetText();
            tb_SDT.ResetText();
        }

        private void Reset_Text_TimKiem()
        {
            tb_TimKiem_CCCD.ResetText();
            tb_TimKiem_HoTen.ResetText();
            tb_TimKiem_MaHanhKhach.ResetText();
            tb_TimKiem_SDT.ResetText();
        }

        private void dgv_QuanLyHanhKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_QuanLyHanhKhach.CurrentCell.RowIndex;
            if (r < dgv_QuanLyHanhKhach.Rows.Count - 1 && r >= 0)
            {
                tb_MaHanhKhach.Text = dgv_QuanLyHanhKhach.Rows[r].Cells[0].Value.ToString();
                tb_HoTen.Text = dgv_QuanLyHanhKhach.Rows[r].Cells[1].Value.ToString();
                tb_CCCD.Text = dgv_QuanLyHanhKhach.Rows[r].Cells[2].Value.ToString();
                tb_SDT.Text = dgv_QuanLyHanhKhach.Rows[r].Cells[3].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            string MaHK = tb_MaHanhKhach.Text.ToString();
            string HoTen = tb_HoTen.Text.ToString();
            string CCCD = tb_CCCD.Text.ToString();
            string SDT = tb_SDT.Text.ToString();
            string error = "";
            bool b = db.ThemHanhKhach(MaHK, HoTen, CCCD, SDT, ref error);
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
            string MaHK = tb_MaHanhKhach.Text.ToString();
            string HoTen = tb_HoTen.Text.ToString();
            string CCCD = tb_CCCD.Text.ToString();
            string SDT = tb_SDT.Text.ToString();
            string error = "";
            bool b = db.SuaHanhKhach(MaHK, HoTen, CCCD, SDT, ref error);
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
            string MaHK = tb_MaHanhKhach.Text.ToString();
            string error = "";
            bool b = db.XoaHanhKhach(MaHK, ref error);
            if (b)
            {
                MessageBox.Show("Xoá thành công", "Thành công", MessageBoxButtons.OK);
                LoadData();
            }
            else
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            Reset_Text();
            string CCCD = tb_TimKiem_CCCD.Text.Trim();
            DataTable dataTable = new DataTable();
            if (CCCD.Length > 0)
            {
                dataTable = db.TimHanhKhachTheoCCCD(CCCD);
                dgv_QuanLyHanhKhach.DataSource = dataTable;
                return;
            }
            string MaHK = tb_TimKiem_MaHanhKhach.Text.Trim();
            if(MaHK.Length > 0)
            {
                dataTable = db.TimHanhKhachTheoMaHK(MaHK);
                dgv_QuanLyHanhKhach.DataSource = dataTable;
                return;
            }
            string HoTen = tb_TimKiem_HoTen.Text.Trim();
            string sdt = tb_TimKiem_SDT.Text.Trim();
            if (HoTen.Length > 0 && sdt.Length == 0)
            {
                dataTable = db.TimHanhKhachTheoHoTen(HoTen);
                dgv_QuanLyHanhKhach.DataSource = dataTable;
                return;
            }
            if(HoTen.Length == 0 && sdt.Length > 0)
            {
                dataTable = db.TimHanhKhachTheoSDT(sdt);
                dgv_QuanLyHanhKhach.DataSource = dataTable;
                return;
            }
            if(HoTen.Length > 0 && sdt.Length > 0)
            {
                dataTable = db.TimHanhKhachTheoHoTenVaSDT(HoTen, sdt);
                dgv_QuanLyHanhKhach.DataSource = dataTable;
                return;
            }    
        }

        private void btn_ReLoad_Click(object sender, EventArgs e)
        {
            Reset_Text_TimKiem();
            LoadData();
        }

        private void FormQuanLyHanhKhach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBMS_DataSet.HanhKhach' table. You can move, or remove it, as needed.
            this.hanhKhachTableAdapter.Fill(this.dBMS_DataSet.HanhKhach);

        }

        private void rb_sdt_CheckedChanged(object sender, EventArgs e)
        {
            tb_TimKiem_SDT.Enabled = !tb_TimKiem_SDT.Enabled;
            tb_TimKiem_SDT.ResetText();
        }

        private void rb_cccd_CheckedChanged(object sender, EventArgs e)
        {
            tb_TimKiem_CCCD.Enabled = !tb_TimKiem_CCCD.Enabled;
            tb_TimKiem_CCCD.ResetText();
        }

        private void rb_mahk_CheckedChanged(object sender, EventArgs e)
        {
            tb_TimKiem_MaHanhKhach.Enabled = !tb_TimKiem_MaHanhKhach.Enabled;
            tb_TimKiem_MaHanhKhach.ResetText();
        }

        private void rb_hoten_CheckedChanged(object sender, EventArgs e)
        {
            tb_TimKiem_HoTen.Enabled = !tb_TimKiem_HoTen.Enabled;
            tb_TimKiem_HoTen.ResetText();
        }
    }
}
