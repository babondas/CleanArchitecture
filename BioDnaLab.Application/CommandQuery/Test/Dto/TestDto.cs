using BioDnaLab.Application.CommandQuery.BaseEntityDto;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BioDnaLab.Application.CommandQuery.Test.Dto
{
    public class TestDto : BaseDto
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Test Name is required.")]
        [StringLength(300, MinimumLength = 2, ErrorMessage = "Test Name must be between 2 and 300 characters.")]
        public string TestName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Test Methodology ID must be a positive integer.")]
        public int? RefTestMethodologyId { get; set; } = null;

        [Range(1, int.MaxValue, ErrorMessage = "Test Sample ID must be a positive integer.")]
        public int? RefTestSampleId { get; set; } = null;

        [Range(1, int.MaxValue, ErrorMessage = "Test Volume ID must be a positive integer.")]
        public int? RefTestVolumeId { get; set; } = null;

        [Range(1, int.MaxValue, ErrorMessage = "Test Storage ID must be a positive integer.")]
        public int? RefTestStorageId { get; set; } = null;

        [Range(1, int.MaxValue, ErrorMessage = "Test Schedule ID must be a positive integer.")]
        public int? RefTestScheduleId { get; set; } = null;

        [Range(1, int.MaxValue, ErrorMessage = "Test Report ID must be a positive integer.")]
        public int? RefTestReportId { get; set; } = null;

        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "MRP must be greater than zero.")]
        public decimal MRP { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Discount must be a non-negative number.")]
        public decimal? TestPriceDiscount { get; set; } = null;

        [Range(0, 100, ErrorMessage = "Discount percentage must be between 0 and 100.")]
        public int? TestPriceDiscountInPercent { get; set; } = null;

        public bool IsActive { get; set; } = true;
    }
}
