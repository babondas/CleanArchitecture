using BioDnaLab.Domain.IRepository.IRepositoryCommand.IRepositoryCommandBase;
using BioDnaLab.Infrastructure.Data;

namespace BioDnaLab.Infrastructure.Repository.Command.Base
{
    public class BaseRepositoryCommand<T, TId> : IBaseRepositoryCommand<T, TId> where T : class
    {
        protected readonly BioDnaLabContext _context;

        public BaseRepositoryCommand(BioDnaLabContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        async Task<T> IBaseRepositoryCommand<T, TId>.DeleteAsync(TId id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return null; // Entity not found
            }

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        //async Task<T> IBaseRepositoryCommand<T, TId>.UpdateAsync(TId id, T entity)
        //{

        //    // You need to ensure that the entity has some identifier to locate it in the database
        //    // If TId is not part of the entity itself, you may need to find another way to uniquely identify the entity

        //    var existingEntity = await _context.Set<T>().FindAsync(id);
        //    if (existingEntity == null)
        //        return null; // Entity not found

        //    _context.Entry(existingEntity).CurrentValues.SetValues(entity);
        //    await _context.SaveChangesAsync();

        //    return existingEntity;
        //}
    }
}
