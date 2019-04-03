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
    public partial class Registro : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public Registro()
        {
            InitializeComponent();
        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void Registrar()
        {
            if (TxtNombre.Text == "" | TxtCedula.Text == "" | TxtDireccion.Text == "" | TxtTargetaNum.Text == "" | TxtLimiteCredito.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar", "Error");
            }
            else
            {

                try
                {






                    con.Open();
                    string sql = "INSERT INTO Cliente (NombreCliente,CedulaCliente, DireccionCliente,NoTarjetaCR,LimiteCredito,TipoPersona) VALUES (@nombre,@cedula,@Direccion,@Targeta,@LimiteCredito,@TipoPersona) ";
                    SqlCommand comando = new SqlCommand(sql, con);
                    comando.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                    comando.Parameters.AddWithValue("@cedula", TxtCedula.Text);
                    comando.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                    comando.Parameters.AddWithValue("@Targeta", TxtTargetaNum.Text);
                    comando.Parameters.AddWithValue("@LimiteCredito", TxtLimiteCredito.Text);

                    if (Rbfisica.Checked)
                    {


                        try
                        {

                            comando.Parameters.AddWithValue("@TipoPersona", "Fisica");

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al seleccionar tipo Persona");
                            Rbfisica.Focus();
                            return;
                        }



                    }

                    if (Rbjuridica.Checked)
                    {


                        try
                        {

                            comando.Parameters.AddWithValue("@TipoPersona", "Juridica");

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al seleccionar tipo Persona");
                            Rbjuridica.Focus();
                            return;
                        }



                    }
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ha sido registrado");

                    this.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }


        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void TxtTargetaNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void TxtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void cargarcombobox() {

            
            con.Open();
            //creacion de tabla intermedia

            DataTable tbl1 = new DataTable();
            

            string sql1 = "select IdCliente from Cliente";
            
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);


            
            cmd1.ExecuteNonQuery();
            da1.Fill(tbl1);

            //Llenado Combo box Vehiculos
            cmbId.DisplayMember = "IdCliente";
            cmbId.ValueMember = "IdCliente";
            cmbId.DataSource = tbl1;

           

            


        }
        private void cargarinfo() {

            try
            {
                
                con.Open();
                DataTable tbl2 = new DataTable();
                string sql2 = "select NombreCliente,CedulaCliente,DireccionCliente,NoTarjetaCR,LimiteCredito,TipoPersona from Cliente where IdCliente like  @idCliente ";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);


                cmd2.Parameters.AddWithValue("@idCliente", cmbId.SelectedValue);
                cmd2.ExecuteNonQuery();
               


                //Llenado Combo Box Empleado
                TxtNombre.Text = "NombreCliente"; 
                TxtCedula.Text = "CedulaCliente";
                TxtDireccion.Text = "DireccionCliente";
                TxtTargetaNum.Text = "NoTarjetaCR";
                TxtLimiteCredito.Text = "LimiteCredito";

                
                da2.Fill(tbl2);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
        private void BtEditar_Click(object sender, EventArgs e)
        {

            if (TxtNombre.Text == "" | TxtCedula.Text == "" | TxtDireccion.Text == "" | TxtTargetaNum.Text == "" | TxtLimiteCredito.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar", "Error");
            }
            else
            {
                try
                {






                    con.Open();

                    string sql = "UPDATE Cliente SET NombreCliente = " + "'" + TxtNombre.Text + "'" + ", CedulaCliente = " + "'" + TxtCedula.Text + "'" + ", DireccionCliente = " + "'" + TxtDireccion + "'" + ", NoTarjetaCR = " + "'" + TxtTargetaNum.Text + "'" + ", LimiteCredito = " + "'" + TxtLimiteCredito.Text + "'" + ",TipoPersona = " + "'" + "@TipoPersona" + "'" + "where IdInspeccion = " + "'" + cmbId.SelectedValue + "'" + " ";

                    SqlCommand comando = new SqlCommand(sql, con);



                    if (Rbfisica.Checked)
                    {


                        try
                        {

                            comando.Parameters.AddWithValue("@TipoPersona", "Fisica");

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al seleccionar tipo Persona");
                            Rbfisica.Focus();
                            return;
                        }



                    }

                    if (Rbjuridica.Checked)
                    {


                        try
                        {

                            comando.Parameters.AddWithValue("@TipoPersona", "Juridica");

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al seleccionar tipo Persona");
                            Rbjuridica.Focus();
                            return;
                        }



                    }
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ha sido actualizado");

                    this.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }


        }

        private void Registro_Load(object sender, EventArgs e)
        {
            cargarcombobox();
        }

        private void cmbId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarinfo();
        }

        private void button1_Click(object sender, EventArgs e)
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

