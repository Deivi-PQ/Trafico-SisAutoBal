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
    
    
    [Route("api/Lugar")]
    [ApiController()]
    public partial class LugarController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CLugar oLugar)
        {
            try
            {
                LugarFacade faLugar = new LugarFacade();
                bool result = faLugar.Grabar(oLugar);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faLugar.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDLugar}")]
        [HttpGet()]
        public virtual int Eliminar(Int32 IDLugar)
        {
            try
            {
                LugarFacade faLugar = new LugarFacade();
                return faLugar.Eliminar(IDLugar);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDLugar}")]
        [HttpGet()]
        public virtual CLugar Recuperar(Int32 IDLugar)
        {
            try
            {
                LugarFacade faLugar = new LugarFacade();
                return faLugar.Recuperar(IDLugar);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDLugar}")]
        [HttpGet()]
        public virtual bool Existe(Int32 IDLugar)
        {
            try
            {
                LugarFacade faLugar = new LugarFacade();
                return faLugar.Existe(IDLugar);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CLugar> Listar()
        {
            try
            {
                LugarFacade faLugar = new LugarFacade();
                return faLugar.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
