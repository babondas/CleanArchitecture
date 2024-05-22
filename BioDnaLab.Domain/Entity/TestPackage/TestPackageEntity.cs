using BioDnaLab.Domain.Entity.Base;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.Entity.TestPackage
{
    public class TestPackageEntity : BaseEntity
    {
        [MaxLength(300)]
        public string TestPackageSecondName { get; set; } = string.Empty;
        public long? RefTestPackageFirstNameId { get; set; }
        public TestPackageFirstNameEntity TestPackageFirstName { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? MRP { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? OfferPrice { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
