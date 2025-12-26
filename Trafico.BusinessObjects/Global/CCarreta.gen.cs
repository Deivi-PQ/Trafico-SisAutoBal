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
    public partial class CCarreta
    {
        
        [DataMember()]
        public String Nro_Placa_Carreta {get;set;}
        
        [DataMember()]
        public String Descripcion {get;set;}
        
        [DataMember()]
        public String Nro_Certificado_Inscripcion {get;set;}
        
        [DataMember()]
        public String IDProveedor {get;set;}
        
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
        public String UserNew {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}
        
        [DataMember()]
        public String Nro_Placa_Hist {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Ini {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Fin {get;set;}
        
        [DataMember()]
        public String Obs_Carreta {get;set;}
        
        [DataMember()]
        public Boolean Flag_Peso_Modif {get;set;}
        
        [DataMember()]
        public Double PesoMaxCjtoEje1 {get;set;}
        
        [DataMember()]
        public Double PesoMaxCjtoEje2 {get;set;}
        
        [DataMember()]
        public String Modelo {get;set;}
        
        [DataMember()]
        public String Color {get;set;}
        
        [DataMember()]
        public Int32 Anio {get;set;}
        
        [DataMember()]
        public Int16 NroEjes {get;set;}
        
        [DataMember()]
        public String Tipo_Carroceria {get;set;}
        
        [DataMember()]
        public String Tipo {get;set;}
        
        [DataMember()]
        public String Clasificacion {get;set;}
        
        [DataMember()]
        public DateTime Vcto_Bonificacion {get;set;}
        
        [DataMember()]
        public Double Porc_Bonif {get;set;}
        
        [DataMember()]
        public String Precinto1 {get;set;}
        
        [DataMember()]
        public String Precinto2 {get;set;}
        
        [DataMember()]
        public Char Status {get;set;}
        
        [DataMember()]
        public String IDCarreta {get;set;}
        
        #region Constructores
        // Constructores
        public CCarreta()
        {
        }
        
        public CCarreta(
                    String Nro_Placa_Carreta_, 
                    String Descripcion_, 
                    String Nro_Certificado_Inscripcion_, 
                    String IDProveedor_, 
                    Double Largo_, 
                    Double Ancho_, 
                    Double Alto_, 
                    String Conf_Vehicular_, 
                    Double Peso_, 
                    String UserNew_, 
                    DateTime DateNew_, 
                    String UserEdit_, 
                    DateTime DateEdit_, 
                    String Nro_Placa_Hist_, 
                    DateTime Fecha_Ini_, 
                    DateTime Fecha_Fin_, 
                    String Obs_Carreta_, 
                    Boolean Flag_Peso_Modif_, 
                    Double PesoMaxCjtoEje1_, 
                    Double PesoMaxCjtoEje2_, 
                    String Modelo_, 
                    String Color_, 
                    Int32 Anio_, 
                    Int16 NroEjes_, 
                    String Tipo_Carroceria_, 
                    String Tipo_, 
                    String Clasificacion_, 
                    DateTime Vcto_Bonificacion_, 
                    Double Porc_Bonif_, 
                    String Precinto1_, 
                    String Precinto2_, 
                    Char Status_, 
                    String IDCarreta_)
        {
            Nro_Placa_Carreta = Nro_Placa_Carreta_;
            Descripcion = Descripcion_;
            Nro_Certificado_Inscripcion = Nro_Certificado_Inscripcion_;
            IDProveedor = IDProveedor_;
            Largo = Largo_;
            Ancho = Ancho_;
            Alto = Alto_;
            Conf_Vehicular = Conf_Vehicular_;
            Peso = Peso_;
            UserNew = UserNew_;
            DateNew = DateNew_;
            UserEdit = UserEdit_;
            DateEdit = DateEdit_;
            Nro_Placa_Hist = Nro_Placa_Hist_;
            Fecha_Ini = Fecha_Ini_;
            Fecha_Fin = Fecha_Fin_;
            Obs_Carreta = Obs_Carreta_;
            Flag_Peso_Modif = Flag_Peso_Modif_;
            PesoMaxCjtoEje1 = PesoMaxCjtoEje1_;
            PesoMaxCjtoEje2 = PesoMaxCjtoEje2_;
            Modelo = Modelo_;
            Color = Color_;
            Anio = Anio_;
            NroEjes = NroEjes_;
            Tipo_Carroceria = Tipo_Carroceria_;
            Tipo = Tipo_;
            Clasificacion = Clasificacion_;
            Vcto_Bonificacion = Vcto_Bonificacion_;
            Porc_Bonif = Porc_Bonif_;
            Precinto1 = Precinto1_;
            Precinto2 = Precinto2_;
            Status = Status_;
            IDCarreta = IDCarreta_;
        }
        #endregion
    }
}
