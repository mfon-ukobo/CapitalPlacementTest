using CapitalPlacement.Enums;

namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class WorkExperience
    {
        public WorkExperienceField Company { get; set; } = new(QuestionType.Short_Answer);
        public WorkExperienceField Title { get; set; } = new(QuestionType.Short_Answer);
        public WorkExperienceField Location { get; set; } = new(QuestionType.Dropdown);
        public WorkExperienceField StartDate { get; set; } = new(QuestionType.Date);
        public WorkExperienceField EndDate { get; set; } = new(QuestionType.Date);
    }
}
