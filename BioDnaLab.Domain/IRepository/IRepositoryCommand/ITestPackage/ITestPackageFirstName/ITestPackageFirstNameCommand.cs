using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IRepositoryCommandBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.ITestPackageFirstName
{
    public interface ITestPackageFirstNameCommand : IBaseRepositoryCommand<TestPackageFirstNameEntity, long>
    {
        Task<TestPackageFirstNameEntity> UpdateAsync(long id, TestPackageFirstNameEntity entity);
    }
}
