namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class ApplicationFormProfileEducation : ApplicationFormProfileField
    {
        public Education Education { get; set; } = new();
    }
}
