using DBMS_Project.BL;
using DBMS_Project.ConnectDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class FormQuanLyPhanDoan : Form
    {
        BL_QuanLyPhanDoan bl = new BL_QuanLyPhanDoan();
        ChinhSua state = ChinhSua.none;
        public FormQuanLyPhanDoan()
        {
            InitializeComponent();
        }

        private void FormQuanLyPhanDoan_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            DataTable dataTable = bl.LayDuLieu();
            dgv_phandoan.DataSource = dataTable;
            dgv_phandoan.AutoResizeColumns();
            Reset_Text();

            cbb_loai.DataSource = bl.getLoaiMayBay();
            cbb_loai.DisplayMember = "TenLoaiMayBay";
            cbb_sanbaydi.DataSource = bl.getSanBay();
            cbb_sanbaydi.DisplayMember = "MaSanBay";
            cbb_sanbayden.DataSource = bl.getSanBay();
            cbb_sanbayden.DisplayMember = "MaSanBay";
        }
        private void Reset_Text()
        {
            txt_id.ResetText();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.them;
            pnlEnabled.Enabled = true;
            txt_id.Enabled = true;
            nud_stt.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.sua;
            pnlEnabled.Enabled = true;
            txt_id.Enabled = false;
            nud_stt.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (txt_id.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa Phân đoạn " + txt_id.Text +
                    "? Thao tác này sẽ xóa tất cả các lịch trình tham gia của nhân viên trong phân đoạn này", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    bl.XoaPhanDoan(txt_id.Text, Convert.ToInt32(nud_stt.Value));
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn phân đoạn muốn xóa!"); }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (state == ChinhSua.them)
            {
                if (!bl.KiemTraDuDieu(txt_id.Text, Convert.ToInt32(nud_stt.Value)) && txt_id.Text != "")
                {
                    bl.ThemPhanDoan(txt_id.Text, Convert.ToInt32(nud_stt.Value), cbb_SoHieu.Text, cbb_loai.Text,
                        cbb_sanbaydi.Text, new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0), dtp_ngaydi.Value,
                        cbb_sanbayden.Text, new TimeSpan(Convert.ToInt32(nud_gioden.Value), Convert.ToInt32(nud_phutden.Value), 0), dtp_ngayden.Value);                
                }
                else MessageBox.Show("Mã chuyến bay không hợp lệ!");
            }
            else if (state == ChinhSua.sua)
            {
                if (bl.KiemTraDuDieu(txt_id.Text, Convert.ToInt32(nud_stt.Value)) && txt_id.Text != "")
                {
                    bl.ThayDoiThongTin(txt_id.Text, Convert.ToInt32(nud_stt.Value), cbb_SoHieu.Text, cbb_loai.Text,
                        cbb_sanbaydi.Text, new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0), dtp_ngaydi.Value,
                        cbb_sanbayden.Text, new TimeSpan(Convert.ToInt32(nud_gioden.Value), Convert.ToInt32(nud_phutden.Value), 0), dtp_ngayden.Value);
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

        private void dgv_phandoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_phandoan.CurrentCell.RowIndex;
            if (r < dgv_phandoan.Rows.Count - 1 && r >= 0)
            {
                txt_id.Text = dgv_phandoan.Rows[r].Cells[0].Value.ToString();
                nud_stt.Value = Convert.ToInt32(dgv_phandoan.Rows[r].Cells[1].Value);
                cbb_loai.Text = dgv_phandoan.Rows[r].Cells[3].Value.ToString();
                cbb_SoHieu.Text = dgv_phandoan.Rows[r].Cells[2].Value.ToString();
                cbb_sanbaydi.Text = dgv_phandoan.Rows[r].Cells[4].Value.ToString();
                DateTime gioDiDateTime = DateTime.ParseExact(dgv_phandoan.Rows[r].Cells[5].Value.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);
                TimeSpan gioDi = gioDiDateTime.TimeOfDay;
                nud_giodi.Value = gioDi.Hours; nud_phutdi.Value = gioDi.Minutes;
                dtp_ngaydi.Value = Convert.ToDateTime(dgv_phandoan.Rows[r].Cells[6].Value.ToString());
                cbb_sanbayden.Text = dgv_phandoan.Rows[r].Cells[7].Value.ToString();
                DateTime giodenDateTime = DateTime.ParseExact(dgv_phandoan.Rows[r].Cells[8].Value.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);
                TimeSpan gioDen = giodenDateTime.TimeOfDay;
                nud_gioden.Value = gioDen.Hours; nud_phutden.Value = gioDen.Minutes;
                dtp_ngayden.Value = Convert.ToDateTime(dgv_phandoan.Rows[r].Cells[9].Value.ToString());
            }
        }

        private void cbb_loai_SelectedValueChanged(object sender, EventArgs e)
        {
            cbb_SoHieu.DataSource = bl.getSoHieuTheoLoaiMB(cbb_loai.Text);
            cbb_SoHieu.DisplayMember = "SoHieu";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenloai = cbb_loai.Text;
            MessageBox.Show("Công ty sản xuất loại máy bay " + tenloai + " là: " + bl.CongTySanXuat(tenloai));
        }
    }
}
