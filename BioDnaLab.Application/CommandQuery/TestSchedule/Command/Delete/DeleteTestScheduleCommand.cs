using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSchedule.Command.Delete
{
    public class DeleteTestScheduleCommand : IRequest<long>
    {
        public long Id { get; set; }
    }
}