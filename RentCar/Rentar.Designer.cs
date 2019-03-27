namespace RentCar
{
    partial class Rentar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbIdCliente = new System.Windows.Forms.ComboBox();
            this.CmbIdEmpleado = new System.Windows.Forms.ComboBox();
            this.CmbIdVehiculo = new System.Windows.Forms.ComboBox();
            this.BtRentar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtComentarios = new System.Windows.Forms.TextBox();
            this.TxtCantidadDias = new System.Windows.Forms.TextBox();
            this.TxtMontoXdia = new System.Windows.Forms.TextBox();
            this.TxtDeposito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.CmbIdCliente);
            this.panel1.Controls.Add(this.CmbIdEmpleado);
            this.panel1.Controls.Add(this.CmbIdVehiculo);
            this.panel1.Controls.Add(this.BtRentar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtComentarios);
            this.panel1.Controls.Add(this.TxtCantidadDias);
            this.panel1.Controls.Add(this.TxtMontoXdia);
            this.panel1.Controls.Add(this.TxtDeposito);
            this.panel1.Location = new System.Drawing.Point(41, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 219);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(535, 124);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // CmbIdCliente
            // 
            this.CmbIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIdCliente.FormattingEnabled = true;
            this.CmbIdCliente.Location = new System.Drawing.Point(215, 78);
            this.CmbIdCliente.Name = "CmbIdCliente";
            this.CmbIdCliente.Size = new System.Drawing.Size(178, 21);
            this.CmbIdCliente.TabIndex = 20;
            // 
            // CmbIdEmpleado
            // 
            this.CmbIdEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIdEmpleado.FormattingEnabled = true;
            this.CmbIdEmpleado.Location = new System.Drawing.Point(215, 48);
            this.CmbIdEmpleado.Name = "CmbIdEmpleado";
            this.CmbIdEmpleado.Size = new System.Drawing.Size(178, 21);
            this.CmbIdEmpleado.TabIndex = 19;
            // 
            // CmbIdVehiculo
            // 
            this.CmbIdVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIdVehiculo.FormattingEnabled = true;
            this.CmbIdVehiculo.Location = new System.Drawing.Point(215, 22);
            this.CmbIdVehiculo.Name = "CmbIdVehiculo";
            this.CmbIdVehiculo.Size = new System.Drawing.Size(178, 21);
            this.CmbIdVehiculo.TabIndex = 18;
            this.CmbIdVehiculo.SelectedIndexChanged += new System.EventHandler(this.CmbIdVehiculo_SelectedIndexChanged);
            this.CmbIdVehiculo.SelectionChangeCommitted += new System.EventHandler(this.CmbIdVehiculo_SelectionChangeCommitted);
            this.CmbIdVehiculo.Click += new System.EventHandler(this.CmbIdVehiculo_Click);
            // 
            // BtRentar
            // 
            this.BtRentar.Location = new System.Drawing.Point(629, 162);
            this.BtRentar.Name = "BtRentar";
            this.BtRentar.Size = new System.Drawing.Size(75, 42);
            this.BtRentar.TabIndex = 2;
            this.BtRentar.Text = "Rentar";
            this.BtRentar.UseVisualStyleBackColor = true;
            this.BtRentar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha de devolucion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Comentario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad de dias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monto por dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Deposito de renta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de renta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "No.Vehiculo";
            // 
            // TxtComentarios
            // 
            this.TxtComentarios.Location = new System.Drawing.Point(535, 91);
            this.TxtComentarios.Name = "TxtComentarios";
            this.TxtComentarios.Size = new System.Drawing.Size(178, 20);
            this.TxtComentarios.TabIndex = 7;
            // 
            // TxtCantidadDias
            // 
            this.TxtCantidadDias.Location = new System.Drawing.Point(535, 56);
            this.TxtCantidadDias.Name = "TxtCantidadDias";
            this.TxtCantidadDias.ReadOnly = true;
            this.TxtCantidadDias.Size = new System.Drawing.Size(85, 20);
            this.TxtCantidadDias.TabIndex = 6;
            // 
            // TxtMontoXdia
            // 
            this.TxtMontoXdia.Location = new System.Drawing.Point(535, 23);
            this.TxtMontoXdia.Name = "TxtMontoXdia";
            this.TxtMontoXdia.Size = new System.Drawing.Size(178, 20);
            this.TxtMontoXdia.TabIndex = 5;
            this.TxtMontoXdia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMontoXdia_KeyPress);
            // 
            // TxtDeposito
            // 
            this.TxtDeposito.Location = new System.Drawing.Point(215, 131);
            this.TxtDeposito.Name = "TxtDeposito";
            this.TxtDeposito.Size = new System.Drawing.Size(178, 20);
            this.TxtDeposito.TabIndex = 4;
            this.TxtDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDeposito_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Renta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgvVehiculos);
            this.panel2.Location = new System.Drawing.Point(41, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 280);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CmbMarca);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.BtBuscar);
            this.panel3.Location = new System.Drawing.Point(52, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 73);
            this.panel3.TabIndex = 21;
            // 
            // CmbMarca
            // 
            this.CmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Location = new System.Drawing.Point(110, 28);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(156, 21);
            this.CmbMarca.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Marca";
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(304, 17);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 40);
            this.BtBuscar.TabIndex = 0;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(16, 108);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.Size = new System.Drawing.Size(697, 169);
            this.dgvVehiculos.TabIndex = 0;
            // 
            // Rentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Rentar";
            this.Text = "Rentar";
            this.Load += new System.EventHandler(this.Rentar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtComentarios;
        private System.Windows.Forms.TextBox TxtCantidadDias;
        private System.Windows.Forms.TextBox TxtMontoXdia;
        private System.Windows.Forms.TextBox TxtDeposito;
        private System.Windows.Forms.ComboBox CmbIdCliente;
        private System.Windows.Forms.ComboBox CmbIdEmpleado;
        private System.Windows.Forms.ComboBox CmbIdVehiculo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button BtRentar;
    }
}