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
    
    
    [Route("api/Vehiculo")]
    [ApiController()]
    public partial class VehiculoController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CVehiculo oVehiculo)
        {
            try
            {
                VehiculoFacade faVehiculo = new VehiculoFacade();
                bool result = faVehiculo.Grabar(oVehiculo);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faVehiculo.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Nro_Placa}")]
        [HttpGet()]
        public virtual int Eliminar(String Nro_Placa)
        {
            try
            {
                VehiculoFacade faVehiculo = new VehiculoFacade();
                return faVehiculo.Eliminar(Nro_Placa);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Nro_Placa}")]
        [HttpGet()]
        public virtual CVehiculo Recuperar(String Nro_Placa)
        {
            try
            {
                VehiculoFacade faVehiculo = new VehiculoFacade();
                return faVehiculo.Recuperar(Nro_Placa);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Nro_Placa}")]
        [HttpGet()]
        public virtual bool Existe(String Nro_Placa)
        {
            try
            {
                VehiculoFacade faVehiculo = new VehiculoFacade();
                return faVehiculo.Existe(Nro_Placa);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar/{Nro_Placa}/{IDProveedor}/{Año}/{Nro_Ejes}/{Estado}/{Tipo_Unidad}")]
        [HttpGet()]
        public virtual IList<CVehiculo> Listar(String Nro_Placa, String IDProveedor, Int16 Año, Int16 Nro_Ejes, String Estado,String Tipo_Unidad)
        {
            try
            {
                VehiculoFacade faVehiculo = new VehiculoFacade();
                return faVehiculo.Listar(Nro_Placa,IDProveedor, Año, Nro_Ejes, Estado, Tipo_Unidad);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
