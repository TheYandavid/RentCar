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
    public partial class AgregarMarca : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public AgregarMarca()
        {
            InitializeComponent();
            TxtMarca.MaxLength = 20;
            TxtModelo.MaxLength = 25;
        }

        private void AgregarMarca_Load(object sender, EventArgs e)
        {

            
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

            

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            agregarModelo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarMarca();
        }

        private void agregarMarca ()
        {

             try
               {
                if (TxtMarca.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar", "Error");
                }
                else
                {
                    
                    con.Open();
                    string sql1 = " INSERT INTO Marca (Marca_Nombre) VALUES (@Marcanombre) ";

                    SqlCommand comando1 = new SqlCommand(sql1, con);



                    comando1.Parameters.AddWithValue("@Marcanombre", TxtMarca.Text);
                    comando1.ExecuteNonQuery();

                    MessageBox.Show("La marca se ha registrado");

                    this.Refresh();
                    this.Close();

                    // con.Close();


                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            con.Close();



        }
           private void agregarModelo()
           {
                try
                {
                if (TxtModelo.Text == "")
                {

                    MessageBox.Show("Faltan campos por llenar", "Error");

                }
                else {
                    
                    con.Open();
                    string sql1 = " INSERT INTO Modelo (Modelo_Nombre,Marca_Nombre) VALUES (@ModeloNombre,@Marcanombre) ";

                    SqlCommand comando1 = new SqlCommand(sql1, con);
                    comando1.Parameters.AddWithValue("@ModeloNombre", TxtModelo.Text);
                    comando1.Parameters.AddWithValue("@Marcanombre", CmbMarca.SelectedValue);
                    comando1.ExecuteNonQuery();

                    MessageBox.Show("El Modelo Fue registrado");

                    con.Close();

                }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Confirmacion.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                
            }
        }

        private void TxtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void AgregarMarca_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
