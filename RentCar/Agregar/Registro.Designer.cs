namespace RentCar
{
    partial class Registro
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTargetaNum = new System.Windows.Forms.TextBox();
            this.TxtLimiteCredito = new System.Windows.Forms.TextBox();
            this.Rbfisica = new System.Windows.Forms.RadioButton();
            this.Rbjuridica = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtRegistrar = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.LbId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(95, 55);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(228, 20);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(95, 94);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(228, 20);
            this.TxtCedula.TabIndex = 1;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(95, 136);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(228, 20);
            this.TxtDireccion.TabIndex = 2;
            // 
            // TxtTargetaNum
            // 
            this.TxtTargetaNum.Location = new System.Drawing.Point(142, 175);
            this.TxtTargetaNum.Name = "TxtTargetaNum";
            this.TxtTargetaNum.Size = new System.Drawing.Size(181, 20);
            this.TxtTargetaNum.TabIndex = 3;
            this.TxtTargetaNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTargetaNum_KeyPress);
            // 
            // TxtLimiteCredito
            // 
            this.TxtLimiteCredito.Location = new System.Drawing.Point(104, 214);
            this.TxtLimiteCredito.Name = "TxtLimiteCredito";
            this.TxtLimiteCredito.Size = new System.Drawing.Size(219, 20);
            this.TxtLimiteCredito.TabIndex = 4;
            this.TxtLimiteCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLimiteCredito_KeyPress);
            // 
            // Rbfisica
            // 
            this.Rbfisica.AutoSize = true;
            this.Rbfisica.Location = new System.Drawing.Point(153, 260);
            this.Rbfisica.Name = "Rbfisica";
            this.Rbfisica.Size = new System.Drawing.Size(52, 17);
            this.Rbfisica.TabIndex = 5;
            this.Rbfisica.TabStop = true;
            this.Rbfisica.Text = "Fisica";
            this.Rbfisica.UseVisualStyleBackColor = true;
            // 
            // Rbjuridica
            // 
            this.Rbjuridica.AutoSize = true;
            this.Rbjuridica.Location = new System.Drawing.Point(153, 295);
            this.Rbjuridica.Name = "Rbjuridica";
            this.Rbjuridica.Size = new System.Drawing.Size(61, 17);
            this.Rbjuridica.TabIndex = 6;
            this.Rbjuridica.TabStop = true;
            this.Rbjuridica.Text = "Juridica";
            this.Rbjuridica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "No.Targeta de crediro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Limpite de Credito";
            // 
            // BtRegistrar
            // 
            this.BtRegistrar.Location = new System.Drawing.Point(189, 394);
            this.BtRegistrar.Name = "BtRegistrar";
            this.BtRegistrar.Size = new System.Drawing.Size(153, 44);
            this.BtRegistrar.TabIndex = 12;
            this.BtRegistrar.Text = "Registrarse";
            this.BtRegistrar.UseVisualStyleBackColor = true;
            this.BtRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click);
            // 
            // BtEditar
            // 
            this.BtEditar.Location = new System.Drawing.Point(15, 394);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(149, 44);
            this.BtEditar.TabIndex = 13;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // cmbId
            // 
            this.cmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(95, 20);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(121, 21);
            this.cmbId.TabIndex = 14;
            this.cmbId.SelectionChangeCommitted += new System.EventHandler(this.cmbId_SelectionChangeCommitted);
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.Location = new System.Drawing.Point(6, 28);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(83, 13);
            this.LbId.TabIndex = 15;
            this.LbId.Text = "ID de Empleado";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.LbId);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.BtEditar);
            this.Controls.Add(this.BtRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rbjuridica);
            this.Controls.Add(this.Rbfisica);
            this.Controls.Add(this.TxtLimiteCredito);
            this.Controls.Add(this.TxtTargetaNum);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtNombre);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTargetaNum;
        private System.Windows.Forms.TextBox TxtLimiteCredito;
        private System.Windows.Forms.RadioButton Rbfisica;
        private System.Windows.Forms.RadioButton Rbjuridica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BtEditar;
        public System.Windows.Forms.Button BtRegistrar;
        public System.Windows.Forms.ComboBox cmbId;
        public System.Windows.Forms.Label LbId;
    }
}