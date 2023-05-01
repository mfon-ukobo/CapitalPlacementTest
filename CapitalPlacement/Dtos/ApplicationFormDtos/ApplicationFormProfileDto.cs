namespace CapitalPlacement.Dtos.ApplicationFormDtos
{
    public class ApplicationFormProfileDto
    {
        public ApplicationFormProfileEducationDto Education { get; set; }
        public ApplicationFormProfileWorkExperienceDto Experience { get; set; }
        public ApplicationFormProfileQuestionFieldDto Resume { get; set; }
        public List<ApplicationFormProfileQuestionFieldDto> Questions { get; set; }
    }
}
