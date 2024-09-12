using Fiap.TechChallenge.Fase1.Data.Context;
using Fiap.TechChallenge.Fase3.Deletar;
using Microsoft.EntityFrameworkCore;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddDbContext<ContextTechChallenge>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("conexao"), x => x.MigrationsAssembly("Fiap.TechChallenge.Fase1.Data"));
});

var host = builder.Build();
host.Run();
