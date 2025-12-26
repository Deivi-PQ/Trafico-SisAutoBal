//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.C.R.L.
//     Fecha: miércoles, 01 de abril de 2015
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Trafico.BusinessObjects.Seguridad
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CAcceso
    {
        
        [DataMember()]
        public String? Cod_Acceso {get;set;}
        
        [DataMember()]
        public String? Nombre_Acceso {get;set;}
        
        [DataMember()]
        public String? Descripcion {get;set;}
        
        [DataMember()]
        public String? Comando {get;set;}

        [DataMember()]
        public Int16? Nivel { get; set; }

        [DataMember()]
        public Char? Estado {get;set;}
        
        [DataMember()]
        public String? Imagen {get;set;}
        
        #region Constructores
        // Constructores
        public CAcceso()
        {
        }
        
        public CAcceso(String? Cod_Acceso_, String? Nombre_Acceso_, String? Descripcion_, String? Comando_, Int16? Nivel_, Char? Estado_, String? Imagen_)
        {
            Cod_Acceso = Cod_Acceso_;
            Nombre_Acceso = Nombre_Acceso_;
            Descripcion = Descripcion_;
            Comando = Comando_;
            Nivel = Nivel_;
            Estado = Estado_;
            Imagen = Imagen_;
        }
        #endregion
    }
}
