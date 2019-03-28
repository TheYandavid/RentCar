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
    public partial class Rentar : Form
    {
        private string fecha_inicio, Fecha_Fin;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");

        public Rentar()
        {
            InitializeComponent();
        }
        private void Rentar_Load(object sender, EventArgs e)
        {
            mostrarTabla();
            cargarCombobox();

            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            RentarFormulario();
        }

        private void RentarFormulario()
        {
            try
            {
                
                con.Open();
                string sql = "INSERT INTO Renta (IdVehiculo,IdEmpleado,IdCliente,FechaRenta,DepositoRenta,MontoXdia,CantidadDias,Comentario,FechaDevolucion) VALUES (@IdVehiculo,@IdEmpleado,@IdCliente,@FechaRenta,@DepositoRenta,@MontoXdia,@CantidadDias,@Comentario,@FechaDevolucion)";
                string sql2 = "UPDATE Vehiculos SET Disponibilidad  = 'Rentado' where IdVehiculos = "  +  "'" +CmbIdVehiculo.SelectedValue+ "'" + "";
                SqlCommand comando = new SqlCommand(sql, con);
                SqlCommand comando2 = new SqlCommand(sql2, con);

                  comando.Parameters.AddWithValue("@IdVehiculo", CmbIdVehiculo.SelectedValue);
                  comando.Parameters.AddWithValue("@IdEmpleado", CmbIdEmpleado.SelectedValue);
                  comando.Parameters.AddWithValue("@IdCliente", CmbIdCliente.SelectedValue);

                /* comando.Parameters.AddWithValue("@IdVehiculo", TxtNoVehiculo.Text);
                 comando.Parameters.AddWithValue("@IdEmpleado", TxtEmpleado.Text);
                 comando.Parameters.AddWithValue("@IdCliente", TxtCliente.Text);*/

                comando.Parameters.AddWithValue("@FechaRenta", dateTimePicker1.Value.ToString("yyyy/M/d"));
                comando.Parameters.AddWithValue("@DepositoRenta", TxtDeposito.Text);
                comando.Parameters.AddWithValue("@MontoXdia", TxtMontoXdia.Text);
                comando.Parameters.AddWithValue("@CantidadDias", TxtCantidadDias.Text);
                comando.Parameters.AddWithValue("@Comentario", TxtComentarios.Text);
                comando.Parameters.AddWithValue("@FechaDevolucion", dateTimePicker2.Value.ToString("yyyy/M/d"));

                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();

                if (dateTimePicker1.Value <= dateTimePicker2.Value)
                {
                    
                    comando.ExecuteNonQuery();
                    MessageBox.Show("La Renta se a registrado");
                }
                else
                {
                    MessageBox.Show("Fecha de devolucion erronea.", "Error");
                    return;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarCombobox()
        {

           
            con.Open();
            //creacion de tabla intermedia

            DataTable tbl1 = new DataTable();
            DataTable tbl2 = new DataTable();
            DataTable tbl3 = new DataTable();
            DataTable tbl4 = new DataTable();

            string sql1 = "select IdVehiculos,ModeloVehiculos from Vehiculos";
            string sql2 = "select IdEmpleado,NombreEmpleado from Empleado";
            string sql3 = "select IdCliente,NombreCliente from Cliente";
            string sql4 = "select IdVehiculos,ModeloVehiculos from Vehiculos";

            SqlCommand cmd1 = new SqlCommand(sql1, con);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            SqlCommand cmd4 = new SqlCommand(sql4, con);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);

            da1.Fill(tbl1);
            da2.Fill(tbl2);
            da3.Fill(tbl3);
            da4.Fill(tbl4);

            //Llenado Combo box Vehiculos
            CmbIdVehiculo.DisplayMember = "ModeloVehiculos";
            CmbIdVehiculo.ValueMember = "IdVehiculos";
            CmbIdVehiculo.DataSource = tbl1;

            //Llenado Combo Box Empleado
            CmbIdEmpleado.DisplayMember = "NombreEmpleado";
            CmbIdEmpleado.ValueMember = "IdEmpleado";
            CmbIdEmpleado.DataSource = tbl2;

            //Llenado Combo box cliente

            CmbIdCliente.DisplayMember = "NombreCliente";
            CmbIdCliente.ValueMember = "IdCliente";
            CmbIdCliente.DataSource = tbl3;

            //Llenado Combo box Marcas

            CmbMarca.DisplayMember = "ModeloVehiculos";
            CmbMarca.ValueMember = "IdVehiculos";
            CmbMarca.DataSource = tbl4;
     




        }


        private void CmbIdVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                string sql = "select * from Vehiculos";
                sql += " where IdVehiculos LIKE '" + CmbMarca.SelectedValue + "%' ";
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

            
            con.Open();
            string sql = "select * from Vehiculos";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVehiculos.DataSource = dt;
            dgvVehiculos.Refresh();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Fecha_Fin = dateTimePicker2.Value.Date.ToShortDateString();
            int dias = DateTime.Now.Date.Subtract(dateTimePicker1.Value.Date).Days;
            int rest = DateTime.Now.Date.Subtract(dateTimePicker2.Value.Date).Days;
            int resultado = dias - rest ;
            TxtCantidadDias.Text = resultado.ToString();

        }

        private void calcularfehca_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fecha_inicio,Fecha_Fin);
        }

        private void TxtDeposito_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void TxtMontoXdia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void CmbIdVehiculo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Rentar frmRentar = new Rentar();
            frmRentar.BtRentar.Visible = true;
            valdiarDis();
           
        }

        private void valdiarDis() {

            
            conLogin.Open();
            string sqlLogin = "Select Disponibilidad from Vehiculos where Disponibilidad = 'Disponible' and  IdVehiculos =" + "'"+ CmbIdVehiculo.SelectedValue + "'" + " ";
            SqlDataAdapter sda = new SqlDataAdapter(sqlLogin, conLogin);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            if (dta.Rows.Count == 1 && BtRentar.Visible == false)
            {


                Rentar frmRentar = new Rentar();


                this.Hide();
                frmRentar.BtRentar.Visible = true;
                frmRentar.Show();
                
                MessageBox.Show("Encontrado");


            }


            else
            {
                Rentar frmRentar = new Rentar();
                this.Hide();
                frmRentar.BtRentar.Visible = false;
                frmRentar.Show();
                MessageBox.Show("Ese vehiculo no esta disponible");
            }


        }

        private void CmbIdVehiculo_Click(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //fecha_inicio = dateTimePicker1.Value.Date.ToShortDateString();
            dateTimePicker1.MinDate = DateTime.Now;
            fecha_inicio = dateTimePicker1.Value.Date.ToShortDateString();

        }
    }
            


        }

       
    

