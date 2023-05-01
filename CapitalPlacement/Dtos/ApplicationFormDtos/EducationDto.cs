namespace CapitalPlacement.Dtos.ApplicationFormDtos
{
    public class EducationDto
    {
        public EducationFieldDto School { get; set; }
        public EducationFieldDto Degree { get; set; }
        public EducationFieldDto CourseName { get; set; }
        public EducationFieldDto LocationOfStudy { get; set; }
        public EducationFieldDto StartDate { get; set; }
        public EducationFieldDto? EndDate { get; set; }
        public EducationFieldDto? ICurrentlyStudyHere { get; set; }
    }
}
