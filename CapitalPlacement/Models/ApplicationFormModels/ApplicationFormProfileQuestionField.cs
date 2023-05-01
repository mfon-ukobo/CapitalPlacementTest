using CapitalPlacement.Enums;
using CapitalPlacement.Utilities;

namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class ApplicationFormProfileQuestionField : ApplicationFormProfileField, IField
    {
        protected ApplicationFormProfileQuestionField()
        {

        }

        public ApplicationFormProfileQuestionField(QuestionType questionType)
        {
            Question = QuestionBuilder.Create(questionType);
        }

        public IQuestion Question { get; set; }
    }
}
