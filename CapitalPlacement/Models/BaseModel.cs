﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Models
{
    public abstract class BaseModel
    {
        public string Id { get; set; }

        public virtual void SetId(Guid id)
        {
            Id = id.ToString();
        }
    }
}
