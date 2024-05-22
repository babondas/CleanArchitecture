using BioDnaLab.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.IRepository.IRepositoryCommand.IRepositoryCommandBase
{
    public interface IBaseRepositoryCommand<T, TId> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<T> DeleteAsync(TId id);
        //Task<T> UpdateAsync(TId id, T entity);

    }
}
