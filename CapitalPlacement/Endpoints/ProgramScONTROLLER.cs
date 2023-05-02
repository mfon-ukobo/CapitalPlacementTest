using AutoMapper;
using CapitalPlacement.Database;
using CapitalPlacement.Dtos.ApplicationFormDtos;
using CapitalPlacement.Dtos.ProgramDetailDtos;
using CapitalPlacement.Dtos.WorkflowDtos;
using CapitalPlacement.Models;
using CapitalPlacement.Models.ApplicationFormModels;
using CapitalPlacement.Models.ProgramDetailModels;
using CapitalPlacement.Models.Workflow;
using CapitalPlacement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacement.Endpoints
{
    [Route("programs")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProgramService _programService;

        public ProgramsController(IMapper mapper, IProgramService programService)
        {
            _mapper = mapper;
            _programService = programService;
        }

        /// <summary>
        /// Creates a program with program details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<IActionResult> CreateProgram([FromBody] CreateProgramRequestDto request)
        {
            var program = new ProgramModel
            {
                Detail = _mapper.Map<ProgramDetail>(request)
            };

            try
            {
                var programModel = await _programService.AddAsync(program);
                return Ok(_mapper.Map<ProgramDto>(programModel));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets a single program
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetProgram(string id)
        {
            var program = await _programService.GetAsync(id);
            return Ok(_mapper.Map<ProgramDto>(program));
        }

        /// <summary>
        /// Get multiple programs
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IActionResult> GetPrograms()
        {
            var programs = await _programService.GetMultipleAsync();
            return Ok(_mapper.Map<IEnumerable<ProgramDto>>(programs));
        }

        /// <summary>
        /// Get application form with Id = <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:Guid}/application-form")]
        public async Task<IActionResult> GetApplicationForm(string id)
        {
            var applicationForm = await _programService.GetApplicationFormAsync(id);

            return Ok(_mapper.Map<ApplicationFormDto>(applicationForm));
        }

        /// <summary>
        /// Updates the application form config for a program with Id = <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="applicationFormDto"></param>
        /// <returns></returns>
        [HttpPut("{id:Guid}/application-form")]
        public async Task<IActionResult> UpdateApplicationForm(string id, [FromBody] ApplicationFormDto applicationFormDto)
        {
            var applicationFormToUpdate = _mapper.Map<ApplicationForm>(applicationFormDto);
            applicationFormToUpdate.Id = id;

            try
            {
                var result = await _programService.UpdateApplicationFormAsync(id, applicationFormToUpdate);

                return Ok(_mapper.Map<ApplicationForm>(result));
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Get workflow for a program with Id = <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:Guid}/workflow")]
        public async Task<IActionResult> GetWorkflow(string id)
        {
            var workflow = await _programService.GetWorkflowAsync(id);

            return Ok(_mapper.Map<WorkflowDto>(workflow));
        }

        /// <summary>
        /// Updates workflow for param with Id = <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workflowDto"></param>
        /// <returns></returns>
        [HttpPut("{id:Guid}/workflow")]
        public async Task<IActionResult> UpdateWorkflow(string id, [FromBody] WorkflowDto workflowDto)
        {
            var workflow = _mapper.Map<Workflow>(workflowDto);
            workflow.Id = id;

            try
            {
                var result = await _programService.UpdateWorkflowAsync(id, workflow);

                return Ok(_mapper.Map<WorkflowDto>(result));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{id:Guid}/summary")]
        public async Task<IActionResult> Summary(string id)
        {
            var program = await _programService.GetAsync(id);
            var workflow = await _programService.GetWorkflowAsync(id);
            var applicationForm = await _programService.GetApplicationFormAsync(id);

            return Ok(new ProgramSummaryDto
            {
                Id = id,
                Detail = _mapper.Map<ProgramDetailDto>(program.Detail),
                ApplicationForm = _mapper.Map<ApplicationFormDto>(applicationForm),
                Workflow = _mapper.Map<WorkflowDto>(workflow)
            });
        }
    }
}
