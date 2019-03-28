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
            this.BtGenerarReport = new System.Windows.Forms.Button();
            this.BtReporteRenta = new System.Windows.Forms.Button();
            this.DtRenta = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.DtRenta);
            this.panel1.Controls.Add(this.BtGenerarReport);
            this.panel1.Controls.Add(this.BtReporteRenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 370);
            this.panel1.TabIndex = 0;
            // 
            // BtGenerarReport
            // 
            this.BtGenerarReport.Location = new System.Drawing.Point(339, 58);
            this.BtGenerarReport.Name = "BtGenerarReport";
            this.BtGenerarReport.Size = new System.Drawing.Size(149, 52);
            this.BtGenerarReport.TabIndex = 1;
            this.BtGenerarReport.Text = "Generar Reporte";
            this.BtGenerarReport.UseVisualStyleBackColor = true;
            this.BtGenerarReport.Click += new System.EventHandler(this.BtGenerarReport_Click);
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
            // DtRenta
            // 
            this.DtRenta.AllowUserToAddRows = false;
            this.DtRenta.AllowUserToDeleteRows = false;
            this.DtRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtRenta.Location = new System.Drawing.Point(82, 171);
            this.DtRenta.Name = "DtRenta";
            this.DtRenta.ReadOnly = true;
            this.DtRenta.Size = new System.Drawing.Size(589, 150);
            this.DtRenta.TabIndex = 2;
            // 
            // Generar_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 370);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generar_Reporte";
            this.Text = "Generar_Reporte";
            this.Load += new System.EventHandler(this.Generar_Reporte_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Generar_Reporte_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtRenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtReporteRenta;
        private System.Windows.Forms.Button BtGenerarReport;
        private System.Windows.Forms.DataGridView DtRenta;
    }
}