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

        SqlConnection conn = new SqlConnection(@"Data Source=20220661-Priyanka;Initial Catalog=PracelCompany_assign1_20220661;Integrated Security=True");

        private void loginbttn_Click(object sender, EventArgs e)
        {
            string user_name, user_password;

            user_name = username.Text;
            user_password = password.Text;

            try
            {
                string querry = "select * from Login where Username = '" + username.Text + "' and Password = '" + password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    user_name = username.Text;
                    user_password = password.Text;

                    //page that needs to be loaded

                    Dashborad form3 = new Dashborad();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user credentails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Clear();
                    password.Clear();

                    username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
