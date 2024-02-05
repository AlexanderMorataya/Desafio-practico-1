namespace Trabajo_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRealizarPedido = new System.Windows.Forms.Button();
            this.BtnCrearCliente = new System.Windows.Forms.Button();
            this.BtnModificarCliente = new System.Windows.Forms.Button();
            this.BtnFacturarPedido = new System.Windows.Forms.Button();
            this.DgvInformacionPedidos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformacionPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIENDA DE COMPUTADORAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pedidos";
            // 
            // BtnRealizarPedido
            // 
            this.BtnRealizarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnRealizarPedido.FlatAppearance.BorderSize = 0;
            this.BtnRealizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRealizarPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizarPedido.Location = new System.Drawing.Point(75, 160);
            this.BtnRealizarPedido.Name = "BtnRealizarPedido";
            this.BtnRealizarPedido.Size = new System.Drawing.Size(164, 32);
            this.BtnRealizarPedido.TabIndex = 2;
            this.BtnRealizarPedido.Text = "Realizar pedido";
            this.BtnRealizarPedido.UseVisualStyleBackColor = false;
            this.BtnRealizarPedido.Click += new System.EventHandler(this.BtnRealizarPedido_Click);
            // 
            // BtnCrearCliente
            // 
            this.BtnCrearCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnCrearCliente.FlatAppearance.BorderSize = 0;
            this.BtnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCliente.Location = new System.Drawing.Point(75, 216);
            this.BtnCrearCliente.Name = "BtnCrearCliente";
            this.BtnCrearCliente.Size = new System.Drawing.Size(164, 32);
            this.BtnCrearCliente.TabIndex = 3;
            this.BtnCrearCliente.Text = "Crear cliente";
            this.BtnCrearCliente.UseVisualStyleBackColor = false;
            this.BtnCrearCliente.Click += new System.EventHandler(this.BtnCrearCliente_Click);
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnModificarCliente.FlatAppearance.BorderSize = 0;
            this.BtnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCliente.Location = new System.Drawing.Point(75, 273);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Size = new System.Drawing.Size(164, 32);
            this.BtnModificarCliente.TabIndex = 4;
            this.BtnModificarCliente.Text = "Modificar cliente";
            this.BtnModificarCliente.UseVisualStyleBackColor = false;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // BtnFacturarPedido
            // 
            this.BtnFacturarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnFacturarPedido.FlatAppearance.BorderSize = 0;
            this.BtnFacturarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturarPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturarPedido.Location = new System.Drawing.Point(75, 329);
            this.BtnFacturarPedido.Name = "BtnFacturarPedido";
            this.BtnFacturarPedido.Size = new System.Drawing.Size(164, 32);
            this.BtnFacturarPedido.TabIndex = 5;
            this.BtnFacturarPedido.Text = "Facturar pedido";
            this.BtnFacturarPedido.UseVisualStyleBackColor = false;
            this.BtnFacturarPedido.Click += new System.EventHandler(this.BtnFacturarPedido_Click);
            // 
            // DgvInformacionPedidos
            // 
            this.DgvInformacionPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInformacionPedidos.Location = new System.Drawing.Point(292, 142);
            this.DgvInformacionPedidos.Name = "DgvInformacionPedidos";
            this.DgvInformacionPedidos.Size = new System.Drawing.Size(511, 270);
            this.DgvInformacionPedidos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Abiertos las 365 dias del año";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(850, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvInformacionPedidos);
            this.Controls.Add(this.BtnFacturarPedido);
            this.Controls.Add(this.BtnModificarCliente);
            this.Controls.Add(this.BtnCrearCliente);
            this.Controls.Add(this.BtnRealizarPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda de computadoras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformacionPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRealizarPedido;
        private System.Windows.Forms.Button BtnCrearCliente;
        private System.Windows.Forms.Button BtnModificarCliente;
        private System.Windows.Forms.Button BtnFacturarPedido;
        private System.Windows.Forms.DataGridView DgvInformacionPedidos;
        private System.Windows.Forms.Label label3;
    }
}

