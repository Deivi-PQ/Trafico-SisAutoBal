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
    public partial class CVehiculo
    {
        
        [DataMember()]
        public String Nro_Placa {get;set;}
        
        [DataMember()]
        public String IDProveedor {get;set;}
        
        [DataMember()]
        public String Cod_Interno {get;set;}
        
        [DataMember()]
        public String Marca {get;set;}
        
        [DataMember()]
        public String Modelo {get;set;}
        
        [DataMember()]
        public String Obs_Vehiculo {get;set;}
        
        [DataMember()]
        public String Nro_Certif_Inscripcion {get;set;}
        
        [DataMember()]
        public Int32 Año {get;set;}
        
        [DataMember()]
        public Int16 Nro_Ejes {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        [DataMember()]
        public Double Largo {get;set;}
        
        [DataMember()]
        public Double Ancho {get;set;}
        
        [DataMember()]
        public Double Alto {get;set;}
        
        [DataMember()]
        public String Conf_Vehicular {get;set;}
        
        [DataMember()]
        public Double Peso {get;set;}

        [DataMember()]
        public Char Tipo_Unidad { get; set; }

        #region Constructores
        // Constructores
        public CVehiculo()
        {
        }
        
        public CVehiculo(String Nro_Placa_, String IDProveedor_, String Cod_Interno_, String Marca_, String Modelo_, String Obs_Vehiculo_, String Nro_Certif_Inscripcion_, Int32 Año_, Int16 Nro_Ejes_, Char Estado_, Double Largo_, Double Ancho_, Double Alto_, String Conf_Vehicular_, Double Peso_, char Tipo_Unidad_)
        {
            Nro_Placa = Nro_Placa_;
            IDProveedor = IDProveedor_;
            Cod_Interno = Cod_Interno_;
            Marca = Marca_;
            Modelo = Modelo_;
            Obs_Vehiculo = Obs_Vehiculo_;
            Nro_Certif_Inscripcion = Nro_Certif_Inscripcion_;
            Año = Año_;
            Nro_Ejes = Nro_Ejes_;
            Estado = Estado_;
            Largo = Largo_;
            Ancho = Ancho_;
            Alto = Alto_;
            Conf_Vehicular = Conf_Vehicular_;
            Peso = Peso_;
            Tipo_Unidad = Tipo_Unidad_;
        }
        #endregion
    }
}
