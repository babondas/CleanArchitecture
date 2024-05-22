using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Command.Create
{
    public class CreateTestPackageWithTestCommand : IRequest<long>
    {
        public long? RefTestId { get; set; }
        public long? RefTestPackageId { get; set; }

        public string? Description { get; set; }
    }
}
