using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSchedule.Command.Create
{
    public class CreateTestScheduleCommand : IRequest<long>
    {
        public string TestScheduleName { get; set; }
        public string? Description { get; set; } = null;
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long CreatedBy { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
