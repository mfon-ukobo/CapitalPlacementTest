using CapitalPlacement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Models.ProgramDetailModels
{
    public class ProgramDetail
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Benefits { get; set; }
        public string ApplicationCriteria { get; set; }
        public string[] Skills { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplicationOpen { get; set; }
        public DateTime ApplicationClose { get; set; }
        public ProgramType Type { get; set; }
        public string Duration { get; set; }
        public Qualification MinQualification { get; set; }
        public long MaxApplicationAllowed { get; set; }
    }
}
