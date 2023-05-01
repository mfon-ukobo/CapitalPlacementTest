using CapitalPlacement.Enums;

namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class Education
    {
        public EducationField School { get; set; } = new(QuestionType.Short_Answer);
        public EducationField Degree { get; set; } = new(QuestionType.Dropdown);
        public EducationField CourseName { get; set; } = new(QuestionType.Short_Answer);
        public EducationField LocationOfStudy { get; set; } = new(QuestionType.Short_Answer);
        public EducationField StartDate { get; set; } = new(QuestionType.Date);
        public EducationField? EndDate { get; set; } = new(QuestionType.Date);
        public EducationField? ICurrentlyStudyHere { get; set; } = new(QuestionType.Yes_No);
    }
}
