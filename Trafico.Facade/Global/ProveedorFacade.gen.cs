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

namespace Trafico.Facade.Global
{
    
    
    [DataObject(true)]
    public partial class ProveedorFacade
    {
        
        private ProveedorDao proveedor;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public ProveedorFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: proveedor = new ProveedorDao();
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
        public virtual bool Grabar(CProveedor oProveedor)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oProveedor.IDProveedor.Trim() == "")
            {
            	Error = "IDProveedor no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return proveedor.Grabar(oProveedor);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CProveedor oProveedor, out string error)
        {
            bool rpta = Grabar(oProveedor);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String IDProveedor)
        {
            return proveedor.Eliminar(IDProveedor);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CProveedor Recuperar(String IDProveedor)
        {
            return proveedor.Recuperar(IDProveedor);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String IDProveedor)
        {
            return proveedor.Existe(IDProveedor);
        }
        
        public virtual bool Existe(String IDProveedor, out CProveedor oProveedor)
        {
            return proveedor.Existe(IDProveedor, out oProveedor);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CProveedor> Listar()
        {
            return proveedor.Listar();
        }
        #endregion
    }
}
