using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_Project.BL;
using DBMS_Project.ConnectDataBase;
using static System.Windows.Forms.AxHost;

namespace DBMS_Project
{
    public partial class FormYeuCauTamHoan : Form
    {
        private string id;
        BL_QuanLyTamHoan bl = new BL_QuanLyTamHoan();
        public FormYeuCauTamHoan(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void FormYeuCauTamHoan_Load(object sender, EventArgs e)
        {
            txt_id.Text = id;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!bl.KiemTraDuDieu(id) && txt_id.Text != "")
            {
                bl.ThemChuyenBayTamHoan(txt_id.Text, 
                    new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0), txt_lydo.Text);
            }
            else MessageBox.Show("Mã chuyến bay không hợp lệ!");
            this.Close();
        }
    }
}
