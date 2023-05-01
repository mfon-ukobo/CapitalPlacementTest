namespace CapitalPlacement.Dtos.ApplicationFormDtos
{
    public class ApplicationFormPersonalInfoFieldDto
    {
        public bool IsInternal { get; set; }
        public bool IsVisible { get; set; }
        public bool IsEditable { get; set; }
        public QuestionDto Question { get; set; }
    }
}
