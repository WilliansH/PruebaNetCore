using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carro
    {
        #region Atributos
        public Persona persona { get; set; }
        public int CarroId { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public DateTime fechaRegistro { get; set; }
        public bool activo { get; set; }
        #endregion

        #region Constructor
        public Carro()
        { }

        public Carro(Persona Persona_, string Placa_, string Modelo_, string Marca_)
        {
            persona = Persona_;
            placa = Placa_;
            modelo = Modelo_;
            marca = Marca_;
        }
        #endregion
    }
}
