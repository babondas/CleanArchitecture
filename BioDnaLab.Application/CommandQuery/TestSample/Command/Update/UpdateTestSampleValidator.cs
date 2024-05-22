using BioDnaLab.Application.CommandQuery.TestSample.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Command.Update
{
    public class UpdateTestSampleValidator : AbstractValidator<TestSampleDto>
    {
        public UpdateTestSampleValidator()
        {
            RuleFor(x => x.TestSampleName)
           .NotEmpty().WithMessage("Test Volume Name is required.")
           .MaximumLength(300).WithMessage("Test Volume Name cannot be longer than 300 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");

            RuleFor(x => x.IsActive)
                .NotNull().WithMessage("IsActive status is required.");
        }
    }
}