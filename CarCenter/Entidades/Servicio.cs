using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicio
    {
        #region Atributos
        public int ServicioId { get; set; }
        public Persona persona { get; set; }
        public Carro carro { get; set; }
        public List<Repuesto> listaRepuestos { get; set; }
        public StatusServicio StatusId { get; set; }
        public int tiempoServicio { get; set; }
        public DateTime fechaServicio { get; set; }
        public double costo { get; set; }
        public double costoMecanico { get; set; }
        public string fotos { get; set; }
        #endregion

        #region Constructor
        public Servicio()
        { }

        public Servicio(int Persona_, int Carro_, double Costo_, double CostoMecanico_, string Fotos_)
        {
            persona.PersonaId = Persona_;
            carro.CarroId = Carro_;
            costo = Costo_;
            costoMecanico = CostoMecanico_; 
            fotos = Fotos_;
           
           
        }
        #endregion
    }
}
