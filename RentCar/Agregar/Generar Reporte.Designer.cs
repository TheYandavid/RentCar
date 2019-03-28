namespace RentCar.Agregar
{
    partial class Generar_Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generar_Reporte));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtReporteRenta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtGenerarReport = new System.Windows.Forms.Button();
            this.DtRenta = new System.Windows.Forms.DataGridView();
            this.BtSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.BtSalir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtReporteRenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 370);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // BtReporteRenta
            // 
            this.BtReporteRenta.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtReporteRenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReporteRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtReporteRenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtReporteRenta.Location = new System.Drawing.Point(12, 141);
            this.BtReporteRenta.Name = "BtReporteRenta";
            this.BtReporteRenta.Size = new System.Drawing.Size(128, 74);
            this.BtReporteRenta.TabIndex = 0;
            this.BtReporteRenta.Text = "Reporte de Rentas";
            this.BtReporteRenta.UseVisualStyleBackColor = true;
            this.BtReporteRenta.Click += new System.EventHandler(this.BtReporteRenta_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.DtRenta);
            this.panel2.Controls.Add(this.BtGenerarReport);
            this.panel2.Location = new System.Drawing.Point(310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 370);
            this.panel2.TabIndex = 3;
            // 
            // BtGenerarReport
            // 
            this.BtGenerarReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtGenerarReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGenerarReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGenerarReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtGenerarReport.Location = new System.Drawing.Point(35, 33);
            this.BtGenerarReport.Name = "BtGenerarReport";
            this.BtGenerarReport.Size = new System.Drawing.Size(149, 52);
            this.BtGenerarReport.TabIndex = 1;
            this.BtGenerarReport.Text = "Generar Reporte";
            this.BtGenerarReport.UseVisualStyleBackColor = true;
            this.BtGenerarReport.Click += new System.EventHandler(this.BtGenerarReport_Click);
            // 
            // DtRenta
            // 
            this.DtRenta.AllowUserToAddRows = false;
            this.DtRenta.AllowUserToDeleteRows = false;
            this.DtRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtRenta.Location = new System.Drawing.Point(25, 119);
            this.DtRenta.Name = "DtRenta";
            this.DtRenta.ReadOnly = true;
            this.DtRenta.Size = new System.Drawing.Size(639, 150);
            this.DtRenta.TabIndex = 2;
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(48, 335);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(64, 23);
            this.BtSalir.TabIndex = 1;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // Generar_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 370);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generar_Reporte";
            this.Text = "Generar_Reporte";
            this.Load += new System.EventHandler(this.Generar_Reporte_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Generar_Reporte_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtRenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtReporteRenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DtRenta;
        private System.Windows.Forms.Button BtGenerarReport;
        private System.Windows.Forms.Button BtSalir;
    }
}