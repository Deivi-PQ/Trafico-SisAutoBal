using Trafico.BusinessObjects.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafico.BusinessObjects.Authentication
{
    public class AuthenticateResponse
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string IdPerson { get; set; }
        public Int32 IDPerfil { get; set; }
        public string JwtToken { get; set; }
        
        //[JsonIgnore] // refresh token is returned in http only cookie
        public string RefreshToken { get; set; }
        public bool FlagFirstLogin { get; set; } // true : es primer login, false: no es primer login
        public IList<CAcceso> ListMenu { get; set; }

        public AuthenticateResponse() { }

        public AuthenticateResponse(CUsuario usuario, string jwtToken, string refreshToken, bool flagFirstLogin, IList<CAcceso> listMenu)
        {
            Id = usuario.IDUsuario;
            Username = usuario.Nombre_Usuario;
            IdPerson = usuario.IDPersona;
            IDPerfil = usuario.IDPerfil;
            JwtToken = jwtToken;
            RefreshToken = refreshToken;
            FlagFirstLogin = flagFirstLogin;
            ListMenu = listMenu;
        }
    }
}
