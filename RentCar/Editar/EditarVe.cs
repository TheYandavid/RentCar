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
    public partial class EditarVe : Form
    {
        SqlConnection con = null;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public EditarVe()
        {
            InitializeComponent();
        }

        private void cmbID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //Cargar Marca

                con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                con.Open();
                //creacion de tabla intermedia
                DataTable tbl1 = new DataTable();
                string sql1 = ("Select Marca_Nombre from Marca where Marca_ID like @Select");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                cmd1.Parameters.AddWithValue("@Select", cmbID.SelectedValue);
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

        private void Bteditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbMarca.Text == "" | CmbModelo.Text == "" | CmbTipoCombustible.Text == "" | TxtTipoVehiculo.Text == "" | TxtNuChasis.Text == "" | TxtDescVehiculo.Text == "" | TxtNuMotor.Text == "" | TxtPlaca.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar", "Error");
                }
                else
                {
                    con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                    con.Open();
                    string sql1 = "UPDATE Vehiculos SET MarcaVehiculos = " + "'" + CmbMarca.SelectedValue + "'" + ", ModeloVehiculos = " + "'" + CmbModelo.SelectedValue + "'" + ", TipoCombustible = " + "'" + CmbTipoCombustible.Text + "'" + ", TipoVehiculo = " + "'" +TxtTipoVehiculo.Text + "'" + ", NoChasis = " + "'" + TxtNuChasis.Text + "'" + ",NoMotor= " + "'" + TxtNuMotor.Text + "'" + "'" + ",NoPlaca = " + "'" + TxtPlaca.Text + "'" + ",DescripcionVehiculo = " + "'" + TxtDescVehiculo + "'" + "where IdInspeccion = " + "'" + cmbID + "'" + " ";
               
                    SqlCommand comando1 = new SqlCommand(sql1, con);
                
                    comando1.ExecuteNonQuery();

                    MessageBox.Show("Has editado el vehiculo");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void CmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
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

        private void EditarVe_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargado de Combo Box ID
                con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                con.Open();
                //creacion de tabla intermedia
                DataTable tbl1 = new DataTable();
                string sql1 = "select IdVehiculos,MarcaVehiculos  from Vehiculos";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(tbl1);

                //Llenado Combo box Vehiculos
                cmbID.DisplayMember = "IdVehiculos";
                cmbID.ValueMember = "IdVehiculos";
                cmbID.DataSource = tbl1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

           
        }

        private void cargarEdit()
        {
            con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
            con.Open();
            //creacion de tabla intermedia
            DataTable tbl1 = new DataTable();
            string sql1 = "select IdVehiculos,MarcaVehiculos  from Vehiculos where IdVehiculos like" +cmbID+ "";
            SqlCommand cmd1 = new SqlCommand(sql1, con);

            cmd1.ExecuteNonQuery();
 

            //Llenado Combo box Vehiculos
            TxtTipoVehiculo.Text = "IdVehiculos";
  
     






        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
