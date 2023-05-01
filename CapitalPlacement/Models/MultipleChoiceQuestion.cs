using CapitalPlacement.Enums;

namespace CapitalPlacement.Models
{
    public class MultipleChoiceQuestion : Question, IChoiceQuestion
    {
        public override QuestionType Type => QuestionType.Multiple_Choice;
        public string[] Choices { get; set; }
    }
}
