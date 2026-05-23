using DesignPatterns.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddPatternCatalog()
    .AddPatternServices(builder.Configuration);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
