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
    public partial class CTag_RFID
    {
        
        [DataMember()]
        public String? Cod_RFID {get;set;}
        
        [DataMember()]
        public String? Nro_Placa {get;set;}
        
        [DataMember()]
        public DateTime? DateNew {get;set;}
        
        [DataMember()]
        public DateTime? DateEdit {get;set;}
        
        [DataMember()]
        public String? UserNew {get;set;}
        
        [DataMember()]
        public String? UserEdit {get;set;}
        
        #region Constructores
        // Constructores
        public CTag_RFID()
        {
        }
        
        public CTag_RFID(String? Cod_RFID_, String? Nro_Placa_, DateTime? DateNew_, DateTime? DateEdit_, String? UserNew_, String? UserEdit_)
        {
            Cod_RFID = Cod_RFID_;
            Nro_Placa = Nro_Placa_;
            DateNew = DateNew_;
            DateEdit = DateEdit_;
            UserNew = UserNew_;
            UserEdit = UserEdit_;
        }
        #endregion
    }
}
