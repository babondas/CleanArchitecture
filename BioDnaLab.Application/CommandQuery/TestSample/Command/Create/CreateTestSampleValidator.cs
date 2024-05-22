using BioDnaLab.Application.CommandQuery.TestSample.Dto;
using BioDnaLab.Application.CommandQuery.TestSchedule.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Command.Create
{
    public class CreateTestSampleValidator : AbstractValidator<TestSampleDto>
    {
        public CreateTestSampleValidator()
        {
            RuleFor(x => x.TestSampleName)
           .NotEmpty().WithMessage("Test Volume Name is required.")
           .MaximumLength(300).WithMessage("Test Volume Name cannot be longer than 300 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");
        }
    }
}