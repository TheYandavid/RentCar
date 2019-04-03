using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace RentCar.Clases
{
    class Conexion
    {
       static string connectionStr = ConfigurationManager.ConnectionStrings["RentCar.Properties.Settings.RentCarConnectionString"].ConnectionString;
       public static SqlConnection getSqlConexion()
        {
            return new SqlConnection(connectionStr);
        }
    }
}
