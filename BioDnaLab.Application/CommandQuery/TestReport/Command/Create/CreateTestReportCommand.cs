using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestReport.Command.Create
{
    public class CreateTestReportCommand : IRequest<long>
    {
        public string TestReportName { get; set; }
        public string? Description { get; set; } = null;
    }
}