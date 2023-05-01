using CapitalPlacement.Enums;

namespace CapitalPlacement.Models
{
    public interface IQuestion
    {
        QuestionType Type { get; set; }
        string QuestionText { get; set; }
    }

    public interface IChoiceQuestion
    {
        List<string> Choices { get; set; }
        bool EnableOtherOption { get; set; }
    }
}
