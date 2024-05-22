using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageFirstName.Command.Create
{
    public class CreateTestPackageFirstNameCommand : IRequest<long>
    {
        public string TestPackageFirstName { get; set; }
        public string? Description { get; set; } = null;

    }
}
