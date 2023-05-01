﻿using CapitalPlacement.Database;
using CapitalPlacement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Services
{
    internal class ProgramService : IProgramService
    {
        private readonly ICosmosContext _context;

        public ProgramService(ICosmosContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(ProgramConfig program)
        {
            await _context.Programs.AddAsync(program);
        }

        public async Task DeleteAsync(string id)
        {
            await _context.Programs.DeleteAsync(id);
        }

        public async Task UpdateAsync(string id, ProgramConfig program)
        {
            await _context.Programs.UpdateAsync(id, program);
        }

        public async Task<ProgramConfig> GetAsync(string id)
        {
            return await _context.Programs.GetAsync(id);
        }
    }
}
