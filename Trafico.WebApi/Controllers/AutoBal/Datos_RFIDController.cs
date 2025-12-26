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
using Trafico.BusinessObjects.AutoBal;
using Trafico.Facade.AutoBal;

namespace TraficoWebApi.Controllers.AutoBal
{
    
    
    [Route("api/Datos_RFID")]
    [ApiController()]
    public partial class Datos_RFIDController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CDatos_RFID oDatos_RFID)
        {
            try
            {
                Datos_RFIDFacade faDatos_RFID = new Datos_RFIDFacade();
                bool result = faDatos_RFID.Grabar(oDatos_RFID);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faDatos_RFID.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{ID}")]
        [HttpGet()]
        public virtual int Eliminar(Int64 ID)
        {
            try
            {
                Datos_RFIDFacade faDatos_RFID = new Datos_RFIDFacade();
                return faDatos_RFID.Eliminar(ID);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{ID}")]
        [HttpGet()]
        public virtual CDatos_RFID Recuperar(Int64 ID)
        {
            try
            {
                Datos_RFIDFacade faDatos_RFID = new Datos_RFIDFacade();
                return faDatos_RFID.Recuperar(ID);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{ID}")]
        [HttpGet()]
        public virtual bool Existe(Int64 ID)
        {
            try
            {
                Datos_RFIDFacade faDatos_RFID = new Datos_RFIDFacade();
                return faDatos_RFID.Existe(ID);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CDatos_RFID> Listar()
        {
            try
            {
                Datos_RFIDFacade faDatos_RFID = new Datos_RFIDFacade();
                return faDatos_RFID.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
