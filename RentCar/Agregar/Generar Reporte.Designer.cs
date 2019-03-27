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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtReporteRenta = new System.Windows.Forms.Button();
            this.BtGenerarReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.BtGenerarReport);
            this.panel1.Controls.Add(this.BtReporteRenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 370);
            this.panel1.TabIndex = 0;
            // 
            // BtReporteRenta
            // 
            this.BtReporteRenta.Location = new System.Drawing.Point(12, 106);
            this.BtReporteRenta.Name = "BtReporteRenta";
            this.BtReporteRenta.Size = new System.Drawing.Size(114, 23);
            this.BtReporteRenta.TabIndex = 0;
            this.BtReporteRenta.Text = "Reporte de Rentas";
            this.BtReporteRenta.UseVisualStyleBackColor = true;
            this.BtReporteRenta.Click += new System.EventHandler(this.BtReporteRenta_Click);
            // 
            // BtGenerarReport
            // 
            this.BtGenerarReport.Location = new System.Drawing.Point(257, 91);
            this.BtGenerarReport.Name = "BtGenerarReport";
            this.BtGenerarReport.Size = new System.Drawing.Size(149, 52);
            this.BtGenerarReport.TabIndex = 1;
            this.BtGenerarReport.Text = "Generar Reporte";
            this.BtGenerarReport.UseVisualStyleBackColor = true;
            this.BtGenerarReport.Click += new System.EventHandler(this.BtGenerarReport_Click);
            // 
            // Generar_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 370);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generar_Reporte";
            this.Text = "Generar_Reporte";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Generar_Reporte_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtReporteRenta;
        private System.Windows.Forms.Button BtGenerarReport;
    }
}