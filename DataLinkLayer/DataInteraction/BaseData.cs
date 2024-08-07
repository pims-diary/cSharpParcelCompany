using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace parcelCompany.DataLinkLayer.DataInteraction
{
    // OOP Concept - Inheritance - This is the parent class
    internal class BaseData
    {

        public SqlConnection conn = new SqlConnection(@"Data Source=20220661-Priyanka;Initial Catalog=ParcelCompanyDatabase;Integrated Security=True");

        public BaseData()
        {
            this.conn.Open();
        }

        // OOP Concept - Polymorphism - This is a method in the parent class which can be overridden
        // in a child class. If the child class does not override this method and this method is
        // invoked for the child class object, then the method from the parent class will be invoked.
        public void Create()
        {
            throw new NotImplementedException();
        }
    }
}
