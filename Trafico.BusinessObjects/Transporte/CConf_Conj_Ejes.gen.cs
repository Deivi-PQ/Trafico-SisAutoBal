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

namespace Trafico.BusinessObjects.Transporte
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CConf_Conj_Ejes
    {
        
        [DataMember()]
        public String Conf_Vehicular {get;set;}
        
        [DataMember()]
        public Int16 NroConjEje {get;set;}
        
        [DataMember()]
        public Double CjtoPesoMaxPerm {get;set;}
        
        #region Constructores
        // Constructores
        public CConf_Conj_Ejes()
        {
        }
        
        public CConf_Conj_Ejes(String Conf_Vehicular_, Int16 NroConjEje_, Double CjtoPesoMaxPerm_)
        {
            Conf_Vehicular = Conf_Vehicular_;
            NroConjEje = NroConjEje_;
            CjtoPesoMaxPerm = CjtoPesoMaxPerm_;
        }
        #endregion
    }
}
