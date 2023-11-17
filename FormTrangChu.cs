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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {

            InitializeComponent();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {

            Image myimage = new Bitmap(@"../../Assets/bgtrangchu2.jpg");
            this.BackgroundImage = myimage;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnQLMayBay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyMayBay mayBay = new FormQuanLyMayBay();
            mayBay.ShowDialog();
            this.Show();
        }

        private void btnQLChuyenBay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyChuyenBay cb = new FormQuanLyChuyenBay();
            cb.ShowDialog();
            this.Show();
        }

        private void btnQLNhanSu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQLNhanSu item = new FormQLNhanSu();
            item.ShowDialog();
            this.Show();
        }

        private void btnQLHanhKhach_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyVe item = new FormQuanLyVe();
            item.ShowDialog();
            this.Show();
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            if (BienToanCuc.isadmin) {
                this.Hide();
                FormQLTaiKhoan item = new FormQLTaiKhoan();
                item.ShowDialog();
                this.Show();
            }
            else { MessageBox.Show("Bạn không có quyền!"); }
        }
    }
}
