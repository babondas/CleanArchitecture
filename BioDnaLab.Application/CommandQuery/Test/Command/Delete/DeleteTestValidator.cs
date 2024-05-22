using BioDnaLab.Application.CommandQuery.Test.Dto;
using BioDnaLab.Application.CommandQuery.TestMethodology.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Test.Command.Delete
{
    public class DeleteTestValidator : AbstractValidator<TestDto>
    {
        public DeleteTestValidator()
        {
            RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required.")
            .GreaterThan(0).WithMessage("Id must be a valid and greater than zero.");
        }
    }
}
