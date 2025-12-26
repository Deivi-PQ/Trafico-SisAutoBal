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

namespace TraficoWebApi.Controllers.Auditoria
{
    
    
    [Route("api/Acceso_Modulo")]
    [ApiController()]
    public partial class Acceso_ModuloController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CAcceso_Modulo oAcceso_Modulo)
        {
            try
            {
                Acceso_ModuloFacade faAcceso_Modulo = new Acceso_ModuloFacade();
                bool result = faAcceso_Modulo.Grabar(oAcceso_Modulo);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faAcceso_Modulo.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDAcceso_Mod}")]
        [HttpGet()]
        public virtual int Eliminar(Int32 IDAcceso_Mod)
        {
            try
            {
                Acceso_ModuloFacade faAcceso_Modulo = new Acceso_ModuloFacade();
                return faAcceso_Modulo.Eliminar(IDAcceso_Mod);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDAcceso_Mod}")]
        [HttpGet()]
        public virtual CAcceso_Modulo Recuperar(Int32 IDAcceso_Mod)
        {
            try
            {
                Acceso_ModuloFacade faAcceso_Modulo = new Acceso_ModuloFacade();
                return faAcceso_Modulo.Recuperar(IDAcceso_Mod);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDAcceso_Mod}")]
        [HttpGet()]
        public virtual bool Existe(Int32 IDAcceso_Mod)
        {
            try
            {
                Acceso_ModuloFacade faAcceso_Modulo = new Acceso_ModuloFacade();
                return faAcceso_Modulo.Existe(IDAcceso_Mod);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CAcceso_Modulo> Listar()
        {
            try
            {
                Acceso_ModuloFacade faAcceso_Modulo = new Acceso_ModuloFacade();
                return faAcceso_Modulo.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
