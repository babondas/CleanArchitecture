using BioDnaLab.Application.CommandQuery.TestSchedule.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSchedule.Query.GetById
{
    public class GetTestScheduleByIdQuery : IRequest<TestScheduleDto>
    {
        public long Id { get; set; }
    }
}
