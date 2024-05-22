using BioDnaLab.Application.CommandQuery.TestPackage.Command.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Command.Create
{
    public class CreateTestPackageWithTestValidator : AbstractValidator<CreateTestPackageWithTestCommand>
    {
        public CreateTestPackageWithTestValidator()
        {
            RuleFor(entity => entity.RefTestId)
             .NotNull().WithMessage("RefTestId is required.");

            RuleFor(entity => entity.RefTestPackageId)
                .NotNull().WithMessage("RefTestPackageId is required.");

        }
    }
}
