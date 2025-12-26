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
using Trafico.BusinessObjects.Seguridad;
using Trafico.Facade.Seguridad;

namespace TraficoWebApi.Controllers.Seguridad
{
    
    
    [Route("api/Usuario")]
    [ApiController()]
    public partial class UsuarioController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CUsuario oUsuario)
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                bool result = faUsuario.Grabar(oUsuario);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faUsuario.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDUsuario}")]
        [HttpGet()]
        public virtual int Eliminar(String IDUsuario)
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                return faUsuario.Eliminar(IDUsuario);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDUsuario}")]
        [HttpGet()]
        public virtual CUsuario Recuperar(String IDUsuario)
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                return faUsuario.Recuperar(IDUsuario);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDUsuario}")]
        [HttpGet()]
        public virtual bool Existe(String IDUsuario)
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                return faUsuario.Existe(IDUsuario);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CUsuario> Listar()
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                return faUsuario.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
