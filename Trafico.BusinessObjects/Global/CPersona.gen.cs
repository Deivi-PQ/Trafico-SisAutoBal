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
    public partial class CPersona
    {
        
        [DataMember()]
        public String IDPersona {get;set;}
        
        [DataMember()]
        public String Nombres {get;set;}
        
        [DataMember()]
        public String Apellido_Paterno {get;set;}
        
        [DataMember()]
        public String Apellido_Materno {get;set;}
        
        [DataMember()]
        public String Nro_Doc_Iden {get;set;}
        
        [DataMember()]
        public String Direccion {get;set;}
        
        [DataMember()]
        public String EMail {get;set;}
        
        [DataMember()]
        public String IDProveedor {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Nacimiento {get;set;}
        
        [DataMember()]
        public String Estado_Civil {get;set;}
        
        [DataMember()]
        public Char Sexo {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Registro {get;set;}
        
        [DataMember()]
        public String RUC {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Cese {get;set;}
        
        [DataMember()]
        public String Obs_Persona {get;set;}
        
        [DataMember()]
        public String Nro_Licencia {get;set;}
        
        [DataMember()]
        public Boolean Estado {get;set;}
        
        #region Constructores
        // Constructores
        public CPersona()
        {
        }
        
        public CPersona(
                    String IDPersona_, 
                    String Nombres_, 
                    String Apellido_Paterno_, 
                    String Apellido_Materno_, 
                    String Nro_Doc_Iden_, 
                    String Direccion_, 
                    String EMail_, 
                    String IDProveedor_, 
                    DateTime Fecha_Nacimiento_, 
                    String Estado_Civil_, 
                    Char Sexo_, 
                    DateTime Fecha_Registro_, 
                    String RUC_, 
                    DateTime Fecha_Cese_, 
                    String Obs_Persona_, 
                    String Nro_Licencia_, 
                    Boolean Estado_)
        {
            IDPersona = IDPersona_;
            Nombres = Nombres_;
            Apellido_Paterno = Apellido_Paterno_;
            Apellido_Materno = Apellido_Materno_;
            Nro_Doc_Iden = Nro_Doc_Iden_;
            Direccion = Direccion_;
            EMail = EMail_;
            IDProveedor = IDProveedor_;
            Fecha_Nacimiento = Fecha_Nacimiento_;
            Estado_Civil = Estado_Civil_;
            Sexo = Sexo_;
            Fecha_Registro = Fecha_Registro_;
            RUC = RUC_;
            Fecha_Cese = Fecha_Cese_;
            Obs_Persona = Obs_Persona_;
            Nro_Licencia = Nro_Licencia_;
            Estado = Estado_;
        }
        #endregion
    }
}
