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

namespace Trafico.BusinessObjects.Global
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CTabla
    {
        
        [DataMember()]
        public String CodTabla {get;set;}
        
        [DataMember()]
        public String Nom_Tabla {get;set;}
        
        [DataMember()]
        public String DesTabla {get;set;}
        
        [DataMember()]
        public String CodPadre {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        [DataMember()]
        public String Campo1 {get;set;}
        
        [DataMember()]
        public String Campo2 {get;set;}
        
        [DataMember()]
        public String Cod_Producto_Sunat {get;set;}
        
        [DataMember()]
        public String Obs_Tabla {get;set;}
        
        #region Constructores
        // Constructores
        public CTabla()
        {
        }
        
        public CTabla(String CodTabla_, String Nom_Tabla_, String DesTabla_, String CodPadre_, Char Estado_, String Campo1_, String Campo2_, String Cod_Producto_Sunat_, String Obs_Tabla_)
        {
            CodTabla = CodTabla_;
            Nom_Tabla = Nom_Tabla_;
            DesTabla = DesTabla_;
            CodPadre = CodPadre_;
            Estado = Estado_;
            Campo1 = Campo1_;
            Campo2 = Campo2_;
            Cod_Producto_Sunat = Cod_Producto_Sunat_;
            Obs_Tabla = Obs_Tabla_;
        }
        #endregion
    }
}
