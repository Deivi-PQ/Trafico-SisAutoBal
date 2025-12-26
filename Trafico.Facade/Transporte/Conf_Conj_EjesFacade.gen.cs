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
using Trafico.Facade.Transporte;

namespace Trafico.Facade.Transporte
{
    
    
    [DataObject(true)]
    public partial class Conf_Conj_EjesFacade
    {
        
        private Conf_Conj_EjesDao conf_Conj_Ejes;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Conf_Conj_EjesFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: conf_Conj_Ejes = new Conf_Conj_EjesDao();
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
        public virtual bool Grabar(CConf_Conj_Ejes oConf_Conj_Ejes)
        {
            Error = "";
            hayError = false;
            Config_Pesos_MedidasFacade faConfig_Pesos_Medidas = new Config_Pesos_MedidasFacade();
            //---Validando campos no nulos
            if (oConf_Conj_Ejes.Conf_Vehicular.Trim() == "")
            {
            	Error = "Conf_Vehicular no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oConf_Conj_Ejes.NroConjEje<=0)
            {
            	Error = "NroConjEje no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if (!faConfig_Pesos_Medidas.Existe(oConf_Conj_Ejes.Conf_Vehicular))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oConf_Conj_Ejes.Conf_Vehicular," en Conf_Vehicular no existe. (Config_Pesos_Medidas, Conf_Vehicular)");
            	hayError = true;
            	return false;
            }
            else
            	return conf_Conj_Ejes.Grabar(oConf_Conj_Ejes);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CConf_Conj_Ejes oConf_Conj_Ejes, out string error)
        {
            bool rpta = Grabar(oConf_Conj_Ejes);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Conf_Vehicular, Int16 NroConjEje)
        {
            return conf_Conj_Ejes.Eliminar(Conf_Vehicular,NroConjEje);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CConf_Conj_Ejes Recuperar(String Conf_Vehicular, Int16 NroConjEje)
        {
            return conf_Conj_Ejes.Recuperar(Conf_Vehicular,NroConjEje);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Conf_Vehicular, Int16 NroConjEje)
        {
            return conf_Conj_Ejes.Existe(Conf_Vehicular,NroConjEje);
        }
        
        public virtual bool Existe(String Conf_Vehicular, Int16 NroConjEje, out CConf_Conj_Ejes oConf_Conj_Ejes)
        {
            return conf_Conj_Ejes.Existe(Conf_Vehicular,NroConjEje, out oConf_Conj_Ejes);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CConf_Conj_Ejes> Listar()
        {
            return conf_Conj_Ejes.Listar();
        }
        #endregion
    }
}
