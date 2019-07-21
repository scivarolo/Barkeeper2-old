using Barkeeper2.Data;
using Barkeeper2.Models;
using Barkeeper2.Interfaces;

namespace Barkeeper2.Repositories
{
    public class UserShoppingRepository : BaseRepository<UserShopping>, IUserShoppingRepository {
        private readonly ApplicationDbContext _context;

        public UserShoppingRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }
    }
}
