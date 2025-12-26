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
    public partial class CMaterial
    {
        
        [DataMember()]
        public Int32? IDMaterial {get;set;}
        
        [DataMember()]
        public String? Nombre_Material {get;set;}
        
        [DataMember()]
        public String? UniMed {get;set;}
        
        [DataMember()]
        public String? Stock_Code {get;set;}
        
        [DataMember()]
        public Char? Status {get;set;}
        
        
        #region Constructores
        // Constructores
        public CMaterial()
        {
        }
        
        public CMaterial(Int32? IDMaterial_, String? Nombre_Material_, String? UniMed_, String? Stock_Code_, Char? Status_)
        {
            IDMaterial = IDMaterial_;
            Nombre_Material = Nombre_Material_;
            UniMed = UniMed_;
            Stock_Code = Stock_Code_;
            Status = Status_;        
        }
        #endregion
    }
}
