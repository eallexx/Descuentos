namespace Descuentos
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
            this.lblVenta = new System.Windows.Forms.Label();
            this.lblDescuentoVenta = new System.Windows.Forms.Label();
            this.lblDescuentoPorcentaje = new System.Windows.Forms.Label();
            this.lblVentafinal = new System.Windows.Forms.Label();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.txtDescuentoVenta = new System.Windows.Forms.TextBox();
            this.txtDescuentoPorcentaje = new System.Windows.Forms.TextBox();
            this.txtVentafinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Location = new System.Drawing.Point(40, 46);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(61, 13);
            this.lblVenta.TabIndex = 0;
            this.lblVenta.Text = "Valor venta";
            this.lblVenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescuentoVenta
            // 
            this.lblDescuentoVenta.AutoSize = true;
            this.lblDescuentoVenta.Location = new System.Drawing.Point(40, 111);
            this.lblDescuentoVenta.Name = "lblDescuentoVenta";
            this.lblDescuentoVenta.Size = new System.Drawing.Size(68, 13);
            this.lblDescuentoVenta.TabIndex = 1;
            this.lblDescuentoVenta.Text = "Descuento $";
            // 
            // lblDescuentoPorcentaje
            // 
            this.lblDescuentoPorcentaje.AutoSize = true;
            this.lblDescuentoPorcentaje.Location = new System.Drawing.Point(38, 146);
            this.lblDescuentoPorcentaje.Name = "lblDescuentoPorcentaje";
            this.lblDescuentoPorcentaje.Size = new System.Drawing.Size(70, 13);
            this.lblDescuentoPorcentaje.TabIndex = 2;
            this.lblDescuentoPorcentaje.Text = "Descuento %";
            // 
            // lblVentafinal
            // 
            this.lblVentafinal.AutoSize = true;
            this.lblVentafinal.Location = new System.Drawing.Point(40, 180);
            this.lblVentafinal.Name = "lblVentafinal";
            this.lblVentafinal.Size = new System.Drawing.Size(60, 13);
            this.lblVentafinal.TabIndex = 3;
            this.lblVentafinal.Text = "Venta Final";
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(135, 46);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(100, 20);
            this.txtVenta.TabIndex = 4;
            this.txtVenta.TextChanged += new System.EventHandler(this.txtVenta_TextChanged);
            // 
            // txtDescuentoVenta
            // 
            this.txtDescuentoVenta.Location = new System.Drawing.Point(135, 108);
            this.txtDescuentoVenta.Name = "txtDescuentoVenta";
            this.txtDescuentoVenta.Size = new System.Drawing.Size(100, 20);
            this.txtDescuentoVenta.TabIndex = 5;
            // 
            // txtDescuentoPorcentaje
            // 
            this.txtDescuentoPorcentaje.Location = new System.Drawing.Point(135, 146);
            this.txtDescuentoPorcentaje.Name = "txtDescuentoPorcentaje";
            this.txtDescuentoPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.txtDescuentoPorcentaje.TabIndex = 6;
            // 
            // txtVentafinal
            // 
            this.txtVentafinal.Location = new System.Drawing.Point(135, 180);
            this.txtVentafinal.Name = "txtVentafinal";
            this.txtVentafinal.Size = new System.Drawing.Size(100, 20);
            this.txtVentafinal.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(293, 46);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(293, 111);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(293, 146);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 257);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVentafinal);
            this.Controls.Add(this.txtDescuentoPorcentaje);
            this.Controls.Add(this.txtDescuentoVenta);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.lblVentafinal);
            this.Controls.Add(this.lblDescuentoPorcentaje);
            this.Controls.Add(this.lblDescuentoVenta);
            this.Controls.Add(this.lblVenta);
            this.Name = "Form1";
            this.Text = "Descuentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label lblDescuentoVenta;
        private System.Windows.Forms.Label lblDescuentoPorcentaje;
        private System.Windows.Forms.Label lblVentafinal;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.TextBox txtDescuentoVenta;
        private System.Windows.Forms.TextBox txtDescuentoPorcentaje;
        private System.Windows.Forms.TextBox txtVentafinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

