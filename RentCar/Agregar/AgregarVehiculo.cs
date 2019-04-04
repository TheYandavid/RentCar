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
using RentCar.Clases;

namespace RentCar
{
    public partial class AgregarVehiculo : Form
    {

        SqlConnection con = Conexion.getSqlConexion();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public AgregarVehiculo()
        {
            InitializeComponent();
            TxtDescVehiculo.MaxLength = 15;
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }


        private void Agregar()
        {
            try
            {
                if (TxtNuChasis.Text == "" | TxtNuMotor.Text == "" | TxtPlaca.Text == "" | TxtTipoVehiculo.Text == "" | CmbTipoCombustible.Text == "" )
                {
                    MessageBox.Show("Faltan campos por llenar", "Error");
                }
                else
                {

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    string sql1 = " INSERT INTO Vehiculos (MarcaVehiculos,ModeloVehiculos,TipoCombustible,TipoVehiculo,NoChasis,NoMotor,NoPlaca,DescripcionVehiculo,Disponibilidad) VALUES (@MarcaVehiculos,@ModeloVehiculos,@TipoCombustible, @TipoVehiculo,@Nochasis,@NoMotor,@NoPlaca,@Descripcion,@Disponibilidad) ";
                    //string sql2 = " INSERT INTO Marca (Marca_Nombre, Modelo_Nombre) VALUES (@MarcaNombre, @ModeloNombre) ";
                    SqlCommand comando1 = new SqlCommand(sql1, con);
                   // SqlCommand comando2 = new SqlCommand(sql2, con);

                    comando1.Parameters.AddWithValue("@MarcaVehiculos", CmbMarca.SelectedValue);
                    comando1.Parameters.AddWithValue("@ModeloVehiculos", CmbModelo.SelectedValue);
                    comando1.Parameters.AddWithValue("@TipoCombustible", CmbTipoCombustible.Text);
                    comando1.Parameters.AddWithValue("@TipoVehiculo", TxtTipoVehiculo.Text);
                    comando1.Parameters.AddWithValue("@Nochasis", TxtNuChasis.Text);
                    comando1.Parameters.AddWithValue("@NoMotor", TxtNuMotor.Text);
                    comando1.Parameters.AddWithValue("@NoPlaca", TxtPlaca.Text);
                    comando1.Parameters.AddWithValue("@Descripcion", TxtDescVehiculo.Text);
                    comando1.Parameters.AddWithValue("@Disponibilidad", "Disponible");



                    //comando2.Parameters.AddWithValue("@MarcaNombre", CmbMarca.SelectedValue);
                    // comando2.Parameters.AddWithValue("@ModeloNombre", CmbMarca.SelectedValue);
                    comando1.ExecuteNonQuery();

                    MessageBox.Show("Ha sido registrado el vehiculo");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void AgregarVehiculo_Load(object sender, EventArgs e)
        {
            cargarCmb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarMarca frm  = new AgregarMarca();
            frm.ShowDialog();
            
        }

        private void cargarCmb()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                //creacion de tabla intermedia
                DataTable tbl1 = new DataTable();
                string sql1 = "select Marca_Nombre from Marca";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(tbl1);

                //Llenado Combo box Vehiculos
                CmbMarca.DisplayMember = "Marca_Nombre";
                CmbMarca.ValueMember = "Marca_Nombre";
                CmbMarca.DataSource = tbl1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarmodelos();
        }
        private void cargarmodelos()
        {
            

        }

        private void TxtNuChasis_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtNuMotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (con.State != ConnectionState.Open)
                con.Open();

            DataTable tbl2 = new DataTable();

            string sql2 = ("select Modelo_Nombre from Modelo where Marca_Nombre like @Select ");
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);


            cmd2.Parameters.AddWithValue("@Select", CmbMarca.SelectedValue);
            cmd2.ExecuteNonQuery();


            da2.Fill(tbl2);

            //Llenado Combo Box Empleado
            CmbModelo.DisplayMember = "Modelo_Nombre";
            CmbModelo.ValueMember = "Modelo_Nombre";
            CmbModelo.DataSource = tbl2;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
