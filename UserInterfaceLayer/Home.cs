using parcelCompany.UserInterfaceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcelCompany
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void staffbttn_Click(object sender, EventArgs e)
        {
            loginPageStaff loginPage = new loginPageStaff();
            loginPage.Show();
            this.Hide();
        }

        private void customerbttn_Click(object sender, EventArgs e)
        {
            ViewParcel viewParcelPage = new ViewParcel(Root.Home, "");
            viewParcelPage.Show();
            this.Hide();
        }
    }
}
