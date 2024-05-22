using BioDnaLab.Domain.Entity.TestPackage.JunctionTable;
using BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.TestPackageWithTest;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage.ITestPackageFirstName;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage.TestPackageWithTest;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Repository.Query.TestPackage.TestPackageWithTest
{
    public class TestPackageWithTestRepositoryQuery : BaseRepositoryQuery<TestPackageWithTestEntity, long>, ITestPackageWithTestRepositoryQuery
    {
        public TestPackageWithTestRepositoryQuery(BioDnaLabContext context) : base(context)
        {

        }
    }
}