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
    public partial class CAcceso_Modulo
    {
        
        public Int32 IDAcceso_Mod {get;set;}        

        public string Nombre_Pagina { get; set; }
        
        public DateTime FechaHora {get;set;}
        
        public String Usuario {get;set;}
        
        #region Constructores
        // Constructores
        public CAcceso_Modulo()
        {
        }
        
        public CAcceso_Modulo(Int32 IDAcceso_Mod_, string Nombre_Pagina_, DateTime FechaHora_, String Usuario_)
        {
            IDAcceso_Mod = IDAcceso_Mod_;            
            Nombre_Pagina = Nombre_Pagina_;
            FechaHora = FechaHora_;
            Usuario = Usuario_;
        }
        #endregion
    }
}
