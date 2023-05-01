using CapitalPlacement.Models;
using CapitalPlacement.Models.ApplicationFormModels;
using CapitalPlacement.Models.Workflow;
using CapitalPlacement.Utilities;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Database
{
    internal class CosmosContext : ICosmosContext
    {
        public CosmosContext(CosmosDbServiceProvider provider)
        {
            Programs = provider.Initialize<ProgramModel>("programs");
            ApplicationForms = provider.Initialize<ApplicationForm>("applicationForms");
            Workflows = provider.Initialize<Workflow>("workflows");
        }

        public ICosmosDbSet<ProgramModel> Programs { get; }
        public ICosmosDbSet<ApplicationForm> ApplicationForms { get; }
        public ICosmosDbSet<Workflow> Workflows { get; }
    }
}
