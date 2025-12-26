//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNetCore.InfoApp;
using Trafico.BusinessObjects.Global;
using Trafico.DataObjects.Global;
using Trafico.Facade.Global;

namespace Trafico.Facade.Global
{
    
    
    [DataObject(true)]
    public partial class VehiculoFacade
    {
        
        private VehiculoDao vehiculo;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public VehiculoFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: vehiculo = new VehiculoDao();
            break;
            }
        }
        #endregion
        
        #region Metodos de Control de Errores
        public virtual string getError()
        {
            return Error;
        }
        
        public virtual bool HayError()
        {
            return hayError;
        }
        #endregion
        
        #region Metodos Basicos
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CVehiculo oVehiculo)
        {
            Error = "";
            hayError = false;
            ProveedorFacade faProveedor = new ProveedorFacade();
            //---Validando campos no nulos
            if (oVehiculo.Nro_Placa.Trim() == "")
            {
            	Error = "Nro_Placa no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if ((oVehiculo.IDProveedor.Trim() != "" && (!faProveedor.Existe(oVehiculo.IDProveedor))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oVehiculo.IDProveedor," en IDProveedor no existe. (Proveedor, IDProveedor)");
            	hayError = true;
            	return false;
            }
            else
            	return vehiculo.Grabar(oVehiculo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CVehiculo oVehiculo, out string error)
        {
            bool rpta = Grabar(oVehiculo);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Nro_Placa)
        {
            return vehiculo.Eliminar(Nro_Placa);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CVehiculo Recuperar(String Nro_Placa)
        {
            return vehiculo.Recuperar(Nro_Placa);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Nro_Placa)
        {
            return vehiculo.Existe(Nro_Placa);
        }
        
        public virtual bool Existe(String Nro_Placa, out CVehiculo oVehiculo)
        {
            return vehiculo.Existe(Nro_Placa, out oVehiculo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CVehiculo> Listar(String Nro_Placa, String IDProveedor, Int16 Año, Int16 Nro_Ejes, String Estado, String Tipo_Unidad)
        {
            return vehiculo.Listar( Nro_Placa,  IDProveedor,  Año,  Nro_Ejes,  Estado,  Tipo_Unidad);
        }
        #endregion
    }
}
