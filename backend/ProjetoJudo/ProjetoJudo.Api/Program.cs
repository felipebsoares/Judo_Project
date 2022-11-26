using ProjetoJudo.Application.Contracts.Services;
using ProjetoJudo.Application.Notification;
using ProjetoJudo.Application.Services;
using ProjetoJudo.Domain.Contracts.Repositories;
using ProjetoJudo.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services
    .AddScoped<IUsuarioRepository, TbUsuarioRepository>()
    .AddScoped<IAuthService, AuthService>()
    .AddScoped<INotificator, Notificator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();