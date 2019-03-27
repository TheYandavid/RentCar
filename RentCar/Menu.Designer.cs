namespace RentCar
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialRentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeInspeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteDeRentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.rentaToolStripMenuItem,
            this.inspeccionToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeVehiculosToolStripMenuItem,
            this.agregarVehiculoToolStripMenuItem,
            this.eliminarVehiculoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.clientesToolStripMenuItem.Text = "Vehiculos";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // listaDeVehiculosToolStripMenuItem
            // 
            this.listaDeVehiculosToolStripMenuItem.Name = "listaDeVehiculosToolStripMenuItem";
            this.listaDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listaDeVehiculosToolStripMenuItem.Text = "Lista de Vehiculos";
            this.listaDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.listaDeVehiculosToolStripMenuItem_Click);
            // 
            // agregarVehiculoToolStripMenuItem
            // 
            this.agregarVehiculoToolStripMenuItem.Name = "agregarVehiculoToolStripMenuItem";
            this.agregarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.agregarVehiculoToolStripMenuItem.Text = "Agregar Vehiculo";
            this.agregarVehiculoToolStripMenuItem.Click += new System.EventHandler(this.agregarVehiculoToolStripMenuItem_Click);
            // 
            // eliminarVehiculoToolStripMenuItem
            // 
            this.eliminarVehiculoToolStripMenuItem.Name = "eliminarVehiculoToolStripMenuItem";
            this.eliminarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.eliminarVehiculoToolStripMenuItem.Text = "Editar Vehiculo";
            this.eliminarVehiculoToolStripMenuItem.Click += new System.EventHandler(this.eliminarVehiculoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeClientesToolStripMenuItem,
            this.agregarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de clientes";
            this.listaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listaDeClientesToolStripMenuItem_Click);
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // rentaToolStripMenuItem
            // 
            this.rentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialRentasToolStripMenuItem,
            this.rentarToolStripMenuItem});
            this.rentaToolStripMenuItem.Name = "rentaToolStripMenuItem";
            this.rentaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.rentaToolStripMenuItem.Text = "Renta";
            // 
            // historialRentasToolStripMenuItem
            // 
            this.historialRentasToolStripMenuItem.Name = "historialRentasToolStripMenuItem";
            this.historialRentasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.historialRentasToolStripMenuItem.Text = "Historial rentas";
            this.historialRentasToolStripMenuItem.Click += new System.EventHandler(this.historialRentasToolStripMenuItem_Click);
            // 
            // rentarToolStripMenuItem
            // 
            this.rentarToolStripMenuItem.Name = "rentarToolStripMenuItem";
            this.rentarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.rentarToolStripMenuItem.Text = "Rentar";
            this.rentarToolStripMenuItem.Click += new System.EventHandler(this.rentarToolStripMenuItem_Click);
            // 
            // inspeccionToolStripMenuItem
            // 
            this.inspeccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeInspeccionToolStripMenuItem});
            this.inspeccionToolStripMenuItem.Name = "inspeccionToolStripMenuItem";
            this.inspeccionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.inspeccionToolStripMenuItem.Text = "Inspeccion";
            // 
            // listaDeInspeccionToolStripMenuItem
            // 
            this.listaDeInspeccionToolStripMenuItem.Name = "listaDeInspeccionToolStripMenuItem";
            this.listaDeInspeccionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.listaDeInspeccionToolStripMenuItem.Text = "Lista de inspeccion";
            this.listaDeInspeccionToolStripMenuItem.Click += new System.EventHandler(this.listaDeInspeccionToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteDeRentasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // generarReporteDeRentasToolStripMenuItem
            // 
            this.generarReporteDeRentasToolStripMenuItem.Name = "generarReporteDeRentasToolStripMenuItem";
            this.generarReporteDeRentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarReporteDeRentasToolStripMenuItem.Text = "Generar reporte";
            this.generarReporteDeRentasToolStripMenuItem.Click += new System.EventHandler(this.generarReporteDeRentasToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(788, 411);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialRentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeInspeccionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem rentarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteDeRentasToolStripMenuItem;
    }
}