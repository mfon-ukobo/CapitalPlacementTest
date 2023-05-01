using CapitalPlacement.Models;
using CapitalPlacement.Models.ApplicationFormModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Database
{
    public interface ICosmosContext
    {
        ICosmosDbSet<Models.ProgramModel> Programs { get; }
        ICosmosDbSet<ApplicationForm> ApplicationForms { get; }
    }
}
