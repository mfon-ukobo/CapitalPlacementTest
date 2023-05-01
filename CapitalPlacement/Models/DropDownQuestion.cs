using CapitalPlacement.Enums;

namespace CapitalPlacement.Models
{
    public class DropDownQuestion : Question, IChoiceQuestion
    {
        public override QuestionType Type => QuestionType.Dropdown;
        public string[] Choices { get; set; }
    }
}
