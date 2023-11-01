using DBMS_Project.BL;
using DBMS_Project.ConnectDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DBMS_Project
{
    public partial class FormThamGia : Form
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        ChinhSua state = ChinhSua.none;
        public FormThamGia()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dataTable = db.LayDuLieu("select * from LayThamGia");
            dgv_thamgia.DataSource = dataTable;
            cbb_idchuyenbay.DataSource = db.LayDuLieu("select DISTINCT MaChuyenBay from LoadPhanDoan");
            this.cbb_idchuyenbay.DisplayMember = "MaChuyenBay";
            cbb_stt.DataSource = db.LayDuLieu("select DISTINCT STT from LoadPhanDoan");
            this.cbb_stt.DisplayMember = "STT";

            cbb_id.DataSource = db.LayDuLieu("select DISTINCT MaChuyenBay from LoadPhanDoan");
            this.cbb_id.DisplayMember = "MaChuyenBay";
            cbb_stt1.DataSource = db.LayDuLieu("select DISTINCT STT from LoadPhanDoan");
            this.cbb_stt1.DisplayMember = "STT";
            cbb_idnhanvien.DataSource = db.LayDuLieu("select DISTINCT MaNV from LoadNhanVien");
            this.cbb_idnhanvien.DisplayMember = "MaNV";
            cbb_vaitro.DataSource = db.LayDuLieu("select DISTINCT TenCV from LoadCongViec");
            this.cbb_vaitro.DisplayMember = "TenCV";
        }



        private void FormThamGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBMS_DataSet.ThamGia' table. You can move, or remove it, as needed.
            LoadData();
        }

        private void dgv_thamgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_thamgia.CurrentCell.RowIndex;
            if (r < dgv_thamgia.Rows.Count - 1 && r >= 0)
            {
                cbb_idchuyenbay.Text = dgv_thamgia.Rows[r].Cells[0].Value.ToString();
                cbb_stt.Text = dgv_thamgia.Rows[r].Cells[1].Value.ToString();
                txt_idnhanvien.Text = dgv_thamgia.Rows[r].Cells[2].Value.ToString();
                txt_sogiobay.Text = dgv_thamgia.Rows[r].Cells[3].Value.ToString();
                txt_vaitro.Text = dgv_thamgia.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            state = ChinhSua.them;

            pnlEnabled.Enabled = true;
            cbb_idchuyenbay.Enabled = false;
            cbb_stt.Enabled = false;

            cbb_idchuyenbay.Text = String.Empty;
            cbb_stt.Text = String.Empty;
            txt_idnhanvien.Text = String.Empty;
            txt_sogiobay.Text = String.Empty;
            txt_vaitro.Text = String.Empty;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            state = ChinhSua.sua;
            pnlEnabled.Enabled = true;

            cbb_idchuyenbay.Enabled = false;
            cbb_stt.Enabled = false;
            txt_idnhanvien.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (cbb_idchuyenbay.Text != "" && txt_idnhanvien.Text!= "" && cbb_stt.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("DeleteThamGia", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaChuyenBay", SqlDbType.Char).Value = cbb_idchuyenbay.Text;
                    cmd.Parameters.Add("@STT", SqlDbType.Char).Value = Convert.ToInt32(cbb_stt.Text);
                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = txt_idnhanvien.Text;
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Xóa thất bại");

                    db.closeConnection();
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn phần tử tham gia muốn xóa!"); }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (state == ChinhSua.them)
            {
                if (!db.KiemTraDuLieu("select * from ThamGia where MaChuyenBay = '" + cbb_idchuyenbay.Text + "' and STT =  '" + Convert.ToInt32(cbb_stt.Text) + "' and MaNV = '" + txt_idnhanvien.Text + "'") 
                    && cbb_idchuyenbay.Text != "" && cbb_stt.Text != "" && txt_idnhanvien.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("AddThamGia", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaChuyenBay", SqlDbType.Char).Value = cbb_idchuyenbay.Text;
                    cmd.Parameters.Add("@STT", SqlDbType.Int).Value = Convert.ToInt32(cbb_stt.Text);
                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = txt_idnhanvien.Text;
                    cmd.Parameters.Add("@SoGioBay", SqlDbType.Int).Value = Convert.ToInt32(txt_sogiobay.Text);
                    cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar).Value = txt_vaitro.Text;
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
                if (db.KiemTraDuLieu("select * from ThamGia where MaChuyenBay = '" + cbb_idchuyenbay.Text + "' and STT =  '" + cbb_stt.Text + "' and MaNV = '" + txt_idnhanvien.Text + "'")
    && cbb_idchuyenbay.Text != "" && cbb_stt.Text != "" && txt_idnhanvien.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("UpdateThamGia", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaChuyenBay", SqlDbType.Char).Value = cbb_idchuyenbay.Text;
                    cmd.Parameters.Add("@STT", SqlDbType.Int).Value = Convert.ToInt32(cbb_stt.Text);
                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = txt_idnhanvien.Text;
                    cmd.Parameters.Add("@SoGioBay", SqlDbType.Int).Value = Convert.ToInt32(txt_sogiobay.Text);
                    cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar).Value = txt_vaitro.Text;

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
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            state = ChinhSua.none;
            pnlEnabled.Enabled = false;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            int numIDChuyenBay = cb_idchuyenbay.Checked ? 1 : 0;
            int numSTT = cb_stt.Checked ? 1 : 0;
            int numIDNhanVien = cb_idnhanvien.Checked ? 1 : 0;
            int numSoGioBay = cb_sogiobay.Checked ? 1 : 0;
            int numVaiTro = cb_vaitro.Checked ? 1 : 0;
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from SearchThamGia(@MaCB, @numMaCB, @STT ,@numSTT, @MaNV, @numIDNhanVien, @SoGioBay, @numSoGioBay,@VaiTro, @numVaiTro)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaCB", cbb_id.Text);
            cmd.Parameters.AddWithValue("@numMaCB", numIDChuyenBay);
            cmd.Parameters.AddWithValue("@STT", cbb_stt.Text);
            cmd.Parameters.AddWithValue("@numSTT", numSTT);
            cmd.Parameters.AddWithValue("@MaNV", cbb_idnhanvien.Text);
            cmd.Parameters.AddWithValue("@numIDNhanVien", numIDNhanVien);
            cmd.Parameters.AddWithValue("@SoGioBay", num_sogiobay.Text);
            cmd.Parameters.AddWithValue("@numSoGioBay", numSoGioBay);
            cmd.Parameters.AddWithValue("@VaiTro", cbb_vaitro.Text);
            cmd.Parameters.AddWithValue("@numVaiTro", numVaiTro);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();
            if (data.Rows.Count > 0)
            {
                dgv_thamgia.DataSource = data;
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
    }
}
