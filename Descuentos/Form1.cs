using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descuentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal VentaTotal, DescuentoPorcentaje, DescuentoVenta, MontoTotal;
            
            if(decimal.TryParse(txtVenta.Text, out decimal Venta))
            {
                VentaTotal = Venta;

                if (VentaTotal >= 500)
                {
                    DescuentoPorcentaje = 0.30m;
                }
                else if (VentaTotal > 300 && VentaTotal <= 499)
                {
                    DescuentoPorcentaje = 0.20m;
                }
                else if (VentaTotal > 100 && VentaTotal <= 299)
                {
                    DescuentoPorcentaje = 0.10m;
                }
                else if (VentaTotal <= 100)
                {
                    DescuentoPorcentaje = 0;
                }
                else
                {
                    DescuentoPorcentaje = 0;
                }

                DescuentoVenta = VentaTotal * DescuentoPorcentaje;
                MontoTotal = VentaTotal - DescuentoVenta;

                txtDescuentoPorcentaje.Text = DescuentoPorcentaje.ToString();
                txtVentafinal.Text = MontoTotal.ToString();
                txtDescuentoVenta.Text = DescuentoVenta.ToString();
            }
            else
            {
                MessageBox.Show("El valor de la venta debe ser un valor numerico", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescuentoPorcentaje.Text = "";
            txtDescuentoVenta.Text = "";
            txtVenta.Text = "";
            txtVentafinal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando el programa");
            Close();
        }

        private void txtVenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
