using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.ITestPackageFirstName;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Command.Base;

namespace BioDnaLab.Infrastructure.Repository.Command.TestPackage.TestPackageFirstName
{
    public class TestPackageFirstNameRepositoryCommand : BaseRepositoryCommand<TestPackageFirstNameEntity, long>, ITestPackageFirstNameCommand
    {
        public TestPackageFirstNameRepositoryCommand(BioDnaLabContext context) : base(context)
        {

        }

        public async Task<TestPackageFirstNameEntity> UpdateAsync(long id, TestPackageFirstNameEntity entity)
        {
            // Find the existing entity in the context using the provided id
            var existingEntity = await _context.Set<TestPackageFirstNameEntity>().FindAsync(id);
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

