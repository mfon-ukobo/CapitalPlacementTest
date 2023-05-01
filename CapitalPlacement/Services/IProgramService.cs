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
        Task CreateAsync(ProgramConfig program);
        Task DeleteAsync(string id);
        Task<ProgramConfig> GetAsync(string id);
        Task UpdateAsync(string id, ProgramConfig program);
    }
}
