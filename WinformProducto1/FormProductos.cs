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
using CapaNegocios;

namespace WinformProducto1
{
    public partial class FormProductos : Form
    {
        Productos NuevoProd;
        Productos ProdExistente;
        NegProductos objNegProducto = new NegProductos();
        bool nuevo = true;
        int fila;
        bool HayDescuento = false;
        bool NombreCambia = false;

        public FormProductos()
        {
            InitializeComponent();
            CrearDgv();
            LlenarDGV();
        }

        Productos prodActual = new Productos();

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            //Productos NuevoProd;
            int nGrabados = -1;

            NuevoProd = new Productos(txb_Nombre.Text, int.Parse(txb_Cod.Text), int.Parse(txb_Precio.Text), txb_Genero.Text);

            nGrabados = objNegProducto.abmProductos("Alta", NuevoProd);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el Producto en el sistema");

            }
            else
            {
                lbl_PrecioFinal.Text = NuevoProd.d_precio.ToString();
                lbl_NombreFinal.Text = NuevoProd.d_nombre;
                lbl_Codigo.Text = NuevoProd.d_codigo.ToString();
                lbl_Genero.Text = NuevoProd.d_genero;

                nuevo = true;
                LlenarDGV();
            }
            
            MessageBox.Show("Producto Instanciado");

            prodActual = NuevoProd;
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            
                int descuento = (int.Parse(txb_descuento.Text));
            
            


            //NuevoProd.d_precio = prodActual.CargarDescuento(descuento);

            if (!string.IsNullOrEmpty(txb_cambionomb.Text))
                NombreCambia = true;
            else
            {

            }
            if (!string.IsNullOrEmpty(txb_descuento.Text))
                HayDescuento = true;
            else
            {

            }
        }

        private void LlenarDGV()
        {
            Dgv_Revistas.Rows.Clear();
            DataSet ds = new DataSet();

            ds = objNegProducto.listadoProductos("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Dgv_Revistas.Rows.Add(dr[0], dr[1].ToString(), dr[2].ToString(), dr[3]);
                    
                }
                
            }
            else
            {
                MessageBox.Show("No hay productos cargados en el sistema");
            }
            //if (HayDescuento || NombreCambia)
            //{
            //    dr[2] = txb_descuento.Text;
            //    dr[0] = txb_cambionomb.Text;
            //}
        }

        private void CrearDgv()
        {
            Dgv_Revistas.Columns.Add("0", "Nombre");
            Dgv_Revistas.Columns.Add("1", "Codigo");
            Dgv_Revistas.Columns.Add("2", "Precio");
            Dgv_Revistas.Columns.Add("3", "Genero");

            Dgv_Revistas.Columns[0].Width = 200;
            Dgv_Revistas.Columns[1].Width = 100;
            Dgv_Revistas.Columns[2].Width = 100;
            Dgv_Revistas.Columns[3].Width = 200;
        }

        //    private void AgregarDGV()
        //    {
        //        DataGridView dgv = new DataGridView();
        //        dgv.Size = new Size(200,200);
        //        dgv.Location = new Point(51, 282);
        //        this.Controls.Add(dgv);

        //        DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
        //        columna1.HeaderText = "Nombre";
        //        columna1.Width = 200;
        //        dgv.Columns.Add(columna1);
        //    }
        //}
    }
}