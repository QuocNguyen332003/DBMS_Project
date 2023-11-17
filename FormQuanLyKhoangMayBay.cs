using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_Project.BL;
using DBMS_Project.ConnectDataBase;

namespace DBMS_Project
{
    public partial class FormQuanLyKhoangMayBay : Form
    {
        private string soHieu;
        private string tenLoaiMayBay;

        BL_QuanLyKhoangMayBay bl = new BL_QuanLyKhoangMayBay();
        ChinhSua state = ChinhSua.none;

        public FormQuanLyKhoangMayBay(string soHieu, string tenLoaiMayBay)
        {
            InitializeComponent();
            this.soHieu = soHieu;
            this.tenLoaiMayBay = tenLoaiMayBay;
        }

        private void LoadData()
        {
            DataTable dataTable = bl.LayDuLieu(soHieu,tenLoaiMayBay);
            dgv_khoangmaybay.DataSource = dataTable;
            dgv_khoangmaybay.AutoResizeColumns();
            Reset_Text();
        }

        private void Reset_Text()
        {
            tb_sohieu.Text = string.Empty;
            tb_tenloaimaybay.Text = string.Empty;
            tb_makhoang.Text = string.Empty;
            tb_tenloaikhoang.Text = string.Empty;
            tb_tongsoghe.Text = string.Empty;
        }

        private void FormQuanLyKhoangMayBay_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_khoangmaybay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_khoangmaybay.CurrentCell.RowIndex;
            if (r < dgv_khoangmaybay.Rows.Count - 1 && r >= 0)
            {
                tb_sohieu.Text = dgv_khoangmaybay.Rows[r].Cells[0].Value.ToString();
                tb_tenloaimaybay.Text = dgv_khoangmaybay.Rows[r].Cells[1].Value.ToString();
                tb_makhoang.Text = dgv_khoangmaybay.Rows[r].Cells[2].Value.ToString();
                tb_tenloaikhoang.Text = dgv_khoangmaybay.Rows[r].Cells[3].Value.ToString();
                tb_tongsoghe.Text = dgv_khoangmaybay.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            LoadData();
            pnl_thongso.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.them;
            pnl_thongso.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.sua;
            tb_makhoang.Enabled = false;
            pnl_thongso.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (tb_sohieu.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa khoang máy bay này không? ", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    bl.XoaKhoangMayBay(tb_sohieu.Text, tb_tenloaimaybay.Text, tb_makhoang.Text);
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn khoang máy bay muốn xóa!"); }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (state == ChinhSua.them)
            {
                if(!bl.KiemTraDuDieu(tb_sohieu.Text, tb_tenloaikhoang.Text, tb_makhoang.Text) && tb_sohieu.Text != "")
                {
                    if (tb_tongsoghe.Text == "" || tb_makhoang.Text == "" || tb_tenloaikhoang.Text == "")

                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin khoang máy bay!");
                    }
                    else
                    {
                        bl.ThemKhoangMayBay(tb_sohieu.Text, tb_tenloaimaybay.Text, tb_makhoang.Text, tb_tenloaikhoang.Text, Convert.ToInt32(tb_tongsoghe.Text));
                    }
                }
                else MessageBox.Show("Khoang máy bay không hợp lệ!");
            }
            else if(state == ChinhSua.sua)
            {
                if(bl.KiemTraDuDieu(tb_sohieu.Text, tb_tenloaimaybay.Text, tb_makhoang.Text) && tb_sohieu.Text != "")
                {
                    bl.ThayDoiThongTin(tb_sohieu.Text, tb_tenloaimaybay.Text, tb_makhoang.Text, tb_tenloaikhoang.Text, Convert.ToInt32(tb_tongsoghe.Text));
                }
                else MessageBox.Show("Khoang máy bay không hợp lệ!");
            }
            LoadData();
            state = ChinhSua.none;
            pnl_thongso.Enabled = false;
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyMayBay formQuanLyMayBay = new FormQuanLyMayBay();
            formQuanLyMayBay.ShowDialog();
            Close();
        }
    }
}