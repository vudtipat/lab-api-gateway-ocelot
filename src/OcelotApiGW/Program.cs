using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using MMLib.Ocelot.Provider.AppConfiguration;
using MMLib.SwaggerForOcelot.DependencyInjection;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true);

builder.Services.AddHealthChecks();

builder.Configuration.AddOcelotWithSwaggerSupport(options =>
{
    options.Folder = "Configurations";
});

builder.Services
    .AddOcelot(builder.Configuration)
    .AddAppConfiguration();

builder.Services.AddSwaggerForOcelot(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseRouting();

app.UseSwaggerForOcelotUI(opt =>
{
    opt.PathToSwaggerGenerator = "/swagger/docs";
});

app.UseEndpoints(e =>
{
    e.MapHealthChecks("/probe");
});

app.UseOcelot().Wait();

app.Run();
