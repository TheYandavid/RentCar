namespace RentCar
{
    partial class Inspeccion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.BtBorrar = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdInspeccion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvInspeccion = new System.Windows.Forms.DataGridView();
            this.inspeccionVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSet = new RentCar.RentCarDataSet();
            this.inspeccionVTableAdapter = new RentCar.RentCarDataSetTableAdapters.InspeccionVTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInspeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtAgregar);
            this.panel1.Controls.Add(this.BtBorrar);
            this.panel1.Controls.Add(this.BtEditar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtIdInspeccion);
            this.panel1.Location = new System.Drawing.Point(38, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 70);
            this.panel1.TabIndex = 0;
            // 
            // BtAgregar
            // 
            this.BtAgregar.Location = new System.Drawing.Point(321, 26);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(143, 23);
            this.BtAgregar.TabIndex = 4;
            this.BtAgregar.Text = "Agregar Inspeccion";
            this.BtAgregar.UseVisualStyleBackColor = true;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // BtBorrar
            // 
            this.BtBorrar.Location = new System.Drawing.Point(598, 26);
            this.BtBorrar.Name = "BtBorrar";
            this.BtBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtBorrar.TabIndex = 3;
            this.BtBorrar.Text = "Borrar";
            this.BtBorrar.UseVisualStyleBackColor = true;
            this.BtBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // BtEditar
            // 
            this.BtEditar.Location = new System.Drawing.Point(487, 26);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(75, 23);
            this.BtEditar.TabIndex = 2;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID de inspeccion";
            // 
            // TxtIdInspeccion
            // 
            this.TxtIdInspeccion.Location = new System.Drawing.Point(149, 29);
            this.TxtIdInspeccion.Name = "TxtIdInspeccion";
            this.TxtIdInspeccion.Size = new System.Drawing.Size(100, 20);
            this.TxtIdInspeccion.TabIndex = 0;
            this.TxtIdInspeccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdInspeccion_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvInspeccion);
            this.panel2.Location = new System.Drawing.Point(12, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 286);
            this.panel2.TabIndex = 1;
            // 
            // DgvInspeccion
            // 
            this.DgvInspeccion.AllowUserToAddRows = false;
            this.DgvInspeccion.AllowUserToDeleteRows = false;
            this.DgvInspeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInspeccion.Location = new System.Drawing.Point(3, 4);
            this.DgvInspeccion.Name = "DgvInspeccion";
            this.DgvInspeccion.ReadOnly = true;
            this.DgvInspeccion.Size = new System.Drawing.Size(1054, 279);
            this.DgvInspeccion.TabIndex = 0;
            this.DgvInspeccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInspeccion_CellClick);
            // 
            // inspeccionVBindingSource
            // 
            this.inspeccionVBindingSource.DataMember = "InspeccionV";
            this.inspeccionVBindingSource.DataSource = this.rentCarDataSet;
            // 
            // rentCarDataSet
            // 
            this.rentCarDataSet.DataSetName = "RentCarDataSet";
            this.rentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inspeccionVTableAdapter
            // 
            this.inspeccionVTableAdapter.ClearBeforeFill = true;
            // 
            // Inspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Inspeccion";
            this.Text = "Inspeccion";
            this.Load += new System.EventHandler(this.Inspeccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInspeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdInspeccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtBorrar;
        private System.Windows.Forms.Button BtEditar;
        private RentCarDataSet rentCarDataSet;
        private System.Windows.Forms.BindingSource inspeccionVBindingSource;
        private RentCarDataSetTableAdapters.InspeccionVTableAdapter inspeccionVTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn roturaCristalDataGridViewImageColumn;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.DataGridView DgvInspeccion;
    }
}