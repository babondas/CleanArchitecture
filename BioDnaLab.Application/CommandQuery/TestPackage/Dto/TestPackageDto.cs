using BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackage.Dto
{
    public class TestPackageDto
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Created Date is required.")]
        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; } = null;

        [Required(ErrorMessage = "Created By is required.")]
        public long CreatedBy { get; set; }

        public long? ModifiedBy { get; set; } = null;

        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Description must be between 2 and 1000 characters.")]
        public string? Description { get; set; }

        public int? TestPackageFirstNameId { get; set; }

        [StringLength(300, MinimumLength = 2, ErrorMessage = "Test Package Second Name must be between 2 and 300 characters.")]
        public string? TestPackageSecondName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "MRP must be greater than zero.")]
        public decimal? MRP { get; set; } = 0.00m;

        [Column(TypeName = "decimal(18,2)")]
        [Range(0.00, double.MaxValue, ErrorMessage = "Offer Price must be a non-negative value.")]
        public decimal? OfferPrice { get; set; } = 0.00m;

        public bool IsActive { get; set; } = true;
    }
}
