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
    
    
    [Route("api/Balanza")]
    [ApiController()]
    public partial class BalanzaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CBalanza oBalanza)
        {
            try
            {
                BalanzaFacade faBalanza = new BalanzaFacade();
                bool result = faBalanza.Grabar(oBalanza);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faBalanza.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDBalanza}")]
        [HttpGet()]
        public virtual int Eliminar(String IDBalanza)
        {
            try
            {
                BalanzaFacade faBalanza = new BalanzaFacade();
                return faBalanza.Eliminar(IDBalanza);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDBalanza}")]
        [HttpGet()]
        public virtual CBalanza Recuperar(String IDBalanza)
        {
            try
            {
                BalanzaFacade faBalanza = new BalanzaFacade();
                return faBalanza.Recuperar(IDBalanza);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDBalanza}")]
        [HttpGet()]
        public virtual bool Existe(String IDBalanza)
        {
            try
            {
                BalanzaFacade faBalanza = new BalanzaFacade();
                return faBalanza.Existe(IDBalanza);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar/{Des_Balanza}/{Tipo}/{Estado}/{SN_Contr}")]
        [HttpGet()]
        public virtual IList<CBalanza> Listar(String Des_Balanza, String Tipo, String Estado,String SN_Contr)
        {
            try
            {
                BalanzaFacade faBalanza = new BalanzaFacade();
                return faBalanza.Listar(Des_Balanza=="*"? "": Des_Balanza, Tipo == "*"?"":Tipo, Estado == "T" ? "" : Estado, SN_Contr == "*" ? "" : SN_Contr);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
