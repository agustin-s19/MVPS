using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inmobiliariMVP
{
    public interface IVista
    {
        bool esNuevoText { get; set; }
        string metrosText { get; set; }
        string direccionText { get; set; }
        string precioFinalText { get; set; }

        string Tipo { get; set; }
    }
}
