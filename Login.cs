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
    public partial class Login : Form
    {
        private BL_TaiKhoan bl = new BL_TaiKhoan();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            Image myimage = new Bitmap(@"../../Assets/background.jpg");
            this.BackgroundImage = myimage;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(bl.KiemTraTaiKhoan(tb_user.Text, tb_mk.Text))
            {
                FormTrangChu form = new FormTrangChu();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

    }
    internal class BienToanCuc
    {
        public static bool isadmin = true;
        public static string username = "";
        public static string password = "";
    }
}
