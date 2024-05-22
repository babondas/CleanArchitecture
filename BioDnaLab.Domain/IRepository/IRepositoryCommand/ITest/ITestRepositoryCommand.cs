using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IRepositoryCommandBase;

namespace BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest
{
    public interface ITestRepositoryCommand : IBaseRepositoryCommand<TestEntity, long>
    {
        Task<TestEntity> UpdateAsync(long id, TestEntity entity);
    }
}
