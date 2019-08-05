using Barkeeper2.Interfaces;
using Barkeeper2.Models;
using Barkeeper2.Repositories;

namespace Barkeeper2.Services {
	public class UserTabsService : BaseService<UserTabCocktail>, IUserTabsService {
		private readonly UserTabsRepository _userTabsRepository;

		public UserTabsService (UserTabsRepository userTabsRepository) : base (userTabsRepository) {
			_userTabsRepository = userTabsRepository;
		}
	}
}