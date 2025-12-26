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
    public partial class TablaFacade
    {
        
        private TablaDao tabla;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public TablaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: tabla = new TablaDao();
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
        public virtual bool Grabar(CTabla oTabla)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oTabla.CodTabla.Trim() == "")
            {
            	Error = "CodTabla no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return tabla.Grabar(oTabla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CTabla oTabla, out string error)
        {
            bool rpta = Grabar(oTabla);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String CodTabla)
        {
            return tabla.Eliminar(CodTabla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CTabla Recuperar(String CodTabla)
        {
            return tabla.Recuperar(CodTabla);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String CodTabla)
        {
            return tabla.Existe(CodTabla);
        }
        
        public virtual bool Existe(String CodTabla, out CTabla oTabla)
        {
            return tabla.Existe(CodTabla, out oTabla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CTabla> Listar()
        {
            return tabla.Listar();
        }
        #endregion
    }
}
