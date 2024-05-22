using BioDnaLab.Application.CommandQuery.TestSample.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Command.Delete
{
    public class DeleeTestSampleValidator : AbstractValidator<TestSampleDto>
    {
        public DeleeTestSampleValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.")
                .GreaterThan(0).WithMessage("Id must be a valid and greater than zero.");
        }
    }
}