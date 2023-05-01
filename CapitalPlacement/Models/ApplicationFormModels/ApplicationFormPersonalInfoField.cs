using CapitalPlacement.Enums;
using CapitalPlacement.Utilities;

namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class ApplicationFormPersonalInfoField : IField
    {
        protected ApplicationFormPersonalInfoField()
        {

        }

        public ApplicationFormPersonalInfoField(QuestionType type)
        {
            IsInternal = false;
            IsVisible = false;
            IsEditable = true;
            Question = QuestionBuilder.Create(type);
        }

        public ApplicationFormPersonalInfoField(QuestionType type, bool isEditable)
        {
            IsInternal = false;
            IsVisible = false;
            IsEditable = isEditable;
            Question = QuestionBuilder.Create(type);
        }

        public bool IsInternal { get; set; }
        public bool IsVisible { get; set; }
        public bool IsEditable { get; set; }
        public IQuestion Question { get; set; }
    }
}
