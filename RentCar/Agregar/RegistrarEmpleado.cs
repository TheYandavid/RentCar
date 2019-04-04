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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RentCar
{
    public partial class RegistrarEmpleado : Form
    {

        SqlConnection con = null;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public RegistrarEmpleado()
        {
            InitializeComponent();
            TxtCedula.MaxLength = 11;
            TxtPorcientoComision.MaxLength = 3;
        }

        private void RegistrarEmpleado_Load(object sender, EventArgs e)
        {
            cargarcmb();
        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarEmpelado();
        }

        private void RegistrarEmpelado()
        {
            if (TxtNombre.Text == "" | TxtCedula.Text == "" | cmbTanda.Text == "" | TxtPorcientoComision.Text == "" | cmbEstado.Text == "" | CmbTipoEmpleado.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar", "Error");
            }
            else
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

           
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cargarcmb() {

            con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
            con.Open();
            DataTable tbl2 = new DataTable();
            string sql2 = "select IdEmpleado from Empleado";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);



            cmd2.ExecuteNonQuery();


            da2.Fill(tbl2);
            //Llenado Combo Box Empleado
            cmbIdEmpleado.DisplayMember = "IdEmpleado";
            cmbIdEmpleado.ValueMember = "IdEmpleado";
            cmbIdEmpleado.DataSource = tbl2;


            



        }

        private void btEditar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
