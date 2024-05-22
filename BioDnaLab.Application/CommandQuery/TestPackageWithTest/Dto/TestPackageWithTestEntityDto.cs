using BioDnaLab.Application.CommandQuery.BaseEntityDto;
using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.TestPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Dto
{
    public class TestPackageWithTestEntityDto : BaseDto
    {
        public long? RefTestId { get; set; }
        public long? RefTestPackageId { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
