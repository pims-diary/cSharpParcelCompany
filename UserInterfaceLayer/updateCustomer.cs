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

namespace parcelCompany.UserInterfaceLayer
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void clearbttn_Click(object sender, EventArgs e)
        {
            UiUtility.clearAllFields((ControlCollection)this.Controls);
        }

        private void updatebttn_Click(object sender, EventArgs e)
        {
            if (UiUtility.isEmpty(customerIdTextBox.Text, "Customer ID"))
            {
                return;
            }

            Dictionary<string, string> data = new Dictionary<string, string>();

            if (!UiUtility.isTextBoxEmpty(customerNameTextBox))
            {
                data.Add(Resources.CustomerConstants.CustomerName, customerNameTextBox.Text);
            }
            if (!UiUtility.isTextBoxEmpty(customerAddressTextBox))
            {
                data.Add(Resources.CustomerConstants.CustomerAddress, customerAddressTextBox.Text);
            }
            if (!UiUtility.isTextBoxEmpty(customerEmailTextBox))
            {
                data.Add(Resources.CustomerConstants.CustomerEmail, customerEmailTextBox.Text);
            }
            if (!UiUtility.isTextBoxEmpty(customerMobileTextBox))
            {
                data.Add(Resources.CustomerConstants.CustomerMobile, customerMobileTextBox.Text);
            }

            if (data.Count == 0)
            {
                UiUtility.showError("Atleast one of the fields from Customer Name, Address, Email and Mobile needs to be filled", "Error");
                return;
            }

            CustomerData operation1 = new CustomerData();
            operation1.UpdateCustomer(data, customerIdTextBox.Text);

            UiUtility.showSucces("The customer with ID " + customerIdTextBox.Text + " has been updated.", "Update Successful!");

            CustomerData operation2 = new CustomerData();
            SqlDataAdapter adapter = operation2.searchCustomer(customerIdTextBox.Text);
            UiUtility.populateDataGrid(adapter, dataGridView1);

            UiUtility.clearAllFields((ControlCollection)this.Controls);
        }

        private void backbttn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
