using BioDnaLab.Application.CommandQuery.BaseEntityDto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BioDnaLab.Application.CommandQuery.Account.Dto.Account
{
    public class RegisterDto : BaseDto
    {

        [StringLength(300, ErrorMessage = "Name cannot exceed 300 characters")]
        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(300, ErrorMessage = "Email cannot exceed 300 characters")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Primary Contact Number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [StringLength(15, ErrorMessage = "Primary Contact Number cannot exceed 15 characters")]
        public string PrimaryContactNumber { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        [StringLength(15, ErrorMessage = "Secondary Number cannot exceed 15 characters")]
        public string? SecondaryContactNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long and not exceed 100 characters")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Confirm Password does not match Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(500, ErrorMessage = "Address cannot exceed 500 characters")]
        public string? Address { get; set; } = string.Empty;

        [Required]
        public bool IsActive { get; set; }
    }
}
