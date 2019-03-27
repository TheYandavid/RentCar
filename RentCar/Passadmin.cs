using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class Passadmin : Form
    {
        public Passadmin()
        {
            InitializeComponent();
            TxtPassAdm.PasswordChar = '*';
        }

        private void Btpass_Click(object sender, EventArgs e)
        {
            try
            {
             
                //string pass = 1631;
                if (Convert.ToInt32(TxtPassAdm.Text) == 1631)
                {
                    RegistrarEmpleado frmRegisEmpleado = new RegistrarEmpleado();

                    frmRegisEmpleado.ShowDialog();

                    this.Close();
                }

                else
                {

                    MessageBox.Show("contraseña de afministrador incorrecta");

                }


                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
               
            }
        }

        private void BtPassAdm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPassAdm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
