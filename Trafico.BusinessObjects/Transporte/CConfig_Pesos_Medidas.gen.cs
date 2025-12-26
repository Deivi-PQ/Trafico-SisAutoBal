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
    public partial class CConfig_Pesos_Medidas
    {
        
        [DataMember()]
        public String Conf_Vehicular {get;set;}
        
        [DataMember()]
        public Int32 NroEjes {get;set;}
        
        [DataMember()]
        public Double Peso_Bruto_Max_MTC {get;set;}
        
        [DataMember()]
        public Double Peso_Bruto_Max_Empresa {get;set;}
        
        [DataMember()]
        public String Observacion {get;set;}
        
        [DataMember()]
        public String UserNew {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}
        
        [DataMember()]
        public Int16 NroConjEjes {get;set;}
        
        #region Constructores
        // Constructores
        public CConfig_Pesos_Medidas()
        {
        }
        
        public CConfig_Pesos_Medidas(String Conf_Vehicular_, Int32 NroEjes_, Double Peso_Bruto_Max_MTC_, Double Peso_Bruto_Max_Empresa_, String Observacion_, String UserNew_, DateTime DateNew_, String UserEdit_, DateTime DateEdit_, Int16 NroConjEjes_)
        {
            Conf_Vehicular = Conf_Vehicular_;
            NroEjes = NroEjes_;
            Peso_Bruto_Max_MTC = Peso_Bruto_Max_MTC_;
            Peso_Bruto_Max_Empresa = Peso_Bruto_Max_Empresa_;
            Observacion = Observacion_;
            UserNew = UserNew_;
            DateNew = DateNew_;
            UserEdit = UserEdit_;
            DateEdit = DateEdit_;
            NroConjEjes = NroConjEjes_;
        }
        #endregion
    }
}
