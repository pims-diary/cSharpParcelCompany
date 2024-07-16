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
    public partial class SearchCustomer : Form
    {
        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            CustomerData customerData = new CustomerData();
            SqlDataAdapter data = customerData.searchCustomer(customerIdTextBox.Text);
            UiUtility.populateDataGrid(data, customerDataGridView);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerDataGridView.DataSource = null;
            customerDataGridView.Refresh();
            customerIdTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
