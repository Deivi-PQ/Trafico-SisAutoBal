using Trafico.BusinessObjects.Authentication;
using Trafico.BusinessObjects.Config;
using Trafico.BusinessObjects.Models;
using Trafico.BusinessObjects.Seguridad;
using Trafico.Facade.Config;
using Trafico.Facade.Seguridad;
using Trafico.WebApi.Authorization;
using Google.Authenticator;
using LibreriaBSNetCore;
using LibreriaBSNetCore.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GESREFINWebApi.Controllers.Authentication
{


    [Authorize]
    [Route("Authentication")]
    [ApiController()]
    public class AuthenticationController : ControllerBase
    {
        private IJwtUtils _jwtUtils;

        IConfiguration configuration;

        string DomainController
        {
            get 
            {
                return configuration["AppSettings:DomainController"];
            }
        }

        public AuthenticationController(IJwtUtils jwtUtils, IConfiguration configuration_)
        {
            _jwtUtils = jwtUtils;
            configuration = configuration_;
        }


        [AllowAnonymous]
        [Route("Contrasena_Correcta")]
        [HttpPost()]
        public IActionResult Contrasena_Correcta(AuthenticateRequest model)
        {
            try
            {
                CUsuario oUsuario;
                
                UsuarioFacade faUsuario = new UsuarioFacade();
                oUsuario = faUsuario.Recuperar(model.Username);
                 

                bool Rpta = true;

                // --- Verificar tipo de autenticacion
                if (oUsuario.flagActDir == false)
                {
                    // --- Verificar usuario
                    if (oUsuario.IDUsuario == "" || oUsuario.IDUsuario == null)
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Usuario no registrado" }));
                    }

                    // --- Verificar contraseña
                    bool flagFirstLogin = false;
                    PasswordRequest passwordReq = new PasswordRequest();
                    flagFirstLogin = oUsuario.Passwd.Contains(passwordReq.IndFirstLogin);

                    if (flagFirstLogin)
                    {
                        oUsuario.Passwd = oUsuario.Passwd.Split(passwordReq.IndFirstLogin)[0];
                    }

                    if (model.Password != oUsuario.Passwd) // CreateMD5Hash(model.Password) 
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Contraseña incorrecta" }));
                    }                   
           
                    // --- Verificar estado
                    if (oUsuario.Estado != 'A' && oUsuario.Estado != 'S')
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Usuario inactivo" }));
                    }
                }
                else
                {
                    string Error;
                    // --- Validar el usuario con el dominio
                    if (LComun.ValidarUsuarioDominio(DomainController, oUsuario.IDUsuario, model.Password, out Error))
                    {
                        //return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Usuario de Dominio o password incorrecto" }));
                        Rpta = true;
                    }
                    else
                        Rpta = false;
                }

                // ---- La validacion fue correcta
                if (Rpta)
                {
                    var jwtToken = _jwtUtils.GenerateJwtToken(oUsuario);
                    //var refreshToken = _jwtUtils.GenerateRefreshToken(IpAddress());
                    string refreshToken = _jwtUtils.GenerateRefreshToken(oUsuario);
                    // Recuperamos el menu
                    AccesoFacade accesoFacade = new AccesoFacade();
                    IList<CAcceso> accesos = accesoFacade.MenuSistema(Convert.ToInt32(oUsuario.IDPerfil));

                    //return Ok(new AuthenticateResponse(oUsuario, jwtToken, refreshToken.Token));
                    return Ok(new AuthenticateResponse(oUsuario, jwtToken, refreshToken, true,accesos));
                }
                else
                    return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Se produjo un error" }));
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [AllowAnonymous]
        [Route("Login")]
        [HttpPost()]
        public IActionResult Login(AuthenticateRequest model)
        {
            try
            {
                CUsuario oUsuario;
                UsuarioFacade faUsuario = new UsuarioFacade();
                Configuracion_SistemaFacade oConfiguracionF = new Configuracion_SistemaFacade();
                oUsuario = faUsuario.Recuperar(model.Username);
                int codPerfilWeb = oUsuario.IDPerfil;

                bool Rpta = true;

                bool flagFirstLogin = false;

                // --- Verificando tipo de autenticacion
                if (oUsuario.flagActDir == false)
                {
                    if (oUsuario.IDUsuario == "" || oUsuario.IDUsuario == null)
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Usuario no registrado" }));
                    }

                    // Begin: obtenemos el valor de convención de primer logueo
                    flagFirstLogin = false;
                    PasswordRequest passwordReq = new PasswordRequest();
                    flagFirstLogin = oUsuario.Passwd.Contains(passwordReq.IndFirstLogin);

                    if (flagFirstLogin)
                    {
                        faUsuario.Actualizar_Password(oUsuario.IDUsuario, oUsuario.flagActDir, oUsuario.Passwd.Split(passwordReq.IndFirstLogin)[0], oUsuario.UserEdit);
                        oUsuario.Passwd = oUsuario.Passwd.Split(passwordReq.IndFirstLogin)[0];
                    }
                    // End

                    // --- Verificar contraseña
                    if (oUsuario.Passwd != model.Password) // CreateMD5Hash(model.Password) 
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Contraseña incorrecta" }));
                    }
                    if (model.AppType == "WEB" && (codPerfilWeb == 0))
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "El usuario no tiene acceso a la aplicación web." }));
                    }
                    if (oUsuario.Estado != 'A' && oUsuario.Estado != 'S')
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Usuario inactivo" }));
                    }
                }
                else
                {
                    string Error;
                    // --- Validar el usuario con el dominio
                    if (LComun.ValidarUsuarioDominio(DomainController, oUsuario.IDUsuario, model.Password, out Error))
                    {
                        //return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Usuario de Dominio o password incorrecto" }));
                        Rpta = true;
                    }
                    else
                        Rpta = false;
                }

                // --- Verificando segundo factor de autenticación
                if (Rpta)
                {
                    if (oUsuario.flagDobleFactor)
                    {
                        TwoFactorAuthenticator autenticador = new TwoFactorAuthenticator();

                        //var resultado = autenticador.ValidateTwoFactorPIN(idUsuario, Clave);
                        bool resultado = autenticador.ValidateTwoFactorPIN(oUsuario.Celular, model.TokenGoogle);

                        if (!resultado)
                        {
                            Rpta = false;
                            return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Token incorrecto." }));
                        }
                    }
                }

                // ---- La validacion fue correcta
                if (Rpta)
                {
                    var jwtToken = _jwtUtils.GenerateJwtToken(oUsuario);
                    //var refreshToken = _jwtUtils.GenerateRefreshToken(IpAddress());
                    string refreshToken = _jwtUtils.GenerateRefreshToken(oUsuario);
                    // Recuperamos el menu
                    AccesoFacade accesoFacade = new AccesoFacade();
                    IList<CAcceso> accesos = accesoFacade.MenuSistema(Convert.ToInt32(oUsuario.IDPerfil));

                    AuthenticateResponse response = new AuthenticateResponse(oUsuario, jwtToken, refreshToken, flagFirstLogin,accesos);
                    
                    //return Ok(new AuthenticateResponse(oUsuario, jwtToken, refreshToken.Token));
                    return Ok(response);
                }
                else
                    return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = "Se produjo un error" }));
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Authorize]
        [Route("Logout")]
        [HttpGet()]
        public IActionResult Logout()
        {
            return Ok();
        }

        [AllowAnonymous]
        [Route("Refresh_Token")]
        [HttpPost()]
        public IActionResult RefreshToken(RefreshTokenRequest request)
        {
            //var refreshToken = Request.Cookies["refreshToken"];
            //string token = request["refreshToken"].ToString();

            var userId = _jwtUtils.ValidateRefreshToken(request.RefreshToken);

            if (userId == null)
            {
                return new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }

            CUsuario usuario;
            UsuarioFacade faUsuario = new UsuarioFacade();
            usuario = faUsuario.Recuperar(userId);    

            // generate new jwt
            var jwtToken = _jwtUtils.GenerateJwtToken(usuario);
            string refreshToken = _jwtUtils.GenerateRefreshToken(usuario);
            // Recuperamos el menu
            AccesoFacade accesoFacade = new AccesoFacade();
            IList<CAcceso> accesos = accesoFacade.MenuSistema(Convert.ToInt32(usuario.IDPerfil));

            var response = new AuthenticateResponse(usuario, jwtToken, refreshToken, true,accesos);
            //SetTokenCookie(refreshToken);
            
            return Ok(response);
        }

        //[HttpPost("revoke-token")]
        //public IActionResult RevokeToken(RevokeTokenRequest model)
        //{
        //    // accept refresh token in request body or cookie
        //    var token = model.Token ?? Request.Cookies["refreshToken"];

        //    if (string.IsNullOrEmpty(token))
        //        return BadRequest(new { message = "Token is required" });

        //    _userService.RevokeToken(token, ipAddress());
        //    return Ok(new { message = "Token revoked" });
        //}

        private string CreateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }


        private void SetTokenCookie(string token)
        {
            // append cookie with refresh token to the http response
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };
            Response.Cookies.Append("refreshToken", token, cookieOptions);
        }

        private string IpAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
        
        /// <summary>
        /// Returns true if serverPassword and modelPassword has the same value, otherwise, it returns false.
        /// </summary>
        /// <param name="serverPassword"></param>
        /// <param name="modelPassword"></param>
        /// <returns></returns>
        private bool ComparePasswords(string serverPassword, string modelPassword)
        {
            bool flagFirstLogin = false;
            PasswordRequest passwordReq = new PasswordRequest();
            flagFirstLogin = serverPassword.Contains(passwordReq.IndFirstLogin);

            if (flagFirstLogin)
            {
                serverPassword = serverPassword.Split(passwordReq.IndFirstLogin)[0];
            }

            if (serverPassword != modelPassword)
                return false;
            return true;
        }

    }
}
