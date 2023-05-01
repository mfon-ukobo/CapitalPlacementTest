using CapitalPlacement.Enums;
using CapitalPlacement.Utilities;

namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class EducationField : IField
    {
        protected EducationField()
        {

        }
        public EducationField(QuestionType questionType)
        {
            Question = QuestionBuilder.Create(questionType);
        }

        public IQuestion Question { get; set; }
    }
}
