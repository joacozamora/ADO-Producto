using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class Productos
    {
        #region Atributos
        private string Nombre;
        private int Codigo;
        private int Precio;
        private string Genero;
        
        #endregion

        #region Propiedades

        public int d_precio
        {
            set { Precio = value; }
            get { return Precio; }

        }

        public int d_codigo
        {
            set { Codigo = value; }
            get { return Codigo; }

        }

        public string d_nombre
        {
            set { Nombre = value; }
            get { return Nombre; }

        }

        public string d_genero
        {
            set { Genero = value; }
            get { return Genero; }
        }

        public object V { get; }
        public object Value1 { get; }
        public object Value2 { get; }
        public object Value3 { get; }

        #endregion
        #region Constructores
        public Productos()
        {
        }
        public Productos(string nom , int cod, int prec, string gen)
        {
            Nombre = nom;
            Codigo = cod;
            Precio = prec;
            Genero = gen;
            
        }

        public Productos(object v, object value1, object value2, object value3)
        {
            V = v;
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }
        #endregion

        #region Metodos

        public void CambiarNombre(string nom)
        {
            

        }

        public string CargarDescuento (int descuento) 
        {
            Precio = (descuento*d_precio)/100;
            return Precio.ToString();
            
        
        }

        #endregion
    }
}
