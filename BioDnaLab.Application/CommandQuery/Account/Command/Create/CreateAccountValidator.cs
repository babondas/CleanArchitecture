using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Account.Command.Create
{
    public class CreateAccountValidators : AbstractValidator<AccountDto>
    {
        public CreateAccountValidators()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(300).WithMessage("Name cannot be longer than 100 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email is not a valid email address.");

            RuleFor(x => x.PrimaryContactNumber)
                .NotEmpty().WithMessage("Primary contact number is required.")
                .Matches(@"^\d{10}$").WithMessage("Primary contact number must be a valid 10-digit number.");

            RuleFor(x => x.SecondaryContactNumber)
                .Matches(@"^\d{10}$").WithMessage("Secondary contact number must be a valid 10-digit number.")
                .When(x => !string.IsNullOrEmpty(x.SecondaryContactNumber));

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage("Confirm password is required.")
                .Equal(x => x.Password).WithMessage("Passwords do not match.");

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address is required.")
                .MaximumLength(200).WithMessage("Address cannot be longer than 200 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");
            
        }
    }
}
