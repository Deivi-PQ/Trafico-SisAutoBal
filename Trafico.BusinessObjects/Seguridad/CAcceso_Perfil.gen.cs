//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.C.R.L.
//     Fecha: miércoles, 01 de abril de 2015
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
    public partial class CAcceso_Perfil
    {
        
        [DataMember()]
        public String Cod_Acceso {get;set;}
        
        [DataMember()]
        public Int32 IDPerfil {get;set;}
        
        #region Constructores
        // Constructores
        public CAcceso_Perfil()
        {
        }
        
        public CAcceso_Perfil(String Cod_Acceso_, Int32 IDPerfil_)
        {
            Cod_Acceso = Cod_Acceso_;
            IDPerfil = IDPerfil_;
        }
        #endregion
    }
}
