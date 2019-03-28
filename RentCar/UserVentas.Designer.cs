namespace RentCar
{
    partial class UserVentas
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtRentar = new System.Windows.Forms.Button();
            this.btRegistCliente = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 388);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RentCar.Properties.Resources._5b0e65cf_8104_49f3_8256_bb3d8370b8bb;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 385);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.BtRentar);
            this.panel2.Controls.Add(this.btRegistCliente);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 385);
            this.panel2.TabIndex = 2;
            // 
            // BtRentar
            // 
            this.BtRentar.Location = new System.Drawing.Point(33, 65);
            this.BtRentar.Name = "BtRentar";
            this.BtRentar.Size = new System.Drawing.Size(142, 51);
            this.BtRentar.TabIndex = 0;
            this.BtRentar.Text = "Rentar";
            this.BtRentar.UseVisualStyleBackColor = true;
            this.BtRentar.Click += new System.EventHandler(this.BtRentar_Click_1);
            // 
            // btRegistCliente
            // 
            this.btRegistCliente.Location = new System.Drawing.Point(33, 208);
            this.btRegistCliente.Name = "btRegistCliente";
            this.btRegistCliente.Size = new System.Drawing.Size(142, 51);
            this.btRegistCliente.TabIndex = 1;
            this.btRegistCliente.Text = "Registrar Cliente";
            this.btRegistCliente.UseVisualStyleBackColor = true;
            // 
            // UserVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 384);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserVentas";
            this.Text = "UserVentas";
            this.Load += new System.EventHandler(this.UserVentas_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtRentar;
        private System.Windows.Forms.Button btRegistCliente;
    }
}