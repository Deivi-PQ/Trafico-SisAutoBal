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
    
    
    [Route("api/Config_Pesos_Medidas")]
    [ApiController()]
    public partial class Config_Pesos_MedidasController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CConfig_Pesos_Medidas oConfig_Pesos_Medidas)
        {
            try
            {
                Config_Pesos_MedidasFacade faConfig_Pesos_Medidas = new Config_Pesos_MedidasFacade();
                bool result = faConfig_Pesos_Medidas.Grabar(oConfig_Pesos_Medidas);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faConfig_Pesos_Medidas.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Conf_Vehicular}")]
        [HttpGet()]
        public virtual int Eliminar(String Conf_Vehicular)
        {
            try
            {
                Config_Pesos_MedidasFacade faConfig_Pesos_Medidas = new Config_Pesos_MedidasFacade();
                return faConfig_Pesos_Medidas.Eliminar(Conf_Vehicular);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Conf_Vehicular}")]
        [HttpGet()]
        public virtual CConfig_Pesos_Medidas Recuperar(String Conf_Vehicular)
        {
            try
            {
                Config_Pesos_MedidasFacade faConfig_Pesos_Medidas = new Config_Pesos_MedidasFacade();
                return faConfig_Pesos_Medidas.Recuperar(Conf_Vehicular);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Conf_Vehicular}")]
        [HttpGet()]
        public virtual bool Existe(String Conf_Vehicular)
        {
            try
            {
                Config_Pesos_MedidasFacade faConfig_Pesos_Medidas = new Config_Pesos_MedidasFacade();
                return faConfig_Pesos_Medidas.Existe(Conf_Vehicular);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CConfig_Pesos_Medidas> Listar()
        {
            try
            {
                Config_Pesos_MedidasFacade faConfig_Pesos_Medidas = new Config_Pesos_MedidasFacade();
                return faConfig_Pesos_Medidas.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
