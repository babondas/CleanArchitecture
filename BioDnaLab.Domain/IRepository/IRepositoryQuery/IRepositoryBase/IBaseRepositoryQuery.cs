using BioDnaLab.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.IRepository.IRepositoryQuery.IRepositoryBase
{
    public interface IBaseRepositoryQuery<T, TId> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(TId id);
    }

}
