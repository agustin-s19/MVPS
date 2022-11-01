using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inmobiliariMVP
{
    internal class Local : Inmueble
    {
        private int numVentanas;

        public int NumVentanas { get => numVentanas; set => numVentanas = value; }
       
        

        public void CalcularPrecioInicial()
        {
            base.Cotizar();
        }
        public override int Cotizar()
        {
            if(Metros > 50) { 
                PrecioFinal = Convert.ToInt32(PrecioFinal * 1.01);
            }
            if (NumVentanas <= 1) {
                PrecioFinal = Convert.ToInt32(PrecioFinal * 0.98);
            }else if(NumVentanas>1){
                PrecioFinal = Convert.ToInt32(PrecioFinal * 1.04);
               
            }
            return PrecioFinal;
        }
    }
}
