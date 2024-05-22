using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestVolume;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Query.Base;

namespace BioDnaLab.Infrastructure.Repository.Query.Test.TestVolume
{
    public class TestVolumeRepositoryQuery : BaseRepositoryQuery<TestVolumeEntity, long>, ITestVolumeQuery
    {
        public TestVolumeRepositoryQuery(BioDnaLabContext context) : base(context)
        {

        }
    }
}
