using System.Collections.Generic;
using System.Threading.Tasks;
using Barkeeper2.Interfaces;
using Barkeeper2.Models;

namespace Barkeeper2.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository) {
            _repository = repository;
        }

        public async Task<ICollection<T>> GetAll() {
            return await _repository.GetAllAsync();
        }

        public async Task<T> SaveNew(T t) {
            return await _repository.AddAsync(t);
        }
    }
}