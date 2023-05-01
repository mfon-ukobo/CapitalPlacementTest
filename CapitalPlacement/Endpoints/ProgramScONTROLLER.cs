using AutoMapper;
using CapitalPlacement.Dtos.Requests;
using CapitalPlacement.Models;
using CapitalPlacement.Models.ProgramDetailModels;
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

        [HttpPost("")]
        public async Task<IActionResult> CreateProgram([FromBody] CreateProgramRequestDto request)
        {
            var program = new ProgramModel(Guid.NewGuid())
            {
                Detail = _mapper.Map<ProgramDetail>(request)
            };

            try
            {
                var result = await _programService.CreateAsync(program);
                return Ok(new { result.Id });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
