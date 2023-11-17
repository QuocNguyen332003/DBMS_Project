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
        BL_ThamGia bl = new BL_ThamGia();
        BL_QuanLyNhanSu bl_ns = new BL_QuanLyNhanSu();
        ChinhSua state = ChinhSua.none;
        public FormThamGia()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dataTable = bl.LayDuLieu();
            dgv_thamgia.DataSource = dataTable;


            cbb_idchuyenbay.DataSource = bl.GetPhanDoan_id();
            this.cbb_idchuyenbay.DisplayMember = "MaChuyenBay";

            cbb_stt.DataSource = bl.GetPhanDoan_stt();
            this.cbb_stt.DisplayMember = "STT";

            cbb_id.DataSource = bl.GetPhanDoan_id();
            this.cbb_id.DisplayMember = "MaChuyenBay";

            cbb_stt1.DataSource = bl.GetPhanDoan_stt();
            this.cbb_stt1.DisplayMember = "STT";
            cbb_idnhanvien.DataSource = bl_ns.GetNhanVien();
            this.cbb_idnhanvien.DisplayMember = "MaNV";

            cbb_vaitro.DataSource = bl.GetCongViec();
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
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.them;

            pnlEnabled.Enabled = true;

            txt_idnhanvien.Text = String.Empty;
            txt_sogiobay.Text = String.Empty;
            txt_vaitro.Text = String.Empty;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.sua;
            pnlEnabled.Enabled = true;

            cbb_idchuyenbay.Enabled = false;
            cbb_stt.Enabled = false;
            txt_idnhanvien.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (cbb_idchuyenbay.Text != "" && txt_idnhanvien.Text!= "" && cbb_stt.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    bl.XoaThamGia(cbb_idchuyenbay.Text, cbb_stt.Text, txt_idnhanvien.Text);
                    LoadData();
                }

            }
            else { MessageBox.Show("Bạn chưa chọn phần tử tham gia muốn xóa!"); }
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (state == ChinhSua.them)
            {
                if (!bl.KiemTraDuLieu(cbb_idchuyenbay.Text,cbb_stt.Text, txt_idnhanvien.Text) 
                    && cbb_idchuyenbay.Text != "" && cbb_stt.Text != "" && txt_idnhanvien.Text != "")
                {
                    bl.ThemThamGia(cbb_idchuyenbay.Text, cbb_stt.Text, txt_idnhanvien.Text, txt_sogiobay.Text, txt_vaitro.Text);
                }
                else MessageBox.Show(" Không hợp lệ!");
            }
            else if (state == ChinhSua.sua)
            {
                if (bl.KiemTraDuLieu(cbb_idchuyenbay.Text, cbb_stt.Text, txt_idnhanvien.Text)
    && cbb_idchuyenbay.Text != "" && cbb_stt.Text != "" && txt_idnhanvien.Text != "")
                {
                    bl.SuaThamGia(cbb_idchuyenbay.Text, cbb_stt.Text, txt_idnhanvien.Text, txt_sogiobay.Text, txt_vaitro.Text);
                }
                else MessageBox.Show("Không hợp lệ!");
            }
            state = ChinhSua.none;
            LoadData();
            pnlEnabled.Enabled = false;
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

            DataTable data = bl.TimThamGia(cbb_id.Text, numIDChuyenBay, cbb_stt.Text, numSTT, cbb_idnhanvien.Text, numIDNhanVien, num_sogiobay.Text, numSoGioBay, cbb_vaitro.Text, numVaiTro);
            if (data != null)
            {
                dgv_thamgia.DataSource = data;
            }
            else
            {
                MessageBox.Show("Không tồn tại!");
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
