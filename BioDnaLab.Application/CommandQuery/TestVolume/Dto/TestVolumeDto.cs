using BioDnaLab.Application.Common.Mappings;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Dto
{
    public class TestVolumeDto :  IMapFrom<TestVolumeEntity>
    {
       
        public long Id { get; set; }

        [StringLength(300, MinimumLength = 2, ErrorMessage = "Test Volume Name must be between 2 and 300 characters.")]
        public string TestVolumeName { get; set; }
        public bool IsActive { get; set; } = true;
        public string? Description { get; set; }
    }
}
