namespace Trabajo_1
{
    partial class Ventana_IniciarPedido
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
            this.BtnCodigoCliente = new System.Windows.Forms.Button();
            this.BtnCrearCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIENDA DE COMPUTADORAS";
            // 
            // BtnCodigoCliente
            // 
            this.BtnCodigoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnCodigoCliente.FlatAppearance.BorderSize = 0;
            this.BtnCodigoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCodigoCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCodigoCliente.Location = new System.Drawing.Point(121, 235);
            this.BtnCodigoCliente.Name = "BtnCodigoCliente";
            this.BtnCodigoCliente.Size = new System.Drawing.Size(208, 32);
            this.BtnCodigoCliente.TabIndex = 3;
            this.BtnCodigoCliente.Text = "Ingresar codigo cliente";
            this.BtnCodigoCliente.UseVisualStyleBackColor = false;
            this.BtnCodigoCliente.Click += new System.EventHandler(this.BtnCodigoCliente_Click);
            // 
            // BtnCrearCliente
            // 
            this.BtnCrearCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.BtnCrearCliente.FlatAppearance.BorderSize = 0;
            this.BtnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCliente.Location = new System.Drawing.Point(515, 235);
            this.BtnCrearCliente.Name = "BtnCrearCliente";
            this.BtnCrearCliente.Size = new System.Drawing.Size(208, 32);
            this.BtnCrearCliente.TabIndex = 4;
            this.BtnCrearCliente.Text = "Crear cliente";
            this.BtnCrearCliente.UseVisualStyleBackColor = false;
            this.BtnCrearCliente.Click += new System.EventHandler(this.BtnCrearCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tu satisfaccion es nuestra razon de ser";
            // 
            // Ventana_IniciarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(850, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCrearCliente);
            this.Controls.Add(this.BtnCodigoCliente);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Ventana_IniciarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana_IniciarPedido_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCodigoCliente;
        private System.Windows.Forms.Button BtnCrearCliente;
        private System.Windows.Forms.Label label3;
    }
}