using CapitalPlacement.Database;
using CapitalPlacement.Endpoints;
using CapitalPlacement.Models;
using CapitalPlacement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:4000");

builder.Configuration.AddJsonFile("appsettings.json");

var services = builder.Services;
var configuration = builder.Configuration;

services.AddControllers();

var configurationSection = configuration.GetSection("CosmosDb");
var databaseName = configurationSection["DatabaseName"];
var account = configurationSection["Account"];
var key = configurationSection["Key"];

services.AddSingleton<CosmosDbServiceProvider>(InitializeCosmosClientInstanceAsync(account, key, databaseName).GetAwaiter().GetResult());
services.AddSingleton<ICosmosContext, CosmosContext>();
services.AddScoped<IProgramService, ProgramService>();

services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

app.MapControllers();

//var testingService = app.Services.GetRequiredService<TestingEndpoints>();
//await testingService.AddProgram();
//await testingService.GetProgram();
//await testingService.AddApplicationForm();

app.Run();

static async Task<CosmosDbServiceProvider> InitializeCosmosClientInstanceAsync(string account, string key, string databaseName)
{
    var client = new CosmosClient(account, key, new()
    {
        SerializerOptions = new()
        {
            PropertyNamingPolicy = CosmosPropertyNamingPolicy.CamelCase
        }
    });

    var database = await client.CreateDatabaseIfNotExistsAsync(databaseName);
    //await database.Database.CreateContainerIfNotExistsAsync(containerName, "/id");
    return new CosmosDbServiceProvider(account, key, databaseName);
}