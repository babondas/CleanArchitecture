using BioDnaLab.Application.CommandQuery.BaseEntityDto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageFirstName.Dto
{
    public class TestPackageFirstNameEntityDto : BaseDto
    {
        public long Id { get; set; }

        [StringLength(300, MinimumLength = 2, ErrorMessage = "Test Package First Name must be between 2 and 300 characters.")]
        public string TestPackageFirstName { get; set; }
        public bool IsActive { get; set; } = true;
    }
}