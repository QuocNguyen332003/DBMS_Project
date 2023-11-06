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
    internal class BL_QuanLyKhoangMayBay
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();

        public BL_QuanLyKhoangMayBay() { }

        public DataTable LayDuLieu(string soHieu, string ten)
        {
            return db.LayDuLieu("select * from TT_KhoangMB where SoHieu = '" + soHieu + "' and TenLoaiMayBay = '" + ten + "'");
        }

        public bool KiemTraDuDieu(string soHieu, string ten, string maKhoang)
        {
            return db.KiemTraDuLieu("select * from KhoangMayBay where SoHieu = '" + soHieu + "' and TenLoaiMayBay = '" + ten + "' and MaKhoang = '" + maKhoang + "'");
        }

        public void XoaKhoangMayBay(string soHieu, string ten, string maKhoang)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("XoaKhoangMayBay", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = soHieu;
            cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = ten;
            cmd.Parameters.Add("@MaKhoang", SqlDbType.VarChar).Value = maKhoang;

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa thất bại");
            db.closeConnection();
        }

        public void ThemKhoangMayBay(string soHieu, string ten, string maKhoang, string tenKhoang, int soGhe)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("ThemKhoangMayBay", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = soHieu;
            cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = ten;
            cmd.Parameters.Add("@MaKhoang", SqlDbType.VarChar).Value = maKhoang;
            cmd.Parameters.Add("@TenLoaiKhoang", SqlDbType.NVarChar).Value = tenKhoang;
            cmd.Parameters.Add("@TongSoGhe", SqlDbType.Int).Value = soGhe;

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thêm thành công!");
            else
                MessageBox.Show("Thêm thất bại");
            db.closeConnection();
        }

        public void ThayDoiThongTin(string soHieu, string ten, string maKhoang, string tenKhoang, int soGhe)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("UpdateKhoangMayBay", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = soHieu;
            cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = ten;
            cmd.Parameters.Add("@MaKhoang", SqlDbType.VarChar).Value = maKhoang;
            cmd.Parameters.Add("@TenLoaiKhoang", SqlDbType.NVarChar).Value = tenKhoang;
            cmd.Parameters.Add("@TongSoGhe", SqlDbType.Int).Value = soGhe;

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thay đổi thành công!");
            else
                MessageBox.Show("Thay đổi thất bại");
            db.closeConnection();
        }
    }
}
