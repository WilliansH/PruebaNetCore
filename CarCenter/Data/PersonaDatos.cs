using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Entidades;
using Microsoft.Extensions.Configuration;

namespace CarCenter.Core.API.Datos
{
    public class PersonaDatos
    {
        private Conexion Connect;

        public PersonaDatos(IConfiguration configuration)
        {

            Connect = new Conexion(configuration);
        }

        #region Metodos
       /* public int CrearPersona(Persona persona)
        {
            int busqueda;
            try
            {
                busqueda = int.Parse(Connect.ConsultaScalar(String.Format("Persona_Insert '{0}','{1}','{2}',{3},'{4}','{5}','{6}'", persona.nombre, persona.apellido, persona.tipoDocumento, persona.documento,
                persona.fechaNacimiento.ToString("dd/MM/yyyy"), persona.correo)));
            }
            catch (Exception ex)
            {
                busqueda = 0;
            }


            return busqueda;
        }*/

        public List<Persona> PersonaGetAll()
        {
            List<Persona> listaPersonas = new List<Persona>();

            DataTable dt = Connect.ConsultaDt(string.Format("Personas_All"));

            if (dt.Rows.Count > 0)
            {

                foreach (DataRow row in dt.Rows)
                {
                    Persona persona = new Persona();

                    persona.PersonaId = (int)row[0];
                    persona.nombre = row[1].ToString();
                    persona.apellido= row[2].ToString();
                    persona.fechaNacimiento = (DateTime)row[3];
                    persona.tipoDocumento = row[4].ToString();
                    persona.documento = (int)row[5];
                    persona.correo = row[6].ToString();
                    persona.fechaCreacion = (DateTime)row[7];
                    persona.activo = (bool)row[8];

                    listaPersonas.Add(persona);
                }
            }

            return listaPersonas;
        }

        public Persona PersonaGetId(int PersonaId)
        {
            Persona persona = new Persona();

            var row = Connect.ConsultaDr(string.Format("Persona_por_id {0}", PersonaId));

           if (row[0] != DBNull.Value)
           {
                persona.PersonaId = (int)row[0];
                persona.nombre = row[1].ToString();
                persona.apellido = row[2].ToString();
                persona.fechaNacimiento = (DateTime)row[3];
                persona.tipoDocumento = row[4].ToString();
                persona.documento = (int)row[5]; 
                persona.correo = row[6].ToString();
                persona.fechaCreacion = (DateTime)row[7];
                persona.activo = (bool)row[8];
           }

            return persona;
        }

       /* public bool PersonaUpdate(Persona persona)
        {
            string busqueda = Connect.ConsultaScalar(string.Format("Persona_Update {0},'{1}','{2}','{3}',{4},'{5}','{6}',{7},'{8}'", persona.PersonaId, persona.nombre, persona.apellido, persona.tipoDocumento, persona.documento,
                                                                persona.fechaNacimiento.ToString("dd/MM/yyyy"), persona.correo, persona.activo));

            if (string.IsNullOrEmpty(busqueda))
            {
                return false;
            }
            else
            {
                return true;
            }
        }*/
        #endregion
    }

   
}
