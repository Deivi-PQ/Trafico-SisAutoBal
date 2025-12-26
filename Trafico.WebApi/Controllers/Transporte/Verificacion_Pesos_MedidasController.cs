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
    
    
    [Route("api/Verificacion_Pesos_Medidas")]
    [ApiController()]
    public partial class Verificacion_Pesos_MedidasController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CVerificacion_Pesos_Medidas oVerificacion_Pesos_Medidas)
        {
            try
            {
                Verificacion_Pesos_MedidasFacade faVerificacion_Pesos_Medidas = new Verificacion_Pesos_MedidasFacade();
                bool result = faVerificacion_Pesos_Medidas.Grabar(oVerificacion_Pesos_Medidas);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faVerificacion_Pesos_Medidas.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDVerificacion}")]
        [HttpGet()]
        public virtual int Eliminar(Int32 IDVerificacion)
        {
            try
            {
                Verificacion_Pesos_MedidasFacade faVerificacion_Pesos_Medidas = new Verificacion_Pesos_MedidasFacade();
                return faVerificacion_Pesos_Medidas.Eliminar(IDVerificacion);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDVerificacion}")]
        [HttpGet()]
        public virtual CVerificacion_Pesos_Medidas Recuperar(Int32 IDVerificacion)
        {
            try
            {
                Verificacion_Pesos_MedidasFacade faVerificacion_Pesos_Medidas = new Verificacion_Pesos_MedidasFacade();
                return faVerificacion_Pesos_Medidas.Recuperar(IDVerificacion);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDVerificacion}")]
        [HttpGet()]
        public virtual bool Existe(Int32 IDVerificacion)
        {
            try
            {
                Verificacion_Pesos_MedidasFacade faVerificacion_Pesos_Medidas = new Verificacion_Pesos_MedidasFacade();
                return faVerificacion_Pesos_Medidas.Existe(IDVerificacion);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CVerificacion_Pesos_Medidas> Listar()
        {
            try
            {
                Verificacion_Pesos_MedidasFacade faVerificacion_Pesos_Medidas = new Verificacion_Pesos_MedidasFacade();
                return faVerificacion_Pesos_Medidas.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
