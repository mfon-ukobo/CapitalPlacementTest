using AutoMapper;
using CapitalPlacement.Dtos.Requests;
using CapitalPlacement.Models;
using CapitalPlacement.Models.ProgramDetailModels;

namespace CapitalPlacement.Mapping
{
    public class ProgramMapping : Profile
    {
        public ProgramMapping()
        {
            CreateMap<CreateProgramRequestDto, ProgramDetail>();
        }
    }
}
