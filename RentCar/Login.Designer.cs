namespace RentCar
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtIngresarLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtIDLogin = new System.Windows.Forms.TextBox();
            this.TxtCedulaLogin = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtIngresarLogin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TxtIDLogin);
            this.panel1.Controls.Add(this.TxtCedulaLogin);
            this.panel1.Location = new System.Drawing.Point(79, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 284);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Empleado";
            // 
            // BtIngresarLogin
            // 
            this.BtIngresarLogin.Location = new System.Drawing.Point(90, 226);
            this.BtIngresarLogin.Name = "BtIngresarLogin";
            this.BtIngresarLogin.Size = new System.Drawing.Size(122, 42);
            this.BtIngresarLogin.TabIndex = 7;
            this.BtIngresarLogin.Text = "Ingresar";
            this.BtIngresarLogin.UseVisualStyleBackColor = true;
            this.BtIngresarLogin.Click += new System.EventHandler(this.BtIngresarLogin_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(101, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 97);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtIDLogin
            // 
            this.TxtIDLogin.Location = new System.Drawing.Point(90, 109);
            this.TxtIDLogin.Name = "TxtIDLogin";
            this.TxtIDLogin.Size = new System.Drawing.Size(153, 20);
            this.TxtIDLogin.TabIndex = 4;
            this.TxtIDLogin.TextChanged += new System.EventHandler(this.TxtIDLogin_TextChanged);
            this.TxtIDLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIDLogin_KeyPress);
            // 
            // TxtCedulaLogin
            // 
            this.TxtCedulaLogin.Location = new System.Drawing.Point(90, 151);
            this.TxtCedulaLogin.Name = "TxtCedulaLogin";
            this.TxtCedulaLogin.Size = new System.Drawing.Size(153, 20);
            this.TxtCedulaLogin.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 21);
            this.button2.TabIndex = 13;
            this.button2.Text = "Registrarse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registrar empleado requiere contraseña del administrador";
            // 
            // BtSalir
            // 
            this.BtSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSalir.BackgroundImage")));
            this.BtSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSalir.Location = new System.Drawing.Point(417, 2);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(42, 34);
            this.BtSalir.TabIndex = 15;
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 357);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtIngresarLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtIDLogin;
        private System.Windows.Forms.TextBox TxtCedulaLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtSalir;
    }
}