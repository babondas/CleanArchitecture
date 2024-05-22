using BioDnaLab.Application.CommandQuery.TestStorage.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestStorage.Query.GetById
{
    public class GetTestStorageByIdQuery : IRequest<TestStorageDto>
    {
        public long Id { get; set; }
    }
}
