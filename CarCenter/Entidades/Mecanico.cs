using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mecanico
    {
        #region Atributos
        public int MecanicoId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDocumento { get; set; }
        public int documento { get; set; }
        public int telefono { get; set; }
        public DateTime fechaRegistro { get; set; }
        public bool activo { get; set; }
        #endregion

        #region Constructor
        public Mecanico()
        { }

        public Mecanico(string Nombre_, string Apellido_, string TipoDocumento_, int Documento_, int Telefono_)
        {
            nombre = Nombre_;
            apellido = Apellido_;
            tipoDocumento = TipoDocumento_;
            documento = Documento_;
            telefono = Telefono_;
        }
        #endregion
    }
}
