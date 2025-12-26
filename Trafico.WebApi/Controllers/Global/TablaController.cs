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
    
    
    [Route("api/Tabla")]
    [ApiController()]
    public partial class TablaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CTabla oTabla)
        {
            try
            {
                TablaFacade faTabla = new TablaFacade();
                bool result = faTabla.Grabar(oTabla);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faTabla.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{CodTabla}")]
        [HttpGet()]
        public virtual int Eliminar(String CodTabla)
        {
            try
            {
                TablaFacade faTabla = new TablaFacade();
                return faTabla.Eliminar(CodTabla);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{CodTabla}")]
        [HttpGet()]
        public virtual CTabla Recuperar(String CodTabla)
        {
            try
            {
                TablaFacade faTabla = new TablaFacade();
                return faTabla.Recuperar(CodTabla);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{CodTabla}")]
        [HttpGet()]
        public virtual bool Existe(String CodTabla)
        {
            try
            {
                TablaFacade faTabla = new TablaFacade();
                return faTabla.Existe(CodTabla);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CTabla> Listar()
        {
            try
            {
                TablaFacade faTabla = new TablaFacade();
                return faTabla.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
