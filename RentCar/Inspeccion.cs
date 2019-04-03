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
    public partial class Inspeccion : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public Inspeccion()
        {
            InitializeComponent();
        }

        private void Inspeccion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet.InspeccionV' table. You can move, or remove it, as needed.
            this.inspeccionVTableAdapter.Fill(this.rentCarDataSet.InspeccionV);

            CargarTabla();
        }

        private void BtActualizar_Click(object sender, EventArgs e)
        {
            EditarInspeccion frmEditInspeccion = new EditarInspeccion();
            frmEditInspeccion.ShowDialog();
            
        }

        private void CargarTabla()
        {


            
            con.Open();
            string sql = "select * from InspeccionV ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DgvInspeccion.DataSource = dt;
            DgvInspeccion.Refresh();

            con.Close();



        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {

            try
            {

                
                con.Open();
                string sql = "DELETE FROM InspeccionV WHERE IdVehiculos = " + "'" + TxtIdInspeccion.Text + "'" + "";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.ExecuteNonQuery();


                MessageBox.Show("Registro Borrado");
                DgvInspeccion.Refresh();
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error");

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            AgregarInspeccion frmagregarinspeccion = new AgregarInspeccion();
            frmagregarinspeccion.ShowDialog();
        }

        private void TxtIdInspeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void DgvInspeccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
               // TxtIdVehiculo.Text = DgvInspeccion.Rows[e.RowIndex].Cells["IdVehiculo"].Value.ToString();
            
           
            
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
