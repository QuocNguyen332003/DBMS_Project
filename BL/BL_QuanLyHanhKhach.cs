using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DBMS_Project.ConnectDataBase;

namespace DBMS_Project.BL
{
    internal class BL_QuanLyHanhKhach
    {
        DB_QuanLyChuyenBay connect = new DB_QuanLyChuyenBay();

        public BL_QuanLyHanhKhach()
        {
        }

        ~BL_QuanLyHanhKhach() { }

        public DataTable LayDuLieu()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.CommandText = "select * from LayThongTinHanhKhach";
                comm.Connection = connect.getConnection;
                DataTable ds = new DataTable();
                ds = connect.ExecuteQueryDataTable(comm, connect);
                return ds;
            }
        }

        public bool ThemHanhKhach(string MaHK, string HoTen, string CCCD, string SDT, ref string error)
        {
            bool b = false;
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = "ThemHanhKhach";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect.getConnection;
                command.Parameters.AddWithValue("@MaHK", MaHK);
                command.Parameters.AddWithValue("@HoTen", HoTen);
                command.Parameters.AddWithValue("@CCCD", CCCD);
                command.Parameters.AddWithValue("@SDT", SDT);
                b = connect.MyExecuteNonQuery(command, connect, ref error);
            }
            return b;
        }

        public bool SuaHanhKhach(string MaHK, string HoTen, string CCCD, string SDT, ref string error)
        {
            bool b = false;
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = "SuaHanhKhach";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect.getConnection;
                command.Parameters.AddWithValue("@MaHK", MaHK);
                command.Parameters.AddWithValue("@HoTen", HoTen);
                command.Parameters.AddWithValue("@CCCD", CCCD);
                command.Parameters.AddWithValue("@SDT", SDT);
                b = connect.MyExecuteNonQuery(command, connect, ref error);
            }
            return b;
        }

        public bool XoaHanhKhach(string MaHK, ref string error)
        {
            bool b = false;
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = "XoaHanhKhach";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect.getConnection;
                command.Parameters.AddWithValue("@MaHK", MaHK);
                b = connect.MyExecuteNonQuery(command, connect, ref error);
            }
            return b;
        }

        public DataTable TimHanhKhachTheoCCCD(string CCCD)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.CommandText = "SELECT * FROM dbo.TimHanhKhachTheoCCCD(@CCCD)";
                comm.Parameters.AddWithValue("@CCCD", CCCD);
                comm.CommandType = CommandType.Text;
                comm.Connection = connect.getConnection;
                DataTable ds = new DataTable();
                ds = connect.ExecuteQueryDataTable(comm, connect);
                return ds;
            }
        }

        public DataTable TimHanhKhachTheoMaHK(string MaHK)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.CommandText = "SELECT * FROM dbo.TimHanhKhachTheoMaHK(@MaHK)";
                comm.Parameters.AddWithValue("@MaHK", MaHK);
                comm.CommandType = CommandType.Text;
                comm.Connection = connect.getConnection;
                DataTable ds = new DataTable();
                ds = connect.ExecuteQueryDataTable(comm, connect);
                return ds;
            }
        }

        public DataTable TimHanhKhachTheoHoTen(string HoTen)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.CommandText = "SELECT * FROM dbo.TimHanhKhachTheoHoTen(@HoTen)";
                comm.Parameters.AddWithValue("@HoTen", HoTen);
                comm.CommandType = CommandType.Text;
                comm.Connection = connect.getConnection;
                DataTable ds = new DataTable();
                ds = connect.ExecuteQueryDataTable(comm, connect);
                return ds;
            }
        }

        public DataTable TimHanhKhachTheoSDT(string SDT)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.CommandText = "SELECT * FROM dbo.TimHanhKhachTheoSDT(@SDT)";
                comm.Parameters.AddWithValue("@SDT", SDT);
                comm.CommandType = CommandType.Text;
                comm.Connection = connect.getConnection;
                DataTable ds = new DataTable();
                ds = connect.ExecuteQueryDataTable(comm, connect);
                return ds;
            }
        }

        public DataTable TimHanhKhachTheoHoTenVaSDT(string HoTen, string SDT)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.CommandText = "SELECT * FROM dbo.TimHanhKhachTheoHoTenVaSDT(@HoTen,@SDT)";
                comm.Parameters.AddWithValue("@Hoten", HoTen);
                comm.Parameters.AddWithValue("@SDT", SDT);
                comm.CommandType = CommandType.Text;
                comm.Connection = connect.getConnection;
                DataTable ds = new DataTable();
                ds = connect.ExecuteQueryDataTable(comm, connect);
                return ds;
            }
        }
    }
}
