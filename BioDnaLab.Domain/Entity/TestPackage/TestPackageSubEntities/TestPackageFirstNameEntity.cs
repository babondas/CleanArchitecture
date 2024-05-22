using BioDnaLab.Domain.Entity.Base;
using BioDnaLab.Domain.Entity.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities
{
    public class TestPackageFirstNameEntity : BaseEntity
    {
        [MaxLength(300)]
        public string TestPackageFirstName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}

