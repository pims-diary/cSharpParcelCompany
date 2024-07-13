using parcelCompany.DataLinkLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcelCompany.DataLinkLayer.DataInteraction
{
    public enum LoginStatus
    {
        Success,
        Failure,
        ServerError
    }

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
