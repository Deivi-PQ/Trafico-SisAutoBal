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
using Trafico.BusinessObjects.Config;
using Trafico.DataObjects.Config;

namespace Trafico.Facade.Config
{
    
    
    [DataObject(true)]
    public partial class Configuracion_UsuarioFacade
    {
        
        private Configuracion_UsuarioDao configuracion_Usuario;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Configuracion_UsuarioFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: configuracion_Usuario = new Configuracion_UsuarioDao();
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
        public virtual bool Grabar(CConfiguracion_Usuario oConfiguracion_Usuario)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oConfiguracion_Usuario.IDUsuario.Trim() == "")
            {
            	Error = "IDUsuario no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oConfiguracion_Usuario.Nombre_Variable.Trim() == "")
            {
            	Error = "Nombre_Variable no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return configuracion_Usuario.Grabar(oConfiguracion_Usuario);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CConfiguracion_Usuario oConfiguracion_Usuario, out string error)
        {
            bool rpta = Grabar(oConfiguracion_Usuario);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String IDUsuario, String Nombre_Variable)
        {
            return configuracion_Usuario.Eliminar(IDUsuario,Nombre_Variable);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CConfiguracion_Usuario Recuperar(String IDUsuario, String Nombre_Variable)
        {
            return configuracion_Usuario.Recuperar(IDUsuario,Nombre_Variable);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String IDUsuario, String Nombre_Variable)
        {
            return configuracion_Usuario.Existe(IDUsuario,Nombre_Variable);
        }
        
        public virtual bool Existe(String IDUsuario, String Nombre_Variable, out CConfiguracion_Usuario oConfiguracion_Usuario)
        {
            return configuracion_Usuario.Existe(IDUsuario,Nombre_Variable, out oConfiguracion_Usuario);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CConfiguracion_Usuario> Listar()
        {
            return configuracion_Usuario.Listar();
        }
        #endregion
    }
}
