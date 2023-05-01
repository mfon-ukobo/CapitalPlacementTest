using CapitalPlacement.Enums;
using CapitalPlacement.Utilities;

namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class WorkExperienceField : IField
    {
        protected WorkExperienceField()
        {

        }
        public WorkExperienceField(QuestionType questionType)
        {
            Question = QuestionBuilder.Create(questionType);
        }

        public IQuestion Question { get; set; }
    }
}
