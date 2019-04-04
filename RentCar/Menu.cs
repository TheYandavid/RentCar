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
    public partial class Menu : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public Menu()
        {
            InitializeComponent();
        }

        private void listaDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           


            
        }

        private void BtIngresarLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro frmRegistro = new Registro();
            frmRegistro.BtEditar.Visible = false;
            frmRegistro.LbId.Visible = false;
            frmRegistro.cmbId.Visible = false;
            frmRegistro.ShowDialog();

            //frmRentar.BtRentar.Visible = false;
        }

        private void eliminarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarVehiculos frmedit = new EditarVehiculos();
            frmedit.ShowDialog();
        }

        private void agregarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarVehiculo frmAgrVehiculo = new AgregarVehiculo();
            frmAgrVehiculo.ShowDialog();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClientes frmlistaClientes = new ListaClientes();
            frmlistaClientes.ShowDialog();
        }

        private void historialRentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoRentas frmhistorentas = new HistoRentas();
            frmhistorentas.ShowDialog();
            this.Close();
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeInspeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inspeccion frmInspeccion = new Inspeccion();
            frmInspeccion.ShowDialog();
            
        }

        private void rentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rentar frmRentar = new Rentar();
            
     
            frmRentar.ShowDialog();

        
          
         
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void generarReporteDeRentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar.Generar_Reporte frmReporte = new Agregar.Generar_Reporte();
            frmReporte.ShowDialog();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEmpleados frmlistaEmpleados = new ListaEmpleados();
            frmlistaEmpleados.ShowDialog();
        }
    }
}
