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
    public partial class ListaClientes : Form
    {
        SqlConnection con = null;
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
           


            cargarTabla();

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                con.Open();
                string sql = "DELETE FROM Cliente WHERE IdCliente = " + "'" + TxtId.Text + "'" + "";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.ExecuteNonQuery();


                MessageBox.Show("Registro Borrado");
                Dgvclientes.Refresh();
                this.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }



        }
        private void cargarTabla()
        {


            con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
            con.Open();
            string sql = "select * from Cliente";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Dgvclientes.DataSource = dt;
            Dgvclientes.Refresh();
            
            con.Close();

        }

        private void BtActualizar_Click(object sender, EventArgs e)
        {

            Registro frmRegistro = new Registro();
            frmRegistro.BtRegistrar.Visible = false;
            frmRegistro.ShowDialog();
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
