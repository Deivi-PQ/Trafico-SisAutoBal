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
using Trafico.BusinessObjects.Concentrado;
using Trafico.Facade.Concentrado;

namespace TraficoWebApi.Controllers.Concentrado
{
    
    
    [Route("api/Lote_Concentrado")]
    [ApiController()]
    public partial class Lote_ConcentradoController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CLote_Concentrado oLote_Concentrado)
        {
            try
            {
                Lote_ConcentradoFacade faLote_Concentrado = new Lote_ConcentradoFacade();
                bool result = faLote_Concentrado.Grabar(oLote_Concentrado);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faLote_Concentrado.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Nro_Lote}")]
        [HttpGet()]
        public virtual int Eliminar(String Nro_Lote)
        {
            try
            {
                Lote_ConcentradoFacade faLote_Concentrado = new Lote_ConcentradoFacade();
                return faLote_Concentrado.Eliminar(Nro_Lote);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Nro_Lote}")]
        [HttpGet()]
        public virtual CLote_Concentrado Recuperar(String Nro_Lote)
        {
            try
            {
                Lote_ConcentradoFacade faLote_Concentrado = new Lote_ConcentradoFacade();
                return faLote_Concentrado.Recuperar(Nro_Lote);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Nro_Lote}")]
        [HttpGet()]
        public virtual bool Existe(String Nro_Lote)
        {
            try
            {
                Lote_ConcentradoFacade faLote_Concentrado = new Lote_ConcentradoFacade();
                return faLote_Concentrado.Existe(Nro_Lote);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CLote_Concentrado> Listar()
        {
            try
            {
                Lote_ConcentradoFacade faLote_Concentrado = new Lote_ConcentradoFacade();
                return faLote_Concentrado.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
