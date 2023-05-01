using AutoMapper;
using CapitalPlacement.Dtos.ProgramDetailDtos;
using CapitalPlacement.Models;
using CapitalPlacement.Models.ProgramDetailModels;

namespace CapitalPlacement.Mapping
{
    public class ProgramMapping : Profile
    {
        public ProgramMapping()
        {
            CreateMap<ProgramModel, ProgramDto>();
            CreateMap<CreateProgramRequestDto, ProgramDetail>();
            CreateMap<ProgramDetail, ProgramDetailDto>();
        }
    }
}
