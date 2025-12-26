using Trafico.BusinessObjects.Authentication;
using Trafico.Facade.Seguridad;
using Microsoft.Extensions.Options;

namespace Trafico.WebApi.Authorization
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;

        public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        {
            _next = next;
            _appSettings = appSettings.Value;
        }

        public async Task Invoke(HttpContext context, IJwtUtils jwtUtils)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            //var appType = context.Request.Headers[""]
            var userId = jwtUtils.ValidateJwtToken(token);

            if (userId != null)
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                var user = faUsuario.Recuperar(userId);
                context.Items["User"] = faUsuario.Recuperar(userId);
            }

            await _next(context);
        }
    }
}
