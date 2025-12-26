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
    public partial class Tag_RFIDFacade
    {
        
        private Tag_RFIDDao tag_RFID;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Tag_RFIDFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: tag_RFID = new Tag_RFIDDao();
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
        public virtual bool Grabar(CTag_RFID oTag_RFID)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oTag_RFID.Cod_RFID.Trim() == "")
            {
            	Error = "Cod_RFID no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return tag_RFID.Grabar(oTag_RFID);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CTag_RFID oTag_RFID, out string error)
        {
            bool rpta = Grabar(oTag_RFID);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_RFID)
        {
            return tag_RFID.Eliminar(Cod_RFID);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CTag_RFID Recuperar(String Cod_RFID)
        {
            return tag_RFID.Recuperar(Cod_RFID);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_RFID)
        {
            return tag_RFID.Existe(Cod_RFID);
        }
        
        public virtual bool Existe(String Cod_RFID, out CTag_RFID oTag_RFID)
        {
            return tag_RFID.Existe(Cod_RFID, out oTag_RFID);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CTag_RFID> Listar(String Cod_RFID, String Nro_Placa)
        {
            return tag_RFID.Listar(Cod_RFID,Nro_Placa);
        }
        #endregion
    }
}
