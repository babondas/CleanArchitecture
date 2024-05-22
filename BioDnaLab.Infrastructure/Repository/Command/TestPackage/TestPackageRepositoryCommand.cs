using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Command.Base;

namespace BioDnaLab.Infrastructure.Repository.Command.TestPackage
{
    public class TestPackageRepositoryCommand : BaseRepositoryCommand<TestPackageEntity, long>, ITestPackageRepositoryCommand
    {
        public TestPackageRepositoryCommand(BioDnaLabContext context) : base(context)
        {

        }

        public async Task<TestPackageEntity> UpdateAsync(long id, TestPackageEntity entity)
        {
            // Find the existing entity in the context using the provided id
            var existingEntity = await _context.Set<TestPackageEntity>().FindAsync(id);
            if (existingEntity == null)
            {
                return null; // Entity not found
            }

            // Manually copy each property value from the entity to the existingEntity
            existingEntity.Description = entity.Description;
            //existingEntity.TestName = entity.TestName;
            existingEntity.ModifiedDate = entity.ModifiedDate;
            existingEntity.ModifiedBy = entity.ModifiedBy;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return existingEntity;
        }
    }
}
