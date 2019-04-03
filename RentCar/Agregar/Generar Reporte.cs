using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Data.SqlClient;
using RentCar.Clases;

namespace RentCar.Agregar
{
    public partial class Generar_Reporte : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
        SqlConnection con = Conexion.getSqlConexion();
        DataTable dt = new DataTable();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public Generar_Reporte()
        {
            InitializeComponent();
        }

        private void Generar_Reporte_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtReporteRenta_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x012, 0xf050, 0);

            if (panel1.Width == 900)
            {
                panel1.Width = 150;
            }
            else
            {
                panel1.Width = 900;
            }
        }

        private void BtGenerarReport_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte.writeFileHeader("sep=,");
                Reporte.writeFileLine("ID Renta, ID Articulo, ID Cliente, FechaRenta, DepositoRenta, MontoXdia, CantidadDias, Comentario, FechaDevolucion ");
                foreach (DataRow row in dt.Rows)
                {
                    string linea = "";
                    foreach (DataColumn dc in dt.Columns)
                    {
                        linea += row[dc].ToString() + ",";
                    }
                    Reporte.writeFileLine(linea);
                }
                Process.Start(@"D:\prueba.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void cargartabla() {
            if (con.State != ConnectionState.Open)
                con.Open();
            string SQL = "select * from Renta ";
            SqlDataAdapter oDa = new SqlDataAdapter(SQL, con);
            dt = new DataTable();
            oDa.Fill(dt);
            DtRenta.DataSource = dt;
        }

        private void Generar_Reporte_Load(object sender, EventArgs e)
        {
            cargartabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

