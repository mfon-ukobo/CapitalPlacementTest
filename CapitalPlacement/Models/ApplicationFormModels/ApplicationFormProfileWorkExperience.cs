namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class ApplicationFormProfileWorkExperience : ApplicationFormProfileField
    {
        public WorkExperience WorkExperience { get; set; } = new();
    }
}
