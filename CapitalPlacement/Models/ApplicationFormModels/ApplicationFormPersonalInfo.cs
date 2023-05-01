using CapitalPlacement.Enums;
using Newtonsoft.Json;
using System.Reflection;

namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class ApplicationFormPersonalInfo
    {
        public ApplicationFormPersonalInfoField FirstName { get; set; } = new(QuestionType.Short_Answer, false);
        public ApplicationFormPersonalInfoField LastName { get; set; } = new(QuestionType.Short_Answer, false);
        public ApplicationFormPersonalInfoField Email { get; set; } = new(QuestionType.Short_Answer, false);
        public ApplicationFormPersonalInfoField Phone { get; set; } = new(QuestionType.Number);
        public ApplicationFormPersonalInfoField Nationality { get; set; } = new(QuestionType.Dropdown);
        public ApplicationFormPersonalInfoField CurrentResidence { get; set; } = new(QuestionType.Short_Answer);
        public ApplicationFormPersonalInfoField IDNumber { get; set; } = new(QuestionType.Number);
        public ApplicationFormPersonalInfoField DateOfBirth { get; set; } = new(QuestionType.Date);
        public ApplicationFormPersonalInfoField Gender { get; set; } = new(QuestionType.Dropdown);
        public List<ApplicationFormPersonalInfoField> Questions { get; set; } = new();
    }
}
