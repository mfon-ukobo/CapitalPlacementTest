using CapitalPlacement.Enums;

namespace CapitalPlacement.Dtos
{
    public class QuestionDto
    {
        public virtual QuestionType Type { get; set; }
        public string QuestionText { get; set; }
    }
}
