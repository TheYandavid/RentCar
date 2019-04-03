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
using System.Runtime.InteropServices;

namespace RentCar
{
    public partial class AgregarInspeccion : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public AgregarInspeccion()
        {
            InitializeComponent();
        }

        private void AgregarInspeccion_Load(object sender, EventArgs e)
        {

            
            con.Open();
            //creacion de tabla intermedia

            DataTable tbl1 = new DataTable();
            DataTable tbl2 = new DataTable();
            DataTable tbl3 = new DataTable();

            string sql1 = "select IdVehiculos,ModeloVehiculos from Vehiculos";
            string sql2 = "select IdEmpleado,NombreEmpleado from Empleado";
            string sql3 = "select IdCliente,NombreCliente from Cliente";

            SqlCommand cmd1 = new SqlCommand(sql1, con);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            SqlCommand cmd3 = new SqlCommand(sql3, con);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);

            da1.Fill(tbl1);
            da2.Fill(tbl2);
            da3.Fill(tbl3);

            //Llenado Combo box Vehiculos
            CmbIdVehiculo.DisplayMember = "ModeloVehiculos";
            CmbIdVehiculo.ValueMember = "IdVehiculos";
            CmbIdVehiculo.DataSource = tbl1;

            //Llenado Combo Box Empleado
            CmbIdEmpleado.DisplayMember = "NombreEmpleado";
            CmbIdEmpleado.ValueMember = "IdEmpleado";
            CmbIdEmpleado.DataSource = tbl2;

            //Llenado Combo box cliente

            CmbIdCliente.DisplayMember = "NombreCliente";
            CmbIdCliente.ValueMember = "IdCliente";
            CmbIdCliente.DataSource = tbl3;

            con.Close();
        }
        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            CrearInspeccion();
        }

        private void CrearInspeccion()
        {

            try
            {
                if (CmbIdVehiculo.Text == "" | CmbIdCliente.Text == "" | CmbRalladuras.Text == "" | CmbCombustible.Text == "" | CmbGomaRepuesto.Text == "" | CmbGato.Text == "" | CmbRoturaCristal.Text == "" | CmbEstadoGomas.Text == "" | DtpFechaInspeccion.Text == "" | CmbIdEmpleado.Text =="")
                {
                    MessageBox.Show("Faltan campos por llenar", "Error");
                }
                else
                {

                }
                
                con.Open();
                string sql = " INSERT INTO InspeccionV (IdVehiculo,IdCliente,Ralladuras,CantidadCombustible,GomaRespuesto,Gato,RoturaCristal,EstadoGomas,FechaInspeccion,IdEmpleado) VALUES (@IdVehiculo,@IdCliente, @Ralladuras,@CantidadCombustible,@GomaRespuesto,@Gato,@RoturaCristal,@EstadoGomas,@FechaInspeccion,@IdEmpleado) ";
                SqlCommand comando = new SqlCommand(sql, con);

              
                comando.Parameters.AddWithValue("@IdVehiculo", CmbIdVehiculo.SelectedValue);
                comando.Parameters.AddWithValue("@IdCliente", CmbIdCliente.SelectedValue);
                comando.Parameters.AddWithValue("@Ralladuras", CmbRalladuras.Text);
                comando.Parameters.AddWithValue("@CantidadCombustible", CmbCombustible.Text);
                comando.Parameters.AddWithValue("@GomaRespuesto", CmbGomaRepuesto.Text);
                comando.Parameters.AddWithValue("@Gato", CmbGato.Text);
                comando.Parameters.AddWithValue("@RoturaCristal", CmbRoturaCristal.Text);
                comando.Parameters.AddWithValue("@EstadoGomas", CmbEstadoGomas.Text);
                comando.Parameters.AddWithValue("@FechaInspeccion", DtpFechaInspeccion.Value.ToString("yyyy/M/d"));
                comando.Parameters.AddWithValue("@IdEmpleado", CmbIdEmpleado.SelectedValue);
                comando.ExecuteNonQuery();

                
                MessageBox.Show("Ha sido registrada la inspeccion");

                
                con.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }







        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
