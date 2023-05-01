namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class ApplicationForm : BaseModel
    {
        public ApplicationForm(Guid id) : base(id)
        {
            
        }

        public string CoverImageUrl { get; set; }
        public ApplicationFormPersonalInfo PersonalInfo { get; set; } = new();
        public ApplicationFormProfile Profile { get; set; } = new();
        public List<IQuestion> AdditionalQuestions { get; set; } = new();
    }
}
