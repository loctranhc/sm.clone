using Api.Configurations;
using Infrastructures.Contexts;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
EnvironmentConfigurations.Load(builder.Configuration);
DbContextConfiguration.SetApplicationDbContext(
    builder.Services,
    builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddApiEndpoints();

var app = builder.Build();
app.MapControllers();
app.Run();
