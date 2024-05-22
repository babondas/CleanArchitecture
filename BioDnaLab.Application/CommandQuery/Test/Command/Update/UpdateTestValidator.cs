using BioDnaLab.Application.CommandQuery.Test.Dto;
using FluentValidation;

namespace BioDnaLab.Application.CommandQuery.Test.Command.Update
{
    public class UpdateTestValidator : AbstractValidator<TestDto>
    {
        public UpdateTestValidator()
        {

            RuleFor(x => x.TestName)
          .NotEmpty().WithMessage("Test Volume Name is required.")
          .MaximumLength(300).WithMessage("Test Volume Name cannot be longer than 300 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");

            RuleFor(x => x.IsActive)
                .NotNull().WithMessage("IsActive status is required.");
        }
    }
}