using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;

namespace DBMS_Project.ConnectDataBase
{
    internal class connectDataBase
    {
        ~connectDataBase() { }

        string ConnStr = "Data Source=ADMIN\\BAOQUOC;Initial Catalog=QuanLyChuyenBay;Integrated Security=True";
        SqlConnection conn = null;
        public connectDataBase()
        {
            conn = new SqlConnection(ConnStr);

        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public SqlConnection getConnection()
        {
            return conn;
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public bool MyExecuteNonQuery(SqlCommand comm, connectDataBase conn, ref string error)
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

        public DataTable ExecuteQueryDataTable(SqlCommand comm, connectDataBase connect)
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
    }
}
