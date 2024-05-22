using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestReport;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Repository.Query.Test.TestReport
{
    public class TestReportRepositoryQuery : BaseRepositoryQuery<TestReportEntity, long>, ITestReportQuery
    {
        public TestReportRepositoryQuery(BioDnaLabContext context) : base(context)
        {

        }
    }
}
