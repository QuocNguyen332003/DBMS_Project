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
    internal enum ChinhSua
    {
        them,
        sua,
        none
    }
    public partial class FormQuanLyChuyenBay : Form
    {
        BL_QuanLyChuyenBay bl = new BL_QuanLyChuyenBay();
        ChinhSua state = ChinhSua.none;
        public FormQuanLyChuyenBay()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dataTable = bl.LayDuLieu();
            dgv_chuyenbay.DataSource = dataTable;
            dgv_chuyenbay.AutoResizeColumns();
            Reset_Text();
        }
        private void FormQuanLyChuyenBay_Load(object sender, EventArgs e)
        {
            LoadData();
            cbb_id.DataSource = bl.get1Col("MaChuyenBay");
            this.cbb_id.DisplayMember = "MaChuyenBay";
            cbb_tinhtrang.DataSource = bl.get1Col("TinhTrangHD");
            this.cbb_tinhtrang.DisplayMember = "TinhTrangHD";
            cbb_giodi.DataSource = bl.get1Col("GioDi");
            this.cbb_giodi.DisplayMember = "GioDi";
            cbb_ngaydi.DataSource = bl.get1Col("NgayDi");
            this.cbb_ngaydi.DisplayMember = "NgayDi";
            cbb_gioden.DataSource = bl.get1Col("GioDen");
            this.cbb_gioden.DisplayMember = "GioDen";
            cbb_ngayden.DataSource = bl.get1Col("NgayDen");
            this.cbb_ngayden.DisplayMember = "NgayDen";
        }
        private void Reset_Text()
        {
            txt_id.ResetText();
            txt_tinhtrang.ResetText();
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            int numID = cb_id.Checked ? 1 : 0;
            int numTT = cb_tt.Checked ? 1 : 0;
            int numGioDi = cb_giodi.Checked ? 1 : 0;
            int numNgayDi = cb_ngaydi.Checked ? 1 : 0;
            int numGioDen = cb_gioden.Checked ? 1 : 0;
            int numNgayDen = cb_ngayden.Checked ? 1 : 0;
            DataTable data = bl.TimChuyenBay(cbb_id.Text, numID, cbb_tinhtrang.Text, numTT,
                cbb_giodi.Text, numGioDi, cbb_ngaydi.Text, numNgayDi, 
                cbb_gioden.Text, numGioDen, cbb_ngayden.Text, numNgayDen);
            if (data != null)
            {
                dgv_chuyenbay.DataSource = data;
            }
            else
            {
                MessageBox.Show("Không tồn tại chuyến bay!");
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.them;
            pnlEnabled.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.sua;
            pnlEnabled.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (txt_id.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa Chuyến bay " + txt_id.Text + 
                    "? Thao tác này sẽ xóa tất cả phân đoạn và các lịch trình tham gia của nhân viên có cùng mã chuyến bay", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    bl.XoaChuyenBay(txt_id.Text);
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn chuyến bay muốn xóa!"); }
        }
        private void btnTamHoan_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (txt_id.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xác nhận tạm hoãn chuyến bay?" + txt_id.Text + "?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    FormYeuCauTamHoan form = new FormYeuCauTamHoan(txt_id.Text);
                    form.ShowDialog();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn tài khoản muốn xóa!"); }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (state == ChinhSua.them)
            {
                if (!bl.KiemTraDuDieu(txt_id.Text) && txt_id.Text != "")
                {
                    bl.ThemChuyenBay(txt_id.Text, txt_tinhtrang.Text,
                        new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0), dtp_ngaydi.Value,
                        new TimeSpan(Convert.ToInt32(nud_gioden.Value), Convert.ToInt32(nud_phutden.Value), 0), dtpngayden.Value);
                }
                else MessageBox.Show("Mã chuyến bay không hợp lệ!");
            }
            else if(state == ChinhSua.sua) 
            {
                if (bl.KiemTraDuDieu(txt_id.Text) && txt_id.Text != "")
                {
                    bl.ThayDoiThongTin(txt_id.Text, txt_tinhtrang.Text,
                        new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0), dtp_ngaydi.Value,
                        new TimeSpan(Convert.ToInt32(nud_gioden.Value), Convert.ToInt32(nud_phutden.Value), 0), dtpngayden.Value);
                }
                else MessageBox.Show("Mã chuyến bay không hợp lệ!");
            }
            LoadData();
            state = ChinhSua.none;
            pnlEnabled.Enabled = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            state = ChinhSua.none;
            pnlEnabled.Enabled = false;
        }

        private void dgv_chuyenbay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_chuyenbay.CurrentCell.RowIndex;
            if (r < dgv_chuyenbay.Rows.Count - 1 && r >= 0)
            {
                txt_id.Text = dgv_chuyenbay.Rows[r].Cells[0].Value.ToString();
                txt_tinhtrang.Text = dgv_chuyenbay.Rows[r].Cells[1].Value.ToString();
                DateTime gioDiDateTime = DateTime.ParseExact(dgv_chuyenbay.Rows[r].Cells[2].Value.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);
                TimeSpan gioDi = gioDiDateTime.TimeOfDay;
                nud_giodi.Value = gioDi.Hours; nud_phutdi.Value = gioDi.Minutes;
                dtp_ngaydi.Value = Convert.ToDateTime(dgv_chuyenbay.Rows[r].Cells[3].Value.ToString());
                DateTime giodenDateTime = DateTime.ParseExact(dgv_chuyenbay.Rows[r].Cells[4].Value.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);
                TimeSpan gioDen = giodenDateTime.TimeOfDay;
                nud_gioden.Value = gioDen.Hours; nud_phutden.Value = gioDen.Minutes;
                dtpngayden.Value = Convert.ToDateTime(dgv_chuyenbay.Rows[r].Cells[5].Value.ToString());
            }
        }

        private void btn_QLphandoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyPhanDoan form = new FormQuanLyPhanDoan();
            form.ShowDialog();
            this.Show();
            LoadData();
        }

        private void btn_QLTamHoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChuyenBayTamHoan form = new FormChuyenBayTamHoan();
            form.ShowDialog();
            LoadData();
            this.Show();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            DateTime date = Convert.ToDateTime(cbb_ngaydi.Text);
            MessageBox.Show(" Số lượng chuyến bay trong ngày " + date + " là: " +bl.SoLuongChuyenBayTheoNgay(date).ToString());
        }
    }
}
