using Barkeeper2.Interfaces;
using Barkeeper2.Models;
using Barkeeper2.Repositories;

namespace Barkeeper2.Services {
	public class CocktailsService : BaseService<Cocktail>, ICocktailsService {
		private readonly CocktailsRepository _cocktailsRepository;

		public CocktailsService (CocktailsRepository cocktailsRepository) : base (cocktailsRepository) {
			_cocktailsRepository = cocktailsRepository;
		}
	}
}