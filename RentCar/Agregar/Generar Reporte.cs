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

namespace RentCar.Agregar
{
    public partial class Generar_Reporte : Form
    {
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
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            if (panel1.Width == 500)
            {
                panel1.Width = 150;
            }
            else
            {
                panel1.Width = 500;
            }
        }

        private void BtGenerarReport_Click(object sender, EventArgs e)
        {

          

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
            con.Open();
            string SQL = "select * from Renta ";
            DataTable Dt = new DataTable();

           
            SqlDataAdapter oDa = new SqlDataAdapter(SQL, con);

            Dt = new DataTable();
            oDa.Fill(Dt);
            

            writeFileHeader("ID Renta, ID Articulo, ID Cliente, FechaRenta ,DepositoRenta ,MontoXdia ,CantidadDias ,Comentario ,FechaDevolucion ");

                foreach (DataRow row in Dt.Rows)
                {
                    string linea = "";
                    foreach (DataColumn dc in Dt.Columns)
                    {
                        linea += row[dc].ToString() + ",";
                    }
                    writeFileLine(linea);
                }

                Process.Start(@"D:\prueba.xls");
         }

            private void writeFileLine(string pLine)
            {
                using (System.IO.StreamWriter w = File.AppendText("D:\\prueba.xls"))
                {
                    w.WriteLine(pLine);
                }
            }
            private void writeFileHeader(string pLine)
            {
                using (System.IO.StreamWriter w = File.CreateText("D:\\prueba.xls"))
                {
                    w.WriteLine(pLine);
                }
            }
        }
    }

