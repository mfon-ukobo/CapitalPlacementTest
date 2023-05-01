using AutoMapper;
using CapitalPlacement.Dtos.WorkflowDtos;
using CapitalPlacement.Models.Workflow;

namespace CapitalPlacement.Mapping
{
    public class WorkflowMapping : Profile
    {
        public WorkflowMapping()
        {
            CreateMap<Workflow, WorkflowDto>();
            CreateMap<Stage, StageDto>();
            CreateMap<VideoInterviewStage, VideoInterviewStageDto>();
            CreateMap<VideoInterviewQuestion, VideoInterviewQuestionDto>();
            CreateMap<StageVideoDuration, StageVideoDurationDto>();
        }
    }
}
