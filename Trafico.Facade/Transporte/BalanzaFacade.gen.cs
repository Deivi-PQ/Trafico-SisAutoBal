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
    public partial class BalanzaFacade
    {
        
        private BalanzaDao balanza;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public BalanzaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: balanza = new BalanzaDao();
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
        public virtual bool Grabar(CBalanza oBalanza)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oBalanza.IDBalanza.Trim() == "")
            {
            	Error = "IDBalanza no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return balanza.Grabar(oBalanza);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CBalanza oBalanza, out string error)
        {
            bool rpta = Grabar(oBalanza);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String IDBalanza)
        {
            return balanza.Eliminar(IDBalanza);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CBalanza Recuperar(String IDBalanza)
        {
            return balanza.Recuperar(IDBalanza);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String IDBalanza)
        {
            return balanza.Existe(IDBalanza);
        }
        
        public virtual bool Existe(String IDBalanza, out CBalanza oBalanza)
        {
            return balanza.Existe(IDBalanza, out oBalanza);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CBalanza> Listar(String Des_Balanza, String Tipo, String Estado, String SN_Contr)
        {
            return balanza.Listar( Des_Balanza, Tipo, Estado, SN_Contr);
        }
        #endregion
    }
}
