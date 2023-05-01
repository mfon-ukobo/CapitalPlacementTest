using CapitalPlacement.Enums;

namespace CapitalPlacement.Models
{
    public class Question : IQuestion
    {
        public virtual QuestionType Type { get; set; }
        public string QuestionText { get; set; }
    }
}
