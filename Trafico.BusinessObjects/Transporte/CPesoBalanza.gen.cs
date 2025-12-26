//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: jueves, 11 de diciembre de 2025
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
    public partial class CPesoBalanza
    {
        
        [DataMember()]
        public Int32? IDPesaje {get;set;}
        
        [DataMember()]
        public Char? Tipo_Mov {get;set;}
        
        [DataMember()]
        public String? Nro_Placa {get;set;}
        
        [DataMember()]
        public String? DNI_Conductor {get;set;}
        
        [DataMember()]
        public String? IDBalanza {get;set;}
        
        [DataMember()]
        public Double? Peso {get;set;}
        
        [DataMember()]
        public DateTime? FechaHora {get;set;}
        
        [DataMember()]
        public Char? Status {get;set;}
        
        [DataMember()]
        public Int32? IDMaterial {get;set;}
        
        [DataMember()]
        public Int32? IDPesajeEnt {get;set;}
        
        [DataMember()]
        public String? UserNew {get;set;}
        
        [DataMember()]
        public String? UserEdit {get;set;}
        
        [DataMember()]
        public DateTime? DateNew {get;set;}
        
        [DataMember()]
        public DateTime? DateEdit {get;set;}
        
        [DataMember()]
        public Char? Turno {get;set;}
        
        [DataMember()]
        public String? Tipo_Unidad {get;set;}
        
        [DataMember()]
        public String? Destinatario {get;set;}
        
        [DataMember()]
        public String? Lugar_Carga {get;set;}

        #region Atributos Secundarios 
        public int TotalRows { get; set; } // Para el paginado
        #endregion

        #region Constructores
        // Constructores
        public CPesoBalanza()
        {
        }
        
        public CPesoBalanza(
                    Int32? IDPesaje_, 
                    Char? Tipo_Mov_, 
                    String? Nro_Placa_, 
                    String? DNI_Conductor_, 
                    String? IDBalanza_, 
                    Double? Peso_, 
                    DateTime? FechaHora_, 
                    Char? Status_, 
                    Int32? IDMaterial_, 
                    Int32? IDPesajeEnt_, 
                    String? UserNew_, 
                    String? UserEdit_, 
                    DateTime? DateNew_, 
                    DateTime? DateEdit_, 
                    Char? Turno_, 
                    String? Tipo_Unidad_, 
                    String? Destinatario_, 
                    String? Lugar_Carga_)
        {
            IDPesaje = IDPesaje_;
            Tipo_Mov = Tipo_Mov_;
            Nro_Placa = Nro_Placa_;
            DNI_Conductor = DNI_Conductor_;
            IDBalanza = IDBalanza_;
            Peso = Peso_;
            FechaHora = FechaHora_;
            Status = Status_;
            IDMaterial = IDMaterial_;
            IDPesajeEnt = IDPesajeEnt_;
            UserNew = UserNew_;
            UserEdit = UserEdit_;
            DateNew = DateNew_;
            DateEdit = DateEdit_;
            Turno = Turno_;
            Tipo_Unidad = Tipo_Unidad_;
            Destinatario = Destinatario_;
            Lugar_Carga = Lugar_Carga_;
        }
        #endregion
    }
}
