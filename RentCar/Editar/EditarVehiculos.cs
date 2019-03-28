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
    public partial class EditarVehiculos : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
        public EditarVehiculos()
        {
            InitializeComponent();
        }

        private void EditarVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet1.Vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this.rentCarDataSet1.Vehiculos);

            cargarTabla();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            EditarVe frmeditar = new EditarVe();
            frmeditar.ShowDialog();

        }
    

        private void cargarTabla()
        {


            
            con.Open();
            string sql = "select * from Vehiculos";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DgvEditVehiculos.DataSource = dt;
            DgvEditVehiculos.Refresh();



        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
        
            try
            {
                
                
                string sql = "DELETE FROM Vehiculos WHERE IdVehiculos = " + "'" + TxtId.Text + "'" + "";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.ExecuteNonQuery();


                MessageBox.Show("Registro Borrado");
                DgvEditVehiculos.Refresh();
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error");

            }

            
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
