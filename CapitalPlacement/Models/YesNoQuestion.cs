using CapitalPlacement.Enums;

namespace CapitalPlacement.Models
{
    public class YesNoQuestion : Question
    {
        public override QuestionType Type => QuestionType.Yes_No;
    }
}
