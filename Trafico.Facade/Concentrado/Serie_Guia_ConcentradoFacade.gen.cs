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
using Trafico.BusinessObjects.Concentrado;
using Trafico.DataObjects.Concentrado;

namespace Trafico.Facade.Concentrado
{
    
    
    [DataObject(true)]
    public partial class Serie_Guia_ConcentradoFacade
    {
        
        private Serie_Guia_ConcentradoDao serie_Guia_Concentrado;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Serie_Guia_ConcentradoFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: serie_Guia_Concentrado = new Serie_Guia_ConcentradoDao();
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
        public virtual bool Grabar(CSerie_Guia_Concentrado oSerie_Guia_Concentrado)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oSerie_Guia_Concentrado.Nro_Serie.Trim() == "")
            {
            	Error = "Nro_Serie no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return serie_Guia_Concentrado.Grabar(oSerie_Guia_Concentrado);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CSerie_Guia_Concentrado oSerie_Guia_Concentrado, out string error)
        {
            bool rpta = Grabar(oSerie_Guia_Concentrado);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Nro_Serie)
        {
            return serie_Guia_Concentrado.Eliminar(Nro_Serie);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CSerie_Guia_Concentrado Recuperar(String Nro_Serie)
        {
            return serie_Guia_Concentrado.Recuperar(Nro_Serie);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Nro_Serie)
        {
            return serie_Guia_Concentrado.Existe(Nro_Serie);
        }
        
        public virtual bool Existe(String Nro_Serie, out CSerie_Guia_Concentrado oSerie_Guia_Concentrado)
        {
            return serie_Guia_Concentrado.Existe(Nro_Serie, out oSerie_Guia_Concentrado);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CSerie_Guia_Concentrado> Listar()
        {
            return serie_Guia_Concentrado.Listar();
        }
        #endregion
    }
}
