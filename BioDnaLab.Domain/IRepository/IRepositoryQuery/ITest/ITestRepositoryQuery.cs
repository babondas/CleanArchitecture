using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IRepositoryBase;

namespace BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest
{
    public interface ITestRepositoryQuery : IBaseRepositoryQuery<TestEntity, long>
    {
        // You can add more customer-specific methods here if needed
    }
}
