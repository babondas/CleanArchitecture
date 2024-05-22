using BioDnaLab.Application.CommandQuery.TestPackageWithTest.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Query.GetById
{
    public class GetTestPackageWithTestByIdQuery : IRequest<TestPackageWithTestEntityDto>
    {
        public long Id { get; set; }
    }
}

