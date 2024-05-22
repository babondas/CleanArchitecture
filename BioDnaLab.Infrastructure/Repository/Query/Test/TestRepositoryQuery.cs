using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Repository.Query.Test
{
    public class TestRepositoryQuery : BaseRepositoryQuery<TestEntity, long>, ITestRepositoryQuery
    {
        public TestRepositoryQuery(BioDnaLabContext context) : base(context)
        {

        }
    }
}
