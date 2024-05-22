using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IRepositoryCommandBase;

namespace BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage
{
    public interface ITestPackageRepositoryCommand : IBaseRepositoryCommand<TestPackageEntity, long>
    {
        Task<TestPackageEntity> UpdateAsync(long id, TestPackageEntity entity);
    }
}
