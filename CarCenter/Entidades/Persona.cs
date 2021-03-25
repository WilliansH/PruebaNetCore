using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Atributos
        public int PersonaId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDocumento { get; set; }
        public int documento { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public bool activo { get; set; }
        #endregion

        #region Constructor
        public Persona()
        { }

        public Persona(string Nombre_ , string Apellido_, string TipoDocumento_, int Documento_, DateTime Fecha_, string Correo_)
        {
            nombre = Nombre_;
            apellido = Apellido_;
            tipoDocumento = TipoDocumento_ ;
            documento = Documento_;
            fechaNacimiento = Fecha_;
            correo = Correo_;
        }
        #endregion
    }
}
