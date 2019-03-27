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

namespace RentCar
{
    public partial class UserVentas : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);
        public UserVentas()
        {
            InitializeComponent();
        }

        private void BtRentar_Click(object sender, EventArgs e)
        {
            Rentar frmRentar = new Rentar();
            frmRentar.ShowDialog();
        }

        private void btRegistCliente_Click(object sender, EventArgs e)
        {
            Registro frmRegistro = new Registro();
            frmRegistro.ShowDialog();
        }

        private void UserVentas_Load(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
