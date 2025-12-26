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
    public partial class CPerfil
    {
        
        [DataMember()]
        public Int32? IDPerfil {get;set;}
                      
        [DataMember()]
        public String? Des_Perfil {get;set;}
        
        [DataMember()]
        public Char? Estado {get;set;}
        
        #region Constructores
        // Constructores
        public CPerfil()
        {
        }
        
        public CPerfil(Int32? IDPerfil_, String? Des_Perfil_, Char? Estado_)
        {
            IDPerfil = IDPerfil_;
            Des_Perfil = Des_Perfil_;
            Estado = Estado_;
        }
        #endregion
    }
}
