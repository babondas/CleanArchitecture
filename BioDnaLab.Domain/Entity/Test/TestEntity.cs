using BioDnaLab.Domain.Entity.Base;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BioDnaLab.Domain.Entity.Test
{
    public class TestEntity : BaseEntity
    {
        [MaxLength(300)]
        public string TestName { get; set; } = string.Empty;

        public long? RefTestMethodologyId { get; set; }
        public TestMethodologyEntity TestMethodology { get; set; }

        public long? RefTestSampleId { get; set; }
        public TestSampleEntity TestSample { get; set; }

        public long? RefTestVolumeId { get; set; }
        public TestVolumeEntity TestVolume { get; set; }

        public long? RefTestStorageId { get; set; }
        public TestStorageEntity TestStorage { get; set; }

        public long? RefTestScheduleId { get; set; }
        public TestScheduleEntity TestSchedule { get; set; }

        public long? RefTestReportId { get; set; }
        public TestReportEntity TestReport { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MRP { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? TestPriceDiscount { get; set; }

        public int? TestPriceDiscountInPercent { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
