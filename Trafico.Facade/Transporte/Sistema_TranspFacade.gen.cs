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
using Trafico.BusinessObjects.Transporte;
using Trafico.DataObjects.Transporte;

namespace Trafico.Facade.Transporte
{
    
    
    [DataObject(true)]
    public partial class Sistema_TranspFacade
    {
        
        private Sistema_TranspDao sistema_Transp;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Sistema_TranspFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: sistema_Transp = new Sistema_TranspDao();
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
        public virtual bool Grabar(CSistema_Transp oSistema_Transp)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oSistema_Transp.Cod_Sis_Transp.Trim() == "")
            {
            	Error = "Cod_Sis_Transp no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return sistema_Transp.Grabar(oSistema_Transp);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CSistema_Transp oSistema_Transp, out string error)
        {
            bool rpta = Grabar(oSistema_Transp);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_Sis_Transp)
        {
            return sistema_Transp.Eliminar(Cod_Sis_Transp);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CSistema_Transp Recuperar(String Cod_Sis_Transp)
        {
            return sistema_Transp.Recuperar(Cod_Sis_Transp);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_Sis_Transp)
        {
            return sistema_Transp.Existe(Cod_Sis_Transp);
        }
        
        public virtual bool Existe(String Cod_Sis_Transp, out CSistema_Transp oSistema_Transp)
        {
            return sistema_Transp.Existe(Cod_Sis_Transp, out oSistema_Transp);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CSistema_Transp> Listar()
        {
            return sistema_Transp.Listar();
        }
        #endregion
    }
}
