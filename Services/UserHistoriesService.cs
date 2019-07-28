using Barkeeper2.Interfaces;
using Barkeeper2.Models;
using Barkeeper2.Repositories;

namespace Barkeeper2.Services {
	public class UserHistoriesService : BaseService<UserHistory>, IUserHistoriesService {
		private readonly UserHistoriesRepository _userHistoriesRepository;

		public UserHistoriesService (UserHistoriesRepository userHistoriesRepository) : base (userHistoriesRepository) {
			_userHistoriesRepository = userHistoriesRepository;
		}
	}
}