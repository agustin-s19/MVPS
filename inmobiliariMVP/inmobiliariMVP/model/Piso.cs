using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace inmobiliariMVP
{
    internal class Piso : Inmueble
    {
        private int numPiso;

        public int NumPiso { get => numPiso; set => numPiso = value; }


      
        public void CalcularPrecioInicial()
        {
            base.Cotizar();
        }
        public override int Cotizar()
        {
            if (numPiso >= 3)
            {
                PrecioFinal = Convert.ToInt32(PrecioFinal * 1.03);
                
            }
            return PrecioFinal;
        }

    }
}
