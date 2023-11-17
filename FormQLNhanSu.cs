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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DBMS_Project
{

    public partial class FormQLNhanSu : Form
    {
        BL_QuanLyNhanSu bl = new BL_QuanLyNhanSu();
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
            DataTable dataTable = bl.LayDuLieu();
            dgvQLNhanSu.DataSource = dataTable;
            trangthai1();

            cbb_idnhanvien.DataSource = bl.GetNhanVien();
            this.cbb_idnhanvien.DisplayMember = "MaNV";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
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
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            state = ChinhSua.sua;
            trangthai2();
            txt_id_emp.Enabled = false;

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (state == ChinhSua.them)
            {
                if (!bl.KiemTraDuDieu(txt_id_emp.Text) && txt_id_emp.Text != "")
                {
                    bl.ThemNhanSu(txt_id_emp.Text, txt_name.Text, txt_gender.Text, txt_address.Text, dtp_born.Value, txt_phone.Text,
                        txt_id_work.Text, dtp_tuyendung.Value , txt_hesoluong.Text);
                }
                else MessageBox.Show("Mã chuyến bay không hợp lệ!");
            }
            else if (state == ChinhSua.sua)
            {
                if (bl.KiemTraDuDieu(txt_id_emp.Text) && txt_id_emp.Text != "")
                {
                    bl.UpdateNhanSu(txt_id_emp.Text, txt_name.Text, txt_gender.Text, txt_address.Text, dtp_born.Value, txt_phone.Text,
                        txt_id_work.Text, dtp_tuyendung.Value, txt_hesoluong.Text);
                }
                else MessageBox.Show("Mã chuyến bay không hợp lệ!");
            }
            LoadData();
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
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            if (txt_id_emp.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa Nhân Viên " + txt_id_emp.Text + "?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    bl.XoaNhanVien(txt_id_emp.Text);
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn nhân viên muốn xóa!"); }

        }
        private void btn_Luong_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            bl.TinhLuong(txt_id_emp.Text);
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
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            DataTable data = bl.TimNhanVien(cbb_idnhanvien.Text);
            if (data != null)
            {
                dgvQLNhanSu.DataSource = data;
            }
            else
            {
                MessageBox.Show("Không tồn tại nhân viên!");
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (!BienToanCuc.isadmin) { MessageBox.Show("Bạn không có quyền!"); return; }
            this.Hide();
            FormThongKeNV thongke = new FormThongKeNV();
            thongke.ShowDialog();
            this.Show();
        }
    }
}
