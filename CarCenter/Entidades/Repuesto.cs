using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Repuesto
    {
        #region Atributos
        public int RepuestoId { get; set; }
        public string descripcion { get; set; }
        public string serial { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }

        #endregion

        #region Constructor
        public Repuesto()
        { }

        public Repuesto(string Descripcion_, string Serial_, string Marca_, string Modelo_, double Precio_, int Cantidad_)
        {
            descripcion = Descripcion_;
            serial = Serial_;
            marca = Marca_;
            modelo = Modelo_;
            precio = Precio_;
            cantidad = Cantidad_;
        }
        #endregion
    }
}
