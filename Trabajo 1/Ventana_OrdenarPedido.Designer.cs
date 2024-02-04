namespace Trabajo_1
{
    partial class Ventana_OrdenarPedido
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
            this.LbNombreCliente = new System.Windows.Forms.Label();
            this.LbCodigoCliente = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbDescripcionProducto = new System.Windows.Forms.Label();
            this.LbPrecioProducto = new System.Windows.Forms.Label();
            this.CbProductos = new System.Windows.Forms.ComboBox();
            this.CbUnidades = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvProductosOrdenados = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbPagoTotal = new System.Windows.Forms.Label();
            this.lbIva = new System.Windows.Forms.Label();
            this.LbSumaTotal = new System.Windows.Forms.Label();
            this.BtnCancelarPedido = new System.Windows.Forms.Button();
            this.BtnConfirmarPedido = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosOrdenados)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.LbNombreCliente);
            this.panel1.Controls.Add(this.LbCodigoCliente);
            this.panel1.Location = new System.Drawing.Point(45, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 51);
            this.panel1.TabIndex = 13;
            // 
            // LbNombreCliente
            // 
            this.LbNombreCliente.AutoSize = true;
            this.LbNombreCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombreCliente.Location = new System.Drawing.Point(13, 26);
            this.LbNombreCliente.Name = "LbNombreCliente";
            this.LbNombreCliente.Size = new System.Drawing.Size(45, 16);
            this.LbNombreCliente.TabIndex = 13;
            this.LbNombreCliente.Text = "Nombre: ";
            // 
            // LbCodigoCliente
            // 
            this.LbCodigoCliente.AutoSize = true;
            this.LbCodigoCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCodigoCliente.Location = new System.Drawing.Point(13, 10);
            this.LbCodigoCliente.Name = "LbCodigoCliente";
            this.LbCodigoCliente.Size = new System.Drawing.Size(40, 16);
            this.LbCodigoCliente.TabIndex = 12;
            this.LbCodigoCliente.Text = "Codigo: ";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.Location = new System.Drawing.Point(61, 373);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(137, 28);
            this.BtnAgregarProducto.TabIndex = 12;
            this.BtnAgregarProducto.Text = "Agregar producto";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "TIENDA DE COMPUTADORAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Informacion del cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seleccione producto: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Unidades solicitadas:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.LbDescripcionProducto);
            this.panel2.Controls.Add(this.LbPrecioProducto);
            this.panel2.Location = new System.Drawing.Point(45, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 93);
            this.panel2.TabIndex = 17;
            // 
            // LbDescripcionProducto
            // 
            this.LbDescripcionProducto.AutoSize = true;
            this.LbDescripcionProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDescripcionProducto.Location = new System.Drawing.Point(13, 26);
            this.LbDescripcionProducto.Name = "LbDescripcionProducto";
            this.LbDescripcionProducto.Size = new System.Drawing.Size(63, 16);
            this.LbDescripcionProducto.TabIndex = 13;
            this.LbDescripcionProducto.Text = "Descripcion: ";
            // 
            // LbPrecioProducto
            // 
            this.LbPrecioProducto.AutoSize = true;
            this.LbPrecioProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrecioProducto.Location = new System.Drawing.Point(13, 10);
            this.LbPrecioProducto.Name = "LbPrecioProducto";
            this.LbPrecioProducto.Size = new System.Drawing.Size(40, 16);
            this.LbPrecioProducto.TabIndex = 12;
            this.LbPrecioProducto.Text = "Precio: ";
            // 
            // CbProductos
            // 
            this.CbProductos.FormattingEnabled = true;
            this.CbProductos.Location = new System.Drawing.Point(180, 203);
            this.CbProductos.Name = "CbProductos";
            this.CbProductos.Size = new System.Drawing.Size(155, 21);
            this.CbProductos.TabIndex = 18;
            // 
            // CbUnidades
            // 
            this.CbUnidades.FormattingEnabled = true;
            this.CbUnidades.Location = new System.Drawing.Point(180, 227);
            this.CbUnidades.Name = "CbUnidades";
            this.CbUnidades.Size = new System.Drawing.Size(155, 21);
            this.CbUnidades.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Informacion del pedido";
            // 
            // DgvProductosOrdenados
            // 
            this.DgvProductosOrdenados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(123)))), ((int)(((byte)(188)))));
            this.DgvProductosOrdenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosOrdenados.Location = new System.Drawing.Point(394, 122);
            this.DgvProductosOrdenados.Name = "DgvProductosOrdenados";
            this.DgvProductosOrdenados.Size = new System.Drawing.Size(416, 197);
            this.DgvProductosOrdenados.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(123)))), ((int)(((byte)(188)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LbPagoTotal);
            this.panel3.Controls.Add(this.lbIva);
            this.panel3.Controls.Add(this.LbSumaTotal);
            this.panel3.Location = new System.Drawing.Point(394, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 67);
            this.panel3.TabIndex = 14;
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
            // lbIva
            // 
            this.lbIva.AutoSize = true;
            this.lbIva.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIva.Location = new System.Drawing.Point(13, 26);
            this.lbIva.Name = "lbIva";
            this.lbIva.Size = new System.Drawing.Size(24, 16);
            this.lbIva.TabIndex = 13;
            this.lbIva.Text = "Iva: ";
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
            // BtnCancelarPedido
            // 
            this.BtnCancelarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnCancelarPedido.FlatAppearance.BorderSize = 0;
            this.BtnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarPedido.Location = new System.Drawing.Point(454, 421);
            this.BtnCancelarPedido.Name = "BtnCancelarPedido";
            this.BtnCancelarPedido.Size = new System.Drawing.Size(137, 28);
            this.BtnCancelarPedido.TabIndex = 22;
            this.BtnCancelarPedido.Text = "Cancelar pedido";
            this.BtnCancelarPedido.UseVisualStyleBackColor = false;
            // 
            // BtnConfirmarPedido
            // 
            this.BtnConfirmarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnConfirmarPedido.FlatAppearance.BorderSize = 0;
            this.BtnConfirmarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarPedido.Location = new System.Drawing.Point(636, 421);
            this.BtnConfirmarPedido.Name = "BtnConfirmarPedido";
            this.BtnConfirmarPedido.Size = new System.Drawing.Size(137, 28);
            this.BtnConfirmarPedido.TabIndex = 23;
            this.BtnConfirmarPedido.Text = "Confirmar pedido";
            this.BtnConfirmarPedido.UseVisualStyleBackColor = false;
            // 
            // Ventana_OrdenarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(850, 489);
            this.Controls.Add(this.BtnConfirmarPedido);
            this.Controls.Add(this.BtnCancelarPedido);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DgvProductosOrdenados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbUnidades);
            this.Controls.Add(this.CbProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Ventana_OrdenarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenar pedido";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosOrdenados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbNombreCliente;
        private System.Windows.Forms.Label LbCodigoCliente;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbDescripcionProducto;
        private System.Windows.Forms.Label LbPrecioProducto;
        private System.Windows.Forms.ComboBox CbProductos;
        private System.Windows.Forms.ComboBox CbUnidades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvProductosOrdenados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbPagoTotal;
        private System.Windows.Forms.Label lbIva;
        private System.Windows.Forms.Label LbSumaTotal;
        private System.Windows.Forms.Button BtnCancelarPedido;
        private System.Windows.Forms.Button BtnConfirmarPedido;
    }
}