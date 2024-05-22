using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.Entity.TestPackage.JunctionTable;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.TestPackageWithTest;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Command.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Repository.Command.TestPackage.TestPackageWithTest
{
    public class TestPackageWithTestRepositoryCommand : BaseRepositoryCommand<TestPackageWithTestEntity, long>, ITestPackageWithTestRepositoryCommand
    {
        public TestPackageWithTestRepositoryCommand(BioDnaLabContext context) : base(context)
        {
        }

        public async Task<TestPackageWithTestEntity> UpdateAsync(long id, TestPackageWithTestEntity entity)
        {
            // Find the existing entity in the context using the provided id
            var existingEntity = await _context.Set<TestPackageWithTestEntity>().FindAsync(id);
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
