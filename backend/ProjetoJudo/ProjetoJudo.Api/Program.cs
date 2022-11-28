using System.Text;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ProjetoJudo.Application.Configuration;
using ProjetoJudo.Application.Configuration.Key;
using ProjetoJudo.Application.Contracts;
using ProjetoJudo.Application.Contracts.Services;
using ProjetoJudo.Application.Notification;
using ProjetoJudo.Application.Services;
using ProjetoJudo.Domain.Contracts.Repositories;
using ProjetoJudo.Domain.Entities;
using ProjetoJudo.Domain.Validations;
using ProjetoJudo.Infra;
using ProjetoJudo.Infra.Repositories;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//Ajustar o configuration

#region AjusteConfiguration

builder
    .Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

#endregion

#region InjecaoDeDependencia

builder.Services
    .AddScoped<IAuthService, AuthService>()
    .AddScoped<INotificator, Notificator>()
    .AddScoped<IPasswordHasher<TbUsuario>, PasswordHasher<TbUsuario>>();

builder.Services
    .AddScoped<IValidator<TbUsuario>, UsuarioValidation>()
    .AddScoped<ITbUsuarioRepository, TbUsuarioRepository>();

builder.Services
    .AddScoped<IValidator<TbAtleta>, AtletaValidation>()
    .AddScoped<IAtletaService, AtletaService>()
    .AddScoped<IAtletaRepository, TbAtletaRepository>();

#endregion

//Db
builder.Services.ConfigureDataBase(builder.Configuration);

//Melhorar os logs
builder
    .Host
    .UseSystemd()
    .UseSerilog((_, lc) =>
    {
        lc.WriteTo.Console();
        lc.WriteTo.Debug();
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Judo API", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme() 
    { 
        Name = "Authorization", 
        Type = SecuritySchemeType.ApiKey, 
        Scheme = "Bearer", 
        BearerFormat = "JWT", 
        In = ParameterLocation.Header, 
        Description = "Você deve colocar o token no seguinte formato:  " +
                      "Bearer [COLOQUE O TOKEN AQUI]", 
    }); 
    c.AddSecurityRequirement(new OpenApiSecurityRequirement 
    { 
        { 
            new OpenApiSecurityScheme 
            { 
                Reference = new OpenApiReference 
                { 
                    Type = ReferenceType.SecurityScheme, 
                    Id = "Bearer" 
                } 
            }, 
            new string[] {} 
        } 
    }); 
});
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

var key = Encoding.ASCII.GetBytes(Settings.Secret);
builder.Services
    .AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();