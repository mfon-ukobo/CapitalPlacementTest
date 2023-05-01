using CapitalPlacement.Enums;

namespace CapitalPlacement.Dtos.WorkflowDtos
{
    public class StageDto
    {
        public int Order { get; set; }
        public string Name { get; set; }
        public virtual StageType Type { get; set; }
        public bool ShowToCandidate { get; set; }
    }
}
