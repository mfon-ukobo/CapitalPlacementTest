namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class ApplicationForm : BaseModel
    {
        public ApplicationForm(Guid id) : base(id)
        {
            ProgramId = id.ToString();
        }

        public string ProgramId { get; set; }
        public string CoverImageUrl { get; set; }
        public ApplicationFormPersonalInfo PersonalInfo { get; set; } = new();
        public ApplicationFormProfile Profile { get; set; } = new();
    }
}
