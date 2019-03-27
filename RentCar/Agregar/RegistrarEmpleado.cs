using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentCar
{
    public partial class RegistrarEmpleado : Form
    {

        SqlConnection con = null;

        public RegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void RegistrarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarEmpelado();
        }

        private void RegistrarEmpelado()
        {
            try
            {

                

                con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                con.Open();
                string sql = "INSERT INTO Empleado (NombreEmpleado,CedulaEmpleado,TandaLabor,PorcientoComision,FechaIngreso,Estado,TipoEmpleado) VALUES (@nombre,@cedula,@TandaLaboral,@PorcientoComision,@FechaIngreso,@Estado,@TipoEmpleado) ";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                comando.Parameters.AddWithValue("@cedula", TxtCedula.Text);
                comando.Parameters.AddWithValue("@TandaLaboral", cmbTanda.Text);
                comando.Parameters.AddWithValue("@PorcientoComision", TxtPorcientoComision.Text);
                comando.Parameters.AddWithValue("@FechaIngreso", dateTimePicker1.Value.ToString("yyyy/M/d")); 
                comando.Parameters.AddWithValue("@Estado", cmbEstado.Text);
                comando.Parameters.AddWithValue("@TipoEmpleado", CmbTipoEmpleado.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Ha sido registrado");

                this.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al registrar el empleado " + ex.Message);

               
            }





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

       }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void TxtPorcientoComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {

           
            
        }
    }
}
