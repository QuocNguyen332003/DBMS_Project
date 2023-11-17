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
    public partial class FormChuyenBayTamHoan : Form
    {
        BL_QuanLyTamHoan bl = new BL_QuanLyTamHoan();
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
            DataTable dataTable = bl.LayDuLieu();
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
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.sua;
            pnl_modify.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (txt_id.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xác nhận xóa tạm hoãn cho chuyến bay " + txt_id.Text + "? ", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    bl.XoaChuyenBayTamHoan(txt_id.Text);
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn chuyến bay muốn xóa!"); }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (state == ChinhSua.sua)
            {
                if (bl.KiemTraDuDieu(txt_id.Text) && txt_id.Text != "")
                {
                    bl.ThayDoiChuyenBayTamHoan(txt_id.Text, 
                        new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0), txt_lydo.Text);
                    LoadData();
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

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            FormChiTietTamHoan form = new FormChiTietTamHoan();
            form.ShowDialog();
        }
    }
}
