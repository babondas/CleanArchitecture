using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage.ITestPackageFirstName;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Repository.Query.TestPackage.TestPackageFirstName
{
    public class TestPackageFirstNameRepositoryQuery : BaseRepositoryQuery<TestPackageFirstNameEntity, long>, ITestPackageFirstNameNameQuery
    {
        public TestPackageFirstNameRepositoryQuery(BioDnaLabContext context) : base(context)
        {

        }
    }
}
