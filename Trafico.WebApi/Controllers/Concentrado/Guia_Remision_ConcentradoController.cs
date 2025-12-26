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
    
    
    [Route("api/Guia_Remision_Concentrado")]
    [ApiController()]
    public partial class Guia_Remision_ConcentradoController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CGuia_Remision_Concentrado oGuia_Remision_Concentrado)
        {
            try
            {
                Guia_Remision_ConcentradoFacade faGuia_Remision_Concentrado = new Guia_Remision_ConcentradoFacade();
                bool result = faGuia_Remision_Concentrado.Grabar(oGuia_Remision_Concentrado);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faGuia_Remision_Concentrado.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Nro_Serie}/{Nro_Guia_Remision}")]
        [HttpGet()]
        public virtual int Eliminar(String Nro_Serie, String Nro_Guia_Remision)
        {
            try
            {
                Guia_Remision_ConcentradoFacade faGuia_Remision_Concentrado = new Guia_Remision_ConcentradoFacade();
                return faGuia_Remision_Concentrado.Eliminar(Nro_Serie,Nro_Guia_Remision);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Nro_Serie}/{Nro_Guia_Remision}")]
        [HttpGet()]
        public virtual CGuia_Remision_Concentrado Recuperar(String Nro_Serie, String Nro_Guia_Remision)
        {
            try
            {
                Guia_Remision_ConcentradoFacade faGuia_Remision_Concentrado = new Guia_Remision_ConcentradoFacade();
                return faGuia_Remision_Concentrado.Recuperar(Nro_Serie,Nro_Guia_Remision);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Nro_Serie}/{Nro_Guia_Remision}")]
        [HttpGet()]
        public virtual bool Existe(String Nro_Serie, String Nro_Guia_Remision)
        {
            try
            {
                Guia_Remision_ConcentradoFacade faGuia_Remision_Concentrado = new Guia_Remision_ConcentradoFacade();
                return faGuia_Remision_Concentrado.Existe(Nro_Serie,Nro_Guia_Remision);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CGuia_Remision_Concentrado> Listar()
        {
            try
            {
                Guia_Remision_ConcentradoFacade faGuia_Remision_Concentrado = new Guia_Remision_ConcentradoFacade();
                return faGuia_Remision_Concentrado.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
