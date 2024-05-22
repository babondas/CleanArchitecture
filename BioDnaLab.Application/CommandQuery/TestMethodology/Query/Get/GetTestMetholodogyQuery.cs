using BioDnaLab.Application.CommandQuery.TestMethodology.Dto;
using BioDnaLab.Application.CommandQuery.TestReport.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestMethodology.Query.Get
{
    public class GetTestMetholodogyQuery : IRequest<List<TestMethodologyDto>>
    {
    }
}
