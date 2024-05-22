using BioDnaLab.Domain.IRepository.IRepositoryQuery.IRepositoryBase;
using BioDnaLab.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BioDnaLab.Infrastructure.Repository.Query.Base
{
    public class BaseRepositoryQuery<T, TId> : IBaseRepositoryQuery<T, TId> where T : class
    {
        protected readonly BioDnaLabContext _context;

        public BaseRepositoryQuery(BioDnaLabContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(TId id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }

}
