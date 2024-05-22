using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.Entity.TestPackage.JunctionTable;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IRepositoryCommandBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.TestPackageWithTest
{
    public interface ITestPackageWithTestRepositoryCommand : IBaseRepositoryCommand<TestPackageWithTestEntity, long>
    {
        Task<TestPackageWithTestEntity> UpdateAsync(long id, TestPackageWithTestEntity entity);
    }
}

