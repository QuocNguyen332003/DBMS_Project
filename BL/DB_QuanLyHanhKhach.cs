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
    internal class DB_QuanLyHanhKhach
    {
        ~DB_QuanLyHanhKhach() { }

        DB_QuanLyChuyenBay connect = new DB_QuanLyChuyenBay();

        public DB_QuanLyHanhKhach()
        {
        }

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

        public bool ThemHanhKhach(string MaHK, string CCCD, string SDT, ref string error)
        {
            bool b = false;
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = "ThemHanhKhach";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect.getConnection;
                command.Parameters.AddWithValue("@MaHK", MaHK);
                command.Parameters.AddWithValue("@CCCD", CCCD);
                command.Parameters.AddWithValue("@SDT", SDT);
                b = connect.MyExecuteNonQuery(command, connect, ref error);
            }
            return b;
        }

        public bool SuaHanhKhach(string MaHK, string CCCD, string SDT, ref string error)
        {
            bool b = false;
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = "SuaHanhKhach";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect.getConnection;
                command.Parameters.AddWithValue("@MaHK", MaHK);
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

        public DataTable TimHanhKhach(string CCCD)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.CommandText = "SELECT * FROM dbo.TimHanhKhach(@CCCD)";
                comm.Parameters.AddWithValue("@CCCD", CCCD);
                comm.CommandType = CommandType.Text;
                comm.Connection = connect.getConnection;
                DataTable ds = new DataTable();
                ds = connect.ExecuteQueryDataTable(comm, connect);
                return ds;
            }
        }
    }
}
