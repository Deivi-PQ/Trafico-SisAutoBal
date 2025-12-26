//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 27 de diciembre de 2016
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
    public partial class CComunic_Baja_Sunat
    {
        
        [DataMember()]
        public Int32 IDEnvio {get;set;}
        
        [DataMember()]
        public String Cod_Sucursal {get;set;}
        
        [DataMember()]
        public String Codigo_Envio {get;set;}
        
        [DataMember()]
        public String TipoDoc {get;set;}
        
        [DataMember()]
        public String Nro_Serie {get;set;}
        
        [DataMember()]
        public String Nro_Comprobante {get;set;}
        
        [DataMember()]
        public Int16 Nro_Envio {get;set;}
        
        [DataMember()]
        public Char Estado_EnvioSunat {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Envio {get;set;}
        
        [DataMember()]
        public DateTime Fecha_Anulacion {get;set;}
        
        [DataMember()]
        public String RUC {get;set;}
        
        [DataMember()]
        public String EMail {get;set;}
        
        [DataMember()]
        public String XML_Origen {get;set;}
        
        [DataMember()]
        public String XML_Respuesta {get;set;}
        
        [DataMember()]
        public String Mensaje_Error {get;set;}
        
        [DataMember()]
        public String Observacion {get;set;}
        
        [DataMember()]
        public String DigestValue {get;set;}
        
        [DataMember()]
        public String SignatureValue {get;set;}
        
        [DataMember()]
        public String Motivo_Anulacion {get;set;}
        
        [DataMember()]
        public Boolean flagEnvioCorreo {get;set;}
        
        [DataMember()]
        public Boolean flagEnvioServidor {get;set;}
        
        #region Constructores
        // Constructores
        public CComunic_Baja_Sunat()
        {
        }
        
        public CComunic_Baja_Sunat(
                    Int32 IDEnvio_, 
                    String Cod_Sucursal_, 
                    String Codigo_Envio_, 
                    String TipoDoc_, 
                    String Nro_Serie_, 
                    String Nro_Comprobante_, 
                    Int16 Nro_Envio_, 
                    Char Estado_EnvioSunat_, 
                    DateTime Fecha_Envio_, 
                    DateTime Fecha_Anulacion_, 
                    String RUC_, 
                    String EMail_, 
                    String XML_Origen_, 
                    String XML_Respuesta_, 
                    String Mensaje_Error_, 
                    String Observacion_, 
                    String DigestValue_, 
                    String SignatureValue_, 
                    String Motivo_Anulacion_, 
                    Boolean flagEnvioCorreo_, 
                    Boolean flagEnvioServidor_)
        {
            IDEnvio = IDEnvio_;
            Cod_Sucursal = Cod_Sucursal_;
            Codigo_Envio = Codigo_Envio_;
            TipoDoc = TipoDoc_;
            Nro_Serie = Nro_Serie_;
            Nro_Comprobante = Nro_Comprobante_;
            Nro_Envio = Nro_Envio_;
            Estado_EnvioSunat = Estado_EnvioSunat_;
            Fecha_Envio = Fecha_Envio_;
            Fecha_Anulacion = Fecha_Anulacion_;
            RUC = RUC_;
            EMail = EMail_;
            XML_Origen = XML_Origen_;
            XML_Respuesta = XML_Respuesta_;
            Mensaje_Error = Mensaje_Error_;
            Observacion = Observacion_;
            DigestValue = DigestValue_;
            SignatureValue = SignatureValue_;
            Motivo_Anulacion = Motivo_Anulacion_;
            flagEnvioCorreo = flagEnvioCorreo_;
            flagEnvioServidor = flagEnvioServidor_;
        }
        #endregion
    }
}
