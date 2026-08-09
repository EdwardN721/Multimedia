using Multimedia.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); 

// Agregar conexión
builder.Services.AddDbContextConfiguration(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();