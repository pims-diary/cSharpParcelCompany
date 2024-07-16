using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcelCompany.DataLinkLayer.DataInteraction
{
    internal class DriverData: BaseData
    {
        public SqlDataAdapter ShowDriverDetails(string driverId)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DriverInfo WHERE DriverID=@DriverID", conn);
            cmd.Parameters.AddWithValue("@DriverID", driverId);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            conn.Close();
            return data;
        }

        public Dictionary<string, string> GetDriversNameAndID()
        {
            SqlCommand cmd = new SqlCommand("SELECT DriverID, DriverName FROM DriverInfo", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Dictionary<string, string> driver = new Dictionary<string, string>();
                while (reader.Read())
                {
                    driver.Add(reader.GetString(0), reader.GetString(1));
                }
                return driver;
            }
            else
            {
                return null;
            }


        }
    }
}
