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
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargarcmb();
            mostrarTabla();
        
        }

       

        private void BtBuscar_Click(object sender, EventArgs e)
        {

            
            ejecutarConsulta();

        }

        private void ejecutarConsulta()
        {

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                con.Open();
                string sql = "select * from Vehiculos";
                sql += " where MarcaVehiculos LIKE '" + CmbMarca.Text +"%' ";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVehiculos.DataSource = dt;
                dgvVehiculos.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);

            }



        }
        private void mostrarTabla()
        {

            con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
            con.Open();
            string sql = "select * from Vehiculos";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVehiculos.DataSource = dt;
            dgvVehiculos.Refresh();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro frm = new Registro();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cargarcmb() {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
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
    }
}
