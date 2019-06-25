using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Barkeeper2.Data;
using Barkeeper2.Models;
using Microsoft.EntityFrameworkCore;

namespace Barkeeper2.Repositories
{
    public class IngredientsRepository
    {
        private readonly ApplicationDbContext _context;

        public IngredientsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ingredient>> GetAllAsync() {
            return await _context.Ingredients.ToListAsync();
        }
    }
}
