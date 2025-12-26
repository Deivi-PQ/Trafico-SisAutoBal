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
using Trafico.BusinessObjects.AutoBal;
using Trafico.DataObjects.AutoBal;

namespace Trafico.Facade.AutoBal
{
    
    
    [DataObject(true)]
    public partial class Datos_RFIDFacade
    {
        
        private Datos_RFIDDao datos_RFID;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Datos_RFIDFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: datos_RFID = new Datos_RFIDDao();
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
        public virtual bool Grabar(CDatos_RFID oDatos_RFID)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oDatos_RFID.ID<0)
            {
            	Error = "ID no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return datos_RFID.Grabar(oDatos_RFID);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CDatos_RFID oDatos_RFID, out string error)
        {
            bool rpta = Grabar(oDatos_RFID);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int64 ID)
        {
            return datos_RFID.Eliminar(ID);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CDatos_RFID Recuperar(Int64 ID)
        {
            return datos_RFID.Recuperar(ID);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int64 ID)
        {
            return datos_RFID.Existe(ID);
        }
        
        public virtual bool Existe(Int64 ID, out CDatos_RFID oDatos_RFID)
        {
            return datos_RFID.Existe(ID, out oDatos_RFID);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CDatos_RFID> Listar()
        {
            return datos_RFID.Listar();
        }
        #endregion
    }
}
