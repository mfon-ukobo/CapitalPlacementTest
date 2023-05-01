using CapitalPlacement.Database;
using CapitalPlacement.Endpoints;
using CapitalPlacement.Services;
using CapitalPlacement.Utilities;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

/*var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:4000");

builder.Configuration.AddJsonFile("appsettings.json");

var services = builder.Services;
var configuration = builder.Configuration;

var configurationSection = configuration.GetSection("CosmosDb");
var databaseName = configurationSection["DatabaseName"];
var account = configurationSection["Account"];
var key = configurationSection["Key"];

services.AddSingleton<CosmosDbServiceProvider>(InitializeCosmosClientInstanceAsync(account, key, databaseName).GetAwaiter().GetResult());
services.AddSingleton<ICosmosContext, CosmosContext>();
services.AddScoped<IProgramService, ProgramService>();

// TODO: Clean up
services.AddScoped<TestingEndpoints>();

var app = builder.Build();

var testingService = app.Services.GetRequiredService<TestingEndpoints>();
await testingService.AddProgram();
//await testingService.GetProgram();
//await testingService.AddApplicationForm();

await app.RunAsync();

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
}*/