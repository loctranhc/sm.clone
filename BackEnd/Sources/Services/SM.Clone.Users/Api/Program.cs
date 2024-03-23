using Api.Configurations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
DbContextConfiguration.SetUserDbContext(
    builder.Services,
    builder.Configuration);

var app = builder.Build();
app.MapControllers();
app.Run();
