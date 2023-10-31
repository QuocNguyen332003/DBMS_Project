using DBMS_Project.BL;
using DBMS_Project.ConnectDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class FormThamGia : Form
    {
        DB_QuanLyChuyenBay db = new DB_QuanLyChuyenBay();
        public FormThamGia()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dataTable = db.LayDuLieu("select * from LayThamGia");
            dgv_thamgia.DataSource = dataTable;
        }



        private void FormThamGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBMS_DataSet.ThamGia' table. You can move, or remove it, as needed.
            LoadData();
        }
    }
}
