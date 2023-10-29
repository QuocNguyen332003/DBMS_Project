using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.DB_layer
{
    internal class DB_QuanLyChuyenBay
    {
        string ConnStr = "Data Source=LAPTOP-MEAMVPHN\\SQLSERVER;Initial Catalog=QuanLyInternet;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DB_QuanLyChuyenBay()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();

        }
        public DataSet LayDuLieu(string strSQL)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
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
            if (reader.HasRows) return true;
            else return false;
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
