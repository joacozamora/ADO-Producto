using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinformProducto1
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        Productos prodActual = new Productos();

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            Productos NuevoProd;

            NuevoProd = new Productos(txb_Nombre.Text, int.Parse(txb_Precio.Text)) ;
            lbl_PrecioFinal.Text = NuevoProd.d_precio.ToString();
            lbl_NombreFinal.Text = NuevoProd.d_nombre;
            lbl_Genero.Text = NuevoProd.d_genero;
            MessageBox.Show("Producto Instanciado");

            prodActual = NuevoProd;
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            int descuento = int.Parse(txb_descuento.Text);

            lbl_PrecioFinal.Text = prodActual.CargarDescuento(descuento, prodActual.d_precio);
            lbl_NombreFinal.Text = txb_cambionomb.Text;
        }
    }
}
