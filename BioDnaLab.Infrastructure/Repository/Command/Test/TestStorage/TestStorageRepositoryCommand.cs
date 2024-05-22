using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestStorage;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Command.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Repository.Command.Test.TestStorage
{
    public class TestStorageRepositoryCommand : BaseRepositoryCommand<TestStorageEntity, long>, ITestStorageCommand
    {
        public TestStorageRepositoryCommand(BioDnaLabContext context) : base(context)
        {

        }

        public async Task<TestStorageEntity> UpdateAsync(long id, TestStorageEntity entity)
        {
            // Find the existing entity in the context using the provided id
            var existingEntity = await _context.Set<TestStorageEntity>().FindAsync(id);
            if (existingEntity == null)
            {
                return null; // Entity not found
            }

            // Manually copy each property value from the entity to the existingEntity
            existingEntity.Description = entity.Description;
            existingEntity.TestStorageName = entity.TestStorageName;
            existingEntity.ModifiedDate = DateTime.Now;
            existingEntity.ModifiedBy = 1;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return existingEntity;
        }
    }
}
