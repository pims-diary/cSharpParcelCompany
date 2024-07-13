using parcelCompany.DataLinkLayer.DataInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcelCompany
{
    public partial class loginPageStaff : Form
    {
        public loginPageStaff()
        {
            InitializeComponent();
        }

        private void loginbttn_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData();

            LoginStatus status = userData.ValidateLogin(username.Text, password.Text);

            if (status == LoginStatus.Success)
            {
                //page that needs to be loaded
                dashboard form2 = new dashboard();
                form2.Show();
                this.Hide();
            }
            else if (status == LoginStatus.Failure)
            {
                MessageBox.Show("Invalid user credentails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Clear();
                password.Clear();

                username.Focus();

            }
            else if(status == LoginStatus.ServerError)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
