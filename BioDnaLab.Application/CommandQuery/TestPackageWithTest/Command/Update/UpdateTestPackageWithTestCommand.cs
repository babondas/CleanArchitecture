using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Command.Update
{
    public class UpdateTestPackageWithTestCommand : IRequest<long>
    {
        public long Id { get; set; }
        public long? RefTestId { get; set; }
        public long? RefTestPackageId { get; set; }

        public string? Description { get; set; }
    }
}
