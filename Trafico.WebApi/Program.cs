using Trafico.BusinessObjects.Authentication;
using Trafico.WebApi.Authorization;
using Trafico.WebApi.Helpers;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: MyAllowSpecificOrigins,
        policy =>
        {
            policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
                .DisallowCredentials(); // en net8 esto sigue existiendo pero ojo que excluye AllowAnyOrigin + AllowCredentials
        });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// AppSettings
builder.Services.Configure<AppSettings>(
    builder.Configuration.GetSection("AppSettings"));

// Servicios propios
builder.Services.AddSingleton<MailService>();
builder.Services.AddScoped<IJwtUtils, JwtUtils>();

// Cultura
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-PE");

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

// CORS
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

// Middleware JWT personalizado
app.UseMiddleware<JwtMiddleware>();

app.MapControllers();

LibreriaBSNetCore.Exceptions.Logger.Info(new Exception("Iniciando servicio"));

app.Run();
