using BioDnaLab.Application.CommandQuery.BaseEntityDto;
using BioDnaLab.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Dto
{
    public class TestSampleDto : BaseDto
    {
        public long Id { get; set; }

        [StringLength(300, MinimumLength = 2, ErrorMessage = "Test Sample Name must be between 2 and 300 characters.")]
        public string TestSampleName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

    }
}
