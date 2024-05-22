using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestMethodology.Command.Update
{
    public class UpdateTestMetholodogyCommand : IRequest<long>
    {
        public long Id { get; set; }
        public string TestMetholodogyName { get; set; }
        public string? Description { get; set; } = null;
        public bool IsActive { get; set; } = true;
    }
}