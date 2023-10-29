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
    public partial class FormQLNhanSu : Form
    {
        public FormQLNhanSu()
        {
            InitializeComponent();
        }

        private void FormQLNhanSu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBMS_DataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dBMS_DataSet.NhanVien);

        }
    }
}
