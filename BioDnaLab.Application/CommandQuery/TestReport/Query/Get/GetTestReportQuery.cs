using BioDnaLab.Application.CommandQuery.TestReport.Dto;
using BioDnaLab.Application.CommandQuery.TestSample.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestReport.Query.Get
{
    public class GetTestReportQuery : IRequest<List<TestReportDto>>
    {
    }
}