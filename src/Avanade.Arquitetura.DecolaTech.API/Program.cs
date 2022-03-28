using Avanade.Arquitetura.DecolaTech.Domain.Entidades;
using Avanade.Arquitetura.DecolaTech.Domain.Interfaces;
using Avanade.Arquitetura.DecolaTech.Infra.Database;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo {
        Title = "Avanade.Arquitetura.DecolaTech.API", 
        Version = "1"
    });
});

builder.Services.AddSingleton<IRepositorio<Pessoa>, PessoaRepositorio>();

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
