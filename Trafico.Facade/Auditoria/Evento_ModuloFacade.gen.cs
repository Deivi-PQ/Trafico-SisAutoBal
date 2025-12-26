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
    public partial class Evento_ModuloFacade
    {
        
        private Evento_ModuloDao evento_Modulo;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Evento_ModuloFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: evento_Modulo = new Evento_ModuloDao();
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
        public virtual bool Grabar(CEvento_Modulo oEvento_Modulo)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oEvento_Modulo.IDEvento_Mod<=0)
            {
            	Error = "IDEvento_Mod no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return evento_Modulo.Grabar(oEvento_Modulo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CEvento_Modulo oEvento_Modulo, out string error)
        {
            bool rpta = Grabar(oEvento_Modulo);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 IDEvento_Mod)
        {
            return evento_Modulo.Eliminar(IDEvento_Mod);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CEvento_Modulo Recuperar(Int32 IDEvento_Mod)
        {
            return evento_Modulo.Recuperar(IDEvento_Mod);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 IDEvento_Mod)
        {
            return evento_Modulo.Existe(IDEvento_Mod);
        }
        
        public virtual bool Existe(Int32 IDEvento_Mod, out CEvento_Modulo oEvento_Modulo)
        {
            return evento_Modulo.Existe(IDEvento_Mod, out oEvento_Modulo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CEvento_Modulo> Listar()
        {
            return evento_Modulo.Listar();
        }
        #endregion
    }
}
