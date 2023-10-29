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
    public partial class FormQuanLyChuyenBay : Form
    {
        public FormQuanLyChuyenBay()
        {
            InitializeComponent();
        }

        private void FormQuanLyChuyenBay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBMS_DataSet.ChuyenBay' table. You can move, or remove it, as needed.
            this.chuyenBayTableAdapter.Fill(this.dBMS_DataSet.ChuyenBay);

        }
    }
}
