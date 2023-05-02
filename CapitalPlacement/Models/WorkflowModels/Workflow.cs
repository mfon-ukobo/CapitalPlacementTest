using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Models.Workflow
{
    public class Workflow : BaseModel
    {
        public string ProgramId { get; set; }
        public List<Stage> Stages { get; set; } = new();
    }
}
