using CarCenter.Core.API.Datos;
using Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;


 namespace CarCenter.Core.API.LogicLayer
{
    public class PersonaLogic
    {
        private PersonaDatos personaDatos;

        #region Constructor
        public PersonaLogic(IConfiguration configuration)
        {
            personaDatos = new PersonaDatos(configuration);
        }
        #endregion

        #region Metodos Publicos
       /* public int CrearPersona(Persona persona)
        {
            return personaDatos.CrearPersona(persona);
        }*/

        public List<Persona> PersonaGetAll()
        {
            List<Persona> listaPersonas = personaDatos.PersonaGetAll();
            return listaPersonas;
        }

        public Persona PersonaGetId(int PersonaId)
        {
            Persona persona = personaDatos.PersonaGetId(PersonaId);
            return persona;
        }

        /*public bool PersonaUpdate(Persona persona)
        {
            return personaDatos.PersonaUpdate(persona);
        }*/
        #endregion 


    }


}
