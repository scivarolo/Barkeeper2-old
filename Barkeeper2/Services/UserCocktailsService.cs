using Barkeeper2.Interfaces;
using Barkeeper2.Models;
using Barkeeper2.Repositories;

namespace Barkeeper2.Services {
	public class UserCocktailsService : BaseService<UserCocktail>, IUserCocktailsService {
		private readonly UserCocktailsRepository _userCocktailsRepository;

		public UserCocktailsService (UserCocktailsRepository userCocktailsRepository) : base (userCocktailsRepository) {
			_userCocktailsRepository = userCocktailsRepository;
		}

	}
}