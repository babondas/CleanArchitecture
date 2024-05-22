using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestMethodology.Command.Create
{
    public class CreateTestMetholodogyCommand : IRequest<long>
    {
        public string TestMetholodogyName { get; set; }
        public string? Description { get; set; } = null;
    }
}
