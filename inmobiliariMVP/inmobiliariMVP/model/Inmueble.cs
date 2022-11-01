using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inmobiliariMVP
{
    public class Inmueble 
    {
        private int precioBase = 100;
        private string direccion;
        private int metros;
        private bool esNuevo;
        private int precioFinal = 0;
        private bool tipo;

        public int PrecioFinal { get => precioFinal; set => precioFinal = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Metros { get => metros; set => metros = value; }

        public bool EsNuevo { get => esNuevo; set => esNuevo = value; }
        public int PrecioBase { get => precioBase; set => precioBase = value; }

        public bool Tipo { get => tipo; set => tipo = value; }
        public virtual int Cotizar()
        {
            if(this.esNuevo == true)
            {
                PrecioFinal = Convert.ToInt32(PrecioBase * 0.99);
            }
            else if(this.esNuevo == false)
            {
                PrecioFinal = Convert.ToInt32(PrecioBase * 0.98);
            }
            return PrecioFinal;
        }

     

    }
}
