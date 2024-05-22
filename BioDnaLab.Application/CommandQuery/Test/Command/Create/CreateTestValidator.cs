using BioDnaLab.Application.CommandQuery.Test.Dto;
using BioDnaLab.Application.CommandQuery.TestMethodology.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Test.Command.Create
{
    public class CreateTestValidator : AbstractValidator<TestDto>
    {
        public CreateTestValidator()
        {
             RuleFor(x => x.TestName)
            .NotEmpty().WithMessage("Test Name Name is required.")
          .  MaximumLength(300).WithMessage("Test Name cannot be longer than 300 characters.");

             RuleFor(x => x.Description)
            .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");

            RuleFor(x => x.RefTestMethodologyId)
           .NotEmpty().WithMessage("Test Methodology is required.")
           .GreaterThan(0).WithMessage("TestMethodology must be a valid and greater than zero.");

            RuleFor(x => x.RefTestSampleId)
           .NotEmpty().WithMessage("Test Sample is required.")
           .GreaterThan(0).WithMessage("TestSample must be a valid and greater than zero.");

            RuleFor(x => x.RefTestVolumeId)
           .NotEmpty().WithMessage("Test Volume is required.")
           .GreaterThan(0).WithMessage("TestVolume must be a valid and greater than zero.");

            RuleFor(x => x.RefTestStorageId)
           .NotEmpty().WithMessage("Test Storage is required.")
           .GreaterThan(0).WithMessage("TestStorage must be a valid and greater than zero.");

            RuleFor(x => x.RefTestScheduleId)
           .NotEmpty().WithMessage("Test Schedule is required.")
           .GreaterThan(0).WithMessage("Test Schedule must be a valid and greater than zero.");

            RuleFor(x => x.RefTestReportId)
           .NotEmpty().WithMessage("Test Report is required.")
           .GreaterThan(0).WithMessage("Test Report must be a valid and greater than zero.");

            RuleFor(x => x.MRP)
                .GreaterThan(0).WithMessage("MRP must be greater than 0");

            RuleFor(x => x.TestPriceDiscount)
                .GreaterThanOrEqualTo(0).WithMessage("Test Price Discount must be greater than or equal to 0")
                .LessThan(x => x.MRP).When(x => x.TestPriceDiscount.HasValue).WithMessage("Test Price Discount must be less than MRP");

            RuleFor(x => x.TestPriceDiscountInPercent)
                .InclusiveBetween(0, 100).When(x => x.TestPriceDiscountInPercent.HasValue).WithMessage("Test Price Discount In Percent must be between 0 and 100");
        }
    }
}