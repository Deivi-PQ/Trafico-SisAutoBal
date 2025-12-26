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
    public partial class CLote_Concentrado
    {
        
        [DataMember()]
        public String Nro_Lote {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Inicio_Vigencia {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Fin_Vigencia {get;set;}
        
        [DataMember()]
        public String IDProveedor {get;set;}
        
        [DataMember()]
        public Double Cantidad_Prod {get;set;}
        
        [DataMember()]
        public Double Porc_Hum_Prom_Desp {get;set;}
        
        [DataMember()]
        public Double Ley_Cobre_Prom {get;set;}
        
        [DataMember()]
        public String Estado {get;set;}
        
        [DataMember()]
        public Double Porc_Hum_Prom_Recep {get;set;}
        
        [DataMember()]
        public String Tipo_Material {get;set;}
        
        [DataMember()]
        public String UserNew {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}
        
        #region Constructores
        // Constructores
        public CLote_Concentrado()
        {
        }
        
        public CLote_Concentrado(String Nro_Lote_, DateTime Fecha_Inicio_Vigencia_, DateTime Fecha_Fin_Vigencia_, String IDProveedor_, Double Cantidad_Prod_, Double Porc_Hum_Prom_Desp_, Double Ley_Cobre_Prom_, String Estado_, Double Porc_Hum_Prom_Recep_, String Tipo_Material_, String UserNew_, DateTime DateNew_, String UserEdit_, DateTime DateEdit_)
        {
            Nro_Lote = Nro_Lote_;
            Fecha_Inicio_Vigencia = Fecha_Inicio_Vigencia_;
            Fecha_Fin_Vigencia = Fecha_Fin_Vigencia_;
            IDProveedor = IDProveedor_;
            Cantidad_Prod = Cantidad_Prod_;
            Porc_Hum_Prom_Desp = Porc_Hum_Prom_Desp_;
            Ley_Cobre_Prom = Ley_Cobre_Prom_;
            Estado = Estado_;
            Porc_Hum_Prom_Recep = Porc_Hum_Prom_Recep_;
            Tipo_Material = Tipo_Material_;
            UserNew = UserNew_;
            DateNew = DateNew_;
            UserEdit = UserEdit_;
            DateEdit = DateEdit_;
        }
        #endregion
    }
}
