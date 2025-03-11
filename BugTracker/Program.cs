using BugTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models; // ✅ Agregar esta línea


var builder = WebApplication.CreateBuilder(args);

// ✅ Agrega la base de datos al servicio
// Agregar la configuración del contexto de base de datos
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Registrar los controladores y Swagger    
builder.Services.AddControllers();  // ✅ Registra los controladores
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "BugTracker API",
        Version = "v1",
        Description = "API para la gestión de tickets de bugs."
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "BugTracker API v1");
        c.RoutePrefix = string.Empty; // Esto hace que Swagger cargue en la URL raíz
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();  // ✅ IMPORTANTE: Mapea los controladores

app.Run();

app.Run();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
