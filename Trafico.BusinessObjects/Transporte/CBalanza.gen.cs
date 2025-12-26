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
    public partial class CBalanza
    {
        
        [DataMember()]
        public String? IDBalanza {get;set;}
        
        [DataMember()]
        public String? Des_Balanza {get;set;}
        
        [DataMember()]
        public String? Tipo {get;set;}
        
        [DataMember()]
        public String? UserNew {get;set;}
        
        [DataMember()]
        public DateTime? DateNew {get;set;}
        
        [DataMember()]
        public String? UserEdit {get;set;}
        
        [DataMember()]
        public DateTime? DateEdit {get;set;}
        
        [DataMember()]
        public Char? Estado {get;set;}
        
        [DataMember()]
        public String? SN_Contr {get;set;}
        
        #region Constructores
        // Constructores
        public CBalanza()
        {
        }
        
        public CBalanza(String? IDBalanza_, String? Des_Balanza_, String? Tipo_, String? UserNew_, DateTime? DateNew_, String? UserEdit_, DateTime? DateEdit_, Char? Estado_, String? SN_Contr_)
        {
            IDBalanza = IDBalanza_;
            Des_Balanza = Des_Balanza_;
            Tipo = Tipo_;
            UserNew = UserNew_;
            DateNew = DateNew_;
            UserEdit = UserEdit_;
            DateEdit = DateEdit_;
            Estado = Estado_;
            SN_Contr = SN_Contr_;
        }
        #endregion
    }
}
