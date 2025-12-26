//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 17 de noviembre de 2025
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
    
    
    [Route("api/Comandos")]
    [ApiController()]
    public partial class ComandosController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(Comandos ocomandos)
        {
            try
            {
                ComandosFacade faomandos = new ComandosFacade();
                bool result = faomandos.Grabar(ocomandos);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faomandos.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{id}")]
        [HttpGet()]
        public virtual int Eliminar(Int32 id)
        {
            try
            {
                ComandosFacade faomandos = new ComandosFacade();
                return faomandos.Eliminar(id);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{sn}")]
        [HttpGet()]
        public virtual Comandos Recuperar(String sn)
        {
            try
            {
                ComandosFacade faomandos = new ComandosFacade();
                return faomandos.Recuperar(sn);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{id}")]
        [HttpGet()]
        public virtual bool Existe(Int32 id)
        {
            try
            {
                ComandosFacade faomandos = new ComandosFacade();
                return faomandos.Existe(id);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<Comandos> Listar()
        {
            try
            {
                ComandosFacade faomandos = new ComandosFacade();
                return faomandos.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
