using BioDnaLab.Application.CommandQuery.TestStorage.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestStorage.Command.Delete
{
    public class DeleteTestStorageValidator : AbstractValidator<TestStorageDto>
    {
        public DeleteTestStorageValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.")
                .GreaterThan(0).WithMessage("Id must be a valid and greater than zero.");
        }
    }
}
