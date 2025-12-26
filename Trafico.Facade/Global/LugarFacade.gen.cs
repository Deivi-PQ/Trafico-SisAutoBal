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
    public partial class LugarFacade
    {
        
        private LugarDao lugar;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public LugarFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: lugar = new LugarDao();
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
        public virtual bool Grabar(CLugar oLugar)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oLugar.IDLugar<=0)
            {
            	Error = "IDLugar no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return lugar.Grabar(oLugar);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CLugar oLugar, out string error)
        {
            bool rpta = Grabar(oLugar);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 IDLugar)
        {
            return lugar.Eliminar(IDLugar);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CLugar Recuperar(Int32 IDLugar)
        {
            return lugar.Recuperar(IDLugar);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 IDLugar)
        {
            return lugar.Existe(IDLugar);
        }
        
        public virtual bool Existe(Int32 IDLugar, out CLugar oLugar)
        {
            return lugar.Existe(IDLugar, out oLugar);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CLugar> Listar()
        {
            return lugar.Listar();
        }
        #endregion
    }
}
