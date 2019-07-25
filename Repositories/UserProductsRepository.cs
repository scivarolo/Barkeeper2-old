using Barkeeper2.Data;
using Barkeeper2.Models;
using Barkeeper2.Interfaces;

namespace Barkeeper2.Repositories
{
    public class UserProductsRepository : BaseRepository<UserProduct> {
        private readonly ApplicationDbContext _context;

        public UserProductsRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }
    }
}
