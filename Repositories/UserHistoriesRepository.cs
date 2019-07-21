using Barkeeper2.Data;
using Barkeeper2.Models;
using Barkeeper2.Interfaces;

namespace Barkeeper2.Repositories
{
    public class UserHistoriesRepository : BaseRepository<UserHistory>, IUserHistoriesRepository {
        private readonly ApplicationDbContext _context;

        public UserHistoriesRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }
    }
}
