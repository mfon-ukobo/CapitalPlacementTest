using CapitalPlacement.Models;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Database
{
    internal class CosmosDbSet<T> : ICosmosDbSet<T> where T : BaseModel
    {
        private Container _container;

        public CosmosDbSet(
            CosmosClient cosmosDbClient,
            string databaseName,
            string containerName)
        {
            cosmosDbClient.GetDatabase(databaseName).CreateContainerIfNotExistsAsync(containerName, "/id").GetAwaiter().GetResult();
            _container = cosmosDbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddAsync(T item)
        {
            await _container.CreateItemAsync(item, new PartitionKey(item.Id));
        }

        public async Task DeleteAsync(string id)
        {
            await _container.DeleteItemAsync<T>(id, new PartitionKey(id));
        }

        public async Task<T> GetAsync(string id)
        {
            try
            {
                var response = await _container.ReadItemAsync<T>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException) //For handling item not found and other exceptions
            {
                return default;
            }
        }

        public async Task<IEnumerable<T>> GetMultipleAsync(string queryString)
        {
            var query = _container.GetItemQueryIterator<T>(new QueryDefinition(queryString));

            var results = new List<T>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateAsync(string id, T item)
        {
            await _container.UpsertItemAsync(item, new PartitionKey(id));
        }
    }
}
