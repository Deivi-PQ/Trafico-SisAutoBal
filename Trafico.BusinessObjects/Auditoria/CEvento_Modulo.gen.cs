//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.C.R.L.
//     Fecha: sábado, 14 de enero de 2012
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Trafico.BusinessObjects.Auditoria
{
    
    
    // Propiedades AutoImplementadas
    public partial class CEvento_Modulo
    {
        
        public Int32 IDEvento_Mod {get;set;}
        
        public String Modulo {get;set;}
        
        public String Des_Evento {get;set;}
        
        /// <summary>
        /// E: Eliminar; I: Imprimir; A: Actualizar; G: Grabar; O:Otros
        /// </summary>
        public char Tipo_Evento { get; set; }
        
        public String Usuario {get;set;}
        
        public DateTime FechaHora {get;set;}
        
        #region Constructores
        // Constructores
        public CEvento_Modulo()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IDEvento_Mod_"></param>
        /// <param name="Modulo_"></param>
        /// <param name="Des_Evento_"></param>
        /// <param name="Tipo_Evento_">E: Eliminar; I: Imprimir; A: Actualizar; G: Grabar; O:Otros</param>
        /// <param name="Usuario_"></param>
        /// <param name="FechaHora_"></param>
        public CEvento_Modulo(Int32 IDEvento_Mod_, String Modulo_, String Des_Evento_, char Tipo_Evento_, String Usuario_, DateTime FechaHora_)
        {
            IDEvento_Mod = IDEvento_Mod_;
            Modulo = Modulo_;
            Des_Evento = Des_Evento_;
            Tipo_Evento = Tipo_Evento_;
            Usuario = Usuario_;
            FechaHora = FechaHora_;
        }
        #endregion
    }
}
