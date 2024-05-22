using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IRepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestVolume
{
    public interface ITestVolumeQuery : IBaseRepositoryQuery<TestVolumeEntity, long>
    {
        // You can add more customer-specific methods here if needed
    }
}
