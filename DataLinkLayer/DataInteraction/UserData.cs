using System.Data;
using System.Data.SqlClient;

namespace parcelCompany.DataLinkLayer.DataInteraction
{
    public enum LoginStatus
    {
        Success,
        Failure,
        ServerError
    }

    // OOP Concept - Inheritance - This is the child class
    internal class UserData: BaseData
    {
        public LoginStatus ValidateLogin(string username, string password)
        {
            try
            {
                string query = "select * from Login where Username = '" + username + "' and Password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, this.conn);
                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    return LoginStatus.Success;
                }
                else
                {
                    return LoginStatus.Failure;
                }
            }
            catch
            {
                return LoginStatus.ServerError;
            }
            finally
            {
                this.conn.Close();
            }
        }
    }
}
