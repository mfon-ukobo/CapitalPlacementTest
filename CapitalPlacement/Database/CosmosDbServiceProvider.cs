using CapitalPlacement.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Database
{
    internal class CosmosDbServiceProvider
    {
        private readonly string _databaseName;
        private readonly string _containerName;
        private readonly string _account;
        private readonly string _key;

        public CosmosDbServiceProvider(string account, string key, string databaseName)
        {
            _databaseName = databaseName;
            _account = account;
            _key = key;
        }

        public CosmosDbSet<T> Initialize<T>(string containerName) where T : BaseModel
        {
            var client = new CosmosClient(_account, _key, new()
            {
                SerializerOptions = new()
                {
                    PropertyNamingPolicy = CosmosPropertyNamingPolicy.CamelCase,
                    Indented = true
                }
            });

            var cosmosDbService = new CosmosDbSet<T>(client, _databaseName, containerName);
            return cosmosDbService;
        }
    }
}
