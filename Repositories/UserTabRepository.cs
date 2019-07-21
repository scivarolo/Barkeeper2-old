using Barkeeper2.Data;
using Barkeeper2.Models;
using Barkeeper2.Interfaces;

namespace Barkeeper2.Repositories
{
    public class UserTabsRepository : BaseRepository<UserTabCocktail>, IUserTabsRepository {
        private readonly ApplicationDbContext _context;

        public UserTabsRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }
    }
}
