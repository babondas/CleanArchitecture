using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Application.CommandQuery.TestSchedule.Dto;
using BioDnaLab.Application.CommandQuery.TestStorage.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestStorage.Command.Update
{
    public class UpdateTestStorageValidator : AbstractValidator<TestStorageDto>
    {
        public UpdateTestStorageValidator()
        {
            RuleFor(x => x.TestStorageName)
            .NotEmpty().WithMessage("Test Volume Name is required.")
            .MaximumLength(300).WithMessage("Test Volume Name cannot be longer than 300 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");

            RuleFor(x => x.IsActive)
                .NotNull().WithMessage("IsActive status is required.");
        }
    }
}
