using CapitalPlacement.Enums;
using CapitalPlacement.Models;
using CapitalPlacement.Models.ApplicationFormModels;
using CapitalPlacement.Utilities;

namespace CapitalPlacement.Dtos.ApplicationFormDtos
{
    public class ApplicationFormDto
    {
        public string CoverImageUrl { get; set; }
        public ApplicationFormPersonalInfoDto? PersonalInfo { get; set; }
        public ApplicationFormProfileDto? Profile { get; set; }
    }
}
