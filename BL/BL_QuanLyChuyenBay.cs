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
    internal class BL_QuanLyChuyenBay
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();

        public BL_QuanLyChuyenBay()
        {
        }

        public DataTable LayDuLieu()
        {
            return db.LayDuLieu("select * from LoadChuyenBay"); 
        }
        public bool KiemTraDuDieu(string macb)
        {
            return db.KiemTraDuLieu("select * from ChuyenBay where MaChuyenBay = '" + macb + "'");
        }
        public void ThemChuyenBay(string macb, string tinhtrang, TimeSpan giodi, DateTime ngaydi, TimeSpan gioden, DateTime ngayden)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("InsertChuyenBay", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = macb;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tinhtrang;
            cmd.Parameters.Add("@GioDi", SqlDbType.Time).Value = giodi;
            cmd.Parameters.Add("@NgayDi", SqlDbType.Date).Value = ngaydi.ToShortDateString();
            cmd.Parameters.Add("@GioDen", SqlDbType.Time).Value = gioden;
            cmd.Parameters.Add("@NgayDen", SqlDbType.Date).Value = ngayden.ToShortDateString();

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thêm thành công!");
            else
                MessageBox.Show("Thêm thất bại");
            db.closeConnection();
        }

        public void ThayDoiThongTin(string macb, string tinhtrang, TimeSpan giodi, DateTime ngaydi, TimeSpan gioden, DateTime ngayden)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("UpdateChuyenBay", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = macb;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tinhtrang;
            cmd.Parameters.Add("@GioDi", SqlDbType.Time).Value = giodi;
            cmd.Parameters.Add("@NgayDi", SqlDbType.Date).Value = ngaydi.ToShortDateString();
            cmd.Parameters.Add("@GioDen", SqlDbType.Time).Value = gioden;
            cmd.Parameters.Add("@NgayDen", SqlDbType.Date).Value = ngayden.ToShortDateString();

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thay đổi thành công!");
            else
                MessageBox.Show("Thay đổi thất bại");
            db.closeConnection();
        }

        public void XoaChuyenBay(string MaChuyenBay)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("DeleteChuyenBay", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCB", SqlDbType.VarChar).Value = MaChuyenBay;
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa thất bại");
            db.closeConnection();
        }

        public DataTable TimChuyenBay(string macb,int numcb, string tinhtrang,int numtt,
            string giodi,int numgiodi, string ngaydi,int numngaydi, string gioden, int numgioden, string ngayden, int numngayden)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from SearchChuyenBay(@MaCB, @numMaCB, @TT ,@numTT, @GioDi, @numGioDi, @NgayDi, @numNgayDi,@GioDen, @numGioDen, @NgayDen, @numNgayDen)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaCB", macb);
            cmd.Parameters.AddWithValue("@numMaCB", numcb);
            cmd.Parameters.AddWithValue("@TT", tinhtrang);
            cmd.Parameters.AddWithValue("@numTT", numtt);
            cmd.Parameters.AddWithValue("@GioDi", giodi);
            cmd.Parameters.AddWithValue("@numGioDi", numgiodi);
            cmd.Parameters.AddWithValue("@NgayDi", ngaydi);
            cmd.Parameters.AddWithValue("@numNgayDi", numngaydi);
            cmd.Parameters.AddWithValue("@GioDen", gioden);
            cmd.Parameters.AddWithValue("@numGioDen", numgioden);
            cmd.Parameters.AddWithValue("@NgayDen", ngayden);
            cmd.Parameters.AddWithValue("@numNgayDen", numngayden);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();
            if (data.Rows.Count > 0)
            {
                db.closeConnection();
                return data;
            }
            MessageBox.Show("Không tồn tại chuyến bay!");
            db.closeConnection();
            return null;
        }
        public DataTable get1Col(string namecol)
        {
            string sql = "select DISTINCT " + namecol + " from LoadChuyenBay";
            return db.LayDuLieu(sql);
        }
        public int SoLuongChuyenBayTheoNgay(DateTime ngaydi)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT dbo.SoLuongChuyenBay(@ngaydi)", db.getConnection);
            cmd.Parameters.AddWithValue("@ngaydi", ngaydi.ToShortDateString());
            object result = cmd.ExecuteScalar();
            return (int)result;
        }
    }
}
