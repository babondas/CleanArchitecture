using BioDnaLab.Application.CommandQuery.TestVolume.Command.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageFirstName.Command.Create
{
    public class CreateTestPackageFirstNameValidator : AbstractValidator<CreateTestPackageFirstNameCommand>
    {
        public CreateTestPackageFirstNameValidator()
        {
            RuleFor(x => x.TestPackageFirstName)
            .NotEmpty().WithMessage("Test Volume Name is required.")
            .MaximumLength(300).WithMessage("Test Volume Name cannot be longer than 300 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");
        }
    }
}

