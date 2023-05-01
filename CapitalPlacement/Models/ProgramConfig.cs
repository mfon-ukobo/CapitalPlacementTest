using CapitalPlacement.Enums;
using CapitalPlacement.Models.ProgramDetailModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Models
{
    public class ProgramConfig : BaseModel
    {
        public ProgramDetail Detail { get; set; } = new ProgramDetail();
        public ProgramStatus Status { get; set; } = ProgramStatus.Draft;
    }
}
