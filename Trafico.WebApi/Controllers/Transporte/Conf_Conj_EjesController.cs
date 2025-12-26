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
    
    
    [Route("api/Conf_Conj_Ejes")]
    [ApiController()]
    public partial class Conf_Conj_EjesController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CConf_Conj_Ejes oConf_Conj_Ejes)
        {
            try
            {
                Conf_Conj_EjesFacade faConf_Conj_Ejes = new Conf_Conj_EjesFacade();
                bool result = faConf_Conj_Ejes.Grabar(oConf_Conj_Ejes);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faConf_Conj_Ejes.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Conf_Vehicular}/{NroConjEje}")]
        [HttpGet()]
        public virtual int Eliminar(String Conf_Vehicular, Int16 NroConjEje)
        {
            try
            {
                Conf_Conj_EjesFacade faConf_Conj_Ejes = new Conf_Conj_EjesFacade();
                return faConf_Conj_Ejes.Eliminar(Conf_Vehicular,NroConjEje);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Conf_Vehicular}/{NroConjEje}")]
        [HttpGet()]
        public virtual CConf_Conj_Ejes Recuperar(String Conf_Vehicular, Int16 NroConjEje)
        {
            try
            {
                Conf_Conj_EjesFacade faConf_Conj_Ejes = new Conf_Conj_EjesFacade();
                return faConf_Conj_Ejes.Recuperar(Conf_Vehicular,NroConjEje);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Conf_Vehicular}/{NroConjEje}")]
        [HttpGet()]
        public virtual bool Existe(String Conf_Vehicular, Int16 NroConjEje)
        {
            try
            {
                Conf_Conj_EjesFacade faConf_Conj_Ejes = new Conf_Conj_EjesFacade();
                return faConf_Conj_Ejes.Existe(Conf_Vehicular,NroConjEje);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CConf_Conj_Ejes> Listar()
        {
            try
            {
                Conf_Conj_EjesFacade faConf_Conj_Ejes = new Conf_Conj_EjesFacade();
                return faConf_Conj_Ejes.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
