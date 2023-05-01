namespace CapitalPlacement.Dtos.WorkflowDtos
{
    public class VideoInterviewQuestionDto
    {
        public string QuestionText { get; set; }
        public string Instructions { get; set; }
        public int MaxDurationOfVideo { get; set; }
        public StageVideoDurationDto MaxVideoDuration { get; set; }
        public int DeadlineAfterDays { get; set; }
    }
}
