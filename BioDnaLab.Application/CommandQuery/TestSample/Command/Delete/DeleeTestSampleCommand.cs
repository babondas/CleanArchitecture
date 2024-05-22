using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Command.Delete
{
    public class DeleeTestSampleCommand : IRequest<long>
    {
        public long Id { get; set; }
    }
}
