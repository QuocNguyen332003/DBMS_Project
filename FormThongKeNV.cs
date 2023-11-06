using DBMS_Project.BL;
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

namespace DBMS_Project
{
    public partial class FormThongKeNV : Form
    {
        BL_QuanLyNhanSu bl = new BL_QuanLyNhanSu();
        public FormThongKeNV()
        {
            InitializeComponent();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            if(cbb_thongke.Text == "Xem lịch sử tham gia chuyến bay của nhân viên")
            {
                DataTable dataTable = bl.HoSoBay_NV();
                dgv_thongke.DataSource = dataTable;
            }
            if(cbb_thongke.Text == "Xem bảng thống kê số giờ bay và lương của nhân viên")
            {
                DataTable dataTable = bl.ThongKe();
                dgv_thongke.DataSource = dataTable;
            }
        }
    }
}
