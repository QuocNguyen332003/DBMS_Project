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
    public partial class FormQuanLyPhanDoan : Form
    {
        public FormQuanLyPhanDoan()
        {
            InitializeComponent();
        }

        private void FormQuanLyPhanDoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBMS_DataSet.PhanDoan' table. You can move, or remove it, as needed.
            this.phanDoanTableAdapter.Fill(this.dBMS_DataSet.PhanDoan);

        }
    }
}
