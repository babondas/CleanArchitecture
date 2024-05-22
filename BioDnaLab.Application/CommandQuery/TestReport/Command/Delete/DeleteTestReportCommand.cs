using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestReport.Command.Delete
{
    public class DeleteTestReportCommand : IRequest<long>
    {
        public long Id { get; set; }
    }
}
