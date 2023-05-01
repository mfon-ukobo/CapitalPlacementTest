using CapitalPlacement.Enums;

namespace CapitalPlacement.Models.Workflow
{
    public class VideoInterviewStage : Stage
    {
        public override StageType Type => StageType.Video_Interview;
        public VideoInterviewQuestion Question { get; set; }
    }
}
