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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            Image myimage = new Bitmap(@"../../Assets/background.jpg");
            this.BackgroundImage = myimage;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
