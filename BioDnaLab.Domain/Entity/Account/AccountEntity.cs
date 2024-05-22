using BioDnaLab.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.Entity.Account
{
    public class AccountEntity : BaseEntity
    {
        [MaxLength(300)]
        public string? Name { get; set; }

        [EmailAddress]
        [MaxLength(300)]
        public string? Email { get; set; }

        [Phone]
        [MaxLength(20)]
        public string PrimaryContactNumber { get; set; } = string.Empty;

        [Phone]
        [MaxLength(20)]
        public string? SecondaryContactNumber { get; set; }

        [MaxLength(500)]
        public string? Address { get; set; }

        [MaxLength(100)]
        public string Password { get; set; } = string.Empty;

        public int? RoleId { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
