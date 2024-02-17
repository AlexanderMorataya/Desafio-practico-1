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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbNombreCliente = new System.Windows.Forms.Label();
            this.LbCodigoCliente = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbDescripcionProducto = new System.Windows.Forms.Label();
            this.LbPrecioProducto = new System.Windows.Forms.Label();
            this.CbProductos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvProductosOrdenados = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LbPagoTotal = new System.Windows.Forms.Label();
            this.lbIva = new System.Windows.Forms.Label();
            this.LbSumaTotal = new System.Windows.Forms.Label();
            this.BtnElimarProducto = new System.Windows.Forms.Button();
            this.BtnConfirmarPedido = new System.Windows.Forms.Button();
            this.CbUnidades = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosOrdenados)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LbNombreCliente);
            this.panel1.Controls.Add(this.LbCodigoCliente);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(45, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 51);
            this.panel1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombre: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Codigo: ";
            // 
            // LbNombreCliente
            // 
            this.LbNombreCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombreCliente.ForeColor = System.Drawing.Color.White;
            this.LbNombreCliente.Location = new System.Drawing.Point(59, 26);
            this.LbNombreCliente.Name = "LbNombreCliente";
            this.LbNombreCliente.Size = new System.Drawing.Size(231, 16);
            this.LbNombreCliente.TabIndex = 13;
            // 
            // LbCodigoCliente
            // 
            this.LbCodigoCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCodigoCliente.ForeColor = System.Drawing.Color.White;
            this.LbCodigoCliente.Location = new System.Drawing.Point(59, 10);
            this.LbCodigoCliente.Name = "LbCodigoCliente";
            this.LbCodigoCliente.Size = new System.Drawing.Size(231, 16);
            this.LbCodigoCliente.TabIndex = 12;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(61, 373);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(137, 28);
            this.BtnAgregarProducto.TabIndex = 12;
            this.BtnAgregarProducto.Text = "Agregar producto";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
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
            this.label3.ForeColor = System.Drawing.Color.White;
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
            this.label5.ForeColor = System.Drawing.Color.White;
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
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Unidades solicitadas:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LbDescripcionProducto);
            this.panel2.Controls.Add(this.LbPrecioProducto);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.panel2.Location = new System.Drawing.Point(45, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 93);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descripcion: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Precio: ";
            // 
            // LbDescripcionProducto
            // 
            this.LbDescripcionProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDescripcionProducto.ForeColor = System.Drawing.Color.White;
            this.LbDescripcionProducto.Location = new System.Drawing.Point(13, 40);
            this.LbDescripcionProducto.Name = "LbDescripcionProducto";
            this.LbDescripcionProducto.Size = new System.Drawing.Size(277, 42);
            this.LbDescripcionProducto.TabIndex = 13;
            // 
            // LbPrecioProducto
            // 
            this.LbPrecioProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrecioProducto.ForeColor = System.Drawing.Color.White;
            this.LbPrecioProducto.Location = new System.Drawing.Point(59, 8);
            this.LbPrecioProducto.Name = "LbPrecioProducto";
            this.LbPrecioProducto.Size = new System.Drawing.Size(131, 16);
            this.LbPrecioProducto.TabIndex = 12;
            // 
            // CbProductos
            // 
            this.CbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProductos.FormattingEnabled = true;
            this.CbProductos.Location = new System.Drawing.Point(180, 203);
            this.CbProductos.Name = "CbProductos";
            this.CbProductos.Size = new System.Drawing.Size(155, 21);
            this.CbProductos.TabIndex = 18;
            this.CbProductos.SelectedIndexChanged += new System.EventHandler(this.CbProductos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(416, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Informacion del pedido";
            // 
            // DgvProductosOrdenados
            // 
            this.DgvProductosOrdenados.AllowUserToAddRows = false;
            this.DgvProductosOrdenados.AllowUserToDeleteRows = false;
            this.DgvProductosOrdenados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvProductosOrdenados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvProductosOrdenados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(123)))), ((int)(((byte)(188)))));
            this.DgvProductosOrdenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosOrdenados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(123)))), ((int)(((byte)(188)))));
            this.DgvProductosOrdenados.Location = new System.Drawing.Point(394, 132);
            this.DgvProductosOrdenados.Name = "DgvProductosOrdenados";
            this.DgvProductosOrdenados.ReadOnly = true;
            this.DgvProductosOrdenados.RowHeadersVisible = false;
            this.DgvProductosOrdenados.Size = new System.Drawing.Size(416, 193);
            this.DgvProductosOrdenados.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(123)))), ((int)(((byte)(188)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.LbPagoTotal);
            this.panel3.Controls.Add(this.lbIva);
            this.panel3.Controls.Add(this.LbSumaTotal);
            this.panel3.Location = new System.Drawing.Point(394, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 67);
            this.panel3.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Precio final: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Iva: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Precio: ";
            // 
            // LbPagoTotal
            // 
            this.LbPagoTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPagoTotal.ForeColor = System.Drawing.Color.White;
            this.LbPagoTotal.Location = new System.Drawing.Point(96, 42);
            this.LbPagoTotal.Name = "LbPagoTotal";
            this.LbPagoTotal.Size = new System.Drawing.Size(117, 16);
            this.LbPagoTotal.TabIndex = 14;
            // 
            // lbIva
            // 
            this.lbIva.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIva.ForeColor = System.Drawing.Color.White;
            this.lbIva.Location = new System.Drawing.Point(93, 26);
            this.lbIva.Name = "lbIva";
            this.lbIva.Size = new System.Drawing.Size(120, 16);
            this.lbIva.TabIndex = 13;
            // 
            // LbSumaTotal
            // 
            this.LbSumaTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSumaTotal.ForeColor = System.Drawing.Color.White;
            this.LbSumaTotal.Location = new System.Drawing.Point(99, 10);
            this.LbSumaTotal.Name = "LbSumaTotal";
            this.LbSumaTotal.Size = new System.Drawing.Size(114, 16);
            this.LbSumaTotal.TabIndex = 12;
            // 
            // BtnElimarProducto
            // 
            this.BtnElimarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnElimarProducto.FlatAppearance.BorderSize = 0;
            this.BtnElimarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnElimarProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnElimarProducto.Location = new System.Drawing.Point(620, 91);
            this.BtnElimarProducto.Name = "BtnElimarProducto";
            this.BtnElimarProducto.Size = new System.Drawing.Size(190, 28);
            this.BtnElimarProducto.TabIndex = 22;
            this.BtnElimarProducto.Text = "Sacar ultimo producto";
            this.BtnElimarProducto.UseVisualStyleBackColor = false;
            this.BtnElimarProducto.Click += new System.EventHandler(this.BtnElimarProducto_Click);
            // 
            // BtnConfirmarPedido
            // 
            this.BtnConfirmarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnConfirmarPedido.FlatAppearance.BorderSize = 0;
            this.BtnConfirmarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarPedido.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmarPedido.Location = new System.Drawing.Point(660, 416);
            this.BtnConfirmarPedido.Name = "BtnConfirmarPedido";
            this.BtnConfirmarPedido.Size = new System.Drawing.Size(137, 28);
            this.BtnConfirmarPedido.TabIndex = 23;
            this.BtnConfirmarPedido.Text = "Confirmar pedido";
            this.BtnConfirmarPedido.UseVisualStyleBackColor = false;
            this.BtnConfirmarPedido.Click += new System.EventHandler(this.BtnConfirmarPedido_Click);
            // 
            // CbUnidades
            // 
            this.CbUnidades.Location = new System.Drawing.Point(180, 227);
            this.CbUnidades.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CbUnidades.Name = "CbUnidades";
            this.CbUnidades.Size = new System.Drawing.Size(155, 20);
            this.CbUnidades.TabIndex = 24;
            this.CbUnidades.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CbUnidades.ValueChanged += new System.EventHandler(this.CbUnidades_ValueChanged);
            // 
            // Ventana_OrdenarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(850, 489);
            this.Controls.Add(this.CbUnidades);
            this.Controls.Add(this.BtnConfirmarPedido);
            this.Controls.Add(this.BtnElimarProducto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DgvProductosOrdenados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Ventana_OrdenarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenar pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana_OrdenarPedido_FormClosed);
            this.Load += new System.EventHandler(this.Ventana_OrdenarPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosOrdenados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbUnidades)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvProductosOrdenados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbPagoTotal;
        private System.Windows.Forms.Label lbIva;
        private System.Windows.Forms.Label LbSumaTotal;
        private System.Windows.Forms.Button BtnElimarProducto;
        private System.Windows.Forms.Button BtnConfirmarPedido;
        private System.Windows.Forms.NumericUpDown CbUnidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}