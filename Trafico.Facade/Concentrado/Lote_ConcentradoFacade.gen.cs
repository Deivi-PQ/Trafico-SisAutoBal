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
    public partial class Lote_ConcentradoFacade
    {
        
        private Lote_ConcentradoDao lote_Concentrado;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Lote_ConcentradoFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: lote_Concentrado = new Lote_ConcentradoDao();
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
        public virtual bool Grabar(CLote_Concentrado oLote_Concentrado)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oLote_Concentrado.Nro_Lote.Trim() == "")
            {
            	Error = "Nro_Lote no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return lote_Concentrado.Grabar(oLote_Concentrado);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CLote_Concentrado oLote_Concentrado, out string error)
        {
            bool rpta = Grabar(oLote_Concentrado);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Nro_Lote)
        {
            return lote_Concentrado.Eliminar(Nro_Lote);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CLote_Concentrado Recuperar(String Nro_Lote)
        {
            return lote_Concentrado.Recuperar(Nro_Lote);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Nro_Lote)
        {
            return lote_Concentrado.Existe(Nro_Lote);
        }
        
        public virtual bool Existe(String Nro_Lote, out CLote_Concentrado oLote_Concentrado)
        {
            return lote_Concentrado.Existe(Nro_Lote, out oLote_Concentrado);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CLote_Concentrado> Listar()
        {
            return lote_Concentrado.Listar();
        }
        #endregion
    }
}
