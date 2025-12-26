//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 17 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Trafico.BusinessObjects.AutoBal
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class  Comandos
    {
        
        [DataMember()]
        public Int32 id {get;set;}
        
        [DataMember()]
        public String sn {get;set;}
        
        [DataMember()]
        public String comando {get;set;}
        
        [DataMember()]
        public String estado {get;set;}
        
        [DataMember()]
        public DateTime ttime {get;set;}
        
        #region Constructores
        // Constructores
        public Comandos()
        {
        }
        
        public Comandos(Int32 id_, String sn_, String comando_, String estado_, DateTime ttime_)
        {
            id = id_;
            sn = sn_;
            comando = comando_;
            estado = estado_;
            ttime = ttime_;
        }
        #endregion
    }
}
