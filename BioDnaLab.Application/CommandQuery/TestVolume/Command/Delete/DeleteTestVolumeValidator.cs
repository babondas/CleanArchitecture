using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Command.Delete
{
    public class DeleteTestVolumeValidator : AbstractValidator<DeleteTestVolumeCommand>
    {
        public DeleteTestVolumeValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.")
                .GreaterThan(0).WithMessage("Id must be a valid and greater than zero."); 
        }
    }
}
