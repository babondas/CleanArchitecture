using BioDnaLab.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.Entity.Test.TestSubEntities
{
    public class TestSampleEntity : BaseEntity
    {
        [MaxLength(300)]
        public string TestSampleName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        
    }
}
