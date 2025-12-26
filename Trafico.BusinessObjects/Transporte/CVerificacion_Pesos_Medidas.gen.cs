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

namespace Trafico.BusinessObjects.Transporte
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CVerificacion_Pesos_Medidas
    {
        
        [DataMember()]
        public Int32 IDVerificacion {get;set;}
        
        [DataMember()]
        public String Nro_Constancia {get;set;}
        
        [DataMember()]
        public String Nro_Guia_Remision {get;set;}
        
        [DataMember()]
        public DateTime Fecha {get;set;}
        
        [DataMember()]
        public String Nombre_Material {get;set;}
        
        [DataMember()]
        public String NroPlaca_Vehiculo {get;set;}
        
        [DataMember()]
        public String NroPlaca_Cisterna {get;set;}
        
        [DataMember()]
        public String Nro_Placa_Carreta {get;set;}
        
        [DataMember()]
        public Int32 IDMaterial {get;set;}
        
        [DataMember()]
        public Double Largo {get;set;}
        
        [DataMember()]
        public Double Ancho {get;set;}
        
        [DataMember()]
        public Double Alto {get;set;}
        
        [DataMember()]
        public Double Peso_Bruto_Max_Perm {get;set;}
        
        [DataMember()]
        public Double Peso_Bruto_Max_Transp {get;set;}
        
        [DataMember()]
        public String Conf_Veh_Vehiculo {get;set;}
        
        [DataMember()]
        public String Conf_Veh_Cisterna {get;set;}
        
        [DataMember()]
        public String Conf_Veh_Carreta {get;set;}
        
        [DataMember()]
        public String Observacion {get;set;}
        
        [DataMember()]
        public String IDPersona_Genera {get;set;}
        
        [DataMember()]
        public String Nro_Guia_Transportista {get;set;}
        
        [DataMember()]
        public String UserNew {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}
        
        [DataMember()]
        public Double PesoCjtoEje1 {get;set;}
        
        [DataMember()]
        public Double PesoCjtoEje2 {get;set;}
        
        [DataMember()]
        public Double PesoCjtoEje3 {get;set;}
        
        [DataMember()]
        public Double PesoCjtoEje4 {get;set;}
        
        [DataMember()]
        public Double PesoCjtoEje5 {get;set;}
        
        [DataMember()]
        public Double PesoCjtoEje6 {get;set;}
        
        [DataMember()]
        public Int32 Trafico_IDPersona_Genera {get;set;}
        
        #region Constructores
        // Constructores
        public CVerificacion_Pesos_Medidas()
        {
        }
        
        public CVerificacion_Pesos_Medidas(
                    Int32 IDVerificacion_, 
                    String Nro_Constancia_, 
                    String Nro_Guia_Remision_, 
                    DateTime Fecha_, 
                    String Nombre_Material_, 
                    String NroPlaca_Vehiculo_, 
                    String NroPlaca_Cisterna_, 
                    String Nro_Placa_Carreta_, 
                    Int32 IDMaterial_, 
                    Double Largo_, 
                    Double Ancho_, 
                    Double Alto_, 
                    Double Peso_Bruto_Max_Perm_, 
                    Double Peso_Bruto_Max_Transp_, 
                    String Conf_Veh_Vehiculo_, 
                    String Conf_Veh_Cisterna_, 
                    String Conf_Veh_Carreta_, 
                    String Observacion_, 
                    String IDPersona_Genera_, 
                    String Nro_Guia_Transportista_, 
                    String UserNew_, 
                    DateTime DateNew_, 
                    String UserEdit_, 
                    DateTime DateEdit_, 
                    Double PesoCjtoEje1_, 
                    Double PesoCjtoEje2_, 
                    Double PesoCjtoEje3_, 
                    Double PesoCjtoEje4_, 
                    Double PesoCjtoEje5_, 
                    Double PesoCjtoEje6_, 
                    Int32 Trafico_IDPersona_Genera_)
        {
            IDVerificacion = IDVerificacion_;
            Nro_Constancia = Nro_Constancia_;
            Nro_Guia_Remision = Nro_Guia_Remision_;
            Fecha = Fecha_;
            Nombre_Material = Nombre_Material_;
            NroPlaca_Vehiculo = NroPlaca_Vehiculo_;
            NroPlaca_Cisterna = NroPlaca_Cisterna_;
            Nro_Placa_Carreta = Nro_Placa_Carreta_;
            IDMaterial = IDMaterial_;
            Largo = Largo_;
            Ancho = Ancho_;
            Alto = Alto_;
            Peso_Bruto_Max_Perm = Peso_Bruto_Max_Perm_;
            Peso_Bruto_Max_Transp = Peso_Bruto_Max_Transp_;
            Conf_Veh_Vehiculo = Conf_Veh_Vehiculo_;
            Conf_Veh_Cisterna = Conf_Veh_Cisterna_;
            Conf_Veh_Carreta = Conf_Veh_Carreta_;
            Observacion = Observacion_;
            IDPersona_Genera = IDPersona_Genera_;
            Nro_Guia_Transportista = Nro_Guia_Transportista_;
            UserNew = UserNew_;
            DateNew = DateNew_;
            UserEdit = UserEdit_;
            DateEdit = DateEdit_;
            PesoCjtoEje1 = PesoCjtoEje1_;
            PesoCjtoEje2 = PesoCjtoEje2_;
            PesoCjtoEje3 = PesoCjtoEje3_;
            PesoCjtoEje4 = PesoCjtoEje4_;
            PesoCjtoEje5 = PesoCjtoEje5_;
            PesoCjtoEje6 = PesoCjtoEje6_;
            Trafico_IDPersona_Genera = Trafico_IDPersona_Genera_;
        }
        #endregion
    }
}
