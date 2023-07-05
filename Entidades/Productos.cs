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
        private int Precio;
        private string Genero;
        
        #endregion

        #region Propiedades

        public int d_precio
        {
            set { Precio = value; }
            get { return Precio; }

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

        #endregion
        #region Constructores
        public Productos()
        {
        }
        public Productos(string nom , int prec)
        {
            Nombre = nom;
            Precio = prec;
            Genero = "";
            
        }
        #endregion

        #region Metodos

        public void CambiarNombre(string nom)
        {
            

        }

        public string CargarDescuento (int descuento, int precTotal) 
        {
            int resta = precTotal - descuento;
            return resta.ToString();
            
            
        
        }

        #endregion
    }
}
