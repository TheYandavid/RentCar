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
    public partial class Login : Form
    {
        SqlConnection conLogin = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            TxtCedulaLogin.PasswordChar = '*';
            TxtCedulaLogin.MaxLength = 12;
            
        }
       

        private void BtIngresarLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string pCedula = TxtCedulaLogin.Text;

                int vnTotal = 0;
                string vcCedula = pCedula.Replace("-", "");
                int pLongCed = vcCedula.Trim().Length;
                int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

                if (pLongCed < 11 || pLongCed > 11)
                    return;

                for (int vDig = 1; vDig <= pLongCed; vDig++)
                {
                    int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                    if (vCalculo < 10)
                        vnTotal += vCalculo;
                    else
                        vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
                }

                if (vnTotal % 10 == 0)
                {

                    logmain();

                }

                else
                {

                    MessageBox.Show("Cedula incoreccta");
                }
                return;

            }
            catch (Exception ex)
            {

                MessageBox.Show("ha ocurrido un error al validar la cedula:" + ex.Message);

            }
            

            
           

        }

        private void logmain() {

            try
            {

                
                conLogin.Open();
                string sqlLogin = "Select IdEmpleado,CedulaEmpleado from Empleado where IdEmpleado like " + TxtIDLogin.Text + " and CedulaEmpleado like " + TxtCedulaLogin.Text + " ";
                SqlDataAdapter sda = new SqlDataAdapter(sqlLogin, conLogin);
                DataTable dta = new DataTable();
                sda.Fill(dta);


                if (dta.Rows.Count == 1)
                {
                    MessageBox.Show("Login exitoso.");

                    logadmin();




                }
                else
                {
                    MessageBox.Show("Datos incorrectos.");
                }







            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void logadmin() {

            
            conLogin.Open();
            string sqlLogin = "Select TipoEmpleado from Empleado where IdEmpleado like " + TxtIDLogin.Text + "and TipoEmpleado = " + "'Administrativo'" + " ";
            SqlDataAdapter sda = new SqlDataAdapter(sqlLogin, conLogin);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            if (dta.Rows.Count == 1)
            {
                MessageBox.Show("Bienbenido Administrador.");
                Menu frmMenu = new Menu();
                frmMenu.ShowDialog();
                this.Close();
            }


            else 
            {
                logventa();
            }


        }

        private void logventa()
        {

            
            conLogin.Open();
            string sqlLogin = "Select TipoEmpleado from Empleado where IdEmpleado like " + TxtIDLogin.Text + "and TipoEmpleado = " + "'Ventas'" + " ";
            SqlDataAdapter sda = new SqlDataAdapter(sqlLogin, conLogin);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            if (dta.Rows.Count == 1)
            {
                MessageBox.Show("Bienbenido Empleado de Ventas.");
                UserVentas frmUserventas = new UserVentas();
                frmUserventas.ShowDialog();
            }


            else
            {

                MessageBox.Show("Error al vereficar su tipo de usuario.");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Passadmin frmPass = new Passadmin();
            frmPass.ShowDialog();
        }

        private void TxtIDLogin_TextChanged(object sender, EventArgs e)
        {
           
        }
        

        private void TxtIDLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
