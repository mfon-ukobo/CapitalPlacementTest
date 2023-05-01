using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Dtos.WorkflowDtos
{
    public class WorkflowDto
    {
        public string Id { get; set; }
        public string ProgramId { get; set; }
        public List<StageDto> Stages { get; set; } = new();
    }
}
