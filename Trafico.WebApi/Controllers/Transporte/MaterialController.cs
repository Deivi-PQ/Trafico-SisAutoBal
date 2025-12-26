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
    
    
    [Route("api/Material")]
    [ApiController()]
    public partial class MaterialController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CMaterial oMaterial)
        {
            try
            {
                MaterialFacade faMaterial = new MaterialFacade();
                bool result = faMaterial.Grabar(oMaterial);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faMaterial.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDMaterial}")]
        [HttpGet()]
        public virtual int Eliminar(Int32 IDMaterial)
        {
            try
            {
                MaterialFacade faMaterial = new MaterialFacade();
                return faMaterial.Eliminar(IDMaterial);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDMaterial}")]
        [HttpGet()]
        public virtual CMaterial Recuperar(Int32 IDMaterial)
        {
            try
            {
                MaterialFacade faMaterial = new MaterialFacade();
                return faMaterial.Recuperar(IDMaterial);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDMaterial}")]
        [HttpGet()]
        public virtual bool Existe(Int32 IDMaterial)
        {
            try
            {
                MaterialFacade faMaterial = new MaterialFacade();
                return faMaterial.Existe(IDMaterial);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CMaterial> Listar()
        {
            try
            {
                MaterialFacade faMaterial = new MaterialFacade();
                return faMaterial.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
