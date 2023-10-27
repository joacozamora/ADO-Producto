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
using System.Drawing;


namespace WinformProducto1
{
    public partial class FormProductos : Form
    {
        Productos NuevoProd;
        Productos ProdExistente;
        public NegProductos objNegProducto = new NegProductos();
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
            

            /*int descuento = (int.Parse(txb_descuento.Text));




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

        }*/
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

        private void LimpiarProducto()
        {
            txb_Nombre.Text = string.Empty;
            txb_Cod.Text = string.Empty;
            txb_Precio.Text = string.Empty;
            txb_Genero.Text = string.Empty;
            txb_EliminarProducto.Clear();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (true)
            {

                DgEliminarProductoCod();

                LlenarDGV();

                MessageBox.Show("Se elimino el producto");
            }

            
        }

        public bool ValidacionCamposProducto()
        {

            //Categoria
            if (txb_Genero.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un genero de Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txb_Genero.Text.Length > 50 || txb_Genero.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten generos de 100 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }



            //Nombre Producto
            if (txb_Nombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Nombre Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txb_Nombre.Text.Length > 50 || txb_Nombre.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres entre 2 y 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            //Precio
            if (txb_Precio.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Precio Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txb_Precio.Text.Length > 50 || txb_Precio.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten precio entre 2 y 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txb_Precio.Text.Length > 200)
            {
                MessageBox.Show("La observación no puede superar los 200 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;


        }

        private void TxtBox_a_ObjProducto()
        {
            prodActual.d_nombre = txb_Nombre.Text;
            prodActual.d_codigo = int.Parse(txb_Cod.Text);
            prodActual.d_precio = int.Parse(txb_Precio.Text);
            prodActual.d_genero = txb_Genero.Text;

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            
        }

        public void DgEliminarProductoCod()
        {
            DataRow productoAEliminar = null;
            DataSet ds = objNegProducto.listadoProductos("Todos");
            string codigoProductoABuscar = txb_EliminarProducto.Text;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr[1].ToString() == codigoProductoABuscar)
                {
                    productoAEliminar = dr;
                    break;
                }
            }

            if (productoAEliminar != null)
            {
                int codigoProducto = int.Parse(productoAEliminar[1].ToString());

                Productos producto = new Productos(null,codigoProducto, 0, null); // Ajusta los valores adecuados en el constructor de Productos

                int resultado = objNegProducto.abmProductos("Borrar", producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto");
                }
            }
            else
            {
                MessageBox.Show("El producto no se encontró en la lista");
            }
        }

        private void btn_aplicar_Click_1(object sender, EventArgs e)
        {
            bool validar = ValidacionCamposProducto();
            int nResultado = -1;
            if (validar == true)
            {
                TxtBox_a_ObjProducto();
                nResultado = objNegProducto.abmProductos("Modificar", prodActual);
                if (nResultado != -1)
                {
                    MessageBox.Show("El producto fue modificado con éxito");
                    LimpiarProducto();
                    LlenarDGV();
                    btn_aplicar.Visible = false;

                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar el Producto");
                }
            }
        }

        /* public void DgEliminarProductoCod()
         {
             DataRow revista = null;
             DataSet ds = objNegProducto.listadoProductos("Todos");
             foreach (DataRow dr in ds.Tables[0].Rows)
             {
                 if (dr[1].ToString() == txb_EliminarProducto.Text)
                 {
                     revista = dr;
                     break;
                 }
             }
             if (revista != null)
             {
                 Productos producto = new Productos(revista[0], int.Parse(revista[1].ToString()), int.Parse(revista[2].ToString()), revista[3]);
                 int est = objNegProducto.abmProductos("Borrar", producto);
                 MessageBox.Show("producto borrado");
             }
             else { MessageBox.Show("producto borrado"); }
             //string id = txb_EliminarProducto.Text;
             //Dgv_Revistas.Rows.Clear();
             //DataSet ds = new DataSet();

             //try
             //{
             //    ds = objNegProducto.ListarProductoEliminar(id);

             //    if (ds.Tables.Count >= 0)
             //    {
             //        try
             //        {
             //            foreach (DataRow dr in ds.Tables)
             //            {
             //                Dgv_Revistas.Rows.Add(dr[0], dr[1].ToString(), dr[2].ToString(), dr[3]);
             //            }
             //        }
             //        catch (Exception e)
             //        {
             //            MessageBox.Show(e.Message);
             //        }
             //    }
             //}
             //catch (Exception e)
             //{
             //    MessageBox.Show(e.Message);
             //}
         }
         */
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