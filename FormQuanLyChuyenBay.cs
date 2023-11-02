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
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        ChinhSua state = ChinhSua.none;
        public FormQuanLyChuyenBay()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dataTable = db.LayDuLieu("select * from LoadChuyenBay");
            dgv_chuyenbay.DataSource = dataTable;
            dgv_chuyenbay.AutoResizeColumns();
            Reset_Text();
        }
        private void FormQuanLyChuyenBay_Load(object sender, EventArgs e)
        {
            LoadData();
            cbb_id.DataSource = db.LayDuLieu("select DISTINCT MaChuyenBay from LoadChuyenBay");
            this.cbb_id.DisplayMember = "MaChuyenBay";
            cbb_tinhtrang.DataSource = db.LayDuLieu("select DISTINCT TinhTrangHD from LoadChuyenBay");
            this.cbb_tinhtrang.DisplayMember = "TinhTrangHD";
            cbb_giodi.DataSource = db.LayDuLieu("select DISTINCT GioDi from LoadChuyenBay");
            this.cbb_giodi.DisplayMember = "GioDi";
            cbb_ngaydi.DataSource = db.LayDuLieu("select DISTINCT NgayDi from LoadChuyenBay");
            this.cbb_ngaydi.DisplayMember = "NgayDi";
            cbb_gioden.DataSource = db.LayDuLieu("select DISTINCT GioDen from LoadChuyenBay");
            this.cbb_gioden.DisplayMember = "GioDen";
            cbb_ngayden.DataSource = db.LayDuLieu("select DISTINCT NgayDen from LoadChuyenBay");
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
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from SearchChuyenBay(@MaCB, @numMaCB, @TT ,@numTT, @GioDi, @numGioDi, @NgayDi, @numNgayDi,@GioDen, @numGioDen, @NgayDen, @numNgayDen)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaCB", cbb_id.Text);
            cmd.Parameters.AddWithValue("@numMaCB", numID);
            cmd.Parameters.AddWithValue("@TT", cbb_tinhtrang.Text);
            cmd.Parameters.AddWithValue("@numTT", numTT);
            cmd.Parameters.AddWithValue("@GioDi", cbb_giodi.Text);
            cmd.Parameters.AddWithValue("@numGioDi", numGioDi);
            cmd.Parameters.AddWithValue("@NgayDi", cbb_ngaydi.Text);
            cmd.Parameters.AddWithValue("@numNgayDi", numNgayDi);
            cmd.Parameters.AddWithValue("@GioDen", cbb_gioden.Text);
            cmd.Parameters.AddWithValue("@numGioDen", numGioDen);
            cmd.Parameters.AddWithValue("@NgayDen", cbb_ngayden.Text);
            cmd.Parameters.AddWithValue("@numNgayDen", numNgayDen);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            MessageBox.Show(cmd.CommandText);
            reader.Close();
            if (data.Rows.Count > 0)
            {
                dgv_chuyenbay.DataSource = data;
            }
            else
            {
                MessageBox.Show("Không tồn tại chuyến bay!");
            }
            db.closeConnection();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            state = ChinhSua.them;
            pnlEnabled.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            state = ChinhSua.sua;
            pnlEnabled.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa Chuyến bay " + txt_id.Text + 
                    "? Thao tác này sẽ xóa tất cả phân đoạn và các lịch trình tham gia của nhân viên có cùng mã chuyến bay", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("DeleteChuyenBay", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = txt_id.Text;
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Xóa thất bại");

                    db.closeConnection();
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn chuyến bay muốn xóa!"); }
        }
        private void btnTamHoan_Click(object sender, EventArgs e)
        {
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
            if (state == ChinhSua.them)
            {
                if (!db.KiemTraDuLieu("select * from ChuyenBay where MaChuyenBay = '" + txt_id.Text + "'") && txt_id.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("InsertChuyenBay", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = txt_id.Text;
                    cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = txt_tinhtrang.Text;
                    cmd.Parameters.Add("@GioDi", SqlDbType.Time).Value = new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0);
                    cmd.Parameters.Add("@NgayDi", SqlDbType.Date).Value = dtp_ngaydi.Value.ToShortDateString();
                    cmd.Parameters.Add("@GioDen", SqlDbType.Time).Value = new TimeSpan(Convert.ToInt32(nud_gioden.Value), Convert.ToInt32(nud_phutden.Value), 0);
                    cmd.Parameters.Add("@NgayDen", SqlDbType.Date).Value = dtpngayden.Value.ToShortDateString();

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thêm thành công!");
                    else 
                        MessageBox.Show("Thêm thất bại");
                    LoadData();
                    db.closeConnection();
                }
                else MessageBox.Show("Mã chuyến bay không hợp lệ!");
            }
            else if(state == ChinhSua.sua) {
                if (db.KiemTraDuLieu("select * from ChuyenBay where MaChuyenBay = '" + txt_id.Text + "'") && txt_id.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("UpdateChuyenBay", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = txt_id.Text;
                    cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = txt_tinhtrang.Text;
                    cmd.Parameters.Add("@GioDi", SqlDbType.Time).Value = new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0);
                    cmd.Parameters.Add("@NgayDi", SqlDbType.Date).Value = dtp_ngaydi.Value.ToShortDateString();
                    cmd.Parameters.Add("@GioDen", SqlDbType.Time).Value = new TimeSpan(Convert.ToInt32(nud_gioden.Value), Convert.ToInt32(nud_phutden.Value), 0);
                    cmd.Parameters.Add("@NgayDen", SqlDbType.Date).Value = dtpngayden.Value.ToShortDateString();

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
            this.Show();
            LoadData();
        }
    }
}
