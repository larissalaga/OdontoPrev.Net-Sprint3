using Microsoft.EntityFrameworkCore;
using OdontoPrevAPI.Data;
using OdontoPrevAPI.Mappings;
using OdontoPrevAPI.Repositories.Implementations;
using OdontoPrevAPI.Repositories.Interfaces;
using OdontoPrevAPI.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Initialize ConfigurationManager with the configuration
ConfigManager.Instance.Initialize(builder.Configuration);

// Registrando o AutoMapper com o perfil de mapeamento
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
   c.EnableAnnotations();
});

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseOracle(ConfigManager.Instance.GetConnectionString("OracleConnection"));
});

// Registering repositories as singletons
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
builder.Services.AddScoped<IDentistaRepository, DentistaRepository>();
builder.Services.AddScoped<IPlanoRepository, PlanoRepository>();
builder.Services.AddScoped<IExtratoPontosRepository, ExtratoPontosRepository>();
builder.Services.AddScoped<IRaioXRepository, RaioXRepository>();
builder.Services.AddScoped<IAnaliseRaioXRepository, AnaliseRaioXRepository>();
builder.Services.AddScoped<ICheckInRepository, CheckInRepository>();
builder.Services.AddScoped<IPerguntasRepository, PerguntasRepository>();
builder.Services.AddScoped<IRespostasRepository, RespostasRepository>();
builder.Services.AddScoped<IPacienteDentistaRepository, PacienteDentistaRepository>();

builder.Services.AddDataProtection();
builder.Services.AddSingleton(ConfigManager.Instance);

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
