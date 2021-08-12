using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace PrimarySchoolAPP
{
    class MyConnection
    {
        public SqlConnection con;
        public MyConnection()
        {

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CC"].ConnectionString);
            // con = "Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=EdHardware;Integrated Security=True";


        }

        public static string type;
    }
    
}
