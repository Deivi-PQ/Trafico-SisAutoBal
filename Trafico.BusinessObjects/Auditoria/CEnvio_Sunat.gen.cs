//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: viernes, 5 de agosto de 2016
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
    public partial class CEnvio_Sunat
    {

        [DataMember()]
        public Int32 idEnvio { get; set; }

        [DataMember()]
        public String Cod_Sucursal { get; set; }

        [DataMember()]
        public String TipoDoc { get; set; }

        [DataMember()]
        public String Nro_Serie { get; set; }

        [DataMember()]
        public int Nro_Comprobante { get; set; }

        [DataMember()]
        public String RUC { get; set; }

        [DataMember()]
        public DateTime? Fecha_Envio { get; set; }

        [DataMember()]
        public String EMail_Enviado { get; set; }

        [DataMember()]
        public Char Estado_EnvioSunat { get; set; }

        [DataMember()]
        public String XML_Origen { get; set; }

        [DataMember()]
        public String XML_Respuesta { get; set; }

        [DataMember()]
        public String Mensaje_Error { get; set; } 

        [DataMember()]
        public String DigestValue { get; set; }

        [DataMember()]
        public String SignatureValue { get; set; }

        [DataMember()]
        public Boolean? flagEnvioCorreo { get; set; }

        [DataMember()]
        public Boolean? flagEnvioServidor { get; set; }

        [DataMember()]
        public DateTime? DateNew { get; set; }

        [DataMember()]
        public string Ticket { get; set; }

        #region Constructores
        // Constructores
        public CEnvio_Sunat()
        {
        }

        public CEnvio_Sunat(
                    Int32 idEnvio_,
                    String Cod_Sucursal_,
                    String TipoDoc_,
                    String Nro_Serie_,
                    int Nro_Comprobante_,
                    String RUC_,
                    DateTime? Fecha_Envio_,
                    String EMail_Enviado_,
                    Char Estado_EnvioSunat_,
                    String XML_Origen_,
                    String XML_Respuesta_,
                    String Mensaje_Error_,
                    String DigestValue_,
                    String SignatureValue_,
                    Boolean? flagEnvioCorreo_,
                    Boolean? flagEnvioServidor_,
                    DateTime? DateNew_,
                    string Ticket_)
        {
            idEnvio = idEnvio_;
            Cod_Sucursal = Cod_Sucursal_;
            TipoDoc = TipoDoc_;
            Nro_Serie = Nro_Serie_;
            Nro_Comprobante = Nro_Comprobante_;
            RUC = RUC_;
            Fecha_Envio = Fecha_Envio_;
            EMail_Enviado = EMail_Enviado_;
            Estado_EnvioSunat = Estado_EnvioSunat_;
            XML_Origen = XML_Origen_;
            XML_Respuesta = XML_Respuesta_;
            Mensaje_Error = Mensaje_Error_;
            DigestValue = DigestValue_;
            SignatureValue = SignatureValue_;
            flagEnvioCorreo = flagEnvioCorreo_;
            flagEnvioServidor = flagEnvioServidor_;
            DateNew = DateNew_;
            Ticket = Ticket_;
        }
        #endregion
    }
}
