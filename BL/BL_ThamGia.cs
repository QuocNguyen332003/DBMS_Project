using DBMS_Project.ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project.BL
{
    internal class BL_ThamGia
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        public DataTable LayDuLieu()
        {
            return db.LayDuLieu("select * from  LoadThamGia");
        }
        public DataTable GetPhanDoan_id()
        {
            return db.LayDuLieu("select DISTINCT MaChuyenBay from LoadPhanDoan");
        }
        public DataTable GetPhanDoan_stt()
        {
            return db.LayDuLieu("select DISTINCT STT from LoadPhanDoan");
        }
        public DataTable GetCongViec()
        {
            return db.LayDuLieu("select DISTINCT TenCV from LoadCongViec");
        }
        public void XoaThamGia(string id_chuyenbay, string stt, string id_nhanvien)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("DeleteThamGia", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaChuyenBay", SqlDbType.VarChar).Value = id_chuyenbay;
            cmd.Parameters.Add("@STT", SqlDbType.Int).Value = Convert.ToInt32(stt);
            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = id_nhanvien;
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa thất bại");

            db.closeConnection();
        }
        public bool KiemTraDuLieu(string id_chuyenbay, string stt, string id_nhanvien)
        {
            return db.KiemTraDuLieu("select * from ThamGia where MaChuyenBay = '" + id_chuyenbay + "' and STT =  '" + Convert.ToInt32(stt) + "' and MaNV = '" + id_nhanvien + "'");         
        }
        public void ThemThamGia(string id_chuyenbay, string stt, string id_nhanvien, string sogiobay, string vaitro)
        {

            db.openConnection();
            SqlCommand cmd = new SqlCommand("AddThamGia", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaChuyenBay", SqlDbType.VarChar).Value = id_chuyenbay;
            cmd.Parameters.Add("@STT", SqlDbType.Int).Value = Convert.ToInt32(stt);
            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = id_nhanvien;
            cmd.Parameters.Add("@SoGioBay", SqlDbType.Int).Value = Convert.ToInt32(sogiobay);
            cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar).Value = vaitro;
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thêm thành công!");
            else
                MessageBox.Show("Thêm thất bại");
            db.closeConnection();
        }
        public void SuaThamGia(string id_chuyenbay, string stt, string id_nhanvien, string sogiobay, string vaitro)
        {

            db.openConnection();
            SqlCommand cmd = new SqlCommand("UpdateThamGia", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaChuyenBay", SqlDbType.VarChar).Value = id_chuyenbay;
            cmd.Parameters.Add("@STT", SqlDbType.Int).Value = Convert.ToInt32(stt);
            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = id_nhanvien;
            cmd.Parameters.Add("@SoGioBay", SqlDbType.Int).Value = Convert.ToInt32(sogiobay);
            cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar).Value = vaitro;
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thay đổi thành công!");
            else
                MessageBox.Show("Thay đổi thất bại");
            db.closeConnection();
        }
        public DataTable TimThamGia(string MaCB, int numMaCB, string STT, int numSTT, string MaNV, int numIDNhanVien, string SoGioBay, int numSoGioBay, string VaiTro, int numVaiTro)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from SearchThamGia(@MaCB, @numMaCB, @STT ,@numSTT, @MaNV, @numIDNhanVien, @SoGioBay, @numSoGioBay,@VaiTro, @numVaiTro)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaCB", MaCB);
            cmd.Parameters.AddWithValue("@numMaCB", numMaCB);
            cmd.Parameters.AddWithValue("@STT", STT);
            cmd.Parameters.AddWithValue("@numSTT", numSTT);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.Parameters.AddWithValue("@numIDNhanVien", numIDNhanVien);
            cmd.Parameters.AddWithValue("@SoGioBay", SoGioBay);
            cmd.Parameters.AddWithValue("@numSoGioBay", numSoGioBay);
            cmd.Parameters.AddWithValue("@VaiTro", VaiTro);
            cmd.Parameters.AddWithValue("@numVaiTro", numVaiTro);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();
            if (data.Rows.Count > 0)
            {
                db.closeConnection();
                return data;
            }
            else
            {
                MessageBox.Show("Không tồn tại chuyến bay!");
            }
            db.closeConnection();
            return null;
        }
    }
}
