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
    
    
    [Route("api/Acceso")]
    [ApiController()]
    public partial class AccesoController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CAcceso oAcceso)
        {
            try
            {
                AccesoFacade faAcceso = new AccesoFacade();
                bool result = faAcceso.Grabar(oAcceso);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faAcceso.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_Acceso}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Acceso)
        {
            try
            {
                AccesoFacade faAcceso = new AccesoFacade();
                return faAcceso.Eliminar(Cod_Acceso);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_Acceso}")]
        [HttpGet()]
        public virtual CAcceso Recuperar(String Cod_Acceso)
        {
            try
            {
                AccesoFacade faAcceso = new AccesoFacade();
                return faAcceso.Recuperar(Cod_Acceso);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_Acceso}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Acceso)
        {
            try
            {
                AccesoFacade faAcceso = new AccesoFacade();
                return faAcceso.Existe(Cod_Acceso);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpPost()]
        public virtual IList<CAcceso> Listar(CAcceso acceso)
        {
            try
            {
                AccesoFacade faAcceso = new AccesoFacade();
                return faAcceso.Listar(acceso.Cod_Acceso, acceso.Nombre_Acceso, acceso.Descripcion, Convert.ToString(acceso.Estado));
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
