using CapitalPlacement.Enums;

namespace CapitalPlacement.Dtos.WorkflowDtos
{
    public class VideoInterviewStageDto : StageDto
    {
        public VideoInterviewQuestionDto Question { get; set; }
    }
}
