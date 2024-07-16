using parcelCompany.Controllers;
using parcelCompany.DataLinkLayer.DataInteraction;
using parcelCompany.DataLinkLayer.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace parcelCompany.UserInterfaceLayer
{
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void addbttn_Click(object sender, EventArgs e)
        {
            if (UiUtility.isEmpty(customerNameTextBox.Text, "Customer Name"))
            {
                return;
            }
            if (UiUtility.isEmpty(customerAddressTextBox.Text, "Customer Address"))
            {
                return;
            }
            if (UiUtility.isEmpty(customerEmailTextBox.Text, "Customer Email"))
            {
                return;
            }
            if (UiUtility.isEmpty(customerMobileTextBox.Text, "Customer Mobile"))
            {
                return;
            }
            
            CustomerDetails customer = new CustomerDetails();
            CustomerController controller = new CustomerController();

            customer.CustomerId = controller.generateCustomerId();

            customer.CustomerName = customerNameTextBox.Text;
            customer.CustomerAddress = customerAddressTextBox.Text;
            customer.CustomerEmail = customerEmailTextBox.Text;
            customer.CustomerPhone = customerMobileTextBox.Text;

            CustomerData operation1 = new CustomerData();

            operation1.CreateACustomer(customer);
            UiUtility.showSucces(Resources.Messages.CreateCustomerSuccessBody + customer.CustomerId, "Success!");

            CustomerData operation2 = new CustomerData();

            SqlDataAdapter data = operation2.searchCustomer(customer.CustomerId);
            UiUtility.populateDataGrid(data, dataGridView1);
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
    }
}
