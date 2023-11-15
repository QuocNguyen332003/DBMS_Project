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
    internal class BL_TaiKhoan
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        public BL_TaiKhoan() { }
        public bool KiemTraTaiKhoan(string username, string password)
        {
            db.openConnection();            
            SqlCommand cmd_new = new SqlCommand("SELECT dbo.LayLoaiTaiKhoan(@username, @password)", db.getConnection);
            cmd_new.Parameters.AddWithValue("@username", username);
            cmd_new.Parameters.AddWithValue("@password", password);
            string loai = (string)cmd_new.ExecuteScalar();
            db.closeConnection();
            if (loai == "admin") { 
                BienToanCuc.isadmin = true;
                BienToanCuc.username = "admin_QL";
                BienToanCuc.password = "admin";
                DB_QuanLyChuyenBay.ConnStr = @"Data Source=LAPTOP-MEAMVPHN\SQLSERVER;Initial Catalog=QuanLyChuyenBay;User Id=" + BienToanCuc.username + ";Password=" + BienToanCuc.password + ";";

                return true;
            }
            else if (loai == "user")
            {
                BienToanCuc.isadmin = false;
                BienToanCuc.username = "NguoiXem";
                BienToanCuc.password = "nguoixem";
                DB_QuanLyChuyenBay.ConnStr = @"Data Source=LAPTOP-MEAMVPHN\SQLSERVER;Initial Catalog=QuanLyChuyenBay;User Id=" + BienToanCuc.username + ";Password=" + BienToanCuc.password + ";";

                return true;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa đúng!!!");
                return false;
            }
            
        }
    }
}
