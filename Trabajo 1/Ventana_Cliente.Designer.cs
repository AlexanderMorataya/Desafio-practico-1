namespace Trabajo_1
{
    partial class Ventana_Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigoCliente = new System.Windows.Forms.TextBox();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbDireccion = new System.Windows.Forms.Label();
            this.LbTelefono = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.BtnConfirmarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnModificarCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIENDA DE COMPUTADORAS";
            // 
            // TxtCodigoCliente
            // 
            this.TxtCodigoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(165)))));
            this.TxtCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCliente.ForeColor = System.Drawing.Color.White;
            this.TxtCodigoCliente.Location = new System.Drawing.Point(69, 94);
            this.TxtCodigoCliente.Name = "TxtCodigoCliente";
            this.TxtCodigoCliente.Size = new System.Drawing.Size(174, 27);
            this.TxtCodigoCliente.TabIndex = 2;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(274, 93);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(144, 28);
            this.BtnBuscarCliente.TabIndex = 4;
            this.BtnBuscarCliente.Text = "Buscar cliente";
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LbDireccion);
            this.panel1.Controls.Add(this.LbTelefono);
            this.panel1.Controls.Add(this.LbEmail);
            this.panel1.Controls.Add(this.LbNombre);
            this.panel1.Controls.Add(this.LbCodigo);
            this.panel1.Location = new System.Drawing.Point(58, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 247);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telefono: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Direccion: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Codigo: ";
            // 
            // LbDireccion
            // 
            this.LbDireccion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDireccion.ForeColor = System.Drawing.Color.Black;
            this.LbDireccion.Location = new System.Drawing.Point(114, 94);
            this.LbDireccion.Name = "LbDireccion";
            this.LbDireccion.Size = new System.Drawing.Size(597, 19);
            this.LbDireccion.TabIndex = 17;
            // 
            // LbTelefono
            // 
            this.LbTelefono.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTelefono.ForeColor = System.Drawing.Color.Black;
            this.LbTelefono.Location = new System.Drawing.Point(118, 133);
            this.LbTelefono.Name = "LbTelefono";
            this.LbTelefono.Size = new System.Drawing.Size(593, 19);
            this.LbTelefono.TabIndex = 15;
            // 
            // LbEmail
            // 
            this.LbEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.ForeColor = System.Drawing.Color.Black;
            this.LbEmail.Location = new System.Drawing.Point(114, 169);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(597, 19);
            this.LbEmail.TabIndex = 14;
            // 
            // LbNombre
            // 
            this.LbNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.ForeColor = System.Drawing.Color.Black;
            this.LbNombre.Location = new System.Drawing.Point(114, 58);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(597, 19);
            this.LbNombre.TabIndex = 13;
            // 
            // LbCodigo
            // 
            this.LbCodigo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCodigo.ForeColor = System.Drawing.Color.Black;
            this.LbCodigo.Location = new System.Drawing.Point(114, 22);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(597, 19);
            this.LbCodigo.TabIndex = 12;
            // 
            // BtnConfirmarCliente
            // 
            this.BtnConfirmarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(248)))));
            this.BtnConfirmarCliente.FlatAppearance.BorderSize = 0;
            this.BtnConfirmarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnConfirmarCliente.Location = new System.Drawing.Point(519, 403);
            this.BtnConfirmarCliente.Name = "BtnConfirmarCliente";
            this.BtnConfirmarCliente.Size = new System.Drawing.Size(146, 26);
            this.BtnConfirmarCliente.TabIndex = 10;
            this.BtnConfirmarCliente.Text = "Confirmar informacion";
            this.BtnConfirmarCliente.UseVisualStyleBackColor = false;
            this.BtnConfirmarCliente.Click += new System.EventHandler(this.BtnConfirmarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ofertas del 50% por compras de mas de 5 productos de $20";
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(248)))));
            this.BtnModificarCliente.FlatAppearance.BorderSize = 0;
            this.BtnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarCliente.Location = new System.Drawing.Point(671, 403);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Size = new System.Drawing.Size(119, 26);
            this.BtnModificarCliente.TabIndex = 11;
            this.BtnModificarCliente.Text = "Modificar";
            this.BtnModificarCliente.UseVisualStyleBackColor = false;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // Ventana_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(850, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.TxtCodigoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfirmarCliente);
            this.Controls.Add(this.BtnModificarCliente);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Ventana_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana_Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana_Cliente_FormClosed);
            this.Load += new System.EventHandler(this.Ventana_Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigoCliente;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnConfirmarCliente;
        private System.Windows.Forms.Label LbDireccion;
        private System.Windows.Forms.Label LbTelefono;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbCodigo;
        private System.Windows.Forms.Button BtnModificarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}