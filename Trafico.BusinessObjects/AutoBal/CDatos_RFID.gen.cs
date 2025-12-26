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

namespace Trafico.BusinessObjects.AutoBal
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CDatos_RFID
    {
        
        [DataMember()]
        public Int64? ID {get;set;}
        
        [DataMember()]
        public String? SN {get;set;}
        
        [DataMember()]
        public DateTime? Time {get;set;}
        
        [DataMember()]
        public String? Pin {get;set;}
        
        [DataMember()]
        public String? Card {get;set;}
        
        [DataMember()]
        public Boolean? flagProcesado {get;set;}
        
        #region Constructores
        // Constructores
        public CDatos_RFID()
        {
        }
        
        public CDatos_RFID(Int64? ID_, String? SN_, DateTime? Time_, String? Pin_, String? Card_, Boolean? flagProcesado_)
        {
            ID = ID_;
            SN = SN_;
            Time = Time_;
            Pin = Pin_;
            Card = Card_;
            flagProcesado = flagProcesado_;
        }
        #endregion
    }
}
