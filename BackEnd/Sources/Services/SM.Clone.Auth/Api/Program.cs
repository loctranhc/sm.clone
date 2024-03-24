using Api.Configurations;

var builder = WebApplication.CreateBuilder(args);
EnvironmentConfigurations.Load(builder.Configuration);
DbContextConfiguration.SetApplicationDbContext(
    builder.Services,
    builder.Configuration);
builder.Services.AddControllers();

builder.Services.AddControllers();
var env = builder.Configuration;
var app = builder.Build();
app.MapControllers();
app.Run();
