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
    public partial class CSistema_Transp
    {
        
        [DataMember()]
        public String Cod_Sis_Transp {get;set;}
        
        [DataMember()]
        public String Des_Sis_Transp {get;set;}
        
        [DataMember()]
        public Int16 NroPlacas {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public String UserNew {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        #region Constructores
        // Constructores
        public CSistema_Transp()
        {
        }
        
        public CSistema_Transp(String Cod_Sis_Transp_, String Des_Sis_Transp_, Int16 NroPlacas_, Char Estado_, DateTime DateNew_, String UserNew_, DateTime DateEdit_, String UserEdit_)
        {
            Cod_Sis_Transp = Cod_Sis_Transp_;
            Des_Sis_Transp = Des_Sis_Transp_;
            NroPlacas = NroPlacas_;
            Estado = Estado_;
            DateNew = DateNew_;
            UserNew = UserNew_;
            DateEdit = DateEdit_;
            UserEdit = UserEdit_;
        }
        #endregion
    }
}
