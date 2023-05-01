using CapitalPlacement.Enums;

namespace CapitalPlacement.Models
{
    public class DropDownQuestion : Question, IChoiceQuestion
    {
        public DropDownQuestion()
        {
            EnableOtherOption = true;
        }

        public override QuestionType Type => QuestionType.Dropdown;
        public List<string> Choices { get; set; }
        public bool EnableOtherOption { get; set; }
    }
}
