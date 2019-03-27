namespace RentCar
{
    partial class Passadmin
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
            this.TxtPassAdm = new System.Windows.Forms.TextBox();
            this.Btpass = new System.Windows.Forms.Button();
            this.BtPassAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPassAdm
            // 
            this.TxtPassAdm.Location = new System.Drawing.Point(22, 22);
            this.TxtPassAdm.Name = "TxtPassAdm";
            this.TxtPassAdm.Size = new System.Drawing.Size(177, 20);
            this.TxtPassAdm.TabIndex = 0;
            this.TxtPassAdm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassAdm_KeyPress);
            // 
            // Btpass
            // 
            this.Btpass.Location = new System.Drawing.Point(22, 48);
            this.Btpass.Name = "Btpass";
            this.Btpass.Size = new System.Drawing.Size(75, 23);
            this.Btpass.TabIndex = 1;
            this.Btpass.Text = "Ingresar";
            this.Btpass.UseVisualStyleBackColor = true;
            this.Btpass.Click += new System.EventHandler(this.Btpass_Click);
            // 
            // BtPassAdm
            // 
            this.BtPassAdm.Location = new System.Drawing.Point(124, 48);
            this.BtPassAdm.Name = "BtPassAdm";
            this.BtPassAdm.Size = new System.Drawing.Size(75, 23);
            this.BtPassAdm.TabIndex = 2;
            this.BtPassAdm.Text = "Cancelar";
            this.BtPassAdm.UseVisualStyleBackColor = true;
            this.BtPassAdm.Click += new System.EventHandler(this.BtPassAdm_Click);
            // 
            // Passadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 75);
            this.ControlBox = false;
            this.Controls.Add(this.BtPassAdm);
            this.Controls.Add(this.Btpass);
            this.Controls.Add(this.TxtPassAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Passadmin";
            this.Text = "Passadmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPassAdm;
        private System.Windows.Forms.Button Btpass;
        private System.Windows.Forms.Button BtPassAdm;
    }
}