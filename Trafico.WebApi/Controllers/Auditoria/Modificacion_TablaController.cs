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
    
    
    [Route("api/Modificacion_Tabla")]
    [ApiController()]
    public partial class Modificacion_TablaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CModificacion_Tabla oModificacion_Tabla)
        {
            try
            {
                Modificacion_TablaFacade faModificacion_Tabla = new Modificacion_TablaFacade();
                bool result = faModificacion_Tabla.Grabar(oModificacion_Tabla);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faModificacion_Tabla.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{idModificacion}")]
        [HttpGet()]
        public virtual int Eliminar(Int32 idModificacion)
        {
            try
            {
                Modificacion_TablaFacade faModificacion_Tabla = new Modificacion_TablaFacade();
                return faModificacion_Tabla.Eliminar(idModificacion);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{idModificacion}")]
        [HttpGet()]
        public virtual CModificacion_Tabla Recuperar(Int32 idModificacion)
        {
            try
            {
                Modificacion_TablaFacade faModificacion_Tabla = new Modificacion_TablaFacade();
                return faModificacion_Tabla.Recuperar(idModificacion);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{idModificacion}")]
        [HttpGet()]
        public virtual bool Existe(Int32 idModificacion)
        {
            try
            {
                Modificacion_TablaFacade faModificacion_Tabla = new Modificacion_TablaFacade();
                return faModificacion_Tabla.Existe(idModificacion);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CModificacion_Tabla> Listar()
        {
            try
            {
                Modificacion_TablaFacade faModificacion_Tabla = new Modificacion_TablaFacade();
                return faModificacion_Tabla.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
