//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Trafico.BusinessObjects.Concentrado
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CGuia_Remision_Concentrado
    {
        
        [DataMember()]
        public String Nro_Serie {get;set;}
        
        [DataMember()]
        public String Nro_Guia_Remision {get;set;}
        
        [DataMember()]
        public String Nro_Lote {get;set;}
        
        [DataMember()]
        public String IDProveedor_Transp {get;set;}
        
        [DataMember()]
        public String IDVehiculo {get;set;}
        
        [DataMember()]
        public String IDCarreta {get;set;}
        
        [DataMember()]
        public String IDConductor {get;set;}
        
        [DataMember()]
        public String Motivo_Traslado {get;set;}
        
        [DataMember()]
        public String IDProveedor_Dest {get;set;}
        
        [DataMember()]
        public String Nro_Factura {get;set;}
        
        [DataMember()]
        public Double Costo_Minimo {get;set;}
        
        [DataMember()]
        public String Estado {get;set;}
        
        [DataMember()]
        public Int32 IDLugar_Emision {get;set;}
        
        [DataMember()]
        public String DES_IDUsuario_Despacho {get;set;}
        
        [DataMember()]
        public Int32 DES_IDLugar_Despacho {get;set;}
        
        [DataMember()]
        public DateTime DES_FechaHora_Despacho {get;set;}
        
        [DataMember()]
        public DateTime DES_FechaHora_Inicio_Trasl {get;set;}
        
        [DataMember()]
        public DateTime DES_Fecha_Emision_Valida {get;set;}
        
        [DataMember()]
        public Double DES_Peso_Bruto {get;set;}
        
        [DataMember()]
        public Double DES_Tara {get;set;}
        
        [DataMember()]
        public String DES_Observacion {get;set;}
        
        [DataMember()]
        public String DES_Precinto_Seguridad {get;set;}
        
        [DataMember()]
        public String REC_IDUsuario_Recepcion {get;set;}
        
        [DataMember()]
        public Int32 REC_IDLugar_Recepcion {get;set;}
        
        [DataMember()]
        public DateTime REC_FechaHora_Recepcion {get;set;}
        
        [DataMember()]
        public DateTime REC_FechaHoraFin_Recepcion {get;set;}
        
        [DataMember()]
        public Double REC_Peso_Bruto {get;set;}
        
        [DataMember()]
        public Double REC_Tara {get;set;}
        
        [DataMember()]
        public Boolean REC_Flag_Guia_Procesada {get;set;}
        
        [DataMember()]
        public String REC_Observacion {get;set;}
        
        [DataMember()]
        public String Tipo_Material {get;set;}
        
        [DataMember()]
        public DateTime FechaHora_Salida {get;set;}
        
        [DataMember()]
        public DateTime FechaHora_Llegada {get;set;}
        
        [DataMember()]
        public String Obs_Llegada {get;set;}
        
        [DataMember()]
        public String UserNew {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}
        
        [DataMember()]
        public Boolean FlagTranspFacturado {get;set;}
        
        [DataMember()]
        public Double Peso_Bruto_Total {get;set;}
        
        [DataMember()]
        public String Nro_Placa_Veh {get;set;}
        
        [DataMember()]
        public String Nro_Placa_Car {get;set;}
        
        [DataMember()]
        public String Cod_Sis_Transp {get;set;}
        
        [DataMember()]
        public String REC_Cod_Sis_Transp {get;set;}
        
        [DataMember()]
        public Int16 NroMuestra {get;set;}
        
        #region Constructores
        // Constructores
        public CGuia_Remision_Concentrado()
        {
        }
        
        public CGuia_Remision_Concentrado(
                    String Nro_Serie_, 
                    String Nro_Guia_Remision_, 
                    String Nro_Lote_, 
                    String IDProveedor_Transp_, 
                    String IDVehiculo_, 
                    String IDCarreta_, 
                    String IDConductor_, 
                    String Motivo_Traslado_, 
                    String IDProveedor_Dest_, 
                    String Nro_Factura_, 
                    Double Costo_Minimo_, 
                    String Estado_, 
                    Int32 IDLugar_Emision_, 
                    String DES_IDUsuario_Despacho_, 
                    Int32 DES_IDLugar_Despacho_, 
                    DateTime DES_FechaHora_Despacho_, 
                    DateTime DES_FechaHora_Inicio_Trasl_, 
                    DateTime DES_Fecha_Emision_Valida_, 
                    Double DES_Peso_Bruto_, 
                    Double DES_Tara_, 
                    String DES_Observacion_, 
                    String DES_Precinto_Seguridad_, 
                    String REC_IDUsuario_Recepcion_, 
                    Int32 REC_IDLugar_Recepcion_, 
                    DateTime REC_FechaHora_Recepcion_, 
                    DateTime REC_FechaHoraFin_Recepcion_, 
                    Double REC_Peso_Bruto_, 
                    Double REC_Tara_, 
                    Boolean REC_Flag_Guia_Procesada_, 
                    String REC_Observacion_, 
                    String Tipo_Material_, 
                    DateTime FechaHora_Salida_, 
                    DateTime FechaHora_Llegada_, 
                    String Obs_Llegada_, 
                    String UserNew_, 
                    DateTime DateNew_, 
                    String UserEdit_, 
                    DateTime DateEdit_, 
                    Boolean FlagTranspFacturado_, 
                    Double Peso_Bruto_Total_, 
                    String Nro_Placa_Veh_, 
                    String Nro_Placa_Car_, 
                    String Cod_Sis_Transp_, 
                    String REC_Cod_Sis_Transp_, 
                    Int16 NroMuestra_)
        {
            Nro_Serie = Nro_Serie_;
            Nro_Guia_Remision = Nro_Guia_Remision_;
            Nro_Lote = Nro_Lote_;
            IDProveedor_Transp = IDProveedor_Transp_;
            IDVehiculo = IDVehiculo_;
            IDCarreta = IDCarreta_;
            IDConductor = IDConductor_;
            Motivo_Traslado = Motivo_Traslado_;
            IDProveedor_Dest = IDProveedor_Dest_;
            Nro_Factura = Nro_Factura_;
            Costo_Minimo = Costo_Minimo_;
            Estado = Estado_;
            IDLugar_Emision = IDLugar_Emision_;
            DES_IDUsuario_Despacho = DES_IDUsuario_Despacho_;
            DES_IDLugar_Despacho = DES_IDLugar_Despacho_;
            DES_FechaHora_Despacho = DES_FechaHora_Despacho_;
            DES_FechaHora_Inicio_Trasl = DES_FechaHora_Inicio_Trasl_;
            DES_Fecha_Emision_Valida = DES_Fecha_Emision_Valida_;
            DES_Peso_Bruto = DES_Peso_Bruto_;
            DES_Tara = DES_Tara_;
            DES_Observacion = DES_Observacion_;
            DES_Precinto_Seguridad = DES_Precinto_Seguridad_;
            REC_IDUsuario_Recepcion = REC_IDUsuario_Recepcion_;
            REC_IDLugar_Recepcion = REC_IDLugar_Recepcion_;
            REC_FechaHora_Recepcion = REC_FechaHora_Recepcion_;
            REC_FechaHoraFin_Recepcion = REC_FechaHoraFin_Recepcion_;
            REC_Peso_Bruto = REC_Peso_Bruto_;
            REC_Tara = REC_Tara_;
            REC_Flag_Guia_Procesada = REC_Flag_Guia_Procesada_;
            REC_Observacion = REC_Observacion_;
            Tipo_Material = Tipo_Material_;
            FechaHora_Salida = FechaHora_Salida_;
            FechaHora_Llegada = FechaHora_Llegada_;
            Obs_Llegada = Obs_Llegada_;
            UserNew = UserNew_;
            DateNew = DateNew_;
            UserEdit = UserEdit_;
            DateEdit = DateEdit_;
            FlagTranspFacturado = FlagTranspFacturado_;
            Peso_Bruto_Total = Peso_Bruto_Total_;
            Nro_Placa_Veh = Nro_Placa_Veh_;
            Nro_Placa_Car = Nro_Placa_Car_;
            Cod_Sis_Transp = Cod_Sis_Transp_;
            REC_Cod_Sis_Transp = REC_Cod_Sis_Transp_;
            NroMuestra = NroMuestra_;
        }
        #endregion
    }
}
