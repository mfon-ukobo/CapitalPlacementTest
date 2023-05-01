using CapitalPlacement.Enums;

namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class ApplicationFormProfile
    {
        public ApplicationFormProfileEducation Education { get; set; } = new();
        public ApplicationFormProfileWorkExperience Experience { get; set; } = new();
        public ApplicationFormProfileQuestionField Resume { get; set; } = new(QuestionType.File_Upload);
        public List<ApplicationFormProfileQuestionField> Questions { get; set; } = new();
    }
}
