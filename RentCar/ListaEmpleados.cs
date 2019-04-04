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
    public partial class ListaEmpleados : Form
    {
        SqlConnection con = null;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public ListaEmpleados()
        {
            InitializeComponent();
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                con.Open();
                string sql = "DELETE FROM Empleado WHERE IdEmpleado = " + "'" + cmbIdempleado.Text + "'" + "";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.ExecuteNonQuery();


                MessageBox.Show("Registro Borrado");
                dtgEmpleados.Hide();
                dtgEmpleados.Refresh();
                dtgEmpleados.Show();
                this.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void cargardtg() {

            con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
            con.Open();
            string sql = "select * from Empleado";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgEmpleados.DataSource = dt;
            dtgEmpleados.Refresh();

            con.Close();





        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado frmRegistrarEmpleado = new RegistrarEmpleado();
            frmRegistrarEmpleado.BtRegistrar.Visible = false;
            frmRegistrarEmpleado.ShowDialog();
        }

        private void ListaEmpleados_Load(object sender, EventArgs e)
        {
            cargardtg();
            cargarcmb();
        }
        private void cargarcmb() {

            con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
            con.Open();
            //creacion de tabla intermedia
            DataTable tbl1 = new DataTable();
            string sql1 = "select IdEmpleado,NombreEmpleado from Empleado";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(tbl1);

            //Llenado Combo box Vehiculos
            cmbIdempleado.DisplayMember = "NombreEmpleado";
            cmbIdempleado.ValueMember = "IdEmpleado";
            cmbIdempleado.DataSource = tbl1;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
