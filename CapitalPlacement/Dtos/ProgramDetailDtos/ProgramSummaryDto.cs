using CapitalPlacement.Dtos.ApplicationFormDtos;
using CapitalPlacement.Dtos.WorkflowDtos;

namespace CapitalPlacement.Dtos.ProgramDetailDtos
{
    public class ProgramSummaryDto
    {
        public string Id { get; set; }
        public ProgramDetailDto Detail { get; set; }
        public ApplicationFormDto ApplicationForm { get; set; }
        public WorkflowDto Workflow { get; set; }
    }
}
