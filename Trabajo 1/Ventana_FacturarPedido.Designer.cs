namespace Trabajo_1
{
    partial class Ventana_FacturarPedido
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
            this.BtnCompletarPedido = new System.Windows.Forms.Button();
            this.BtnEliminarPedido = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbPagoTotal = new System.Windows.Forms.Label();
            this.LbIva = new System.Windows.Forms.Label();
            this.LbSumaTotal = new System.Windows.Forms.Label();
            this.DgvProductosOrdenados = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbDireccion = new System.Windows.Forms.Label();
            this.LbContactoCliente = new System.Windows.Forms.Label();
            this.LbTelefono = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbNombreCliente = new System.Windows.Forms.Label();
            this.LbCodigoCliente = new System.Windows.Forms.Label();
            this.TxtEfectivo = new System.Windows.Forms.TextBox();
            this.TxtCambio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosOrdenados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCompletarPedido
            // 
            this.BtnCompletarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnCompletarPedido.FlatAppearance.BorderSize = 0;
            this.BtnCompletarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompletarPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompletarPedido.Location = new System.Drawing.Point(636, 409);
            this.BtnCompletarPedido.Name = "BtnCompletarPedido";
            this.BtnCompletarPedido.Size = new System.Drawing.Size(137, 28);
            this.BtnCompletarPedido.TabIndex = 37;
            this.BtnCompletarPedido.Text = "Completar pedido";
            this.BtnCompletarPedido.UseVisualStyleBackColor = false;
            this.BtnCompletarPedido.Click += new System.EventHandler(this.BtnCompletarPedido_Click);
            // 
            // BtnEliminarPedido
            // 
            this.BtnEliminarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnEliminarPedido.FlatAppearance.BorderSize = 0;
            this.BtnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPedido.Location = new System.Drawing.Point(454, 409);
            this.BtnEliminarPedido.Name = "BtnEliminarPedido";
            this.BtnEliminarPedido.Size = new System.Drawing.Size(137, 28);
            this.BtnEliminarPedido.TabIndex = 36;
            this.BtnEliminarPedido.Text = "Eliminar pedido";
            this.BtnEliminarPedido.UseVisualStyleBackColor = false;
            this.BtnEliminarPedido.Click += new System.EventHandler(this.BtnEliminarPedido_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(123)))), ((int)(((byte)(188)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LbPagoTotal);
            this.panel3.Controls.Add(this.LbIva);
            this.panel3.Controls.Add(this.LbSumaTotal);
            this.panel3.Location = new System.Drawing.Point(394, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 67);
            this.panel3.TabIndex = 27;
            // 
            // LbPagoTotal
            // 
            this.LbPagoTotal.AutoSize = true;
            this.LbPagoTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPagoTotal.Location = new System.Drawing.Point(13, 42);
            this.LbPagoTotal.Name = "LbPagoTotal";
            this.LbPagoTotal.Size = new System.Drawing.Size(62, 16);
            this.LbPagoTotal.TabIndex = 14;
            this.LbPagoTotal.Text = "Precio final: ";
            // 
            // LbIva
            // 
            this.LbIva.AutoSize = true;
            this.LbIva.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIva.Location = new System.Drawing.Point(13, 26);
            this.LbIva.Name = "LbIva";
            this.LbIva.Size = new System.Drawing.Size(24, 16);
            this.LbIva.TabIndex = 13;
            this.LbIva.Text = "Iva: ";
            // 
            // LbSumaTotal
            // 
            this.LbSumaTotal.AutoSize = true;
            this.LbSumaTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSumaTotal.Location = new System.Drawing.Point(13, 10);
            this.LbSumaTotal.Name = "LbSumaTotal";
            this.LbSumaTotal.Size = new System.Drawing.Size(40, 16);
            this.LbSumaTotal.TabIndex = 12;
            this.LbSumaTotal.Text = "Precio: ";
            // 
            // DgvProductosOrdenados
            // 
            this.DgvProductosOrdenados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(123)))), ((int)(((byte)(188)))));
            this.DgvProductosOrdenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosOrdenados.Location = new System.Drawing.Point(394, 116);
            this.DgvProductosOrdenados.Name = "DgvProductosOrdenados";
            this.DgvProductosOrdenados.Size = new System.Drawing.Size(416, 176);
            this.DgvProductosOrdenados.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Informacion del pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Informacion del cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "TIENDA DE COMPUTADORAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.LbDireccion);
            this.panel1.Controls.Add(this.LbContactoCliente);
            this.panel1.Controls.Add(this.LbTelefono);
            this.panel1.Controls.Add(this.LbEmail);
            this.panel1.Controls.Add(this.LbNombreCliente);
            this.panel1.Controls.Add(this.LbCodigoCliente);
            this.panel1.Location = new System.Drawing.Point(32, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 258);
            this.panel1.TabIndex = 38;
            // 
            // LbDireccion
            // 
            this.LbDireccion.AutoSize = true;
            this.LbDireccion.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDireccion.Location = new System.Drawing.Point(21, 82);
            this.LbDireccion.Name = "LbDireccion";
            this.LbDireccion.Size = new System.Drawing.Size(61, 18);
            this.LbDireccion.TabIndex = 17;
            this.LbDireccion.Text = "Direccion: ";
            // 
            // LbContactoCliente
            // 
            this.LbContactoCliente.AutoSize = true;
            this.LbContactoCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbContactoCliente.Location = new System.Drawing.Point(20, 114);
            this.LbContactoCliente.Name = "LbContactoCliente";
            this.LbContactoCliente.Size = new System.Drawing.Size(58, 18);
            this.LbContactoCliente.TabIndex = 16;
            this.LbContactoCliente.Text = "Contacto: ";
            // 
            // LbTelefono
            // 
            this.LbTelefono.AutoSize = true;
            this.LbTelefono.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTelefono.Location = new System.Drawing.Point(20, 147);
            this.LbTelefono.Name = "LbTelefono";
            this.LbTelefono.Size = new System.Drawing.Size(55, 18);
            this.LbTelefono.TabIndex = 15;
            this.LbTelefono.Text = "Telefono: ";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Location = new System.Drawing.Point(20, 180);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(41, 18);
            this.LbEmail.TabIndex = 14;
            this.LbEmail.Text = "Email: ";
            // 
            // LbNombreCliente
            // 
            this.LbNombreCliente.AutoSize = true;
            this.LbNombreCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombreCliente.Location = new System.Drawing.Point(20, 53);
            this.LbNombreCliente.Name = "LbNombreCliente";
            this.LbNombreCliente.Size = new System.Drawing.Size(53, 18);
            this.LbNombreCliente.TabIndex = 13;
            this.LbNombreCliente.Text = "Nombre: ";
            // 
            // LbCodigoCliente
            // 
            this.LbCodigoCliente.AutoSize = true;
            this.LbCodigoCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCodigoCliente.Location = new System.Drawing.Point(20, 23);
            this.LbCodigoCliente.Name = "LbCodigoCliente";
            this.LbCodigoCliente.Size = new System.Drawing.Size(47, 18);
            this.LbCodigoCliente.TabIndex = 12;
            this.LbCodigoCliente.Text = "Codigo: ";
            // 
            // TxtEfectivo
            // 
            this.TxtEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(165)))));
            this.TxtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEfectivo.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEfectivo.Location = new System.Drawing.Point(136, 398);
            this.TxtEfectivo.Name = "TxtEfectivo";
            this.TxtEfectivo.Size = new System.Drawing.Size(203, 26);
            this.TxtEfectivo.TabIndex = 39;
            // 
            // TxtCambio
            // 
            this.TxtCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(165)))));
            this.TxtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCambio.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCambio.Location = new System.Drawing.Point(136, 430);
            this.TxtCambio.Name = "TxtCambio";
            this.TxtCambio.Size = new System.Drawing.Size(203, 26);
            this.TxtCambio.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(65, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Efectivo: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(65, 432);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 18);
            this.label15.TabIndex = 42;
            this.label15.Text = "Cambio: ";
            // 
            // Ventana_FacturarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(850, 489);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtCambio);
            this.Controls.Add(this.TxtEfectivo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCompletarPedido);
            this.Controls.Add(this.BtnEliminarPedido);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DgvProductosOrdenados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Ventana_FacturarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana_FacturarPedido_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosOrdenados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompletarPedido;
        private System.Windows.Forms.Button BtnEliminarPedido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbPagoTotal;
        private System.Windows.Forms.Label LbIva;
        private System.Windows.Forms.Label LbSumaTotal;
        private System.Windows.Forms.DataGridView DgvProductosOrdenados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbDireccion;
        private System.Windows.Forms.Label LbContactoCliente;
        private System.Windows.Forms.Label LbTelefono;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbNombreCliente;
        private System.Windows.Forms.Label LbCodigoCliente;
        private System.Windows.Forms.TextBox TxtEfectivo;
        private System.Windows.Forms.TextBox TxtCambio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}