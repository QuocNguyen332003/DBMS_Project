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
    public partial class FormQuanLyMayBay : Form
    {
        private string soHieu;
        private string tenLoaiMayBay;

        BL_QuanLyMayBay bl = new BL_QuanLyMayBay();
        ChinhSua state = ChinhSua.none;

        public FormQuanLyMayBay()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataTable dataTable = bl.LayDuLieu();
            dgv_Quanlymaybay.DataSource = dataTable;
            dgv_Quanlymaybay.AutoResizeColumns();
            Reset_Text();
        }

        private void Reset_Text()
        {
            tb_sohieu.Text = string.Empty;
            tb_tongsoghe.Text = string.Empty;
        }

        private void FormQuanLyMayBay_Load(object sender, EventArgs e)
        {
            LoadData();
            cbb_sohieu.DataSource = bl.get1Col("SoHieu");
            cbb_sohieu.DisplayMember = "SoHieu";
            cbb_ten.DataSource = bl.get1Col("TenLoaiMayBay");
            cbb_ten.DisplayMember = "TenLoaiMayBay";
            cbb_ten1.DataSource = bl.get1Col("TenLoaiMayBay");
            cbb_ten1.DisplayMember = "TenLoaiMayBay";
            cbb_tongsoghe.DataSource = bl.get1Col("TongSoGhe");
            cbb_tongsoghe.DisplayMember = "TongSoGhe";
            cbb_tinhtrang.DataSource = bl.get1Col("TinhTrangHD");
            cbb_tinhtrang.DisplayMember = "TinhTrangHD";
            cbb_tinhtrang1.DataSource = bl.get1Col("TinhTrangHD");
            cbb_tinhtrang1.DisplayMember = "TinhTrangHD";
        }

        private void dgv_Quanlymaybay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_Quanlymaybay.CurrentCell.RowIndex;
            if(r < dgv_Quanlymaybay.Rows.Count - 1 && r >= 0)
            {
                tb_sohieu.Text = dgv_Quanlymaybay.Rows[r].Cells[0].Value.ToString();
                cbb_ten1.Text = dgv_Quanlymaybay.Rows[r].Cells[1].Value.ToString();
                tb_tongsoghe.Text = dgv_Quanlymaybay.Rows[r].Cells[2].Value.ToString();
                cbb_tinhtrang1.Text = dgv_Quanlymaybay.Rows[r].Cells[3].Value.ToString();
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
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
            Reset_Text();
            pnl_thongso.Enabled = true;
            tb_sohieu.Enabled = true;
            cbb_ten1.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.sua;
            pnl_thongso.Enabled = true;
            tb_sohieu.Enabled = false;
            cbb_ten1.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (tb_sohieu.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa Máy bay này?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    bl.XoaMayBay(tb_sohieu.Text, cbb_ten1.Text);
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn máy bay muốn xóa!"); }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(state == ChinhSua.them)
            {
                if (!bl.KiemTraDuDieu(tb_sohieu.Text, cbb_ten1.Text) && tb_sohieu.Text != "")
                {
                    if (tb_sohieu.Text == "" || cbb_ten1.Text == "" || tb_tongsoghe.Text == "" || cbb_tinhtrang1.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin máy bay!");
                    }
                    else
                    {
                        bl.ThemMayBay(tb_sohieu.Text, cbb_ten1.Text, Convert.ToInt32(tb_tongsoghe.Text), cbb_tinhtrang1.Text);
                    }
                }
                else MessageBox.Show("Máy bay không hợp lệ!");
            }
            else if(state == ChinhSua.sua)
            {
                if(bl.KiemTraDuDieu(tb_sohieu.Text, cbb_ten1.Text) && tb_sohieu.Text != "")
                {
                    bl.ThayDoiThongTin(tb_sohieu.Text, cbb_ten1.Text, Convert.ToInt32(tb_tongsoghe.Text), cbb_tinhtrang1.Text);
                }
                else MessageBox.Show("Bạn chưa chọn máy bay!");
            }
            LoadData();
            state = ChinhSua.none;
            pnl_thongso.Enabled = false;
        }

        private void btn_khoangmaybay_Click(object sender, EventArgs e)
        {
            int r = dgv_Quanlymaybay.CurrentCell.RowIndex;
            this.soHieu = dgv_Quanlymaybay.Rows[r].Cells[0].Value.ToString();
            this.tenLoaiMayBay = dgv_Quanlymaybay.Rows[r].Cells[1].Value.ToString();
            this.Hide();
            FormQuanLyKhoangMayBay formQuanLyKhoangMayBay = new FormQuanLyKhoangMayBay(this.soHieu, this.tenLoaiMayBay);
            formQuanLyKhoangMayBay.ShowDialog();
            this.Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            int numSoHieu = cb_sohieu.Checked ? 1 : 0;
            int numTen = cb_ten.Checked ? 1 : 0;
            int numTongSoGhe = cb_tongsoghe.Checked ? 1 : 0;
            int numTinhTrangHD = cb_tinhtrang.Checked ? 1 : 0;

            DataTable data = bl.TimMayBay(cbb_sohieu.Text, numSoHieu, cbb_ten.Text, numTen, cbb_tongsoghe.Text, numTongSoGhe, cbb_tinhtrang.Text, numTinhTrangHD);
            if (data != null)
            {
                dgv_Quanlymaybay.DataSource = data;
            }
        }   
    }
}
