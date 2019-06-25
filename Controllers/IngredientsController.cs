using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Barkeeper2.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Barkeeper2.Models;
using Microsoft.EntityFrameworkCore;

namespace Barkeeper2.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    public class IngredientsController
    {

        private readonly ApplicationDbContext _context;
        public IngredientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<Ingredient>> Ingredients()
        {
            return await _context.Ingredients.ToListAsync();
        }

    }
}
