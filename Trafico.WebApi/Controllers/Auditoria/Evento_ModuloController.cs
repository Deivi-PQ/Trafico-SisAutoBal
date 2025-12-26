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
using Trafico.BusinessObjects.Auditoria;
using Trafico.Facade.Auditoria;

namespace Trafico.WebApi.Controllers.Auditoria
{
    
    
    [Route("api/Evento_Modulo")]
    [ApiController()]
    public partial class Evento_ModuloController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CEvento_Modulo oEvento_Modulo)
        {
            try
            {
                Evento_ModuloFacade faEvento_Modulo = new Evento_ModuloFacade();
                bool result = faEvento_Modulo.Grabar(oEvento_Modulo);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faEvento_Modulo.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDEvento_Mod}")]
        [HttpGet()]
        public virtual int Eliminar(Int32 IDEvento_Mod)
        {
            try
            {
                Evento_ModuloFacade faEvento_Modulo = new Evento_ModuloFacade();
                return faEvento_Modulo.Eliminar(IDEvento_Mod);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDEvento_Mod}")]
        [HttpGet()]
        public virtual CEvento_Modulo Recuperar(Int32 IDEvento_Mod)
        {
            try
            {
                Evento_ModuloFacade faEvento_Modulo = new Evento_ModuloFacade();
                return faEvento_Modulo.Recuperar(IDEvento_Mod);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDEvento_Mod}")]
        [HttpGet()]
        public virtual bool Existe(Int32 IDEvento_Mod)
        {
            try
            {
                Evento_ModuloFacade faEvento_Modulo = new Evento_ModuloFacade();
                return faEvento_Modulo.Existe(IDEvento_Mod);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CEvento_Modulo> Listar()
        {
            try
            {
                Evento_ModuloFacade faEvento_Modulo = new Evento_ModuloFacade();
                return faEvento_Modulo.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
