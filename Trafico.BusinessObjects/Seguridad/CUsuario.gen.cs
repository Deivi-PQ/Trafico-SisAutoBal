//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 11 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Trafico.BusinessObjects.Seguridad
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CUsuario
    {
        
        [DataMember()]
        public String IDUsuario {get;set;}
        
        [DataMember()]
        public String Passwd {get;set;}
        
        [DataMember()]
        public String IDPersona {get;set;}
        
        [DataMember()]
        public String Nombre_Usuario {get;set;}
        
        [DataMember()]
        public String EMail {get;set;}
        
        [DataMember()]
        public Boolean flagActDir {get;set;}
        
        [DataMember()]
        public Int32 IDPerfil {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        [DataMember()]
        public String UserNew {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}

        [DataMember()]
        public Boolean flagDobleFactor { get; set; }

        [DataMember()]
        public Boolean flagSeRegistro2FA { get; set; }
        [DataMember()]
        public String Celular { get; set; }

        #region Constructores
        // Constructores
        public CUsuario()
        {
        }
        
        public CUsuario(
            String IDUsuario_, 
            String Passwd_, 
            String IDPersona_, 
            String Nombre_Usuario_, 
            String EMail_, 
            Boolean flagActDir_, 
            Int32 IDPerfil_, 
            Char Estado_, 
            String UserNew_, 
            DateTime DateNew_, 
            String UserEdit_,
            DateTime DateEdit_, 
            Boolean flagDobleFactor_,
            Boolean flagSeRegistro2FA_, 
            String Celular_ )
        {
            IDUsuario = IDUsuario_;
            Passwd = Passwd_;
            IDPersona = IDPersona_;
            Nombre_Usuario = Nombre_Usuario_;
            EMail = EMail_;
            flagActDir = flagActDir_;
            IDPerfil = IDPerfil_;
            Estado = Estado_;
            UserNew = UserNew_;
            DateNew = DateNew_;
            UserEdit = UserEdit_;
            DateEdit = DateEdit_;
            flagDobleFactor = flagDobleFactor_;
            flagSeRegistro2FA = flagSeRegistro2FA_;
            Celular=Celular_;
        }
        #endregion
    }
}
