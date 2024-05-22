using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IRepositoryBase;

namespace BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage
{
    public interface ITestPackageRepositoryQuery : IBaseRepositoryQuery<TestPackageEntity, long>
    {
        // You can add more customer-specific methods here if needed
    }
}
