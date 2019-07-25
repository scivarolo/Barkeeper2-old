using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Barkeeper2.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        Task<ICollection<T>> GetAll();
    }
}