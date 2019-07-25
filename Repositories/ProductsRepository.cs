using Barkeeper2.Data;
using Barkeeper2.Models;
using Barkeeper2.Interfaces;

namespace Barkeeper2.Repositories
{

    public class ProductsRepository : BaseRepository<Product> {
        private readonly ApplicationDbContext _context;
        public ProductsRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }
    }
}
