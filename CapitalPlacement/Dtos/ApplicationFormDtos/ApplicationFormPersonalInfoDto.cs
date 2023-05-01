namespace CapitalPlacement.Dtos.ApplicationFormDtos
{
    public class ApplicationFormPersonalInfoDto
    {
        public ApplicationFormPersonalInfoFieldDto FirstName { get; set; }
        public ApplicationFormPersonalInfoFieldDto LastName { get; set; }
        public ApplicationFormPersonalInfoFieldDto Email { get; set; }
        public ApplicationFormPersonalInfoFieldDto Phone { get; set; }
        public ApplicationFormPersonalInfoFieldDto Nationality { get; set; }
        public ApplicationFormPersonalInfoFieldDto CurrentResidence { get; set; }
        public ApplicationFormPersonalInfoFieldDto IDNumber { get; set; }
        public ApplicationFormPersonalInfoFieldDto DateOfBirth { get; set; }
        public ApplicationFormPersonalInfoFieldDto Gender { get; set; }
        public List<ApplicationFormPersonalInfoFieldDto> Questions { get; set; }
    }
}
