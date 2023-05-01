using CapitalPlacement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Models
{
    public interface IField
    {
        IQuestion Question { get; set; }
    }
}
