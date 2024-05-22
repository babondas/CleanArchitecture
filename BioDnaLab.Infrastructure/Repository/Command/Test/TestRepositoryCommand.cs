using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Command.Base;

namespace BioDnaLab.Infrastructure.Repository.Command.Test
{
    public class TestRepositoryCommand : BaseRepositoryCommand<TestEntity, long>, ITestRepositoryCommand
    {
        public TestRepositoryCommand(BioDnaLabContext context) : base(context)
        {

        }

        public async Task<TestEntity> UpdateAsync(long id, TestEntity entity)
        {
            // Find the existing entity in the context using the provided id
            var existingEntity = await _context.Set<TestEntity>().FindAsync(id);
            if (existingEntity == null)
            {
                return null; // Entity not found
            }

            // Manually copy each property value from the entity to the existingEntity
            existingEntity.Description = entity.Description;
            existingEntity.TestName = entity.TestName;
            existingEntity.ModifiedDate = entity.ModifiedDate;
            existingEntity.ModifiedBy = entity.ModifiedBy;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return existingEntity;
        }
    }
}
