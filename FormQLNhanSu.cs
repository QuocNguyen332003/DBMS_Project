using DBMS_Project.ConnectDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DBMS_Project
{

    public partial class FormQLNhanSu : Form
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        ChinhSua state = ChinhSua.none;
        public FormQLNhanSu()
        {
            InitializeComponent();
        }

        private void FormQLNhanSu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DataTable dataTable = db.LayDuLieu("select * from LoadNhanVien");
            dgvQLNhanSu.DataSource = dataTable;
            dgvQLNhanSu.AutoResizeColumns();
            trangthai1();
            cbb_idnhanvien.DataSource = db.LayDuLieu("select DISTINCT MaNV from LoadNhanVien");
            this.cbb_idnhanvien.DisplayMember = "MaNV";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            state = ChinhSua.them;
            trangthai2();

            txt_id_emp.Text = String.Empty;
            txt_name.Text = String.Empty;
            txt_gender.Text = String.Empty;
            txt_address.Text = String.Empty;
            dtp_born.Text = String.Empty;
            txt_phone.Text = String.Empty;
            txt_id_work.Text = String.Empty;
            dtp_tuyendung.Text = String.Empty;
            txt_hesoluong.Text = String.Empty;
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            state = ChinhSua.sua;
            trangthai2();
            txt_id_emp.Enabled = false;

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (state == ChinhSua.them)
            {
                if (!db.KiemTraDuLieu("select * from NhanVien where MaNV = '" + txt_id_emp.Text + "'") && txt_id_emp.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("InsertNhanVien", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = txt_id_emp.Text;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NChar).Value = txt_name.Text;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NChar).Value = txt_gender.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NChar).Value = txt_address.Text;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtp_born.Value.ToShortDateString();
                    cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = txt_phone.Text;
                    cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = txt_id_work.Text;
                    cmd.Parameters.Add("@NgayTuyenDung", SqlDbType.Date).Value = dtp_tuyendung.Value.ToShortDateString();
                    cmd.Parameters.Add("@HeSoLuong", SqlDbType.Float).Value = Convert.ToDouble(txt_hesoluong.Text);

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
                if (db.KiemTraDuLieu("select * from NhanVien where MaNV = '" + txt_id_emp.Text + "'") && txt_id_emp.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("InsertNhanVien", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = txt_id_emp.Text;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NChar).Value = txt_name.Text;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NChar).Value = txt_gender.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NChar).Value = txt_address.Text;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtp_born.Value.ToShortDateString();
                    cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = txt_phone.Text;
                    cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = txt_id_work.Text;
                    cmd.Parameters.Add("@NgayTuyenDung", SqlDbType.Date).Value = dtp_tuyendung.Value.ToShortDateString();
                    cmd.Parameters.Add("@HeSoLuong", SqlDbType.Float).Value = Convert.ToDouble(txt_hesoluong.Text);

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

        private void dgvQLNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvQLNhanSu.CurrentCell.RowIndex;
            if (r < dgvQLNhanSu.Rows.Count - 1 && r >= 0)
            {
                txt_id_emp.Text = dgvQLNhanSu.Rows[r].Cells[0].Value.ToString();
                txt_name.Text = dgvQLNhanSu.Rows[r].Cells[1].Value.ToString();
                txt_gender.Text = dgvQLNhanSu.Rows[r].Cells[2].Value.ToString();
                txt_address.Text = dgvQLNhanSu.Rows[r].Cells[3].Value.ToString();
                dtp_born.Value = Convert.ToDateTime(dgvQLNhanSu.Rows[r].Cells[4].Value.ToString());
                txt_phone.Text = dgvQLNhanSu.Rows[r].Cells[5].Value.ToString();
                txt_id_work.Text = dgvQLNhanSu.Rows[r].Cells[6].Value.ToString();
                dtp_tuyendung.Value = Convert.ToDateTime(dgvQLNhanSu.Rows[r].Cells[7].Value.ToString());
                txt_hesoluong.Text = dgvQLNhanSu.Rows[r].Cells[8].Value.ToString();
            }
        }

        
        private void trangthai1()
        {
            txt_id_emp.Enabled = false;
            txt_name.Enabled = false;
            txt_gender.Enabled = false;
            txt_address.Enabled = false;
            dtp_born.Enabled = false;
            txt_phone.Enabled = false;
            txt_id_work.Enabled = false;
            dtp_tuyendung.Enabled = false;
            txt_hesoluong.Enabled = false;
        }
        private void trangthai2()
        {
            txt_id_emp.Enabled = true;
            txt_name.Enabled = true;
            txt_gender.Enabled = true;
            txt_address.Enabled = true;
            dtp_born.Enabled = true;
            txt_phone.Enabled = true;
            txt_id_work.Enabled = true;
            dtp_tuyendung.Enabled = true;
            txt_hesoluong.Enabled = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            state = ChinhSua.none;
            trangthai1();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_id_emp.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa Nhân Viên " + txt_id_emp.Text + "?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("DeleteNhanVien", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = txt_id_emp.Text;
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Xóa thất bại");

                    db.closeConnection();
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn nhân viên muốn xóa!"); }

        }
        private void btn_Luong_Click(object sender, EventArgs e)
        {

            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT dbo.TinhLuong(@MaNV)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaNV", SqlDbType.Char).Value = txt_id_emp.Text;
            object result = cmd.ExecuteScalar();
            double LuongNV = (double)result;
            string LuongNVString = LuongNV.ToString();
            MessageBox.Show("Lương của nhân viên có Mã Nhân Viên là " + txt_id_emp.Text + "là: " + LuongNVString);
            db.closeConnection();
        }

        private void btn_QLThamGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThamGia thamgia = new FormThamGia();
            thamgia.ShowDialog();
            this.Show();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from SearchNhanVien(@MaNV)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaNV", cbb_idnhanvien.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();
            if (data.Rows.Count > 0)
            {
                dgvQLNhanSu.DataSource = data;
            }
            else
            {
                MessageBox.Show("Không tồn tại nhân viên!");
            }
            db.closeConnection();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
