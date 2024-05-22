using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSchedule.Command.Update
{
    public class UpdateTestScheduleCommand : IRequest<long>
    {
        public long Id { get; set; }
        public string TestScheduleName { get; set; }
        public string? Description { get; set; } = null;
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
    }
}