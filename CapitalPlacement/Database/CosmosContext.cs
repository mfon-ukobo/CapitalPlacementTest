using CapitalPlacement.Models;
using CapitalPlacement.Models.ApplicationFormModels;
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
            Programs = provider.Initialize<Models.ProgramModel>("programs");
            ApplicationForms = provider.Initialize<ApplicationForm>("applicationForms");
        }

        public ICosmosDbSet<Models.ProgramModel> Programs { get; }
        public ICosmosDbSet<ApplicationForm> ApplicationForms { get; }
    }
}
