using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inmobiliariMVP
{
    public class Presenter
    {
        private  IVista _vista;
        protected Inmueble _inmueble;

        public Presenter(IVista _vista)
        {
            this._vista = _vista;
            this._inmueble = new Inmueble();
        }

       
        public void CalcularPrecioInicial() {
            _inmueble.PrecioBase = 100;
            _inmueble.Metros = int.Parse(_vista.metrosText);
            _inmueble.EsNuevo = _vista.esNuevoText;
            _inmueble.Direccion = _vista.direccionText;
           

            
           

        }
        public void ActualizarVista()
        {
            
        }
    }
}
