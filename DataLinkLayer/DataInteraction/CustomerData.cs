using parcelCompany.DataLinkLayer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace parcelCompany.DataLinkLayer.DataInteraction
{
    internal class CustomerData : BaseData
    {

        public void CreateACustomer(CustomerDetails customer)
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

        public void UpdateCustomer(Dictionary<string, string> customerInfo, string customerId)
        {
            string updatedParams = "";
            if (customerInfo != null)
            {
                foreach (KeyValuePair<string, string> info in customerInfo)
                {
                    updatedParams += " " + info.Key + "=@" + info.Key + ",";
                }
                updatedParams = updatedParams.Remove(updatedParams.Length - 1);

                string query = "UPDATE CustomerInfo SET" + updatedParams + " WHERE CustomerID=@CustomerID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                foreach (KeyValuePair<string, string> info in customerInfo)
                {
                    cmd.Parameters.AddWithValue("@" + info.Key, info.Value);
                }

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteCustomer(string customerId)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM CustomerInfo WHERE CustomerID=@CustomerID", conn);
            cmd.Parameters.AddWithValue("@CustomerID", customerId);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO CustomerInfo (CustomerID) VALUES(@CustomerID)", conn);
            cmd1.Parameters.AddWithValue("@CustomerID", customerId);
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        public string GetLastCustomerId()
        {
            SqlCommand cmd = new SqlCommand("SELECT CustomerID FROM CustomerInfo WHERE CustomerID=(SELECT max(CustomerID) FROM CustomerInfo)", conn);
            string customerId = cmd.ExecuteScalar().ToString();
            conn.Close();
            return customerId;
        }

        public SqlDataAdapter searchCustomer(string customerId)
        {
            if (doesCustomerExist(customerId))
            {
                SqlCommand cmd = new SqlCommand("select * from CustomerInfo where CustomerID=@CustomerID", conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                conn.Close();
                return data;
            }
            return null;
        }

        public bool doesCustomerExist(string customerId)
        {
            SqlCommand cmd = new SqlCommand("select COUNT(*) from CustomerInfo where CustomerID=@CustomerID", conn);
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            return count > 0;
        }
    }
}
