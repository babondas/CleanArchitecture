using BioDnaLab.Application.CommandQuery.TestSample.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Query.GetById
{
    public class GetTestSampleByIdQuery : IRequest<TestSampleDto>
    {
        public long Id { get; set; }
    }
}
