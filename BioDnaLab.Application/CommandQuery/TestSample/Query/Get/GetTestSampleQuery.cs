using BioDnaLab.Application.CommandQuery.TestSample.Dto;
using BioDnaLab.Application.CommandQuery.TestSchedule.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Query.Get
{
    public class GetTestSampleQuery : IRequest<List<TestSampleDto>>
    {
    }
}

