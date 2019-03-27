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
    public partial class EditarInspeccion : Form
    {

        SqlConnection con = null;
        public EditarInspeccion()
        {
            InitializeComponent();
        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                con.Open();
                string sqlUpdate = "UPDATE InspeccionV  SET IdVehiculo = " + "'" + CmbIdVehiculo.SelectedValue + "'" + ", IdCliente = " + "'" + CmbIdCliente.SelectedValue + "'" + ", Ralladuras = " + "'" + CmbRalladuras.Text + "'" + ", CantidadCombustible = " + "'" + CmbCombustible.Text + "'" + ", GomaRespuesto = " + "'" + CmbGomaRepuesto.Text + "'" + ",Gato = " + "'" + CmbGato.Text + "'" + "'" + ",RoturaCristal = " + "'" + CmbRoturaCristal.Text + "'" + ",EstadoGomas = " + "'" + CmbEstadoGomas.Text + "'" + ",FechaInspeccion = " + "'" + DtpFechaInspeccion.Value.ToString("yyyy/M/d") + "'" + ",IdEmpleado = " + "'" + CmbIdEmpleado.Text + "where IdInspeccion = " + "'" + cmbIDInsp.SelectedValue + "'" + " ";
                SqlCommand comando = new SqlCommand(sqlUpdate, con);
                comando.ExecuteNonQuery();


                MessageBox.Show("Registro Actualizado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error:"+ ex.Message);
            }
           
            
            con.Close();
        }

        private void cargarCombobox() {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
            con.Open();
            //creacion de tabla intermedia

           
            DataTable tbl4 = new DataTable();


           
            string sql4 = "select IdInspeccion from InspeccionV";

           
            SqlCommand cmd4 = new SqlCommand(sql4, con);

            
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);

            
            da4.Fill(tbl4);

            

            //Llenado Combo box Id inspeccion

            cmbIDInsp.DisplayMember = "IdInspeccion";
            cmbIDInsp.ValueMember = "IdInspeccion";
            cmbIDInsp.DataSource = tbl4;

            con.Close();


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void EditarInspeccion_Load(object sender, EventArgs e)
        {
            cargarCombobox();
        }

        private void cmbIDInsp_Click(object sender, EventArgs e)
        {
           
            
        }

        private void cmbIDInsp_SelectionChangeCommitted(object sender, EventArgs e)
        {
             try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                con.Open();

                DataTable tbl1 = new DataTable();
                DataTable tbl2 = new DataTable();
                DataTable tbl3 = new DataTable();
                

                string sql1 = "select IdVehiculo from InspeccionV  where IdInspeccion like @Select";
                string sql2 = "select IdEmpleado from InspeccionV  where IdInspeccion like @Select";
                string sql3 = "select IdCliente from InspeccionV  where IdInspeccion like @Select";
                

                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                

                
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);

               



                cmd1.Parameters.AddWithValue("@Select", cmbIDInsp.SelectedValue);
                cmd2.Parameters.AddWithValue("@Select", cmbIDInsp.SelectedValue);
                cmd3.Parameters.AddWithValue("@Select", cmbIDInsp.SelectedValue);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();



                da1.Fill(tbl1);
                da2.Fill(tbl2);
                da3.Fill(tbl3);


                //Llenado Combo box Vehiculos
                CmbIdVehiculo.DisplayMember = "IdVehiculo";
                CmbIdVehiculo.ValueMember = "IdVehiculo";
                CmbIdVehiculo.DataSource = tbl1;

                //Llenado Combo Box Empleado
                CmbIdEmpleado.DisplayMember = "IdEmpleado";
                CmbIdEmpleado.ValueMember = "IdEmpleado";
                CmbIdEmpleado.DataSource = tbl2;

                //Llenado Combo box cliente

                CmbIdCliente.DisplayMember = "IdCliente";
                CmbIdCliente.ValueMember = "IdCliente";
                CmbIdCliente.DataSource = tbl3;

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            //creacion de tabla intermedia

        }
    }
}
