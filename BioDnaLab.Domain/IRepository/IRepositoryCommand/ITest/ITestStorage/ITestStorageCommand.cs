using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IRepositoryCommandBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestStorage
{
    public interface ITestStorageCommand : IBaseRepositoryCommand<TestStorageEntity, long>
    {
        // You can add more customer-specific methods here if needed
        Task<TestStorageEntity> UpdateAsync(long id, TestStorageEntity entity);
    }
}
