using CapitalPlacement.Models;
using CapitalPlacement.Models.ApplicationFormModels;
using CapitalPlacement.Utilities;
using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
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
            Programs = provider.Initialize<ProgramConfig>("programs");
            ApplicationForms = provider.Initialize<ApplicationForm>("applicationForms");
        }

        public ICosmosDbSet<ProgramConfig> Programs { get; }
        public ICosmosDbSet<ApplicationForm> ApplicationForms { get; }
    }
}
