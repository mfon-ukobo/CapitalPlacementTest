using CapitalPlacement.Enums;

namespace CapitalPlacement.Models.Workflow
{
    public class Stage
    {
        public int Order { get; set; }
        public string Name { get; set; }
        public virtual StageType Type { get; set; }
        public bool ShowToCandidate { get; set; }
        public DateOnly CreatedAt { get; set; }
    }
}
