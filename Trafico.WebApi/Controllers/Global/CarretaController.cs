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
using Trafico.BusinessObjects.Global;
using Trafico.Facade.Global;

namespace TraficoWebApi.Controllers.Global
{
    
    
    [Route("api/Carreta")]
    [ApiController()]
    public partial class CarretaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CCarreta oCarreta)
        {
            try
            {
                CarretaFacade faCarreta = new CarretaFacade();
                bool result = faCarreta.Grabar(oCarreta);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faCarreta.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDCarreta}")]
        [HttpGet()]
        public virtual int Eliminar(String IDCarreta)
        {
            try
            {
                CarretaFacade faCarreta = new CarretaFacade();
                return faCarreta.Eliminar(IDCarreta);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDCarreta}")]
        [HttpGet()]
        public virtual CCarreta Recuperar(String IDCarreta)
        {
            try
            {
                CarretaFacade faCarreta = new CarretaFacade();
                return faCarreta.Recuperar(IDCarreta);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDCarreta}")]
        [HttpGet()]
        public virtual bool Existe(String IDCarreta)
        {
            try
            {
                CarretaFacade faCarreta = new CarretaFacade();
                return faCarreta.Existe(IDCarreta);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CCarreta> Listar()
        {
            try
            {
                CarretaFacade faCarreta = new CarretaFacade();
                return faCarreta.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
