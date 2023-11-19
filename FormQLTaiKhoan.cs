using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_Project.BL;
namespace DBMS_Project
{
    public partial class FormQLTaiKhoan : Form
    {
        BL_TaiKhoan bl = new BL_TaiKhoan();
        public FormQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormQLTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DataTable dataTable = bl.LoadTaiKhoan();
            dgv_taikhoan.DataSource = dataTable;
            dgv_taikhoan.AutoResizeColumns();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!(txt_user.Text == ""))
            {
                bl.ThemTaiKhoan(txt_user.Text, txt_pass.Text, cbb_loai.Text);
                LoadData();
            }
            else MessageBox.Show("Nhập đầy đủ thông tin");
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!(txt_user.Text == ""))
            {
                bl.XoaTaiKhoan(txt_user.Text);
                LoadData();
            }
            else MessageBox.Show("Nhập đầy đủ thông tin");
        }

        private void dgv_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_taikhoan.CurrentCell.RowIndex;
            if (r < dgv_taikhoan.Rows.Count - 1 && r >= 0)
            {
                txt_user.Text = dgv_taikhoan.Rows[r].Cells[0].Value.ToString();
            }
        }
    }
}
