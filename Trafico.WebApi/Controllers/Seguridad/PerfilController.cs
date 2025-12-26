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
    
    
    [Route("api/Perfil")]
    [ApiController()]
    public partial class PerfilController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CPerfil oPerfil)
        {
            try
            {
                PerfilFacade faPerfil = new PerfilFacade();
                bool result = faPerfil.Grabar(oPerfil);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faPerfil.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDPerfil}")]
        [HttpGet()]
        public virtual int Eliminar(Int32 IDPerfil)
        {
            try
            {
                PerfilFacade faPerfil = new PerfilFacade();
                return faPerfil.Eliminar(IDPerfil);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDPerfil}")]
        [HttpGet()]
        public virtual CPerfil Recuperar(Int32 IDPerfil)
        {
            try
            {
                PerfilFacade faPerfil = new PerfilFacade();
                return faPerfil.Recuperar(IDPerfil);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDPerfil}")]
        [HttpGet()]
        public virtual bool Existe(Int32 IDPerfil)
        {
            try
            {
                PerfilFacade faPerfil = new PerfilFacade();
                return faPerfil.Existe(IDPerfil);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpPost()]
        public virtual IList<CPerfil> Listar(CPerfil oPerfil)
        {
            try
            {
                PerfilFacade faPerfil = new PerfilFacade();
                return faPerfil.Listar(oPerfil);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
