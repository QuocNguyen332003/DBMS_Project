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
    public partial class FormChuyenBayTamHoan : Form
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        ChinhSua state = ChinhSua.none;
        public FormChuyenBayTamHoan()
        {
            InitializeComponent();
        }

        private void FormChuyenBayTamHoan_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void Reset_Text()
        {
            txt_id.ResetText();
            txt_lydo.ResetText();
        }
        private void LoadData()
        {
            DataTable dataTable = db.LayDuLieu("select * from LoadChuyenBayTamHoan");
            dgv_chuyenbay.DataSource = dataTable;
            dgv_chuyenbay.AutoResizeColumns();
            Reset_Text();
        }

        private void dgv_chuyenbay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_chuyenbay.CurrentCell.RowIndex;
            if (r < dgv_chuyenbay.Rows.Count - 1 && r >= 0)
            {
                txt_id.Text = dgv_chuyenbay.Rows[r].Cells[0].Value.ToString();
                txt_lydo.Text = dgv_chuyenbay.Rows[r].Cells[2].Value.ToString();
                DateTime gioDiDateTime = DateTime.ParseExact(dgv_chuyenbay.Rows[r].Cells[1].Value.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);
                TimeSpan gioDi = gioDiDateTime.TimeOfDay;
                nud_giodi.Value = gioDi.Hours; nud_phutdi.Value = gioDi.Minutes;
            }
        }

        private void btn_QLphandoan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            state = ChinhSua.sua;
            pnl_modify.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xác nhận xóa tạm hoãn cho chuyến bay " + txt_id.Text + "? ", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    db.ChinhSuaDuLieu("Update ChuyenBay SET TinhTrangHD = N'Chưa hoạt động' WHERE MaChuyenBay = '" + txt_id.Text + "'");
                    db.openConnection();  
                    SqlCommand cmd = new SqlCommand("[DeleteChuyenBayTamHoan]", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaCB", SqlDbType.Char).Value = txt_id.Text;
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

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (state == ChinhSua.sua)
            {
                if (db.KiemTraDuLieu("select * from ChuyenBayTamHoan where MaChuyenBay = '" + txt_id.Text + "'") && txt_id.Text != "")
                {
                    db.openConnection();
                    SqlCommand cmd = new SqlCommand("UpdateChuyenBayTamHoan", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = txt_id.Text;
                    cmd.Parameters.Add("@ThoiGian", SqlDbType.Time).Value = new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0);
                    cmd.Parameters.Add("@LyDo", SqlDbType.NVarChar).Value = txt_lydo.Text;
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
            pnl_modify.Enabled = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            state = ChinhSua.none;
            pnl_modify.Enabled = false;
        }
    }
}
