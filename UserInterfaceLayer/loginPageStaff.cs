using parcelCompany.DataLinkLayer.DataInteraction;
using parcelCompany.UserInterfaceLayer;
using System;
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

            // Login validation happens below.
            // The result of Login validation is storred in the form of Enum
            LoginStatus status = userData.ValidateLogin(username.Text, password.Text);

            if (status == LoginStatus.Success)
            {
                // Navigate to Dashboard page for successful login
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else if (status == LoginStatus.Failure)
            {
                UiUtility.showError("Invalid user credentails", "Error");
                username.Clear();
                password.Clear();

                username.Focus();
            }
            else if(status == LoginStatus.ServerError)
            {
                UiUtility.showError("Something went wrong", "Error");
            }
        }
    }
}
