using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace waHotelMontaña.Dao
{
    public class Conexion
    {
        public static SqlConnection getConnection()
        {
            SqlConnection cone = new SqlConnection(@"Server=JOELPC\SQLEXPRESS; Database=bdHotel; Integrated Security=true");

            return cone;
        }
    }
}