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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"../../Assets/bgtrangchu.jpg");
            this.BackgroundImage = myimage;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
