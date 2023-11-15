using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DBMS_Project.ConnectDataBase
{
    internal class DB_QuanLyChuyenBay
    {
        /*data source(Anh) = Anh
     data source(Hung) = LAPTOP-4U0DKBNK
     data source(Quoc) = ADMIN\BAOQUOC
     data source(Quan) = LAPTOP-MEAMVPHN\SQLSERVER     */
        //"Data Source=LAPTOP-MEAMVPHN\\SQLSERVER;Initial Catalog=QuanLyChuyenBay;Integrated Security=True" :
        public static string ConnStr = @"Data Source = LAPTOP-MEAMVPHN\SQLSERVER;Initial Catalog = QuanLyChuyenBay; Integrated Security = True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DB_QuanLyChuyenBay()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();

        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public bool MyExecuteNonQuery(SqlCommand comm, DB_QuanLyChuyenBay conn, ref string error)
        {
            bool f = false;
            conn.openConnection();
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.closeConnection();
            }
            return f;
        }

        public DataTable ExecuteQueryDataTable(SqlCommand comm, DB_QuanLyChuyenBay connect)
        {
            using (SqlDataAdapter da = new SqlDataAdapter(comm))
            {
                connect.openConnection();
                DataTable ds = new DataTable();
                da.Fill(ds);
                connect.closeConnection();
                return ds;

            }
        }
        public DataTable LayDuLieu(string strSQL)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            da = new SqlDataAdapter(comm);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        public bool KiemTraDuLieu(string strSQL)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows) { reader.Close(); return true; }
            else { reader.Close(); return false; }
        }
        public bool ChinhSuaDuLieu(string strSQL)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
