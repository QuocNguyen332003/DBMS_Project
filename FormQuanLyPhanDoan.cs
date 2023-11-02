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
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
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
            DataTable dataTable = db.LayDuLieu("select * from LoadPhanDoan");
            dgv_phandoan.DataSource = dataTable;
            dgv_phandoan.AutoResizeColumns();
            Reset_Text();

            cbb_loai.DataSource = db.LayDuLieu("SELECT TenLoaiMayBay FROM LoaiMayBay");
            cbb_loai.DisplayMember = "TenLoaiMayBay";
            cbb_sanbaydi.DataSource = db.LayDuLieu("SElECT MaSanBay FROM SanBay");
            cbb_sanbaydi.DisplayMember = "MaSanBay";
            cbb_sanbayden.DataSource = db.LayDuLieu("SElECT MaSanBay FROM SanBay");
            cbb_sanbayden.DisplayMember = "MaSanBay";
        }
        private void Reset_Text()
        {
            txt_id.ResetText();
            txt_sohieu.ResetText();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            state = ChinhSua.them;
            pnlEnabled.Enabled = true;
            txt_id.Enabled = true;
            nud_stt.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            state = ChinhSua.sua;
            pnlEnabled.Enabled = true;
            txt_id.Enabled = false;
            nud_stt.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa Phân đoạn " + txt_id.Text +
                    "? Thao tác này sẽ xóa tất cả các lịch trình tham gia của nhân viên trong phân đoạn này", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("DeletePhanDoan", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = txt_id.Text;
                    cmd.Parameters.Add("@STT", SqlDbType.Int).Value = Convert.ToInt32(nud_stt.Value);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Xóa thất bại");

                    db.closeConnection();
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn phân đoạn muốn xóa!"); }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (state == ChinhSua.them)
            {
                if (!db.KiemTraDuLieu("select * from PhanDoan where MaChuyenBay = '" + txt_id.Text + "' and STT ="+nud_stt.Value) && txt_id.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("InsertPhanDoan", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = txt_id.Text;
                    cmd.Parameters.Add("@STT", SqlDbType.Int).Value = nud_stt.Value;
                    cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = txt_sohieu.Text;
                    cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = cbb_loai.Text;
                    cmd.Parameters.Add("@MaSanBayDi", SqlDbType.VarChar).Value = cbb_sanbaydi.Text;
                    cmd.Parameters.Add("@GioDi", SqlDbType.Time).Value = new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0);
                    cmd.Parameters.Add("@NgayDi", SqlDbType.Date).Value = dtp_ngaydi.Value.ToShortDateString();
                    cmd.Parameters.Add("@MaSanBayDen", SqlDbType.VarChar).Value = cbb_sanbayden.Text;
                    cmd.Parameters.Add("@GioDen", SqlDbType.Time).Value = new TimeSpan(Convert.ToInt32(nud_gioden.Value), Convert.ToInt32(nud_phutden.Value), 0);
                    cmd.Parameters.Add("@NgayDen", SqlDbType.Date).Value = dtp_ngayden.Value.ToShortDateString();
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thêm thành công!");
                    else
                        MessageBox.Show("Thêm thất bại");
                    LoadData();
                    db.closeConnection();
                }
                else MessageBox.Show("Mã chuyến bay không hợp lệ!");
            }
            else if (state == ChinhSua.sua)
            {
                if (db.KiemTraDuLieu("select * from PhanDoan where MaChuyenBay = '" + txt_id.Text + "' and STT =" + nud_stt.Value) && txt_id.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("UpdatePhanDoan", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = txt_id.Text;
                    cmd.Parameters.Add("@STT", SqlDbType.Int).Value = nud_stt.Value;
                    cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = txt_sohieu.Text;
                    cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = cbb_loai.Text;
                    cmd.Parameters.Add("@MaSanBayDi", SqlDbType.VarChar).Value = cbb_sanbaydi.Text;
                    cmd.Parameters.Add("@GioDi", SqlDbType.Time).Value = new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0);
                    cmd.Parameters.Add("@NgayDi", SqlDbType.Date).Value = dtp_ngaydi.Value.ToShortDateString();
                    cmd.Parameters.Add("@MaSanBayDen", SqlDbType.VarChar).Value = cbb_sanbayden.Text;
                    cmd.Parameters.Add("@GioDen", SqlDbType.Time).Value = new TimeSpan(Convert.ToInt32(nud_gioden.Value), Convert.ToInt32(nud_phutden.Value), 0);
                    cmd.Parameters.Add("@NgayDen", SqlDbType.Date).Value = dtp_ngayden.Value.ToShortDateString();


                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thay đổi thành công!");
                    else
                        MessageBox.Show("Thay đổi thất bại");
                    LoadData();
                    db.closeConnection();
                }
                else MessageBox.Show("Mã chuyến bay không hợp lệ!");
            }
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
                txt_sohieu.Text = dgv_phandoan.Rows[r].Cells[2].Value.ToString();
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
    }
}
