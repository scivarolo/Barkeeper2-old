using System.Collections.Generic;
using System.Threading.Tasks;
using Barkeeper2.Interfaces;
using Barkeeper2.Models;
using Barkeeper2.Repositories;

namespace Barkeeper2.Services {
	public class CocktailIngredientsService : BaseService<CocktailIngredient>, ICocktailIngredientsService {
		private readonly CocktailIngredientsRepository _cocktailIngredientsRepository;

		public CocktailIngredientsService (CocktailIngredientsRepository cocktailIngredientsRepository) : base (cocktailIngredientsRepository) {
			_cocktailIngredientsRepository = cocktailIngredientsRepository;
		}
	}
}