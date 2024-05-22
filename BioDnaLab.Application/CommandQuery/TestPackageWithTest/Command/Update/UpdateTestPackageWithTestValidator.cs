using BioDnaLab.Application.CommandQuery.TestPackage.Dto;
using BioDnaLab.Application.CommandQuery.TestPackageWithTest.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Command.Update
{
    public class UpdateTestPackageWithTestValidator : AbstractValidator<TestPackageWithTestEntityDto>
    {
        public UpdateTestPackageWithTestValidator()
        {

            RuleFor(entity => entity.RefTestId)
            .NotNull().WithMessage("RefTestId is required.")
            .GreaterThan(0).WithMessage("RefTestId must be greater than 0.");

            RuleFor(entity => entity.RefTestPackageId)
                .NotNull().WithMessage("RefTestPackageId is required.")
                .GreaterThan(0).WithMessage("RefTestPackageId must be greater than 0.");

            RuleFor(entity => entity.Description)
                .NotEmpty().WithMessage("Description is required.")
                .Length(1, 500).WithMessage("Description must be between 1 and 500 characters."); // Adjust length as necessary
        }
    }
}