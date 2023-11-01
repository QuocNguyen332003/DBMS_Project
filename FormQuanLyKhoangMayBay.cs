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
    public partial class FormQuanLyKhoangMayBay : Form
    {
        private string soHieu;
        private string tenLoaiMayBay;
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        ChinhSua state = ChinhSua.none;
        public FormQuanLyKhoangMayBay(string soHieu, string tenLoaiMayBay)
        {
            InitializeComponent();
            this.soHieu = soHieu;
            this.tenLoaiMayBay = tenLoaiMayBay;
            tb_sohieu.Enabled = false;
            tb_tenloaimaybay.Enabled = false;
        }

        private void LoadData()
        {
            DataTable dataTable = db.LayDuLieu("select * from TT_KhoangMB where SoHieu = '" + soHieu + "' and TenLoaiMayBay = '" + tenLoaiMayBay + "'");
            dgv_khoangmaybay.DataSource = dataTable;
            dgv_khoangmaybay.AutoResizeColumns();
            ResetText();
        }

        private void ResetText()
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
            state = ChinhSua.them;
            pnl_thongso.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            state = ChinhSua.sua;
            tb_makhoang.Enabled = false;
            pnl_thongso.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tb_sohieu.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa Khoang máy bay này không? " + tb_sohieu.Text + "?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("XoaKhoangMayBay", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = tb_sohieu.Text;
                    cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = tb_tenloaimaybay.Text;
                    cmd.Parameters.Add("@MaKhoang", SqlDbType.VarChar).Value = tb_makhoang.Text;

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
                if(!db.KiemTraDuLieu("select * from KhoangMayBay where SoHieu = '" + tb_sohieu.Text + "' and TenLoaiMayBay = '" + tb_tenloaimaybay + "' and MaKhoang = '" + tb_makhoang + "'") && tb_sohieu.Text != "")
                {
                    if (tb_tongsoghe.Text == "" || tb_makhoang.Text == "" || tb_tenloaikhoang.Text == "")

                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin máy bay!");
                    }
                    else
                    {
                        db.openConnection();
                        SqlCommand cmd = new SqlCommand("ThemKhoangMayBay", db.getConnection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = this.soHieu;
                        cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = this.tenLoaiMayBay;
                        cmd.Parameters.Add("@MaKhoang", SqlDbType.VarChar).Value = tb_makhoang.Text;
                        cmd.Parameters.Add("@TenLoaiKhoang", SqlDbType.NVarChar).Value = tb_tenloaikhoang.Text;
                        cmd.Parameters.Add("@TongSoGhe", SqlDbType.Int).Value = tb_tongsoghe.Text;

                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Thêm thành công!");
                        else
                            MessageBox.Show("Thêm thất bại");
                        LoadData();
                        db.closeConnection();
                    }
                }
                else MessageBox.Show("Khoang máy bay không hợp lệ!");
            }
            else if(state == ChinhSua.sua)
            {
                if(!db.KiemTraDuLieu("select * from KhoangMayBay where SoHieu = '" + tb_sohieu.Text + "' and TenLoaiMayBay = '" + tb_tenloaimaybay + "' and MaKhoang = '" + tb_makhoang + "'") && tb_sohieu.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("UpdateKhoangMayBay", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = tb_sohieu.Text;
                    cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = tb_tenloaimaybay.Text;
                    cmd.Parameters.Add("@MaKhoang", SqlDbType.VarChar).Value=tb_makhoang.Text;
                    cmd.Parameters.Add("@TenLoaiKhoang", SqlDbType.NVarChar).Value = tb_tenloaikhoang.Text;
                    cmd.Parameters.Add("@TongSoGhe", SqlDbType.Int).Value = tb_tongsoghe.Text;

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thay đổi thành công!");
                    else
                        MessageBox.Show("Thay đổi thất bại");
                    LoadData();
                    db.closeConnection();
                }
                else MessageBox.Show("Khoang máy bay không hợp lệ!");
            }
            state = ChinhSua.none;
            pnl_thongso.Enabled = false;
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            FormQuanLyMayBay formQuanLyMayBay = new FormQuanLyMayBay();
            this.Hide();
            formQuanLyMayBay.ShowDialog();
            Close();
        }
    }
}