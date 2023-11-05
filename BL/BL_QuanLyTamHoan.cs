using DBMS_Project.ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project.BL
{
    internal class BL_QuanLyTamHoan
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();

        public BL_QuanLyTamHoan()
        {
        }

        public DataTable LayDuLieu()
        {
            return db.LayDuLieu("select * from LoadChuyenBayTamHoan");
        }
        public bool KiemTraDuDieu(string macb)
        {
            return db.KiemTraDuLieu("select * from ChuyenBayTamHoan where MaChuyenBay = '" + macb + "'");
        }
        public void ThemChuyenBayTamHoan(string macb, TimeSpan thoigian,string lydo)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("[InsertChuyenBayTamHoan]", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = macb;
            cmd.Parameters.Add("@ThoiGian", SqlDbType.Time).Value = thoigian;
            cmd.Parameters.Add("@LyDo", SqlDbType.NVarChar).Value = lydo;

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thêm thành công!");
            else
                MessageBox.Show("Thêm thất bại");
            db.closeConnection();
        }

        public void ThayDoiChuyenBayTamHoan(string macb, TimeSpan thoigian, string lydo)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("UpdateChuyenBayTamHoan", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = macb;
            cmd.Parameters.Add("@ThoiGian", SqlDbType.Time).Value = thoigian;
            cmd.Parameters.Add("@LyDo", SqlDbType.NVarChar).Value = lydo;

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thay đổi thành công!");
            else
                MessageBox.Show("Thay đổi thất bại");
            db.closeConnection();
        }

        public void XoaChuyenBayTamHoan(string MaChuyenBay)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("[DeleteChuyenBayTamHoan]", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = MaChuyenBay;
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa thất bại");
            db.closeConnection();
        }
        public DataTable ChiTiet()
        {
            return db.LayDuLieu("select * from LichTrinhTamHoan");
        }
    }
}
