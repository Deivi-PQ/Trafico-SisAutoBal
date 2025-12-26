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
    
    
    [Route("api/Tag_RFID")]
    [ApiController()]
    public partial class Tag_RFIDController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CTag_RFID oTag_RFID)
        {
            try
            {
                Tag_RFIDFacade faTag_RFID = new Tag_RFIDFacade();
                bool result = faTag_RFID.Grabar(oTag_RFID);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faTag_RFID.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_RFID}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_RFID)
        {
            try
            {
                Tag_RFIDFacade faTag_RFID = new Tag_RFIDFacade();
                return faTag_RFID.Eliminar(Cod_RFID);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_RFID}")]
        [HttpGet()]
        public virtual CTag_RFID Recuperar(String Cod_RFID)
        {
            try
            {
                Tag_RFIDFacade faTag_RFID = new Tag_RFIDFacade();
                return faTag_RFID.Recuperar(Cod_RFID);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_RFID}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_RFID)
        {
            try
            {
                Tag_RFIDFacade faTag_RFID = new Tag_RFIDFacade();
                return faTag_RFID.Existe(Cod_RFID);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar/{Cod_RFID}/{Nro_Placa}")]
        [HttpGet()]
        public virtual IList<CTag_RFID> Listar(String Cod_RFID,String Nro_Placa)
        {
            try
            {
                Tag_RFIDFacade faTag_RFID = new Tag_RFIDFacade();
                return faTag_RFID.Listar(Cod_RFID == "*" ? "" : Cod_RFID, Nro_Placa == "*" ? "" : Nro_Placa);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
