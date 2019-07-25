using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Barkeeper2.Data;
using Barkeeper2.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Barkeeper2.Models;
using Microsoft.EntityFrameworkCore;

namespace Barkeeper2.Controllers
{

    [Authorize]
    [Route("api/v2/ingredients")]
    public class IngredientsController
    {

        private readonly IIngredientsService _ingredientsService;
        public IngredientsController(IIngredientsService ingredientsService) {
            _ingredientsService = ingredientsService;
        }

        [HttpGet]
        public async Task<ICollection<Ingredient>> GetIngredients() {
            var model = await _ingredientsService.GetAll();
            return model;
        }

        [HttpPost]
        public async Task<Ingredient> SaveNewIngredient(Ingredient ingredient) {
            var model = await _ingredientsService.SaveNew(Ingredient ingredient);
            return model;
        }

    }
}
