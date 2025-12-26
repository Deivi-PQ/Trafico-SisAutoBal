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
    public partial class CarretaFacade
    {
        
        private CarretaDao carreta;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public CarretaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: carreta = new CarretaDao();
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
        public virtual bool Grabar(CCarreta oCarreta)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oCarreta.IDCarreta.Trim() == "")
            {
            	Error = "IDCarreta no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return carreta.Grabar(oCarreta);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CCarreta oCarreta, out string error)
        {
            bool rpta = Grabar(oCarreta);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String IDCarreta)
        {
            return carreta.Eliminar(IDCarreta);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CCarreta Recuperar(String IDCarreta)
        {
            return carreta.Recuperar(IDCarreta);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String IDCarreta)
        {
            return carreta.Existe(IDCarreta);
        }
        
        public virtual bool Existe(String IDCarreta, out CCarreta oCarreta)
        {
            return carreta.Existe(IDCarreta, out oCarreta);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CCarreta> Listar()
        {
            return carreta.Listar();
        }
        #endregion
    }
}
