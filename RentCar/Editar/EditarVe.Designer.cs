namespace RentCar
{
    partial class EditarVe
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
            this.BtSalir = new System.Windows.Forms.Button();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.Bteditar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbTipoCombustible = new System.Windows.Forms.ComboBox();
            this.CmbModelo = new System.Windows.Forms.ComboBox();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.LabelTipoVehiculo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescVehiculo = new System.Windows.Forms.TextBox();
            this.TxtTipoVehiculo = new System.Windows.Forms.TextBox();
            this.TxtNuMotor = new System.Windows.Forms.TextBox();
            this.TxtNuChasis = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtSalir);
            this.panel1.Controls.Add(this.cmbID);
            this.panel1.Controls.Add(this.Bteditar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CmbTipoCombustible);
            this.panel1.Controls.Add(this.CmbModelo);
            this.panel1.Controls.Add(this.CmbMarca);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtPlaca);
            this.panel1.Controls.Add(this.LabelTipoVehiculo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtDescVehiculo);
            this.panel1.Controls.Add(this.TxtTipoVehiculo);
            this.panel1.Controls.Add(this.TxtNuMotor);
            this.panel1.Controls.Add(this.TxtNuChasis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 572);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(486, 441);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(75, 42);
            this.BtSalir.TabIndex = 46;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // cmbID
            // 
            this.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(146, 40);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(140, 21);
            this.cmbID.TabIndex = 45;
            this.cmbID.SelectionChangeCommitted += new System.EventHandler(this.cmbID_SelectionChangeCommitted);
            // 
            // Bteditar
            // 
            this.Bteditar.Location = new System.Drawing.Point(404, 441);
            this.Bteditar.Name = "Bteditar";
            this.Bteditar.Size = new System.Drawing.Size(75, 42);
            this.Bteditar.TabIndex = 38;
            this.Bteditar.Text = "Editar";
            this.Bteditar.UseVisualStyleBackColor = true;
            this.Bteditar.Click += new System.EventHandler(this.Bteditar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "ID Vehiculo";
            // 
            // CmbTipoCombustible
            // 
            this.CmbTipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoCombustible.FormattingEnabled = true;
            this.CmbTipoCombustible.Items.AddRange(new object[] {
            "Gasolina",
            "Gas"});
            this.CmbTipoCombustible.Location = new System.Drawing.Point(146, 224);
            this.CmbTipoCombustible.Name = "CmbTipoCombustible";
            this.CmbTipoCombustible.Size = new System.Drawing.Size(140, 21);
            this.CmbTipoCombustible.TabIndex = 43;
            // 
            // CmbModelo
            // 
            this.CmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModelo.FormattingEnabled = true;
            this.CmbModelo.Location = new System.Drawing.Point(146, 177);
            this.CmbModelo.Name = "CmbModelo";
            this.CmbModelo.Size = new System.Drawing.Size(140, 21);
            this.CmbModelo.TabIndex = 42;
            // 
            // CmbMarca
            // 
            this.CmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Location = new System.Drawing.Point(146, 93);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(140, 21);
            this.CmbMarca.TabIndex = 41;
            this.CmbMarca.SelectionChangeCommitted += new System.EventHandler(this.CmbMarca_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "No.Placa";
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(146, 348);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(273, 20);
            this.TxtPlaca.TabIndex = 39;
            // 
            // LabelTipoVehiculo
            // 
            this.LabelTipoVehiculo.AutoSize = true;
            this.LabelTipoVehiculo.Location = new System.Drawing.Point(38, 144);
            this.LabelTipoVehiculo.Name = "LabelTipoVehiculo";
            this.LabelTipoVehiculo.Size = new System.Drawing.Size(87, 13);
            this.LabelTipoVehiculo.TabIndex = 37;
            this.LabelTipoVehiculo.Text = "Tipo de Vehiculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Descripcion del Vehiculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "No.Motor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "No.chasis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tipo de combustible";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Modelo";
            // 
            // TxtDescVehiculo
            // 
            this.TxtDescVehiculo.Location = new System.Drawing.Point(146, 383);
            this.TxtDescVehiculo.Name = "TxtDescVehiculo";
            this.TxtDescVehiculo.Size = new System.Drawing.Size(273, 20);
            this.TxtDescVehiculo.TabIndex = 30;
            // 
            // TxtTipoVehiculo
            // 
            this.TxtTipoVehiculo.Location = new System.Drawing.Point(146, 137);
            this.TxtTipoVehiculo.Name = "TxtTipoVehiculo";
            this.TxtTipoVehiculo.Size = new System.Drawing.Size(273, 20);
            this.TxtTipoVehiculo.TabIndex = 29;
            // 
            // TxtNuMotor
            // 
            this.TxtNuMotor.Location = new System.Drawing.Point(146, 306);
            this.TxtNuMotor.Name = "TxtNuMotor";
            this.TxtNuMotor.Size = new System.Drawing.Size(273, 20);
            this.TxtNuMotor.TabIndex = 28;
            // 
            // TxtNuChasis
            // 
            this.TxtNuChasis.Location = new System.Drawing.Point(146, 264);
            this.TxtNuChasis.Name = "TxtNuChasis";
            this.TxtNuChasis.Size = new System.Drawing.Size(273, 20);
            this.TxtNuChasis.TabIndex = 27;
            // 
            // EditarVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarVe";
            this.Text = "EditarVe";
            this.Load += new System.EventHandler(this.EditarVe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbTipoCombustible;
        private System.Windows.Forms.ComboBox CmbModelo;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Button Bteditar;
        private System.Windows.Forms.Label LabelTipoVehiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescVehiculo;
        private System.Windows.Forms.TextBox TxtTipoVehiculo;
        private System.Windows.Forms.TextBox TxtNuMotor;
        private System.Windows.Forms.TextBox TxtNuChasis;
        private System.Windows.Forms.Button BtSalir;
    }
}