using BioDnaLab.Application.CommandQuery.TestVolume.Command.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackage.Command.Create
{
    public class CreateTestPackageValidator : AbstractValidator<CreateTestPackageCommand>
    {
        public CreateTestPackageValidator()
        {
            RuleFor(x => x.TestPackageSecondName)
            .NotEmpty().WithMessage("Test Package Second Name is required.")
            .MaximumLength(300).WithMessage("Test Package Second Name cannot be longer than 300 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");

            RuleFor(product => product.MRP)
          .NotNull().WithMessage("MRP is required.")
          .GreaterThanOrEqualTo(0).WithMessage("MRP must be greater than or equal to 0.");

            RuleFor(product => product.OfferPrice)
                .NotNull().WithMessage("OfferPrice is required.")
                .GreaterThanOrEqualTo(0).WithMessage("OfferPrice must be greater than or equal to 0.")
                .LessThanOrEqualTo(product => product.MRP).WithMessage("OfferPrice must be less than or equal to MRP.");

        }
    }
}