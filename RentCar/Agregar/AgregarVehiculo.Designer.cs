namespace RentCar
{
    partial class AgregarVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarVehiculo));
            this.TxtNuChasis = new System.Windows.Forms.TextBox();
            this.TxtNuMotor = new System.Windows.Forms.TextBox();
            this.TxtDescVehiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelTipoVehiculo = new System.Windows.Forms.Label();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.CmbModelo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbTipoCombustible = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtSalir = new System.Windows.Forms.Button();
            this.TxtTipoVehiculo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNuChasis
            // 
            this.TxtNuChasis.Location = new System.Drawing.Point(165, 205);
            this.TxtNuChasis.Name = "TxtNuChasis";
            this.TxtNuChasis.Size = new System.Drawing.Size(273, 20);
            this.TxtNuChasis.TabIndex = 7;
            this.TxtNuChasis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNuChasis_KeyPress);
            // 
            // TxtNuMotor
            // 
            this.TxtNuMotor.Location = new System.Drawing.Point(165, 241);
            this.TxtNuMotor.Name = "TxtNuMotor";
            this.TxtNuMotor.Size = new System.Drawing.Size(273, 20);
            this.TxtNuMotor.TabIndex = 8;
            this.TxtNuMotor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNuMotor_KeyPress);
            // 
            // TxtDescVehiculo
            // 
            this.TxtDescVehiculo.Location = new System.Drawing.Point(165, 301);
            this.TxtDescVehiculo.Name = "TxtDescVehiculo";
            this.TxtDescVehiculo.Size = new System.Drawing.Size(273, 20);
            this.TxtDescVehiculo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo de combustible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "No.chasis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "No.Motor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Descripcion del Vehiculo";
            // 
            // LabelTipoVehiculo
            // 
            this.LabelTipoVehiculo.AutoSize = true;
            this.LabelTipoVehiculo.Location = new System.Drawing.Point(35, 109);
            this.LabelTipoVehiculo.Name = "LabelTipoVehiculo";
            this.LabelTipoVehiculo.Size = new System.Drawing.Size(87, 13);
            this.LabelTipoVehiculo.TabIndex = 18;
            this.LabelTipoVehiculo.Text = "Tipo de Vehiculo";
            // 
            // BtAgregar
            // 
            this.BtAgregar.Location = new System.Drawing.Point(363, 344);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(75, 42);
            this.BtAgregar.TabIndex = 19;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = true;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(165, 275);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(273, 20);
            this.TxtPlaca.TabIndex = 20;
            this.TxtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlaca_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "No.Placa";
            // 
            // CmbMarca
            // 
            this.CmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Location = new System.Drawing.Point(165, 63);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(140, 21);
            this.CmbMarca.TabIndex = 22;
            this.CmbMarca.SelectionChangeCommitted += new System.EventHandler(this.CmbMarca_SelectionChangeCommitted);
            // 
            // CmbModelo
            // 
            this.CmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModelo.FormattingEnabled = true;
            this.CmbModelo.Location = new System.Drawing.Point(165, 136);
            this.CmbModelo.Name = "CmbModelo";
            this.CmbModelo.Size = new System.Drawing.Size(140, 21);
            this.CmbModelo.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 21);
            this.button1.TabIndex = 24;
            this.button1.Text = "Agregar Marca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbTipoCombustible
            // 
            this.CmbTipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoCombustible.FormattingEnabled = true;
            this.CmbTipoCombustible.Items.AddRange(new object[] {
            "Gasolina",
            "Gas"});
            this.CmbTipoCombustible.Location = new System.Drawing.Point(165, 178);
            this.CmbTipoCombustible.Name = "CmbTipoCombustible";
            this.CmbTipoCombustible.Size = new System.Drawing.Size(140, 21);
            this.CmbTipoCombustible.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 38);
            this.panel1.TabIndex = 27;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // BtSalir
            // 
            this.BtSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSalir.BackgroundImage")));
            this.BtSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSalir.Location = new System.Drawing.Point(508, 3);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(52, 35);
            this.BtSalir.TabIndex = 6;
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // TxtTipoVehiculo
            // 
            this.TxtTipoVehiculo.Location = new System.Drawing.Point(165, 102);
            this.TxtTipoVehiculo.Name = "TxtTipoVehiculo";
            this.TxtTipoVehiculo.Size = new System.Drawing.Size(273, 20);
            this.TxtTipoVehiculo.TabIndex = 9;
            // 
            // AgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CmbTipoCombustible);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbModelo);
            this.Controls.Add(this.CmbMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.BtAgregar);
            this.Controls.Add(this.LabelTipoVehiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescVehiculo);
            this.Controls.Add(this.TxtTipoVehiculo);
            this.Controls.Add(this.TxtNuMotor);
            this.Controls.Add(this.TxtNuChasis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarVehiculo";
            this.Text = "AgregarVehiculo";
            this.Load += new System.EventHandler(this.AgregarVehiculo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNuChasis;
        private System.Windows.Forms.TextBox TxtNuMotor;
        private System.Windows.Forms.TextBox TxtDescVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelTipoVehiculo;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.ComboBox CmbModelo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbTipoCombustible;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.TextBox TxtTipoVehiculo;
    }
}