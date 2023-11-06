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
    internal class BL_QuanLyNhanSu
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        public DataTable LayDuLieu()
        {
            return db.LayDuLieu("select * from  LoadNhanVien");
        }
        public DataTable GetNhanVien()
        {
            return db.LayDuLieu("select DISTINCT MaNV from LoadNhanVien");
        }
        public bool KiemTraDuDieu(string id)
        {
            return db.KiemTraDuLieu("select * from NhanVien where MaNV = '" + id + "'");
        }
        public DataTable HoSoBay_NV()
        {
            return db.LayDuLieu("select * from HoSoBay_NV");
        }
        public DataTable ThongKe()
        {
            return db.LayDuLieu("select * from ThongKe");
        }
        
        public void ThemNhanSu(string id_emp, string name, string gender, string address, DateTime born, 
            string phone, string id_work, DateTime tuyendung, string hesoluong)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("InsertNhanVien", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = id_emp;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gender;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = born;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = id_work;
            cmd.Parameters.Add("@NgayTuyenDung", SqlDbType.Date).Value = tuyendung;
            cmd.Parameters.Add("@HeSoLuong", SqlDbType.Float).Value = Convert.ToDouble(hesoluong);
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thêm thành công!");
            else
                MessageBox.Show("Thêm thất bại");
            db.closeConnection();
        }
        public void UpdateNhanSu(string id_emp, string name, string gender, string address, DateTime born,
            string phone, string id_work, DateTime tuyendung, string hesoluong)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("UpdateNhanVien", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = id_emp;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gender;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = born;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = id_work;
            cmd.Parameters.Add("@NgayTuyenDung", SqlDbType.Date).Value = tuyendung;
            cmd.Parameters.Add("@HeSoLuong", SqlDbType.Float).Value = Convert.ToDouble(hesoluong);
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thay đổi thành công!");
            else
                MessageBox.Show("Thay đổi thất bại");
            db.closeConnection();
        }

        public void XoaNhanVien(string id)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("DeleteNhanVien", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = id;
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa thất bại");

            db.closeConnection();
        }
        public DataTable TimNhanVien(string id)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from SearchNhanVien(@MaNV)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaNV", id);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();
            if (data.Rows.Count > 0)
            {
                db.closeConnection();
                return data;
            }
            db.closeConnection();
            return null;
        }
        public DataTable TinhLuong(string id)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT dbo.TinhLuong(@MaNV)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaNV", SqlDbType.Char).Value = id;
            object result = cmd.ExecuteScalar();
            double LuongNV = (double)result;
            string LuongNVString = LuongNV.ToString();
            MessageBox.Show("Lương của nhân viên có Mã Nhân Viên là " + id + "là: " + LuongNVString + " VNĐ");
            db.closeConnection();
            return null;
        }

    }
}
