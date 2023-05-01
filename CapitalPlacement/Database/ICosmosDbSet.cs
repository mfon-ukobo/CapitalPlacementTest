using CapitalPlacement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Database
{
    public interface ICosmosDbSet<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetMultipleAsync(string query);
        Task<T> GetAsync(string id);
        Task AddAsync(T item);
        Task UpdateAsync(string id, T item);
        Task DeleteAsync(string id);
    }
}
