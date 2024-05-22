using BioDnaLab.Application.CommandQuery.TestSchedule.Dto;
using BioDnaLab.Application.CommandQuery.TestStorage.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSchedule.Command.Delete
{
    public class DeleteTestScheduleValidator : AbstractValidator<TestScheduleDto>
    {
        public DeleteTestScheduleValidator()
        {

        }
    }
}