using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RentCar.Clases
{
     class Conexion
    {
        private static void SqlConexion()
        {
            SqlConnection con;
             con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
        }
        
      

    }
}
