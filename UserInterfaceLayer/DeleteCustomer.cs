using parcelCompany.DataLinkLayer.DataInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcelCompany.UserInterfaceLayer
{
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void clearbttn_Click(object sender, EventArgs e)
        {
            UiUtility.clearAllFields((ControlCollection)this.Controls);
        }

        private void backbttn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void deletebttn_Click(object sender, EventArgs e)
        {
            if (UiUtility.isEmpty(customerIdTextBox.Text, "Customer ID"))
            {
                return;
            }

            CustomerData customerData = new CustomerData();
            if (!customerData.doesCustomerExist(customerIdTextBox.Text))
            {
                UiUtility.showError("This customer does not exist.", "Delete Failed!");
                return;
            }

            customerData.DeleteCustomer(customerIdTextBox.Text);

            UiUtility.showSucces("Customer with ID " + customerIdTextBox.Text + " has been deleted.", "Delete Successful!");
        }
    }
}
