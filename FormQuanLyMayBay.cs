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
    public partial class FormQuanLyMayBay : Form
    {
        private string soHieu;
        private string tenLoaiMayBay;
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        ChinhSua state = ChinhSua.none;
        public FormQuanLyMayBay()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dataTable = db.LayDuLieu("select * from DSMayBayHD");
            dgv_Quanlymaybay.DataSource = dataTable;
            dgv_Quanlymaybay.AutoResizeColumns();
            Reset_Text();
        }

        private void Reset_Text()
        {
            tb_sohieu.Text = string.Empty;
            tb_ten.Text = string.Empty;
            tb_tongsoghe.Text = string.Empty;
            tb_tinhtrang.Text = string.Empty;
        }

        private void FormQuanLyMayBay_Load(object sender, EventArgs e)
        {
            LoadData();
            cbb_sohieu.DataSource = db.LayDuLieu("select DISTINCT SoHieu from DSMayBayHD");
            cbb_sohieu.DisplayMember = "SoHieu";
            cbb_ten.DataSource = db.LayDuLieu("select DISTINCT TenLoaiMayBay from DSMayBAyHD");
            cbb_ten.DisplayMember = "TenLoaiMayBay";
            cbb_tongsoghe.DataSource = db.LayDuLieu("select DISTINCT TongSoGhe from DSMayBAyHD");
            cbb_tongsoghe.DisplayMember = "TongSoGhe";
            cbb_tinhtrang.DataSource = db.LayDuLieu("select DISTINCT TinhTrangHD from DSMayBAyHD");
            cbb_tinhtrang.DisplayMember = "TinhTrangHD";
        }

        private void dgv_Quanlymaybay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_Quanlymaybay.CurrentCell.RowIndex;
            if(r < dgv_Quanlymaybay.Rows.Count - 1 && r >= 0)
            {
                tb_sohieu.Text = dgv_Quanlymaybay.Rows[r].Cells[0].Value.ToString();
                tb_ten.Text = dgv_Quanlymaybay.Rows[r].Cells[1].Value.ToString();
                tb_tongsoghe.Text = dgv_Quanlymaybay.Rows[r].Cells[2].Value.ToString();
                tb_tinhtrang.Text = dgv_Quanlymaybay.Rows[r].Cells[3].Value.ToString();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            LoadData();
            pnl_thongso.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            state = ChinhSua.them;
            Reset_Text();
            pnl_thongso.Enabled = true;
            tb_sohieu.Enabled = true;
            tb_ten.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            state = ChinhSua.sua;
            pnl_thongso.Enabled = true;
            tb_sohieu.Enabled = false;
            tb_ten.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(tb_sohieu.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa Máy bay này không? " + tb_sohieu.Text + "?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("XoaMayBay", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SoHieu", SqlDbType.Char).Value = tb_sohieu.Text;
                    cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.Char).Value = tb_ten.Text;
                    
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Xóa thất bại");

                    db.closeConnection();
                    LoadData();
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(state == ChinhSua.them)
            {
                if (!db.KiemTraDuLieu("select * from MayBay where SoHieu = '" + tb_sohieu.Text + "' and TenLoaiMayBay = '" + tb_ten + "'") && tb_sohieu.Text != "")
                {
                    if (tb_sohieu.Text == "" || tb_ten.Text == "" || tb_tongsoghe.Text == "" || tb_tinhtrang.Text == "")

                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin máy bay!");
                    }
                    else
                    {
                        db.openConnection();
                        SqlCommand cmd = new SqlCommand("ThemMayBay", db.getConnection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@SoHieu", SqlDbType.Char).Value = tb_sohieu.Text;
                        cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.Char).Value = tb_ten.Text;
                        cmd.Parameters.Add("@TongSoGhe", SqlDbType.Int).Value = tb_tongsoghe.Text;
                        cmd.Parameters.Add("@TinhTrangHD", SqlDbType.NChar).Value = tb_tinhtrang.Text;

                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Thêm thành công!");
                        else
                            MessageBox.Show("Thêm thất bại");
                        LoadData();
                        db.closeConnection();
                    }
                }
                else MessageBox.Show("Số hiệu hoặc Tên loại máy bay không hợp lệ!");
            }
            else if(state == ChinhSua.sua)
            {
                if(!db.KiemTraDuLieu("select * from MayBay where SoHieu = '" + tb_sohieu.Text + "' and TenLoaiMayBay = '" + tb_ten + "'") && tb_sohieu.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("UpdateMayBay", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SoHieu", SqlDbType.Char).Value = tb_sohieu.Text;
                    cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.Char).Value = tb_ten.Text;
                    cmd.Parameters.Add("@TongSoGhe", SqlDbType.Int).Value = tb_tongsoghe.Text;
                    cmd.Parameters.Add("@TinhTrangHD", SqlDbType.NChar).Value = tb_tinhtrang.Text;

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thay đổi thành công!");
                    else
                        MessageBox.Show("Thay đổi thất bại");
                    LoadData();
                    db.closeConnection();
                }
                else MessageBox.Show("Số hiệu hoặc Tên loại máy bay không hợp lệ!");
            }
            state = ChinhSua.none;
            pnl_thongso.Enabled = false;
        }

        private void btn_khoangmaybay_Click(object sender, EventArgs e)
        {
            int r = dgv_Quanlymaybay.CurrentCell.RowIndex;
            this.soHieu = dgv_Quanlymaybay.Rows[r].Cells[0].Value.ToString();
            this.tenLoaiMayBay = dgv_Quanlymaybay.Rows[r].Cells[1].Value.ToString();
            FormQuanLyKhoangMayBay formQuanLyKhoangMayBay = new FormQuanLyKhoangMayBay(this.soHieu, this.tenLoaiMayBay);
            this.Hide();
            formQuanLyKhoangMayBay.ShowDialog();
            this.Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            int numSoHieu = cb_sohieu.Checked ? 1 : 0;
            int numTen = cb_ten.Checked ? 1 : 0;
            int numTongSoGhe = cb_tongsoghe.Checked ? 1 : 0;
            int numTinhTrangHD = cb_tinhtrang.Checked ? 1 : 0;

            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from TimMayBay(@SoHieu, @numSoHieu, @TenLoaiMayBay, @numTenLoaiMayBay, @TongSoGhe, @numTongSoGhe, @TinhTrangHD, @numTinhTrangHD)", db.getConnection);
            cmd.Parameters.AddWithValue("@SoHieu", cbb_sohieu.Text);
            cmd.Parameters.AddWithValue("@numSoHieu", numSoHieu);
            cmd.Parameters.AddWithValue("@TenLoaiMayBay", cbb_ten.Text);
            cmd.Parameters.AddWithValue("@numTenLoaiMayBay", numTen);
            cmd.Parameters.AddWithValue("@TongSoGhe", cbb_tongsoghe.Text);
            cmd.Parameters.AddWithValue("@numTongSoGhe", numTongSoGhe);
            cmd.Parameters.AddWithValue("TinhTrangHD", cbb_tinhtrang.Text);
            cmd.Parameters.AddWithValue("numTinhTrangHD", numTinhTrangHD);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();
            if (data.Rows.Count > 0)
            {
                dgv_Quanlymaybay.DataSource = data;
            }
            else
            {
                MessageBox.Show("Không tồn tại may bay!");
            }
            db.closeConnection();
        }
    }
}
