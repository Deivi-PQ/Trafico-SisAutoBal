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
    
    
    [Route("api/Archivo")]
    [ApiController()]
    public partial class ArchivoController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CArchivo oArchivo)
        {
            try
            {
                ArchivoFacade faArchivo = new ArchivoFacade();
                bool result = faArchivo.Grabar(oArchivo);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faArchivo.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_Archivo}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Archivo)
        {
            try
            {
                ArchivoFacade faArchivo = new ArchivoFacade();
                return faArchivo.Eliminar(Cod_Archivo);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_Archivo}")]
        [HttpGet()]
        public virtual CArchivo Recuperar(String Cod_Archivo)
        {
            try
            {
                ArchivoFacade faArchivo = new ArchivoFacade();
                return faArchivo.Recuperar(Cod_Archivo);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_Archivo}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Archivo)
        {
            try
            {
                ArchivoFacade faArchivo = new ArchivoFacade();
                return faArchivo.Existe(Cod_Archivo);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CArchivo> Listar()
        {
            try
            {
                ArchivoFacade faArchivo = new ArchivoFacade();
                return faArchivo.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
