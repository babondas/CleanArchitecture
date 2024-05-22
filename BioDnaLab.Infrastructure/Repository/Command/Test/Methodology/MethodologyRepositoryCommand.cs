using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestMethodology;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Command.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Repository.Command.Test.Methodology
{
    public class MethodologyRepositoryCommand : BaseRepositoryCommand<TestMethodologyEntity, long>, ITestMethodologyCommand
    {
        public MethodologyRepositoryCommand(BioDnaLabContext context) : base(context)
        {

        }

        public async Task<TestMethodologyEntity> UpdateAsync(long id, TestMethodologyEntity entity)
        {
            // Find the existing entity in the context using the provided id
            var existingEntity = await _context.Set<TestMethodologyEntity>().FindAsync(id);
            if (existingEntity == null)
            {
                return null; // Entity not found
            }

            // Manually copy each property value from the entity to the existingEntity
            existingEntity.Description = entity.Description;
            existingEntity.TestMethodologyName = entity.TestMethodologyName;
            existingEntity.ModifiedDate = DateTime.Now;
            existingEntity.ModifiedBy = 1;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return existingEntity;
        }

    }
}
