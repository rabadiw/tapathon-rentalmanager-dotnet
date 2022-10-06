using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using RentalManager.Rental;
using Steeltoe.Management.Endpoint;
using Steeltoe.Management.Tracing;
using Steeltoe.Connector.RabbitMQ;
using Steeltoe.Connector.PostgreSql.EFCore;
using Steeltoe.Connector.PostgreSql;

var builder = WebApplication.CreateBuilder(args);

// honor PORT var if set
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = string.Concat("http://0.0.0.0:", port);
builder.WebHost.UseUrls(url);

builder.Services.AddPostgresConnection(builder.Configuration);
builder.Services.AddDbContext<RentalDbContext>(options => options.UseNpgsql(builder.Configuration));
// builder.Services.AddRabbitMQConnection(builder.Configuration);

// Learn more about management endpoints at https://docs.steeltoe.io/api/v3/management/
builder.Services.AddAllActuators(builder.Configuration);
builder.Services.ActivateActuatorEndpoints();

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
app.UseDeveloperExceptionPage();
app.UseSwagger();
app.UseSwaggerUI();
// }

app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "StaticFiles")),
    RequestPath = "",
});

using (var serviceScope = app.Services.CreateScope())
{
    var services = serviceScope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<RentalDbContext>();
        context.Database.EnsureCreated();

        if (context.RentalData != null && !context.RentalData.Any())
        {
            // Seed data
            var rentals = new RentalEntity[]
            {
                new() { State = RentalState.Available },
                new() { State = RentalState.Reserved },
                new() { State = RentalState.Available },
            };
            context.RentalData.AddRange(rentals);
            context.SaveChanges();
        }
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Failed to create the rental database");
    }
}

app.MapControllers();
app.Run();