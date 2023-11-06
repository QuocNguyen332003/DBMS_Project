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
    internal class BL_QuanLyMayBay
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();

        public BL_QuanLyMayBay() { }

        public DataTable LayDuLieu()
        {
            return db.LayDuLieu("select * from DSMayBayHD");
        }

        public bool KiemTraDuDieu(string soHieu, string ten)
        {
            return db.KiemTraDuLieu("select * from MayBay where SoHieu = '" + soHieu + "' and TenLoaiMayBay = '" + ten + "'");
        }

        public DataTable get1Col(string namecol)
        {
            string sql = "select DISTINCT " + namecol + " from DSMayBayHD";
            return db.LayDuLieu(sql);
        }

        public void XoaMayBay(string soHieu, string ten)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("XoaMayBay", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = soHieu;
            cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = ten;
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa thất bại");
            db.closeConnection();
        }

        public void ThemMayBay(string soHieu, string ten, int tongSoGhe, string tinhTrang)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("ThemMayBay", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = soHieu;
            cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = ten;
            cmd.Parameters.Add("@TongSoGhe", SqlDbType.Int).Value = tongSoGhe;
            cmd.Parameters.Add("@TinhTrangHD", SqlDbType.NVarChar).Value = tinhTrang;

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thêm thành công!");
            else
                MessageBox.Show("Thêm thất bại");
            db.closeConnection();
        }

        public void ThayDoiThongTin(string soHieu, string ten, int tongSoGhe, string tinhTrang)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("UpdateMayBay", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = soHieu;
            cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = ten;
            cmd.Parameters.Add("@TongSoGhe", SqlDbType.Int).Value = tongSoGhe;
            cmd.Parameters.Add("@TinhTrangHD", SqlDbType.NVarChar).Value = tinhTrang;

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thay đổi thành công!");
            else
                MessageBox.Show("Thay đổi thất bại");
            db.closeConnection();
        }

        public DataTable TimMayBay(string soHieu, int numSoHieu, string ten, int numTen, string tongSoGhe, int numTongSoGhe, string tinhTrang, int numTinhTrangHD)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from TimMayBay(@SoHieu, @numSoHieu, @TenLoaiMayBay, @numTenLoaiMayBay, @TongSoGhe, @numTongSoGhe, @TinhTrangHD, @numTinhTrangHD)", db.getConnection);
            cmd.Parameters.AddWithValue("@SoHieu", soHieu);
            cmd.Parameters.AddWithValue("@numSoHieu", numSoHieu);
            cmd.Parameters.AddWithValue("@TenLoaiMayBay", ten);
            cmd.Parameters.AddWithValue("@numTenLoaiMayBay", numTen);
            cmd.Parameters.AddWithValue("@TongSoGhe", tongSoGhe);
            cmd.Parameters.AddWithValue("@numTongSoGhe", numTongSoGhe);
            cmd.Parameters.AddWithValue("TinhTrangHD", tinhTrang);
            cmd.Parameters.AddWithValue("numTinhTrangHD", numTinhTrangHD);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();
            if (data.Rows.Count > 0)
            {
                db.closeConnection();
                return data;
            }
            MessageBox.Show("Không tồn tại máy bay!");
            db.closeConnection();
            return null;
        }
    }
}

