using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Account.Command.Create
{
    public class CreateAccountCommand : IRequest<AccountDto>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PrimaryContactNumber { get; set; } = string.Empty;
        public string SecondaryContactNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
