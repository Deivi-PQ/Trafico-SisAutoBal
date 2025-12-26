//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LibreriaBSNetCore.Exceptions;
using Microsoft.AspNetCore.Http;
using Trafico.BusinessObjects.Global;
using Trafico.Facade.Global;

namespace TraficoWebApi.Controllers.Global
{
    
    
    [Route("api/Persona")]
    [ApiController()]
    public partial class PersonaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CPersona oPersona)
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                bool result = faPersona.Grabar(oPersona);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faPersona.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDPersona}")]
        [HttpGet()]
        public virtual int Eliminar(String IDPersona)
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.Eliminar(IDPersona);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDPersona}")]
        [HttpGet()]
        public virtual CPersona Recuperar(String IDPersona)
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.Recuperar(IDPersona);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDPersona}")]
        [HttpGet()]
        public virtual bool Existe(String IDPersona)
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.Existe(IDPersona);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CPersona> Listar()
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
