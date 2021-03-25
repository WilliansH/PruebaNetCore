using System;
using System.ComponentModel;
using System.Web.Http.Results;
using CarCenter.Core.API.LogicLayer;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CarCenter.Core.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        
        #region Atributos
        private readonly IConfiguration configuration;
        PersonaLogic logica;

        #endregion

        #region Constructores
        public PersonaController(IConfiguration configuration)
        {
            logica = logica ?? new PersonaLogic(configuration);
        }
        #endregion

        #region Controlador


        [HttpGet]
        [Route("Personas_All")]
        public IActionResult ConsultarTodasLasPersonas() {
            try
            {
                return Ok(logica.PersonaGetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("Personas_por_id")]
        public IActionResult ConsultarPersonaPorId(int PersonaId)
        {
            try
            {
                return Ok(logica.PersonaGetId(PersonaId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

      /*  [HttpPost]
        [Route("CrearPersona")]
        public IActionResult RealizarCrearPersona([FromBody]Persona persona)
        {
            try
            {
                return Ok(logica.CrearPersona(persona));
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("ActualizarPersona")]
        public IActionResult ActualizaPersona([FromBody]Persona persona)
        {
            try
            {
                return Ok(logica.PersonaUpdate(persona));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        */
        #endregion
        
    }
}