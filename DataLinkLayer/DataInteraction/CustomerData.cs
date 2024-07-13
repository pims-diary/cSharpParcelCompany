using parcelCompany.DataLinkLayer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using parcelCompany.Resources;

namespace parcelCompany.DataLinkLayer.DataInteraction
{
    internal class CustomerData : BaseData
    {

        public void CreateCustomer(CustomerDetails customer)
        {
            string insertCommandString = "INSERT INTO CustomerInfo (" +
                "CustomerID, CustomerName, CustomerAddress, CustomerEmail, CustomerMobile) " +
                "VALUES(@CustomerID, @CustomerName, @CustomerAddress, @CustomerEmail, @CustomerMobile)";
            SqlCommand cmd = new SqlCommand(insertCommandString, conn);
            cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerId);
            cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
            cmd.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
            cmd.Parameters.AddWithValue("@CustomerEmail", customer.CustomerEmail);
            cmd.Parameters.AddWithValue("@CustomerMobile", customer.CustomerPhone);
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateCustomer(Dictionary<string, object> customerInfo, string trackId)
        {
            string updatedParams = "";
            if (customerInfo != null)
            {
                foreach (KeyValuePair<string, object> info in customerInfo)
                {
                    updatedParams += " " + info.Key + "=@" + info.Key + ",";
                }
                updatedParams = updatedParams.Remove(updatedParams.Length - 1);

                string query = "UPDATE customerInfo SET" + updatedParams + " WHERE CustomerID=@CustomerID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CustomerID", trackId);

                foreach (KeyValuePair<string, object> info in customerInfo)
                {
                    cmd.Parameters.AddWithValue("@" + info.Key, info.Value);
                }

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
