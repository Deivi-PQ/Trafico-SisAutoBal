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
    
    
    [Route("api/Serie_Guia_Concentrado")]
    [ApiController()]
    public partial class Serie_Guia_ConcentradoController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CSerie_Guia_Concentrado oSerie_Guia_Concentrado)
        {
            try
            {
                Serie_Guia_ConcentradoFacade faSerie_Guia_Concentrado = new Serie_Guia_ConcentradoFacade();
                bool result = faSerie_Guia_Concentrado.Grabar(oSerie_Guia_Concentrado);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faSerie_Guia_Concentrado.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Nro_Serie}")]
        [HttpGet()]
        public virtual int Eliminar(String Nro_Serie)
        {
            try
            {
                Serie_Guia_ConcentradoFacade faSerie_Guia_Concentrado = new Serie_Guia_ConcentradoFacade();
                return faSerie_Guia_Concentrado.Eliminar(Nro_Serie);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Nro_Serie}")]
        [HttpGet()]
        public virtual CSerie_Guia_Concentrado Recuperar(String Nro_Serie)
        {
            try
            {
                Serie_Guia_ConcentradoFacade faSerie_Guia_Concentrado = new Serie_Guia_ConcentradoFacade();
                return faSerie_Guia_Concentrado.Recuperar(Nro_Serie);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Nro_Serie}")]
        [HttpGet()]
        public virtual bool Existe(String Nro_Serie)
        {
            try
            {
                Serie_Guia_ConcentradoFacade faSerie_Guia_Concentrado = new Serie_Guia_ConcentradoFacade();
                return faSerie_Guia_Concentrado.Existe(Nro_Serie);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CSerie_Guia_Concentrado> Listar()
        {
            try
            {
                Serie_Guia_ConcentradoFacade faSerie_Guia_Concentrado = new Serie_Guia_ConcentradoFacade();
                return faSerie_Guia_Concentrado.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
