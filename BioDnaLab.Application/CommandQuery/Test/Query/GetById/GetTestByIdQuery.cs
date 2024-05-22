using BioDnaLab.Application.CommandQuery.Test.Dto;
using BioDnaLab.Application.CommandQuery.TestMethodology.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Test.Query.GetById
{
    public class GetTestByIdQuery : IRequest<TestDto>
    {
        public long Id { get; set; }
    }
}
