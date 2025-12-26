//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Trafico.BusinessObjects.Concentrado
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CSerie_Guia_Concentrado
    {
        
        [DataMember()]
        public String Nro_Serie {get;set;}
        
        [DataMember()]
        public Int16 NroDigitos {get;set;}
        
        [DataMember()]
        public String CorrelativoIni {get;set;}
        
        [DataMember()]
        public Boolean flagCerrado {get;set;}
        
        [DataMember()]
        public String UserNew {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}
        
        [DataMember()]
        public String Cod_Material {get;set;}
        
        #region Constructores
        // Constructores
        public CSerie_Guia_Concentrado()
        {
        }
        
        public CSerie_Guia_Concentrado(String Nro_Serie_, Int16 NroDigitos_, String CorrelativoIni_, Boolean flagCerrado_, String UserNew_, DateTime DateNew_, String UserEdit_, DateTime DateEdit_, String Cod_Material_)
        {
            Nro_Serie = Nro_Serie_;
            NroDigitos = NroDigitos_;
            CorrelativoIni = CorrelativoIni_;
            flagCerrado = flagCerrado_;
            UserNew = UserNew_;
            DateNew = DateNew_;
            UserEdit = UserEdit_;
            DateEdit = DateEdit_;
            Cod_Material = Cod_Material_;
        }
        #endregion
    }
}
