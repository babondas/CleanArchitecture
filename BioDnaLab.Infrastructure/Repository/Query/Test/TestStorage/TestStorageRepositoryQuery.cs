using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestStorage;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Repository.Query.Test.TestStorage
{
    public class TestStorageRepositoryQuery : BaseRepositoryQuery<TestStorageEntity, long>, ITestStorageQuery
    {
        public TestStorageRepositoryQuery(BioDnaLabContext context) : base(context)
        {

        }
    }
}
