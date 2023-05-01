namespace CapitalPlacement.Models.Workflow
{
    public class VideoInterviewQuestion
    {
        public string QuestionText { get; set; }
        public string Instructions { get; set; }
        public int MaxDurationOfVideo { get; set; }
        public StageVideoDuration MaxVideoDuration { get; set; }
        public int DeadlineAfterDays { get; set; }
    }
}
