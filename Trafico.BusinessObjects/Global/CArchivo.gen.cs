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
    public partial class CArchivo
    {
        
        [DataMember()]
        public String Cod_Archivo {get;set;}
        
        [DataMember()]
        public String Nombre_Archivo {get;set;}
        
        [DataMember()]
        public Boolean Archivo {get;set;}
        
        #region Constructores
        // Constructores
        public CArchivo()
        {
        }
        
        public CArchivo(String Cod_Archivo_, String Nombre_Archivo_, Boolean Archivo_)
        {
            Cod_Archivo = Cod_Archivo_;
            Nombre_Archivo = Nombre_Archivo_;
            Archivo = Archivo_;
        }
        #endregion
    }
}
