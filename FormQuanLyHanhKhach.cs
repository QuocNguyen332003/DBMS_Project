using DBMS_Project.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class FormQuanLyHanhKhach : Form
    {
        ~FormQuanLyHanhKhach() { }
        DB_QuanLyHanhKhach db = new DB_QuanLyHanhKhach();
        public FormQuanLyHanhKhach()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = db.LayDuLieu();
            dgv_QuanLyHanhKhach.DataSource = dataTable;
            dgv_QuanLyHanhKhach.AutoResizeColumns();
            Reset_Text();
        }

        private void Reset_Text()
        {
            tb_MaHanhKhach.ResetText();
            tb_HoTen.ResetText();
            tb_CCCD.ResetText();
            tb_SDT.ResetText();
        }

        private void dgv_QuanLyHanhKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_QuanLyHanhKhach.CurrentCell.RowIndex;
            if (r < dgv_QuanLyHanhKhach.Rows.Count - 1 && r >= 0)
            {
                tb_MaHanhKhach.Text = dgv_QuanLyHanhKhach.Rows[r].Cells[0].Value.ToString();
                tb_CCCD.Text = dgv_QuanLyHanhKhach.Rows[r].Cells[1].Value.ToString();
                tb_SDT.Text = dgv_QuanLyHanhKhach.Rows[r].Cells[2].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string MaHK = tb_MaHanhKhach.Text.ToString();
            string CCCD = tb_CCCD.Text.ToString();
            string SDT = tb_SDT.Text.ToString();
            string error = "";
            bool b = db.ThemHanhKhach(MaHK, CCCD, SDT, ref error);
            if (b)
            {
                MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK);
                LoadData();
            }
            else
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string MaHK = tb_MaHanhKhach.Text.ToString();
            string CCCD = tb_CCCD.Text.ToString();
            string SDT = tb_SDT.Text.ToString();
            string error = "";
            bool b = db.SuaHanhKhach(MaHK, CCCD, SDT, ref error);
            if (b)
            {
                MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK);
                LoadData();
            }
            else
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string MaHK = tb_MaHanhKhach.Text.ToString();
            string error = "";
            bool b = db.XoaHanhKhach(MaHK, ref error);
            if (b)
            {
                MessageBox.Show("Xoá thành công", "Thành công", MessageBoxButtons.OK);
                LoadData();
            }
            else
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string CCCD = tb_TimKiem_CCCD.Text.ToString();
            DataTable dataTable = db.TimHanhKhach(CCCD);
            if(dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var MaHK = row["MaHanhKhach"];
                    tb_TimKiem_MaHanhKhach.Text = (string)MaHK;
                    var SDT = row["SDT"];
                    tb_TimKiem_SDT.Text = (string)SDT;
                }
            }    
            else
            {
                tb_TimKiem_MaHanhKhach.Text = "Không tìm thấy";
                tb_TimKiem_HoTen.Text = "Không tìm thấy";
                tb_TimKiem_SDT.Text = "Không tìm thấy";
            }    
        }
    }
}
