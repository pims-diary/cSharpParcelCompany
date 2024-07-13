using parcelCompany.DataLinkLayer.DataInteraction;
using parcelCompany.DataLinkLayer.Models;
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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            // createCustomer();
            // updateParcel();
        }

        public void createCustomer()
        {
            CustomerDetails customer = new CustomerDetails();
            customer.CustomerId = "1002";
            customer.CustomerName = "John";
            customer.CustomerEmail = "john@gmail.com";
            customer.CustomerAddress = "SilverDale";
            customer.CustomerPhone = "021345678";

            CustomerData customerData = new CustomerData();
            customerData.CreateCustomer(customer);
        }

        public void updateParcel() 
        {
            Dictionary<string, object> customerInfo = new Dictionary<string, object>();

            customerInfo.Add(Resources.CustomerConstants.CustomerName, "Dom");
            customerInfo.Add(Resources.CustomerConstants.CustomerAddress, "Kemeu");

            CustomerData customerData = new CustomerData();
            customerData.UpdateCustomer(customerInfo, "1002");
        }
    }
}
