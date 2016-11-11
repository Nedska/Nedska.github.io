using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Prototype_Website.Backend
{
    SqlConnection myConnection = new SqlConnection("user id=username;" +
                                       "password=password;server=serverurl;" +
                                       "Trusted_Connection=yes;" +
                                       "database=database; " +
                                       "connection timeout=30");

    class Class1
    {
        static int Main(string[] args)
        {
            //... 
            return 0;
        }
    }
}
