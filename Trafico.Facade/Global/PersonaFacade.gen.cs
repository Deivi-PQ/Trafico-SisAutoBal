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
    public partial class PersonaFacade
    {
        
        private PersonaDao persona;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public PersonaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: persona = new PersonaDao();
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
        public virtual bool Grabar(CPersona oPersona)
        {
            Error = "";
            hayError = false;
            ProveedorFacade faProveedor = new ProveedorFacade();
            //---Validando campos no nulos
            if (oPersona.IDPersona.Trim() == "")
            {
            	Error = "IDPersona no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if ((oPersona.IDProveedor.Trim() != "" && (!faProveedor.Existe(oPersona.IDProveedor))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oPersona.IDProveedor," en IDProveedor no existe. (Proveedor, IDProveedor)");
            	hayError = true;
            	return false;
            }
            else
            	return persona.Grabar(oPersona);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CPersona oPersona, out string error)
        {
            bool rpta = Grabar(oPersona);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String IDPersona)
        {
            return persona.Eliminar(IDPersona);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CPersona Recuperar(String IDPersona)
        {
            return persona.Recuperar(IDPersona);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String IDPersona)
        {
            return persona.Existe(IDPersona);
        }
        
        public virtual bool Existe(String IDPersona, out CPersona oPersona)
        {
            return persona.Existe(IDPersona, out oPersona);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CPersona> Listar()
        {
            return persona.Listar();
        }
        #endregion
    }
}
