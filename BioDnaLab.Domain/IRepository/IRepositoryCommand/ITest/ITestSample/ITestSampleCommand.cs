using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IRepositoryCommandBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestSample
{
    public interface ITestSampleCommand : IBaseRepositoryCommand<TestSampleEntity, long>
    {
        Task<TestSampleEntity> UpdateAsync(long id, TestSampleEntity entity);
    }
}
