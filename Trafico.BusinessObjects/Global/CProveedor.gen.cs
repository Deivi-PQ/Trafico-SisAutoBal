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
    public partial class CProveedor
    {
        
        [DataMember()]
        public String IDProveedor {get;set;}
        
        [DataMember()]
        public String RazonSocial {get;set;}
        
        [DataMember()]
        public String Ruc {get;set;}
        
        [DataMember()]
        public String Direccion {get;set;}
        
        [DataMember()]
        public String Ciudad {get;set;}
        
        [DataMember()]
        public String Actividad {get;set;}
        
        [DataMember()]
        public String Telefono {get;set;}
        
        [DataMember()]
        public String e_mail {get;set;}
        
        [DataMember()]
        public String Persona_Contacto {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Inscripcion {get;set;}
        
        [DataMember()]
        public String Observaciones {get;set;}
        
        [DataMember()]
        public Boolean Estado {get;set;}
        
        #region Constructores
        // Constructores
        public CProveedor()
        {
        }
        
        public CProveedor(String IDProveedor_, String RazonSocial_, String Ruc_, String Direccion_, String Ciudad_, String Actividad_, String Telefono_, String e_mail_, String Persona_Contacto_, DateTime Fecha_Inscripcion_, String Observaciones_, Boolean Estado_)
        {
            IDProveedor = IDProveedor_;
            RazonSocial = RazonSocial_;
            Ruc = Ruc_;
            Direccion = Direccion_;
            Ciudad = Ciudad_;
            Actividad = Actividad_;
            Telefono = Telefono_;
            e_mail = e_mail_;
            Persona_Contacto = Persona_Contacto_;
            Fecha_Inscripcion = Fecha_Inscripcion_;
            Observaciones = Observaciones_;
            Estado = Estado_;
        }
        #endregion
    }
}
