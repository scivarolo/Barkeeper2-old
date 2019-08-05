using Barkeeper2.Interfaces;
using Barkeeper2.Models;
using Barkeeper2.Repositories;

namespace Barkeeper2.Services {
	public class ProductsService : BaseService<Product>, IProductsService {
		private readonly ProductsRepository _productsRepository;

		public ProductsService (ProductsRepository productsRepository) : base (productsRepository) {
			_productsRepository = productsRepository;
		}
	}
}