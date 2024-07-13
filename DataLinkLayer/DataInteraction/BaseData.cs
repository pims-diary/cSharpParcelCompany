using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcelCompany.DataLinkLayer.DataInteraction
{
    internal class BaseData
    {

        public SqlConnection conn = new SqlConnection(@"Data Source=20220661-Priyanka;Initial Catalog=PracelCompany_assign1_20220661;Integrated Security=True");

        public BaseData()
        {
            this.conn.Open();
        }
    }
}
