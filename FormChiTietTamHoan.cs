using DBMS_Project.ConnectDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project.BL
{
    public partial class FormChiTietTamHoan : Form
    {
        BL_QuanLyTamHoan bl = new BL_QuanLyTamHoan();
        public FormChiTietTamHoan()
        {
            InitializeComponent();
        }

        private void FormChiTietTamHoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DataTable dataTable = bl.ChiTiet();
            dgv_chuyenbay.DataSource = dataTable;
            dgv_chuyenbay.AutoResizeColumns();
        }
    }
}
