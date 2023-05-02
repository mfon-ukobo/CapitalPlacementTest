using CapitalPlacement.Database;
using CapitalPlacement.Dtos.ProgramDetailDtos;
using CapitalPlacement.Models;
using CapitalPlacement.Models.ApplicationFormModels;
using CapitalPlacement.Models.ProgramDetailModels;
using CapitalPlacement.Models.Workflow;
using FluentValidation;

namespace CapitalPlacement.Services
{
    internal class ProgramService : IProgramService
    {
        private readonly ICosmosContext _cosmosContext;

        public ProgramService(ICosmosContext cosmosContext)
        {
            _cosmosContext = cosmosContext;
        }

        public async Task<IEnumerable<ProgramModel>> GetMultipleAsync()
        {
            return await _cosmosContext.Programs.GetMultipleAsync("SELECT * FROM c");
        }

        public async Task<ProgramModel> AddAsync(ProgramModel item)
        {
            item.Id = Guid.NewGuid().ToString();

            await _cosmosContext.Programs.AddAsync(item);
            return item;
        }

        public async Task<ProgramModel> GetAsync(string id)
        {
            return await _cosmosContext.Programs.GetAsync(id);
        }

        public async Task<ProgramModel> UpdateAsync(string id, ProgramModel item)
        {
            await _cosmosContext.Programs.UpdateAsync(id, item);
            return item;
        }

        public async Task<ApplicationForm> GetApplicationFormAsync(string id)
        {
            return await _cosmosContext.ApplicationForms.GetAsync(id);
        }

        public async Task<ApplicationForm> UpdateApplicationFormAsync(string id, ApplicationForm form)
        {
            await _cosmosContext.ApplicationForms.UpdateAsync(id, form);
            return form;
        }

        public async Task<Workflow> GetWorkflowAsync(string id)
        {
            return await _cosmosContext.Workflows.GetAsync(id);
        }

        public async Task<Workflow> UpdateWorkflowAsync(string id, Workflow workflow)
        {
            await _cosmosContext.Workflows.UpdateAsync(id, workflow);
            return workflow;
        }
    }
}
