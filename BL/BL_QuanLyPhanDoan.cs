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
    internal class BL_QuanLyPhanDoan
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();

        public BL_QuanLyPhanDoan()
        {
        }

        public DataTable LayDuLieu()
        {
            return db.LayDuLieu("select * from LoadPhanDoan");
        }
        public bool KiemTraDuDieu(string macb, int stt)
        {
            return db.KiemTraDuLieu("select * from PhanDoan where MaChuyenBay = '" + macb + "' and STT =" + stt);
        }
        public void ThemPhanDoan(string macb, int stt, string sohieu, string tenloaimb, 
            string masbdi, TimeSpan giodi, DateTime ngaydi, string masbden, TimeSpan gioden, DateTime ngayden)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("InsertPhanDoan", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = macb;
            cmd.Parameters.Add("@STT", SqlDbType.Int).Value = stt;
            cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = sohieu;
            cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = tenloaimb;
            cmd.Parameters.Add("@MaSanBayDi", SqlDbType.VarChar).Value = masbdi;
            cmd.Parameters.Add("@GioDi", SqlDbType.Time).Value = giodi;
            cmd.Parameters.Add("@NgayDi", SqlDbType.Date).Value = ngaydi;
            cmd.Parameters.Add("@MaSanBayDen", SqlDbType.VarChar).Value = masbden;
            cmd.Parameters.Add("@GioDen", SqlDbType.Time).Value = gioden;
            cmd.Parameters.Add("@NgayDen", SqlDbType.Date).Value = ngayden;
            try {
                cmd.ExecuteNonQuery();
            }
            catch(SqlException e) { MessageBox.Show(e.Message); }

            db.closeConnection();
        }

        public void ThayDoiThongTin(string macb, int stt, string sohieu, string tenloaimb,
            string masbdi, TimeSpan giodi, DateTime ngaydi, string masbden, TimeSpan gioden, DateTime ngayden)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("UpdatePhanDoan", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = macb;
            cmd.Parameters.Add("@STT", SqlDbType.Int).Value = stt;
            cmd.Parameters.Add("@SoHieu", SqlDbType.VarChar).Value = sohieu;
            cmd.Parameters.Add("@TenLoaiMayBay", SqlDbType.NVarChar).Value = tenloaimb;
            cmd.Parameters.Add("@MaSanBayDi", SqlDbType.VarChar).Value = masbdi;
            cmd.Parameters.Add("@GioDi", SqlDbType.Time).Value = giodi;
            cmd.Parameters.Add("@NgayDi", SqlDbType.Date).Value = ngaydi;
            cmd.Parameters.Add("@MaSanBayDen", SqlDbType.VarChar).Value = masbden;
            cmd.Parameters.Add("@GioDen", SqlDbType.Time).Value = gioden;
            cmd.Parameters.Add("@NgayDen", SqlDbType.Date).Value = ngayden;
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thay đổi thành công!");
            else
                MessageBox.Show("Thay đổi thất bại");
            db.closeConnection();
        }

        public void XoaPhanDoan(string MaChuyenBay, int stt)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("DeletePhanDoan", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = MaChuyenBay;
            cmd.Parameters.Add("@STT", SqlDbType.Int).Value = stt;
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa thất bại");

            db.closeConnection();
        }
        public DataTable getLoaiMayBay()
        {
            return db.LayDuLieu("SELECT TenLoaiMayBay FROM LoaiMayBay");
        }

        public DataTable getSanBay()
        {
            return db.LayDuLieu("SElECT MaSanBay FROM SanBay");
        }
        public DataTable getSoHieuTheoLoaiMB(string tenloaimb)
        {
            return db.LayDuLieu("SELECT SoHieu FROM MayBay WhERE TenLoaiMayBay = N'" + tenloaimb + "'");
        }
        public string CongTySanXuat(string tenloai)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT dbo.[TenCongTySanXuatMayBay](@TenLoaiMayBay)", db.getConnection);
            cmd.Parameters.AddWithValue("@TenLoaiMayBay", tenloai);
            object result = cmd.ExecuteScalar();
            return (string)result;
        }

    }
}
