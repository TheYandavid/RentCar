namespace RentCar
{
    partial class EditarVehiculos
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
            this.components = new System.ComponentModel.Container();
            this.vehiculosTableAdapter = new RentCar.RentCarDataSetTableAdapters.VehiculosTableAdapter();
            this.Eliminar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.vehiculosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSet1 = new RentCar.RentCarDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvEditVehiculos = new System.Windows.Forms.DataGridView();
            this.Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEditVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(632, 63);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 3;
            this.Eliminar.Text = "Borrar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(319, 63);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 4;
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // vehiculosBindingSource1
            // 
            this.vehiculosBindingSource1.DataMember = "Vehiculos";
            this.vehiculosBindingSource1.DataSource = this.rentCarDataSet1;
            // 
            // rentCarDataSet1
            // 
            this.rentCarDataSet1.DataSetName = "RentCarDataSet";
            this.rentCarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Vehiculo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvEditVehiculos);
            this.panel1.Location = new System.Drawing.Point(13, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 258);
            this.panel1.TabIndex = 24;
            // 
            // DgvEditVehiculos
            // 
            this.DgvEditVehiculos.AllowUserToAddRows = false;
            this.DgvEditVehiculos.AllowUserToDeleteRows = false;
            this.DgvEditVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEditVehiculos.Location = new System.Drawing.Point(4, 4);
            this.DgvEditVehiculos.Name = "DgvEditVehiculos";
            this.DgvEditVehiculos.ReadOnly = true;
            this.DgvEditVehiculos.Size = new System.Drawing.Size(971, 254);
            this.DgvEditVehiculos.TabIndex = 0;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(449, 61);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(143, 23);
            this.Actualizar.TabIndex = 2;
            this.Actualizar.Text = "Editar Vehiculos";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // EditarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Actualizar);
            this.Name = "EditarVehiculos";
            this.Text = "EditarVehiculos";
            this.Load += new System.EventHandler(this.EditarVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEditVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RentCarDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TextBox TxtId;
        private RentCarDataSet rentCarDataSet1;
        private System.Windows.Forms.BindingSource vehiculosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChasisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noMotorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPlacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvEditVehiculos;
        private System.Windows.Forms.Button Actualizar;
    }
}