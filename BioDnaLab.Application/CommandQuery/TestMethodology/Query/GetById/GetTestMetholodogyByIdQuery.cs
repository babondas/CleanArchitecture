using BioDnaLab.Application.CommandQuery.TestMethodology.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestMethodology.Query.GetById
{
    public class GetTestMetholodogyByIdQuery : IRequest<TestMethodologyDto>
    {
        public long Id { get; set; }
    }
}
