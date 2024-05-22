using BioDnaLab.Application.CommandQuery.Account.Command.Create;
using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using FluentValidation;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Command.Update
{
    public class UpdateTestVolumeValidator : AbstractValidator<TestVolumeDto>
    {
        public UpdateTestVolumeValidator()
        {
            
            RuleFor(x => x.TestVolumeName)
            .NotEmpty().WithMessage("Test Volume Name is required.")
            .MaximumLength(300).WithMessage("Test Volume Name cannot be longer than 300 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");

            RuleFor(x => x.IsActive)
                .NotNull().WithMessage("IsActive status is required.");
        }
    }
}
