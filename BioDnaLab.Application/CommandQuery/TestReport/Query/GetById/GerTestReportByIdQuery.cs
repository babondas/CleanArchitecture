using BioDnaLab.Application.CommandQuery.TestReport.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestReport.Query.GetById
{
    public class GerTestReportByIdQuery : IRequest<TestReportDto>
    {
        public long Id { get; set; }
    }
}
