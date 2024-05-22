using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IRepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage.ITestPackageFirstName
{
    public interface ITestPackageFirstNameNameQuery : IBaseRepositoryQuery<TestPackageFirstNameEntity, long>
    {
        // You can add more customer-specific methods here if needed
    }
}
