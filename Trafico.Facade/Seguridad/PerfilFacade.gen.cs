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
using Trafico.BusinessObjects.Seguridad;
using Trafico.DataObjects.Seguridad;

namespace Trafico.Facade.Seguridad
{
    
    
    [DataObject(true)]
    public partial class PerfilFacade
    {
        
        private PerfilDao perfil;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public PerfilFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: perfil = new PerfilDao();
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
        public virtual bool Grabar(CPerfil oPerfil)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oPerfil.IDPerfil<=0)
            {
            	Error = "IDPerfil no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return perfil.Grabar(oPerfil);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CPerfil oPerfil, out string error)
        {
            bool rpta = Grabar(oPerfil);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 IDPerfil)
        {
            return perfil.Eliminar(IDPerfil);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CPerfil Recuperar(Int32 IDPerfil)
        {
            return perfil.Recuperar(IDPerfil);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 IDPerfil)
        {
            return perfil.Existe(IDPerfil);
        }
        
        public virtual bool Existe(Int32 IDPerfil, out CPerfil oPerfil)
        {
            return perfil.Existe(IDPerfil, out oPerfil);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CPerfil> Listar(CPerfil oPerfil)
        {
            return perfil.Listar(oPerfil);
        }
        #endregion
    }
}
