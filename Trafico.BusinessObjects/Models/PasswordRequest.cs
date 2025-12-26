using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafico.BusinessObjects.Models
{
    public class PasswordRequest
    {
        public string IndFirstLogin { get; } = "_firstLogin";
        public string Cod_Usuario { get; set; }
        public bool flagActDir { get; set; }
        public string Password { get; set; }
        public string UserEdit { get; set; }
        public bool FlagFirstLogin { get; set; }
    }

    public class Registro2FARequest
    {
        public string Cod_Usuario { get; set; }
        public bool flagSeRegistro2FA { get; set; }
        public string UserEdit { get; set; }
    }

}
