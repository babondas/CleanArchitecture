using BioDnaLab.Application.CommandQuery.TestPackageFirstName.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageFirstName.Query.Get
{
    public class GetTestPackageFirstNameQuery : IRequest<List<TestPackageFirstNameEntityDto>>
    {
    }
}
