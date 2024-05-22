using BioDnaLab.Domain.Entity.Base;
using BioDnaLab.Domain.Entity.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.Entity.TestPackage.JunctionTable
{
    public class TestPackageWithTestEntity : BaseEntity
    {
        public long? RefTestId { get; set; }
        public TestEntity TestEntity { get; set; }

        public long? RefTestPackageId { get; set; }
        public TestPackageEntity TestPackageEntity { get; set; }
        public bool IsActive { get; set; } = true;
    }
}