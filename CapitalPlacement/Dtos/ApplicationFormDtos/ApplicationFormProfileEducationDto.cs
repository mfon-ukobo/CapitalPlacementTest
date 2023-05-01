namespace CapitalPlacement.Dtos.ApplicationFormDtos
{
    public class ApplicationFormProfileEducationDto : ApplicationFormProfileFieldDto
    {
        public EducationDto Education { get; set; } = new();
    }
}
