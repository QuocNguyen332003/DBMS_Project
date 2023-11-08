using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DBMS_Project.ConnectDataBase;
using System.Runtime.Remoting.Contexts;

namespace DBMS_Project.BL
{
    internal class BL_QuanLyVe
    {
        DB_QuanLyChuyenBay connect = new DB_QuanLyChuyenBay();

        public BL_QuanLyVe()
        {
        }

        ~BL_QuanLyVe() { }

        public DataTable LayDuLieu()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.CommandText = "select * from LayThongTinVe";
                comm.Connection = connect.getConnection;
                DataTable ds = new DataTable();
                ds = connect.ExecuteQueryDataTable(comm, connect);
                return ds;
            }
        }

        public bool ThemVe(string MaVe, string MaHK, string MaCB, int GiaVe, int SoGhe, string TenLoaiKhoang, ref string error)
        {
            bool b = false;
            using (SqlCommand command = new SqlCommand()) 
            {
                command.CommandText = "ThemVe";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect.getConnection;
                command.Parameters.AddWithValue("@MaVe", MaVe);
                command.Parameters.AddWithValue("@MaHK", MaHK);
                command.Parameters.AddWithValue("@MaCB", MaCB);
                command.Parameters.AddWithValue("@GiaVe", GiaVe);
                command.Parameters.AddWithValue("@MaSoGhe", SoGhe);
                command.Parameters.AddWithValue("@TenLoaiKhoang", TenLoaiKhoang);
                b = connect.MyExecuteNonQuery(command, connect, ref error);
            }
            return b;
        }

        public bool SuaVe(string MaVe, string MaHK, string MaCB, int GiaVe, int SoGhe, string TenLoaiKhoang, ref string error)
        {
            bool b = false;
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = "SuaVe";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect.getConnection;
                command.Parameters.AddWithValue("@MaVe", MaVe);
                command.Parameters.AddWithValue("@MaHK", MaHK);
                command.Parameters.AddWithValue("@MaCB", MaCB);
                command.Parameters.AddWithValue("@GiaVe", GiaVe);
                command.Parameters.AddWithValue("@MaSoGhe", SoGhe);
                command.Parameters.AddWithValue("@TenLoaiKhoang", TenLoaiKhoang);
                b = connect.MyExecuteNonQuery(command, connect, ref error);
            }
            return b;
        }

        public bool XoaVe(string MaVe, ref string error)
        {
            bool b = false;
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = "XoaVe";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect.getConnection;
                command.Parameters.AddWithValue("@MaVe", MaVe);
                b = connect.MyExecuteNonQuery(command, connect, ref error);
            }
            return b;
        }

        public DataTable ThongKeVe()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.CommandText = "SELECT * FROM dbo.ThongKeVe()";
                comm.CommandType = CommandType.Text;
                comm.Connection = connect.getConnection;
                DataTable ds = new DataTable();
                ds = connect.ExecuteQueryDataTable(comm, connect);
                return ds;
            }
        }
    }
}
