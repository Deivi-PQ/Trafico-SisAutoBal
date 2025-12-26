using System;

namespace Trafico.BusinessObjects.Models
{
    public class CEvento_Dispon_Filter
    {
        public String Tipo { get; set; } = "*";
        public String Cod_Batch { get; set; } = "*";
        public Char Tipo_Batch { get; set; } = '*';
        public DateTime? FechaHora_Ini { get; set; }
        public DateTime? FechaHora_Fin { get; set; }
        public bool? Flag_Aprobado { get; set; }
    }
}