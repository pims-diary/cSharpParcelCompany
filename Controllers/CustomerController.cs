using parcelCompany.DataLinkLayer.DataInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcelCompany.Controllers
{
    internal class CustomerController
    {
        public string generateCustomerId()
        {
            CustomerData customerData = new CustomerData();
            string lastCustomerId = customerData.GetLastCustomerId();
            int newCustomerId = int.Parse(lastCustomerId) + 1;
            return newCustomerId.ToString();
        }
    }
}
