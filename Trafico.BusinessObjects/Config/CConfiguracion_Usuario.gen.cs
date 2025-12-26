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

namespace Trafico.BusinessObjects.Config
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CConfiguracion_Usuario
    {
        
        [DataMember()]
        public String IDUsuario {get;set;}
        
        [DataMember()]
        public String Nombre_Variable {get;set;}
        
        [DataMember()]
        public String Valor_Variable {get;set;}
        
        [DataMember()]
        public Int32 Trafico_IDUsuario {get;set;}
        
        #region Constructores
        // Constructores
        public CConfiguracion_Usuario()
        {
        }
        
        public CConfiguracion_Usuario(String IDUsuario_, String Nombre_Variable_, String Valor_Variable_, Int32 Trafico_IDUsuario_)
        {
            IDUsuario = IDUsuario_;
            Nombre_Variable = Nombre_Variable_;
            Valor_Variable = Valor_Variable_;
            Trafico_IDUsuario = Trafico_IDUsuario_;
        }
        #endregion
    }
}
