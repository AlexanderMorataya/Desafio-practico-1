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
            this.LbDireccion = new System.Windows.Forms.Label();
            this.LbNombreContacto = new System.Windows.Forms.Label();
            this.LbTelefono = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.BtnModificarCliente = new System.Windows.Forms.Button();
            this.BtnConfirmarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.LbDireccion);
            this.panel1.Controls.Add(this.LbNombreContacto);
            this.panel1.Controls.Add(this.LbTelefono);
            this.panel1.Controls.Add(this.LbEmail);
            this.panel1.Controls.Add(this.LbNombre);
            this.panel1.Controls.Add(this.LbCodigo);
            this.panel1.Controls.Add(this.BtnModificarCliente);
            this.panel1.Controls.Add(this.BtnConfirmarCliente);
            this.panel1.Location = new System.Drawing.Point(58, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 281);
            this.panel1.TabIndex = 5;
            // 
            // LbDireccion
            // 
            this.LbDireccion.AutoSize = true;
            this.LbDireccion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDireccion.Location = new System.Drawing.Point(35, 94);
            this.LbDireccion.Name = "LbDireccion";
            this.LbDireccion.Size = new System.Drawing.Size(64, 19);
            this.LbDireccion.TabIndex = 17;
            this.LbDireccion.Text = "Direccion: ";
            // 
            // LbNombreContacto
            // 
            this.LbNombreContacto.AutoSize = true;
            this.LbNombreContacto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombreContacto.Location = new System.Drawing.Point(35, 130);
            this.LbNombreContacto.Name = "LbNombreContacto";
            this.LbNombreContacto.Size = new System.Drawing.Size(62, 19);
            this.LbNombreContacto.TabIndex = 16;
            this.LbNombreContacto.Text = "Contacto: ";
            // 
            // LbTelefono
            // 
            this.LbTelefono.AutoSize = true;
            this.LbTelefono.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTelefono.Location = new System.Drawing.Point(35, 169);
            this.LbTelefono.Name = "LbTelefono";
            this.LbTelefono.Size = new System.Drawing.Size(59, 19);
            this.LbTelefono.TabIndex = 15;
            this.LbTelefono.Text = "Telefono: ";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Location = new System.Drawing.Point(35, 205);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(45, 19);
            this.LbEmail.TabIndex = 14;
            this.LbEmail.Text = "Email: ";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.Location = new System.Drawing.Point(35, 58);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(55, 19);
            this.LbNombre.TabIndex = 13;
            this.LbNombre.Text = "Nombre: ";
            // 
            // LbCodigo
            // 
            this.LbCodigo.AutoSize = true;
            this.LbCodigo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCodigo.Location = new System.Drawing.Point(35, 22);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(49, 19);
            this.LbCodigo.TabIndex = 12;
            this.LbCodigo.Text = "Codigo: ";
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(248)))));
            this.BtnModificarCliente.FlatAppearance.BorderSize = 0;
            this.BtnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarCliente.Location = new System.Drawing.Point(623, 243);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Size = new System.Drawing.Size(102, 26);
            this.BtnModificarCliente.TabIndex = 11;
            this.BtnModificarCliente.Text = "Modificar";
            this.BtnModificarCliente.UseVisualStyleBackColor = false;
            // 
            // BtnConfirmarCliente
            // 
            this.BtnConfirmarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(248)))));
            this.BtnConfirmarCliente.FlatAppearance.BorderSize = 0;
            this.BtnConfirmarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnConfirmarCliente.Location = new System.Drawing.Point(480, 243);
            this.BtnConfirmarCliente.Name = "BtnConfirmarCliente";
            this.BtnConfirmarCliente.Size = new System.Drawing.Size(137, 26);
            this.BtnConfirmarCliente.TabIndex = 10;
            this.BtnConfirmarCliente.Text = "Confirmar informacion";
            this.BtnConfirmarCliente.UseVisualStyleBackColor = false;
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
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Ventana_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana_Cliente";
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
        private System.Windows.Forms.Button BtnModificarCliente;
        private System.Windows.Forms.Button BtnConfirmarCliente;
        private System.Windows.Forms.Label LbDireccion;
        private System.Windows.Forms.Label LbNombreContacto;
        private System.Windows.Forms.Label LbTelefono;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbCodigo;
    }
}