using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Command.Create
{
    public class CreateTestSampleCommand : IRequest<long>
    {
        public string TestSampleName { get; set; }
        public string? Description { get; set; } = null;
    }
}