using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Barkeeper2.Data;
using Barkeeper2.Interfaces;
using Barkeeper2.Models;
using Barkeeper2.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barkeeper2.Controllers {

	[Authorize]
	[Route("api/v2/ingredients")]
	public class IngredientsController {

		private readonly IIngredientsService _ingredientsService;
		public IngredientsController(IIngredientsService ingredientsService) {
			_ingredientsService = ingredientsService;
		}

#region Get Ingredients

		[HttpGet]
		public async Task<ICollection<Ingredient>> GetIngredients() {
			var model = await _ingredientsService.GetAll();
			return model;
		}

		[HttpGet("{id}")]
		public async Task<Ingredient> GetIngredient(int id) {
			var model = await _ingredientsService.GetById(id);
			return model;
		}

#endregion

#region Save Ingredients

		[HttpPost]
		public async Task<Ingredient> AddNewIngredient(Ingredient newIngredient) {
			var model = await _ingredientsService.AddNew(newIngredient);
			return model;
		}

		[HttpPut]
		public async Task<Ingredient> UpdateIngredient(Ingredient updatedIngredient, int id) {
            var model = await _ingredientsService.Update(updatedIngredient, id);
            return model;
        }

#endregion

		[HttpDelete]
		public async Task<int> DeleteIngredient(Ingredient ingredient) {
            return await _ingredientsService.Delete(ingredient);
        }

	}
}