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
using Trafico.BusinessObjects.Transporte;
using Trafico.Facade.Transporte;

namespace TraficoWebApi.Controllers.Transporte
{
    
    
    [Route("api/Sistema_Transp")]
    [ApiController()]
    public partial class Sistema_TranspController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CSistema_Transp oSistema_Transp)
        {
            try
            {
                Sistema_TranspFacade faSistema_Transp = new Sistema_TranspFacade();
                bool result = faSistema_Transp.Grabar(oSistema_Transp);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faSistema_Transp.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_Sis_Transp}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Sis_Transp)
        {
            try
            {
                Sistema_TranspFacade faSistema_Transp = new Sistema_TranspFacade();
                return faSistema_Transp.Eliminar(Cod_Sis_Transp);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_Sis_Transp}")]
        [HttpGet()]
        public virtual CSistema_Transp Recuperar(String Cod_Sis_Transp)
        {
            try
            {
                Sistema_TranspFacade faSistema_Transp = new Sistema_TranspFacade();
                return faSistema_Transp.Recuperar(Cod_Sis_Transp);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_Sis_Transp}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Sis_Transp)
        {
            try
            {
                Sistema_TranspFacade faSistema_Transp = new Sistema_TranspFacade();
                return faSistema_Transp.Existe(Cod_Sis_Transp);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CSistema_Transp> Listar()
        {
            try
            {
                Sistema_TranspFacade faSistema_Transp = new Sistema_TranspFacade();
                return faSistema_Transp.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
