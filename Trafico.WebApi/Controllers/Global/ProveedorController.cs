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
    
    
    [Route("api/Proveedor")]
    [ApiController()]
    public partial class ProveedorController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CProveedor oProveedor)
        {
            try
            {
                ProveedorFacade faProveedor = new ProveedorFacade();
                bool result = faProveedor.Grabar(oProveedor);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faProveedor.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDProveedor}")]
        [HttpGet()]
        public virtual int Eliminar(String IDProveedor)
        {
            try
            {
                ProveedorFacade faProveedor = new ProveedorFacade();
                return faProveedor.Eliminar(IDProveedor);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDProveedor}")]
        [HttpGet()]
        public virtual CProveedor Recuperar(String IDProveedor)
        {
            try
            {
                ProveedorFacade faProveedor = new ProveedorFacade();
                return faProveedor.Recuperar(IDProveedor);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDProveedor}")]
        [HttpGet()]
        public virtual bool Existe(String IDProveedor)
        {
            try
            {
                ProveedorFacade faProveedor = new ProveedorFacade();
                return faProveedor.Existe(IDProveedor);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CProveedor> Listar()
        {
            try
            {
                ProveedorFacade faProveedor = new ProveedorFacade();
                return faProveedor.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
