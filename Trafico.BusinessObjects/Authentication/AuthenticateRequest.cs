using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafico.BusinessObjects.Authentication
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; } // Tambien se usa como parte del Google Authenticator
        
        public string ClientId { get; set; }

        public string ClienteName { get; set; }

        public string TypeOpId { get; set; }
        
        public string TypeOpName { get; set; }

        public string WarehouseId { get; set; }

        public string WarehouseName { get; set; }

        public string AppType { get; set; } = "MOV"; // MOV, WEB
        
        public string MobileId { get; set; }
                
        public string flagDobleFactor { get; set; } = "NO"; // NO, SI

        public string TokenGoogle { get; set; }

        public string versionMobile { get; set; } = ""; //version de a aplicacion movil

    }
}
