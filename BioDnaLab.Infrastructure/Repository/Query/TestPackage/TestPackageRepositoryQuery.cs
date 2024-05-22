using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Repository.Query.TestPackage
{
    public class TestPackageRepositoryQuery : BaseRepositoryQuery<TestPackageEntity, long>, ITestPackageRepositoryQuery
    {
        public TestPackageRepositoryQuery(BioDnaLabContext context) : base(context)
        {

        }
    }
}
