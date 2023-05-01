using AutoMapper;
using CapitalPlacement.Dtos;
using CapitalPlacement.Dtos.ApplicationFormDtos;
using CapitalPlacement.Models;
using CapitalPlacement.Models.ApplicationFormModels;

namespace CapitalPlacement.Mapping
{
    public class ApplicationFormMapping : Profile
    {
        public ApplicationFormMapping()
        {
            CreateMap<ApplicationForm, ApplicationFormDto>().ReverseMap();
            CreateMap<ApplicationFormPersonalInfo, ApplicationFormPersonalInfoDto>().ReverseMap();
            CreateMap<ApplicationFormPersonalInfoField, ApplicationFormPersonalInfoFieldDto>().ReverseMap();
            CreateMap<ApplicationFormProfile, ApplicationFormProfileDto>().ReverseMap();
            CreateMap<ApplicationFormProfileEducation, ApplicationFormProfileEducationDto>().ReverseMap();
            CreateMap<ApplicationFormProfileField, ApplicationFormProfileFieldDto>().ReverseMap();
            CreateMap<ApplicationFormProfileQuestionField, ApplicationFormProfileQuestionFieldDto>().ReverseMap();
            CreateMap<ApplicationFormProfileWorkExperience, ApplicationFormProfileWorkExperienceDto>().ReverseMap();
            CreateMap<Education, EducationDto>().ReverseMap();
            CreateMap<EducationField, EducationFieldDto>().ReverseMap();
            CreateMap<WorkExperience, WorkExperienceDto>().ReverseMap();
            CreateMap<WorkExperienceField, WorkExperienceFieldDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap()
                .IncludeAllDerived();
        }
    }
}
