using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestSample.Dto;
using BioDnaLab.Application.CommandQuery.TestSchedule.Dto;
using BioDnaLab.Application.CommandQuery.TestSchedule.Query.Get;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestSample;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestSchedule;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Query.Get
{
    public class GetTestSampleHandler : IRequestHandler<GetTestSampleQuery, List<TestSampleDto>>
    {
        //contrl .
        private readonly ITestSampleQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestSampleHandler(ITestSampleQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TestSampleDto>> Handle(GetTestSampleQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();

            var finalData = _mapper.Map<List<TestSampleDto>>(data);

            return finalData;
        }
    }
}