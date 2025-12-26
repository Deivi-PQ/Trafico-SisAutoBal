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
    public partial class Config_Pesos_MedidasFacade
    {
        
        private Config_Pesos_MedidasDao config_Pesos_Medidas;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Config_Pesos_MedidasFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: config_Pesos_Medidas = new Config_Pesos_MedidasDao();
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
        public virtual bool Grabar(CConfig_Pesos_Medidas oConfig_Pesos_Medidas)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oConfig_Pesos_Medidas.Conf_Vehicular.Trim() == "")
            {
            	Error = "Conf_Vehicular no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return config_Pesos_Medidas.Grabar(oConfig_Pesos_Medidas);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CConfig_Pesos_Medidas oConfig_Pesos_Medidas, out string error)
        {
            bool rpta = Grabar(oConfig_Pesos_Medidas);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Conf_Vehicular)
        {
            return config_Pesos_Medidas.Eliminar(Conf_Vehicular);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CConfig_Pesos_Medidas Recuperar(String Conf_Vehicular)
        {
            return config_Pesos_Medidas.Recuperar(Conf_Vehicular);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Conf_Vehicular)
        {
            return config_Pesos_Medidas.Existe(Conf_Vehicular);
        }
        
        public virtual bool Existe(String Conf_Vehicular, out CConfig_Pesos_Medidas oConfig_Pesos_Medidas)
        {
            return config_Pesos_Medidas.Existe(Conf_Vehicular, out oConfig_Pesos_Medidas);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CConfig_Pesos_Medidas> Listar()
        {
            return config_Pesos_Medidas.Listar();
        }
        #endregion
    }
}
