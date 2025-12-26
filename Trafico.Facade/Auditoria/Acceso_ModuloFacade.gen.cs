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
using Trafico.BusinessObjects.Auditoria;
using Trafico.DataObjects.Auditoria;

namespace Trafico.Facade.Auditoria
{
    
    
    [DataObject(true)]
    public partial class Acceso_ModuloFacade
    {
        
        private Acceso_ModuloDao acceso_Modulo;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Acceso_ModuloFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: acceso_Modulo = new Acceso_ModuloDao();
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
        public virtual bool Grabar(CAcceso_Modulo oAcceso_Modulo)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oAcceso_Modulo.IDAcceso_Mod<=0)
            {
            	Error = "IDAcceso_Mod no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return acceso_Modulo.Grabar(oAcceso_Modulo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CAcceso_Modulo oAcceso_Modulo, out string error)
        {
            bool rpta = Grabar(oAcceso_Modulo);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 IDAcceso_Mod)
        {
            return acceso_Modulo.Eliminar(IDAcceso_Mod);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CAcceso_Modulo Recuperar(Int32 IDAcceso_Mod)
        {
            return acceso_Modulo.Recuperar(IDAcceso_Mod);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 IDAcceso_Mod)
        {
            return acceso_Modulo.Existe(IDAcceso_Mod);
        }
        
        public virtual bool Existe(Int32 IDAcceso_Mod, out CAcceso_Modulo oAcceso_Modulo)
        {
            return acceso_Modulo.Existe(IDAcceso_Mod, out oAcceso_Modulo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CAcceso_Modulo> Listar()
        {
            return acceso_Modulo.Listar();
        }
        #endregion
    }
}
