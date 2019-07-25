using Barkeeper2.Data;
using Barkeeper2.Models;
using Barkeeper2.Interfaces;

namespace Barkeeper2.Repositories
{
    public class CocktailsRepository : BaseRepository<Cocktail> {
        private readonly ApplicationDbContext _context;

        public CocktailsRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }
    }
}