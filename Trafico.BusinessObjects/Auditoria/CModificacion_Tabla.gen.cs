//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 08 de junio de 2016
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Trafico.BusinessObjects.Auditoria
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CModificacion_Tabla
    {
        
        [DataMember()]
        public Int32 idModificacion {get;set;}
        
        [DataMember()]
        public String Tabla {get;set;}
        
        [DataMember()]
        public Char Tipo_Modificacion {get;set;}
        
        [DataMember()]
        public String Usuario {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Hora {get;set;}
        
        [DataMember()]
        public String Campo {get;set;}
        
        [DataMember()]
        public String Descripcion {get;set;}
        
        #region Constructores
        // Constructores
        public CModificacion_Tabla()
        {
        }
        
        public CModificacion_Tabla(Int32 idModificacion_, String Tabla_, Char Tipo_Modificacion_, String Usuario_, DateTime Fecha_Hora_, String Campo_, String Descripcion_)
        {
            idModificacion = idModificacion_;
            Tabla = Tabla_;
            Tipo_Modificacion = Tipo_Modificacion_;
            Usuario = Usuario_;
            Fecha_Hora = Fecha_Hora_;
            Campo = Campo_;
            Descripcion = Descripcion_;
        }
        #endregion
    }
}
