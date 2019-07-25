using Barkeeper2.Data;
using Barkeeper2.Models;
using Barkeeper2.Interfaces;

namespace Barkeeper2.Repositories
{
    public class UserCocktailsRepository : BaseRepository<UserCocktail> {
        private readonly ApplicationDbContext _context;

        public UserCocktailsRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }
    }
}
