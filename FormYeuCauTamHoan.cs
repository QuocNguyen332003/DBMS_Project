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
using DBMS_Project.ConnectDataBase;
using static System.Windows.Forms.AxHost;

namespace DBMS_Project
{
    public partial class FormYeuCauTamHoan : Form
    {
        private string id;
        private DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
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
            if (!db.KiemTraDuLieu("select * from ChuyenBayTamHoan where MaChuyenBay = '" + txt_id.Text + "'") && txt_id.Text != "")
            {
                db.ChinhSuaDuLieu("Update ChuyenBay SET TinhTrangHD = N'Tạm hoãn' WHERE MaChuyenBay = '" + txt_id.Text + "'");
                db.openConnection();
                SqlCommand cmd = new SqlCommand("[InsertChuyenBayTamHoan]", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = txt_id.Text;
                cmd.Parameters.Add("@ThoiGian", SqlDbType.Time).Value = new TimeSpan(Convert.ToInt32(nud_giodi.Value), Convert.ToInt32(nud_phutdi.Value), 0);
                cmd.Parameters.Add("@LyDo", SqlDbType.NVarChar).Value = txt_lydo.Text;
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thêm thành công!");
                else
                    MessageBox.Show("Thêm thất bại");
                db.closeConnection();
            }
            else MessageBox.Show("Mã chuyến bay không hợp lệ!");
            this.Close();
        }
    }
}
