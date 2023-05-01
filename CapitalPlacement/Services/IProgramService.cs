using CapitalPlacement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Services
{
    public interface IProgramService
    {
        Task<ProgramModel> CreateAsync(Models.ProgramModel program);
        Task DeleteAsync(string id);
        Task<Models.ProgramModel> GetAsync(string id);
        Task UpdateAsync(string id, Models.ProgramModel program);
    }
}
