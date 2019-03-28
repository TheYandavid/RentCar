using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RentCar.Clases
{
     class Conexion
    {
        private static void SqlConexion()
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");

                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha creado un error al establecer la conexion SQL :" + ex);
            }
          
        }
        
      

    }
}
