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
using Trafico.Facade.Seguridad;

namespace Trafico.Facade.Seguridad
{
    
    
    [DataObject(true)]
    public partial class UsuarioFacade
    {
        
        private UsuarioDao usuario;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public UsuarioFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: usuario = new UsuarioDao();
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
        public virtual bool Grabar(CUsuario oUsuario)
        {
            Error = "";
            hayError = false;
            PerfilFacade faPerfil = new PerfilFacade();
            //---Validando campos no nulos
            if (oUsuario.IDUsuario.Trim() == "")
            {
            	Error = "IDUsuario no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if ((oUsuario.IDPerfil <= 0 && (!faPerfil.Existe(oUsuario.IDPerfil))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oUsuario.IDPerfil," en IDPerfil no existe. (Perfil, IDPerfil)");
            	hayError = true;
            	return false;
            }
            else
            	return usuario.Grabar(oUsuario);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CUsuario oUsuario, out string error)
        {
            bool rpta = Grabar(oUsuario);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String IDUsuario)
        {
            return usuario.Eliminar(IDUsuario);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CUsuario Recuperar(String IDUsuario)
        {
            return usuario.Recuperar(IDUsuario);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String IDUsuario)
        {
            return usuario.Existe(IDUsuario);
        }
        
        public virtual bool Existe(String IDUsuario, out CUsuario oUsuario)
        {
            return usuario.Existe(IDUsuario, out oUsuario);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CUsuario> Listar()
        {
            return usuario.Listar();
        }
        public virtual bool Actualizar_Password(string Cod_Usuario, bool flagActDir, string Password, string UserEdit)
        {
            Error = "";
            hayError = false;
            //PersonaFacade faPersona = new PersonaFacade();
            //---Validando campos no nulos
            if (!flagActDir && Password == "")
            {
                Error = "Password no especificado.";
                hayError = true;
                return false;
            }
            else
            {
                return usuario.Actualizar_Password(Cod_Usuario, flagActDir, Password, UserEdit);
            }
        }

        public bool Actualizar_Registro2FA(string Cod_Usuario, bool flagSeRegistro2FA, string UserEdit)
        {
            return usuario.Actualizar_Registro2FA(Cod_Usuario, flagSeRegistro2FA, UserEdit);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CUsuario> Filtra(CUsuario oUsuario)
        {
            return usuario.Filtra(oUsuario);
        }

        #endregion
    }
}
