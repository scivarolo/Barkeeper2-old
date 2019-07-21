using Barkeeper2.Data;
using Barkeeper2.Models;
using Barkeeper2.Interfaces;

namespace Barkeeper2.Repositories
{
    public class CocktailIngredientsRepository : BaseRepository<CocktailIngredient>, ICocktailIngredientsRepository {
        private readonly ApplicationDbContext _context;

        public CocktailIngredientsRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }
    }
}
