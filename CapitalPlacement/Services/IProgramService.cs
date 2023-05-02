using CapitalPlacement.Models;
using CapitalPlacement.Models.ApplicationFormModels;
using CapitalPlacement.Models.Workflow;

namespace CapitalPlacement.Services
{
    public interface IProgramService
    {
        Task<ProgramModel> AddAsync(ProgramModel programModel);
        Task<ApplicationForm> GetApplicationFormAsync(string id);
        Task<ProgramModel> GetAsync(string id);
        Task<IEnumerable<ProgramModel>> GetMultipleAsync();
        Task<Workflow> GetWorkflowAsync(string id);
        Task<ApplicationForm> UpdateApplicationFormAsync(string id, ApplicationForm form);
        Task<ProgramModel> UpdateAsync(string id, ProgramModel item);
        Task<Workflow> UpdateWorkflowAsync(string id, Workflow workflow);
    }
}
