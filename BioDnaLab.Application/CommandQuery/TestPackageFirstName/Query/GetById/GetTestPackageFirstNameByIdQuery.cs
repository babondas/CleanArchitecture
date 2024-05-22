using BioDnaLab.Application.CommandQuery.TestPackageFirstName.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageFirstName.Query.GetById
{
    public class GetTestPackageFirstNameByIdQuery : IRequest<TestPackageFirstNameEntityDto>
    {
        public long Id { get; set; }
    }
}
