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
    public partial class ListaClientes : Form
    {
        SqlConnection con = Conexion.getSqlConexion();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
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

                if (con.State != ConnectionState.Open)
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


            if (con.State != ConnectionState.Open)
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

        private void ListaClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
