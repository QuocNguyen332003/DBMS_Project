using DBMS_Project.ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace DBMS_Project.BL
{
    internal class BL_TaiKhoan
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        public BL_TaiKhoan() { }
        public bool KiemTraTaiKhoan(string username, string password)
        {
            db.openConnectionAdmin();
            SqlCommand cmd_new = new SqlCommand("SELECT dbo.LayLoaiTaiKhoan(@username, @password)", db.getConnectionAdmin);
            cmd_new.Parameters.AddWithValue("@username", username);
            cmd_new.Parameters.AddWithValue("@password", password);
            string loai = (string)cmd_new.ExecuteScalar();
            db.closeConnectionAdmin();
            if (KiemTraUser(username)) {
                BienToanCuc.isadmin = loai == "admin"? true: false;
                BienToanCuc.username = username;
                BienToanCuc.password = password;
                return true;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa đúng!!!");
                return false;
            }
            
        }
        public bool KiemTraUser(string username)
        {
            SqlCommand commadmin = db.getConnectionAdmin.CreateCommand();
            if (db.getConnectionAdmin.State == ConnectionState.Open)
                db.getConnectionAdmin.Close();
            db.getConnectionAdmin.Open();
            string sql = "select * from TaiKhoan where username = '" + username + "'";
            commadmin.CommandText = sql;
            SqlDataReader reader = commadmin.ExecuteReader();
            if (reader.HasRows) { reader.Close(); return true; }
            else { reader.Close(); return false; }
        }
        public DataTable LoadTaiKhoan()
        {
            return db.LayDuLieu("SELECT * FROM LoadTaiKhoan");
        }
        public void ThemTaiKhoan(string username, string password, string Loai)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("InsertTaiKhoan", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@Loai", SqlDbType.NVarChar).Value = Loai;

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Thêm thành công!");
            else
                MessageBox.Show("Thêm thất bại");
            db.closeConnection();
        }
        public void XoaTaiKhoan(string username)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("DeleteTaiKhoan", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            cmd.ExecuteNonQuery();
            
            db.closeConnection();
        }
    }
}
