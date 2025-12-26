//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using LibreriaBSNetCore.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using Trafico.BusinessObjects.Transporte;
using Trafico.Facade.Transporte;

namespace TraficoWebApi.Controllers.Transporte
{
    
    
    [Route("api/PesoBalanza")]
    [ApiController()]
    public partial class PesoBalanzaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CPesoBalanza oPesoBalanza)
        {
            try
            {
                PesoBalanzaFacade faPesoBalanza = new PesoBalanzaFacade();
                bool result = faPesoBalanza.Grabar(oPesoBalanza);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faPesoBalanza.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDPesaje}")]
        [HttpGet()]
        public virtual int Eliminar(Int32 IDPesaje)
        {
            try
            {
                PesoBalanzaFacade faPesoBalanza = new PesoBalanzaFacade();
                return faPesoBalanza.Eliminar(IDPesaje);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDPesaje}")]
        [HttpGet()]
        public virtual CPesoBalanza Recuperar(Int32 IDPesaje)
        {
            try
            {
                PesoBalanzaFacade faPesoBalanza = new PesoBalanzaFacade();
                return faPesoBalanza.Recuperar(IDPesaje);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDPesaje}")]
        [HttpGet()]
        public virtual bool Existe(Int32 IDPesaje)
        {
            try
            {
                PesoBalanzaFacade faPesoBalanza = new PesoBalanzaFacade();
                return faPesoBalanza.Existe(IDPesaje);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar/{IDBalanza}/{ID}/{Nro_Placa}/{fecha_Ini}/{fecha_Fin}/{page_Number}/{page_Size}")]
        [HttpGet()]
        public virtual IList<CPesoBalanza> Listar(String IDBalanza, String ID, String Nro_Placa, DateTime fecha_Ini, DateTime fecha_Fin,int page_Number, int page_Size)
        {
            try
            {
                PesoBalanzaFacade faPesoBalanza = new PesoBalanzaFacade();
                return faPesoBalanza.Listar(IDBalanza,ID, Nro_Placa, fecha_Ini, fecha_Fin,page_Number,page_Size);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("ReportePesoBalanza/{fecha_Ini}/{fecha_Fin}/{Nro_Placa}")]
        [HttpGet()]
        public virtual DataTable ReportePesoBalanza(DateTime fecha_Ini, DateTime fecha_Fin, String Nro_Placa)
        {
            try
            {
                PesoBalanzaFacade faPesoBalanza = new PesoBalanzaFacade();
                return faPesoBalanza.ReportePesoBalanza(fecha_Ini, fecha_Fin, Nro_Placa);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
